
using System.Text;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";
            #region
            Console.WriteLine("6.3.1");
            Exercise1(text);

            Console.WriteLine("\n6.3.2");
            Exercise2(text);

            Console.WriteLine("\n6.3.3");
            Exercise3(text);

            Console.WriteLine("\n6.3.4");
            Exercise4(text);

            Console.WriteLine("\n6.3.5");
            Exercise5(text);

            Console.WriteLine("\n6.3.6");
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
            Console.WriteLine($"\n置換語文字列:{replaced}");
        }

        private static void Exercise3(string text) {
            string[] words = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var word in words) {
                sb.Append(word);
            }
            Console.WriteLine(sb.ToString());
        }

        private static void Exercise4(string text) {
            Console.WriteLine($"単語数:{text.Split(' ').Length}");
        }

        private static void Exercise5(string text) {
            text.Split(' ').Where(s => 4 >= s.Length).ToList().ForEach(Console.WriteLine);
        }

        //アルファベットの数をカウントして表示する
        private static void Exercise6(string text) {
            var str = text.ToLower().Replace(" ", "");

            //辞書（ディクショナリ）を使った集計
            var alphDicCount = Enumerable.Range('a', 26).
                ToDictionary(num => ((char)num).ToString(), num => 0);

            var dict = new SortedDictionary<char, int>();
            foreach (var c in str) {
                if (dict.ContainsKey(c)) {
                    dict[c]++;      //登録されている場合
                } else {
                    dict[c] = 1;    //未登録の場合
                }
            }
            foreach (var word in dict) {
                Console.WriteLine(word.Key + ":" + word.Value);
            }

            //配列を用いた集計



            //'a'から順にカウントして集計


        }
    }
}
