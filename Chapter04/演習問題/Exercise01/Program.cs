
using System.Linq;

namespace Exercise01 {
    internal class Program {
        static void Main(string[] args) {
            List<string> langs = [
                "C#", "Java", "Ruby", "PHP", "Python", "TypeScript",
                "JavaScript", "Swift", "Go",
            ];

            Exercise1(langs);
            Console.WriteLine("---");
            Exercise2(langs);
            Console.WriteLine("---");
            Exercise3(langs);
        }

        private static void Exercise1(List<string> langs) {
            Console.WriteLine("\nforeach文で出力");
            foreach (var lang in langs) {
                if (lang.Contains('S')) {
                    Console.WriteLine(lang);
                }
            }

            Console.WriteLine("\nfor文で出力");
            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
            }

            Console.WriteLine("\nwhile文で出力");
            int count = 0;
            while (count < langs.Count) {
                if (langs[count].Contains('S')) {
                    Console.WriteLine(langs[count]);
                }
                count++;
            }
        }

        private static void Exercise2(List<string> langs) {
            langs.Where(s => s.Contains('S')).ToList().ForEach(s => Console.WriteLine(s));
        }

        private static void Exercise3(List<string> langs) {
            var lang = langs.Find(s => s.Length == 10) ?? "unknown";
            Console.WriteLine(lang);
        }
    }
}