using System.Text.Json.Serialization;

namespace kbdesilva.Models
{
    public class WeatherDesc
    {
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
