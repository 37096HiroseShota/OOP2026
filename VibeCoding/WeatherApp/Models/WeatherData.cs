namespace WeatherApp.Models;

public class WeatherData {
    public double Temperature { get; set; }

    public int Humidity { get; set; }

    public double WindSpeed { get; set; }

    public int WeatherCode { get; set; }

    public List<DailyForecast> Forecasts { get; set; } = [];
}