using Coffee_Ecommerce.WebApp.Features.Footer.Create;
using Coffee_Ecommerce.WebApp.Features.Footer.Update;

namespace Coffee_Ecommerce.WebApp.Features.Footer
{
    public interface IFooterService
    {
        public Task<FooterItemEntity?> CreateAsync(CreateRequest request);
        public Task<bool> DeleteAsync(Guid id);
        public Task<List<FooterItemEntity>?> GetAllAsync();
        public Task<FooterItemEntity?> GetByIdAsync(Guid id);
        public Task<FooterItemEntity?> UpdateAsync(UpdateRequest request);
    }
}
