namespace Coffee_Ecommerce.WebApp.Features.Favorite
{
    public sealed class FavoriteEntity
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProductId { get; set; }
    }
}
