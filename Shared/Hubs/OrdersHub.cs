using Coffee_Ecommerce.WebApp.Features.Order;
using Coffee_Ecommerce.WebApp.Features.Order.Create;
using Coffee_Ecommerce.WebApp.Shared.Events;
using Microsoft.AspNetCore.SignalR.Client;

namespace Coffee_Ecommerce.WebApp.Shared.Hubs
{
    public sealed class OrdersHub
    {
        private readonly string _url;
        public HubConnection? Connection { get; private set; } = null;
        private ReceivedOrders? ReceivedOrders = null;

        public OrdersHub(IConfiguration config, ReceivedOrders receivedOrders)
        {
            _url = $"{config.GetValue<string>("api:communication")}/orderhub";
            ReceivedOrders = receivedOrders;
        }

        public async Task<HubConnection> ConnectAsync(string token)
        {
            if (string.IsNullOrWhiteSpace(token))
                throw new ArgumentNullException(nameof(token), "Token cannot be empty");

            if (Connection != null)
                return Connection;

            var connection = new HubConnectionBuilder()
                .WithUrl(new Uri(_url), options =>
                {
                    options.AccessTokenProvider = () => Task.FromResult(token);
                })
                .Build();

            try
            {
                await connection.StartAsync();
            }
            catch (HttpRequestException)
            {
                throw;
            }

            Connection = connection;

            return connection;
        }

        public void SetNewOrdersListener()
        {
            if (Connection == null)
                throw new NullReferenceException("No established connection to the server");

            if (ReceivedOrders == null)
                throw new NullReferenceException(nameof(ReceivedOrders));

            // Removes a listener if it already exists
            Connection.Remove("ReceiveOrder");

            Connection.On<CreateRequest>("ReceiveOrder", async (order) =>
            {
                await ReceivedOrders.AddOrder(order);
                ToastRaiser.Notifty("Novo pedido recebido");
            });
        }

        public void SetOrderResponseListener()
        {
            if (Connection == null)
                throw new NullReferenceException("No established connection to the server");

            Connection.Remove("ReceiveResponse");

            Connection.On<bool>("ReceiveResponse", (accepted) =>
            {
                if (accepted)
                {
                    ToastRaiser.Notifty("Seu pedido foi aceito pelo estabelecimento");
                }
                else
                {
                    ErrorRaiser.Raise("Seu pedido foi rejeitado pelo estabelecimento");
                }
            });
        }

        public void CloseConnection()
        {
            Connection.Remove("ReceiveOrder");
            Connection.Remove("ReceiveResponse");
            Connection = null;
        }
    }
}
