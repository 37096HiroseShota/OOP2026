using Microsoft.VisualBasic;

namespace Section01 {
    internal class Program {
        static void Main(string[] args) {

            var cities = new List<string> {
               "Tokyo",
               "New Delhi",
               "Bangkok",
               "London",
               "Paris",
               "Berlin",
               "Canberra",
               "Hong Kong",
            };

            var name = cities.Find(s => s.Length == 6);
            Console.WriteLine(name);

            var exists = cities.Exists(s => s[0] == 'o');
            Console.WriteLine(exists);
        }
    }
}