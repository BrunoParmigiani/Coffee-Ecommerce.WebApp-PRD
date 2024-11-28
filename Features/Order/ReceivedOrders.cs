using Blazored.LocalStorage;
using Coffee_Ecommerce.WebApp.Features.NewOrder;
using Coffee_Ecommerce.WebApp.Features.Order.Create;
using Coffee_Ecommerce.WebApp.Shared.Events;

namespace Coffee_Ecommerce.WebApp.Features.Order
{
    public sealed class ReceivedOrders
    {
        public List<CreateRequest> NewOrders { get; private set; } = [];
        private readonly INewOrderService _newOrderService;
        private ILocalStorageService _localStorage;
        private const string KEY = "new_orders";
        
        public ReceivedOrders(ILocalStorageService localStorage, INewOrderService newOrderService)
        {
            _localStorage = localStorage;
            _newOrderService = newOrderService;
        }

        public async Task AddOrder(CreateRequest order)
        {
            NewOrders.Add(order);
            await SaveLocal();
        }

        public async Task RemoveOrder(CreateRequest order)
        {
            NewOrders.RemoveAll(o => o.Id == order.Id);
            await SaveLocal();
        }

        private async Task SaveLocal()
        {
            bool keyExists = await _localStorage.ContainKeyAsync(KEY);

            if (!keyExists)
            {
                await _localStorage.SetItemAsync(KEY, NewOrders);
            }

            var hasNullValue = await _localStorage.GetItemAsync<List<CreateRequest>>(KEY);

            if (hasNullValue == null)
            {
                await _localStorage.SetItemAsync(KEY, NewOrders);
            }

            await _localStorage.SetItemAsync(KEY, NewOrders);
        }

        public async Task LoadLocal()
        {
            bool keyExists = await _localStorage.ContainKeyAsync(KEY);

            if (!keyExists)
                return;

            var result = await _localStorage.GetItemAsync<List<CreateRequest>>(KEY);

            if (result == null)
                return;

            NewOrders = result;
        }

        public async Task GetOrders()
        {
            try
            {
                var pending = await _newOrderService.GetByEstablishmentAsync();

                var result = new HashSet<CreateRequest>(pending);

                if (!result.Any())
                    return;

                var uniqueCollection = result.Union(NewOrders, new RequestComparer());

                NewOrders.RemoveAll(_ => true);

                NewOrders.AddRange(uniqueCollection);
            }
            catch (ApiException ex)
            {
                ErrorRaiser.Raise(ex, "Não foi possível buscar os novos pedidos na base");
            }
        }

        public async Task Load()
        {
            await LoadLocal();
            await GetOrders();
        }
    }
}
