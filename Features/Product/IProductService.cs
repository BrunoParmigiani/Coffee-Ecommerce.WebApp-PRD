using Coffee_Ecommerce.WebApp.Features.Product.Create;
using Coffee_Ecommerce.WebApp.Features.Product.Update;

namespace Coffee_Ecommerce.WebApp.Features.Product
{
    public interface IProductService
    {
        public Task<ProductEntity?> CreateAsync(CreateRequest request);
        public Task<bool> DeleteAsync(Guid id);
        public Task<List<ProductEntity>?> GetAllAsync();
        public Task<List<ProductEntity>?> GetByEstablishmentAsync(Guid id);
        public Task<ProductEntity?> GetByIdAsync(Guid id);
        public Task<ProductEntity?> UpdateAsync(UpdateRequest request);
    }
}