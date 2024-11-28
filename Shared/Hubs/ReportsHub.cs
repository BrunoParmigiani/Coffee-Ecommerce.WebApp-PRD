using Coffee_Ecommerce.WebApp.Shared.Events;
using Microsoft.AspNetCore.SignalR.Client;

namespace Coffee_Ecommerce.WebApp.Shared.Hubs
{
    public sealed class ReportsHub
    {
        private readonly string _url;
        public HubConnection? Connection { get; private set; } = null;

        public ReportsHub(IConfiguration config)
        {
            _url = $"{config.GetValue<string>("api:communication")}/reporthub";
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

        public void SetReportNotificationListener()
        {
            if (Connection == null)
                throw new NullReferenceException("No established connection to the server");

            Connection.Remove("ReceiveReportNotification");

            Connection.On("ReceiveReportNotification", () =>
            {
                ToastRaiser.Warn("Uma nova denúncia foi feita");
            });
        }

        public void CloseConnection()
        {
            Connection.Remove("ReceiveReportNotification");
            Connection = null;
        }
    }
}
