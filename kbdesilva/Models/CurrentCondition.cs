using System.Text.Json.Serialization;

namespace kbdesilva.Models
{

    public class CurrentCondition
    {
        [JsonPropertyName("temp_C")]
        public string Temp_C { get; set; }
        [JsonPropertyName("weatherDesc")]
        public List<WeatherDesc> WeatherDesc { get; set; }
    }
}
