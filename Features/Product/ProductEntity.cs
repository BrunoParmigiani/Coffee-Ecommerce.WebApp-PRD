namespace Coffee_Ecommerce.WebApp.Features.Product
{
    public sealed class ProductEntity
    {
        public Guid Id { get; set; }
        public Guid CreatorId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public Guid EstablishmentId { get; set; }
    }
}