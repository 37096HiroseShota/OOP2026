
namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            var text = "Cozy lummox gives smart squid who job pen";

            Exercise01(text);
            Console.WriteLine();
            Exercise02(text);
        }

        private static void Exercise01(string text) {
            var str = text.ToUpper();

            var alphDicCount = Enumerable.Range('A', 26).
                ToDictionary(n => ((char)n), n => 0);

            foreach (var c in str) {
                if ('A' <= c && c <= 'Z') {
                    alphDicCount[c]++;
                }
            }

            foreach (var c in alphDicCount) {
                Console.WriteLine($"{c.Key}:{c.Value}");
            }
        }

        private static void Exercise02(string text) {
            var str = text.ToUpper();

            var dict = new SortedDictionary<char, int>();

            foreach (var c in str) {
                if ('A' <= c && c <= 'Z') {
                    if (dict.ContainsKey(c)) {
                        dict[c]++;
                    } else {
                        dict[c] = 1;
                    }
                }
            }

            foreach (var c in dict) {
                Console.WriteLine($"{c.Key}:{c.Value}");
            }
        }
    }
}
