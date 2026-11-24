using System.Net.Http;
using System.Text.Json;
using WeatherApp.Models;

namespace WeatherApp.Services;

public class WeatherService {
    private readonly HttpClient _httpClient = new();

    public async Task<WeatherData?> GetWeatherAsync() {
        string url =
            "https://api.open-meteo.com/v1/forecast" +
            "?latitude=35.6895" +
            "&longitude=139.6917" +
            "&current=temperature_2m";

        string json = await _httpClient.GetStringAsync(url);

        using JsonDocument doc = JsonDocument.Parse(json);

        double temperature =
            doc.RootElement
               .GetProperty("current")
               .GetProperty("temperature_2m")
               .GetDouble();

        return new WeatherData {
            Temperature = temperature
        };
    }
}