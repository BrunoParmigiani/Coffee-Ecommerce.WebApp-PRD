using System.Text.Json.Serialization;

namespace Coffee_Ecommerce.WebApp.ThirdParty.GoogleCloud.MapsPlatform
{
    public sealed class Coordinates
    {
        [JsonPropertyName("lat")]
        public float Latitude { get; set; }

        [JsonPropertyName("lng")]
        public float Longitude { get; set; }
    }
}
