using Coffee_Ecommerce.WebApp.Features.Favorite.Create;
using Coffee_Ecommerce.WebApp.Features.Favorite.Delete;
using Coffee_Ecommerce.WebApp.Features.Favorite.GetByUser;

namespace Coffee_Ecommerce.WebApp.Features.Favorite
{
    public interface IFavoriteClient
    {
        [Post("/api/Favorite")]
        Task<CreateResult> CreateAsync([Body] CreateRequest request);

        [Delete("/api/Favorite/{id}")]
        Task<DeleteResult> DeleteAsync(Guid id);

        [Get("/api/Favorite")]
        Task<GetByUserResult> GetByUserAsync();
    }
}
