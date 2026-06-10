
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("6.3.2");
            Exercise2(text);

            Console.WriteLine("6.3.3");
            Exercise3(text);

            Console.WriteLine("6.3.4");
            Exercise4(text);

            Console.WriteLine("6.3.5");
            Exercise5(text);

            Console.WriteLine("6.3.6");
            Exercise6(text);
            #endregion
        }

        private static void Exercise1(string text) {
            Console.WriteLine($"空白数:{text.Count(c => c == ' ')}");
        }

        private static void Exercise2(string text) {
            Console.Write("検索:");
            var search = Console.ReadLine();

            Console.Write("置換:");
            var replace = Console.ReadLine();

            var replaced = text.Replace(search, replace);
            Console.WriteLine($"置換語文字列:{replaced}");
        }

        private static void Exercise3(string text) {
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words) {
                sb.Append(word + ' ');
            }
            Console.WriteLine(sb.ToString());
        }

        private static void Exercise4(string text) {
            string[] words = text.Split(' ');
            Console.WriteLine("単語数" + words.Length);
        }

        private static void Exercise5(string text) {
            string[] words = text.Split(' ');
            words.Where(c => c.Length >= 4).ToList().ForEach(s => Console.WriteLine(s));
        }

        private static void Exercise6(string text) {

        }
    }
}
