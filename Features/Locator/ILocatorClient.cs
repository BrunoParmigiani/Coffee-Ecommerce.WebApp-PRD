namespace Coffee_Ecommerce.WebApp.Features.Locator
{
    public interface ILocatorClient
    {
        [Get("/nearest")]
        public Task<NearestResult> GetNearest();
    }
}
