using Coffee_Ecommerce.WebApp.Features.Product;

namespace Coffee_Ecommerce.WebApp.Features.Favorite.GetByUser
{
    public sealed class FavoriteData
    {
        public Guid FavoriteId { get; set; }
        public ProductEntity Product { get; set; }
    }
}
