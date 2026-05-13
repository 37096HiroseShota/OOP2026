using System.Globalization;

namespace SalesCalculator {
    internal class Program {
        static void Main(string[] args) {
            var sales = new SalesCounter(@"data\sales.csv");
            var amountPerStore = sales.GetPerStoreSales();
            var amountPerProductCategory = sales.GetPerProductCategorySales();

            Console.WriteLine("****店舗別売上****");
            foreach (var obj in amountPerStore) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }

            Console.WriteLine();

            Console.WriteLine("****商品カテゴリ別売上高****");
            foreach (var obj in amountPerProductCategory) {
                Console.WriteLine($"{obj.Key} {obj.Value}");
            }
        }
    }
}