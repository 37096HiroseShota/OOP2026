using System.Windows;
using WeatherApp.Services;

namespace WeatherApp;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        Loaded += MainWindow_Loaded;
    }

    private async void MainWindow_Loaded(object sender, RoutedEventArgs e) {
        WeatherService weatherService = new();

        var weather = await weatherService.GetWeatherAsync();

        if (weather != null) {
            TemperatureText.Text =
                $"気温 : {weather.Temperature:F1} ℃";

            HumidityText.Text =
                $"湿度 : {weather.Humidity} %";

            WindText.Text =
                $"風速 : {weather.WindSpeed:F1} km/h";

            WeatherText.Text =
                $"天気 : {GetWeatherText(weather.WeatherCode)}";

            ForecastGrid.ItemsSource =
                weather.Forecasts;
        }
    }

    private string GetWeatherText(int code) {
        return code switch {
            0 => "快晴",
            1 => "晴れ",
            2 => "一部曇り",
            3 => "曇り",
            45 => "霧",
            48 => "霧氷",
            51 => "弱い霧雨",
            61 => "雨",
            71 => "雪",
            95 => "雷雨",
            _ => $"コード:{code}"
        };
    }
}
