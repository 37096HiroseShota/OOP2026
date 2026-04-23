
using System;
using System.Diagnostics.Metrics;
using System.Runtime;
using System.Threading;

namespace DistanceConverter {
    internal class Program {
        static void Main(string[] args) {
            if (args.Length == 3
                && int.TryParse(args[1], out var start)
                    && int.TryParse(args[2], out var stop)) {

                if (args[0] == "-tom") {
                    PrintFeetToMeterList(start, stop);   //メートルへの変換
                } else if (args[0] == "-tof") {
                    PrintMeterToFeetList(start, stop);   //フィートへの変換
                } else {
                    Console.WriteLine("引数形式エラー");
                }
            } else {
                Console.WriteLine("引数エラー");
            }
        }

        //フィートからメートルへの対応表を出力
        private static void PrintFeetToMeterList(int start, int stop) {
            PrintMessage(start, stop, "フィート", "メートル");
            Console.WriteLine();

            for (int feet = start; feet <= stop; feet++) {
                double meter = FeetConverter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            PrintMessage(start, stop, "メートル", "フィート");
            Console.WriteLine();

            for (int meter = start; meter <= stop; meter++) {
                double feet = FeetConverter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }

        private static void PrintMessage(int start, int stop, String from, String to) {
            Console.WriteLine("(" + start + from + "から" + stop + from + "までの"
                + to + "への変換表を表示" + ")");
        }
    }
}