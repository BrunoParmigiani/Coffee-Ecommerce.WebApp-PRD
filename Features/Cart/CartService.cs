using Blazored.LocalStorage;
using Coffee_Ecommerce.WebApp.Features.Order;
using Coffee_Ecommerce.WebApp.Features.Product;
using Coffee_Ecommerce.WebApp.Shared.Events;
using Coffee_Ecommerce.WebApp.Shared.Models;

namespace Coffee_Ecommerce.WebApp.Features.Cart
{
    public sealed class CartService : ICartService
    {
        private readonly ILocalStorageService _localStorage;
        private readonly CfeContext _cfeContext;
        private const string KEY = "cart";

        public CartService(ILocalStorageService localStorage, CfeContext cfeContext)
        {
            _localStorage = localStorage;
            _cfeContext = cfeContext;
        }

        public async Task AddItem(ProductEntity product, int quantity)
        {
            OrderItem item = new OrderItem(product, quantity);

            var result = await GetItems();

            if (result.Any(i => i.Name == item.Name))
            {
                ErrorRaiser.Raise("Este item já está no carrinho");
                return;
            }

            result.Add(item);
            ToastRaiser.Notifty("Item adicionado ao carrinho");

            await _localStorage.SetItemAsync(KEY, result);
        }

        public async Task<List<OrderItem>> GetItems()
        {
            bool keyExists = await _localStorage.ContainKeyAsync(KEY);

            if (!keyExists)
            {
                await _localStorage.SetItemAsync(KEY, new List<OrderItem>());
            }

            var hasNullValue = await _localStorage.GetItemAsync<List<OrderItem>>(KEY);

            if (hasNullValue == null)
            {
                await _localStorage.SetItemAsync(KEY, new List<OrderItem>());
            }

            return await _localStorage.GetItemAsync<List<OrderItem>>(KEY);
        }

        public async Task<bool> RemoveItem(OrderItem item)
        {
            var result = await GetItems();

            var deleted = result.Remove(item);

            await _localStorage.SetItemAsync(KEY, result);

            return deleted;
        }

        public async Task<bool> UpdateItem(OrderItem item)
        {
            var result = await GetItems();

            result.Remove(item);
            result.Add(item);

            await _localStorage.SetItemAsync(KEY, result);

            return result.Contains(item);
        }

        public async Task ClearCart()
        {
            var result = await GetItems();

            result.RemoveAll(item => item.Establishment == _cfeContext.Establishment.Id);

            await _localStorage.SetItemAsync(KEY, result); 
        }
    }
}
