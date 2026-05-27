
using System.ComponentModel.Design;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(" --- 4.2.1 ---");
            Exercise1();
            Console.WriteLine("\n --- 4.2.2 ---");
            Exercise2();
            Console.WriteLine("\n --- 4.2.3 ---");
            Exercise3();
        }

        private static void Exercise1() {
            //if-else文を使用
            string? inputNumber = Console.ReadLine();
            int.TryParse(inputNumber, out var number);

            if (number < 0) {
                Console.WriteLine(number);
            } else if (number < 100) {
                Console.WriteLine(number * 2);
            } else if (number < 500) {
                Console.WriteLine(number * 3);
            } else {
                Console.WriteLine(number);
            }
        }

        private static void Exercise2() {
            //switch文を使用

        }

        private static void Exercise3() {
            //switch式を使用


        }
    }
}
