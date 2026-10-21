using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;

namespace Exercise01_WPF;

public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();
    }

    private async void Button_Click(object sender, RoutedEventArgs e) {
        var ofd = new OpenFileDialog();

        if (ofd.ShowDialog() is true) {
            TextArea.Text = await TextReaderSample.ReadTextAsync(ofd.FileName);
        }
    }
}

internal class TextReaderSample {
    internal static async Task<string> ReadTextAsync(string fileName) {
        var sb = new StringBuilder();

        //ここに非同期でテキストファイルを読み込む処理を記述する
        using var sr = new StreamReader(fileName);

        while (!sr.EndOfStream) {
            var line = await sr.ReadLineAsync();
            sb.AppendLine(line);
        }

        return sb.ToString();
    }
}