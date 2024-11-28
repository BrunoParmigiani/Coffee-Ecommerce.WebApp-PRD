using Coffee_Ecommerce.WebApp.Features.Order;
using Coffee_Ecommerce.WebApp.Features.Product;

namespace Coffee_Ecommerce.WebApp.Features.Cart
{
    public interface ICartService
    {
        public Task AddItem(ProductEntity product, int quantity);
        public Task<List<OrderItem>> GetItems();
        public Task<bool> RemoveItem(OrderItem item);
        public Task<bool> UpdateItem(OrderItem item);
        public Task ClearCart();
    }
}
