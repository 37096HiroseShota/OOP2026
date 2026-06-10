namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var input1 = Console.ReadLine();
            var input2 = Console.ReadLine();

            if (String.Compare(input1, input2, ignoreCase: true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
