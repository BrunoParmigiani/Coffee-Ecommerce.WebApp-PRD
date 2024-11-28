using Coffee_Ecommerce.WebApp.Features.Establishment;

namespace Coffee_Ecommerce.WebApp.Features.Locator
{
    public sealed class LocatorService : ILocatorService
    {
        private readonly ILocatorClient _client;

        public LocatorService(ILocatorClient client)
        {
            _client = client;
        }

        public async Task<EstablishmentEntity> GetNearest()
        {
            try
            {
                var result = await _client.GetNearest();

                return result.Data;
            }
            catch (ApiException)
            {
                throw;
            }
        }
    }
}
