using System.Text.Json.Serialization;

namespace Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform
{
    public sealed class GeocodeResponse
    {
        [JsonPropertyName("results")]
        public GeocodeResults[] Results { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
