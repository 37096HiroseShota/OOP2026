namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("整数文字列:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out var num)) {
                Console.WriteLine(num.ToString("#,0"));
            } else {
                Console.WriteLine("整数文字列ではありません");
            }
        }
    }
}
