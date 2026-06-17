namespace Section01 {
    internal class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 9, 7, 5, 4, 2, 5, 4, 0, 4, 1, 0, 4 };

            var books = Books.GetBooks();
            var priceAverage = books.Average(x => x.Price);
            var pageAverage = books.Sum(x => x.Pages);
            var maxPrice = books.Max(x => x.Price);

            Console.WriteLine($"平均金額:{priceAverage:#,0}円");
            Console.WriteLine($"合計ページ:{pageAverage:#,0}ページ");
            Console.WriteLine($"高価な本:{maxPrice:#,0}円");

            Console.WriteLine("\n--- 500円以上の本 ---");
            books.Where(x => x.Price >= 500).ToList().ForEach
                (s => Console.WriteLine($"作品名:{s.Title} 値段:{s.Price}円"));

            //250ページ以上の本を上位3冊出力
            var array = books.Where(x => x.Pages >= 250).Take(3);
            foreach(var book in array) {
                Console.WriteLine(book.Title);
            }
        }
    }
}
