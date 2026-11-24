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
                $"{weather.Temperature} ℃";
        }
    }
}
