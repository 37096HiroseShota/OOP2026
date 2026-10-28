namespace Sample0415;

internal class Program {
    static void Main(string[] args) {
        Console.Write("要素数" + ":");

        string? inputnum = Console.ReadLine();
        int num = int.Parse(inputnum!);
        int[] array = new int[num];

        Console.WriteLine("\n(入力)");

        for (int i = 0; i < array.Length; i++) {
            Console.Write("array" + "[" + i + "]" + ":");

            string? inputNum = Console.ReadLine();
            array[i] = int.Parse(inputNum!);
        }

        Console.WriteLine("\n(出力1)");
        
        for (int i = 0; i < array.Length; i++) {
            Console.WriteLine("array" + "[" + i + "]" + ":" + array[i]);
        }
        
        Console.WriteLine("\n合計" + ":" + array.Where(n => n % 2 == 0).Sum());
        Console.WriteLine("\n(出力2)");
        
        astOut(array);
    }

    static void astOut(int[] num) {
        for (int i = 0; i < num.Length; i++) {
            Console.Write("array" + "[" + i + "]" + ":");

            for (int j = 0; j <= i; j++) {
                Console.Write("*\n");
            }
        }
    }
}