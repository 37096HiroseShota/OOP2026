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
            "&current=temperature_2m,relative_humidity_2m,wind_speed_10m,weather_code" +
            "&daily=weather_code,temperature_2m_max,temperature_2m_min,precipitation_probability_max" +
            "&forecast_days=7";

        string json = await _httpClient.GetStringAsync(url);

        using JsonDocument doc = JsonDocument.Parse(json);

        JsonElement current =
            doc.RootElement.GetProperty("current");

        JsonElement daily =
            doc.RootElement.GetProperty("daily");

        var forecasts = new List<DailyForecast>();

        var dates =
            daily.GetProperty("time")
                 .EnumerateArray()
                 .ToArray();

        var maxTemps =
            daily.GetProperty("temperature_2m_max")
                 .EnumerateArray()
                 .ToArray();

        var minTemps =
            daily.GetProperty("temperature_2m_min")
                 .EnumerateArray()
                 .ToArray();

        var rains =
            daily.GetProperty("precipitation_probability_max")
                 .EnumerateArray()
                 .ToArray();

        var weatherCodes =
            daily.GetProperty("weather_code")
                 .EnumerateArray()
                 .ToArray();

        for (int i = 0; i < dates.Length; i++) {
            forecasts.Add(new DailyForecast {
                Date = DateTime.Parse(dates[i].GetString()!),

                MaxTemperature =
                    maxTemps[i].GetDouble(),

                MinTemperature =
                    minTemps[i].GetDouble(),

                PrecipitationProbability =
                    rains[i].GetInt32(),

                WeatherCode =
                    weatherCodes[i].GetInt32()
            });
        }

        return new WeatherData {
            Temperature =
        current.GetProperty("temperature_2m").GetDouble(),

            Humidity =
        current.GetProperty("relative_humidity_2m").GetInt32(),

            WindSpeed =
        current.GetProperty("wind_speed_10m").GetDouble(),

            WeatherCode =
        current.GetProperty("weather_code").GetInt32(),

            Forecasts = forecasts
        };
    }
}