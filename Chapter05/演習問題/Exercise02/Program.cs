using Exercise01;

namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            // 5.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980, 1),
                new YearMonth(1990, 4),
                new YearMonth(2000, 7),
                new YearMonth(2010, 9),
                new YearMonth(2024, 12),
            };

            Console.WriteLine("5.2.2");
            Exercise2(ymCollection);

            Console.WriteLine("5.2.4");
            Exercise4(ymCollection);


            Console.WriteLine("5.2.5");
            Exercise5(ymCollection);
        }

        private static void Exercise2(YearMonth[] ymCollection) {
            foreach(var obj in ymCollection) {
                Console.WriteLine(obj);
            }
        }

        private static void Exercise4(YearMonth[] ymCollection) {
            var obj = Search21Century(ymCollection);
            if (obj is not null) {
                Console.WriteLine(obj);
                return;
            }
            Console.WriteLine("21世紀のデータはありません");
            return;
        }

        private static void Exercise5(YearMonth[] ymCollection) {
        }

        public static YearMonth Search21Century(YearMonth[] ymCollection) {
            foreach (var item in ymCollection) {
                if (item.IS21Century) {
                    return item;
                }
            }
            return null;
        }
    }
}
