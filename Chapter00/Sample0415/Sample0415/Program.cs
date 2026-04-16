using System.Security.Cryptography.X509Certificates;

namespace Sample0415
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("要素数" + ":");
            string? inputnum = Console.ReadLine();

            int num = int.Parse(inputnum);

            int[] array = new int[num];
            int sum = 0;

            Console.WriteLine();
            Console.WriteLine("(入力)");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("array" + "[" + i + "]" + ":");

                string? inputNum = Console.ReadLine();

                array[i] = int.Parse(inputNum);
            }
            Console.WriteLine();

            //集計
            //for (int i = 0; i < array.Length; i++)
            //{
            //    sum += array[i];
            //}

            Console.WriteLine("(出力1)");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("array" + "[" + i + "]" + ":" + array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("合計" + ":" + array.Where(n => n % 2 == 0).Sum()); //LINQ

            Console.WriteLine();
            Console.WriteLine("(出力2)");
            astOut(array);
        }
        static void astOut(int[] num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("array" + "[" + i + "]" + ":");
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
