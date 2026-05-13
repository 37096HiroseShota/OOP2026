using System.Diagnostics.Metrics;
using System.Threading;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length == 3
                && int.TryParse(args[1], out var start)
                    && int.TryParse(args[2], out var stop)) {

                if (args[0] == "-tom") {
                    PrintInchToMeterList(start, stop);   //メートルへの変換
                } else if (args[0] == "-toi") {
                    PrintMeterToInchList(start, stop);   //インチへの変換
                } else {
                    Console.WriteLine("引数形式エラー");
                }
            } else {
                Console.WriteLine("引数エラー");
            }
        }

        //インチからメートルへの対応表を出力
        private static void PrintInchToMeterList(int start, int stop) {
            PrintMessage(start, stop, "インチ", "メートル");
            Console.WriteLine();

            for (int Inch = start; Inch <= stop; Inch++) {
                double meter = InchConverter.ToMeter(Inch);
                Console.WriteLine($"{Inch}inch = {meter:0.0000}m");
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop) {
            PrintMessage(start, stop, "メートル", "インチ");
            Console.WriteLine();

            for (int meter = start; meter <= stop; meter++) {
                double Inch = InchConverter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {Inch:.00}inch");
            }
        }

        private static void PrintMessage(int start, int stop, String from, String to) {
            Console.WriteLine("(" + start + from + "から" + stop + from + "までの"
                + to + "への変換表を表示" + ")");
        }
    }
}
