
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
            Console.WriteLine("(" + start + "フィートから" + stop + "フィートまでの"
                + "メートルへの変換表を表示" + ")");
            
            Console.WriteLine();

            FeetConverter converter = new FeetConverter();

            for (int feet = start; feet <= stop; feet++) {
                double meter = converter.ToMeter(feet);
                Console.WriteLine($"{feet}ft = {meter:0.0000}m");
            }
        }

        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start, int stop) {
            Console.WriteLine("(" + start + "メートルから" + stop + "メートルまでの"
                + "フィートへの変換表を表示" + ")");
            
            Console.WriteLine();

            FeetConverter converter = new FeetConverter();

            for (int meter = start; meter <= stop; meter++) {
                double feet = converter.FromMeter(meter);
                Console.WriteLine($"{meter}m = {feet:0.0000}ft");
            }
        }
    }
}