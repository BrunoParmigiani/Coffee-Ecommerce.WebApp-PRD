using Coffee_Ecommerce.WebApp.Features.Establishment;

namespace Coffee_Ecommerce.WebApp.Features.Locator
{
    public interface ILocatorService
    {
        public Task<EstablishmentEntity> GetNearest();
    }
}
