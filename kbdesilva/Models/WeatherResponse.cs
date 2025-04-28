using System.Text.Json.Serialization;

namespace kbdesilva.Models
{
    public class WeatherResponse
    {
        [JsonPropertyName("current_condition")]
        public List<CurrentCondition> CurrentCondition { get; set; }

    }
}
