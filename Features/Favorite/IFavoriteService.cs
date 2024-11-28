using Coffee_Ecommerce.WebApp.Features.Favorite.GetByUser;

namespace Coffee_Ecommerce.WebApp.Features.Favorite
{
    public interface IFavoriteService
    {
        public Task<FavoriteEntity?> CreateAsync(Guid productId);
        public Task<bool> DeleteAsync(Guid id);
        public Task<List<FavoriteData>?> GetByUserAsync();
    }
}
