using Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform;

namespace Coffee_Ecommerce.WebApp.Services.Interfaces
{
    public interface IAddressService
    {
        public Task<GeocodeResponse?> ValidatePostalCode(string postalCode);
        public string FormatPostalCode(string postalCode);
    }
}
