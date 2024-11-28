namespace Coffee_Ecommerce.WebApp.Features.Footer.Update
{
    public sealed class UpdateRequest
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
    }
}
