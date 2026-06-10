namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列:");
            var str = Console.ReadLine();

            if (int.TryParse(str, out var num)) {
                Console.WriteLine("\nカンマ付き数字文字列:" +$"{num:#,0}");
            } else {
                Console.WriteLine("\n整数文字列ではありません");
            }
        }
    }
}
