namespace WeatherApp.Models;

public class DailyForecast {
    public DateTime Date { get; set; }

    public double MaxTemperature { get; set; }

    public double MinTemperature { get; set; }

    public int PrecipitationProbability { get; set; }

    public int WeatherCode { get; set; }
}