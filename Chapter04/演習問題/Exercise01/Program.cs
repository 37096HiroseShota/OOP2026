
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
            foreach (var item in langs) {
                if (item.Contains('S')) {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < langs.Count; i++) {
                if (langs[i].Contains('S')) {
                    Console.WriteLine(langs[i]);
                }
            }

            Console.WriteLine();

            int count = 0;
            while (true) {
                if (langs[count].Contains('S')) {
                    Console.WriteLine(langs[count]);
                }
                if (count >= (langs.Count - 1)) {
                    break;
                }
                count++;
            }
        }

        private static void Exercise2(List<string> langs) {
            langs.Where(s => s.Contains('S')).ToList().ForEach(s => Console.WriteLine(s));
        }

        private static void Exercise3(List<string> langs) {
            var lang = langs.Find(s => s.Length >= 10);
            if (lang is null) {
                lang = "unknown";
            }
        }

    }
}