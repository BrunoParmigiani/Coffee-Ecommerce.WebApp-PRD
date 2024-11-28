namespace Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform.Clients
{
    public interface IGeocodingClient
    {
        [Get("/geocode/json?key={accessKey}&address={zipcode}")]
        public Task<GeocodeResponse> GetLocationAsync(string accessKey, string zipcode);
    }
}
