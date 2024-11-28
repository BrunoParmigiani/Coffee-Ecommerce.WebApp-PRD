using Coffee_Ecommerce.WebApp.Features.Footer.Create;
using Coffee_Ecommerce.WebApp.Features.Footer.Delete;
using Coffee_Ecommerce.WebApp.Features.Footer.GetAll;
using Coffee_Ecommerce.WebApp.Features.Footer.GetById;
using Coffee_Ecommerce.WebApp.Features.Footer.Update;

namespace Coffee_Ecommerce.WebApp.Features.Footer
{
    public interface IFooterClient
    {
        [Post("/api/FooterItem")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Delete("/api/FooterItem/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/FooterItem")]
        Task<GetAllResult> GetAllAsync();

        [Get("/api/FooterItem/{id}")]
        Task<GetByIdResult> GetByIdAsync(Guid id);

        [Put("/api/FooterItem")]
        Task<UpdateResult> UpdateAsync([Body] UpdateRequest request);
    }
}
