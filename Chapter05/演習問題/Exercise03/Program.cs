using Exercise01;

namespace Exercise03 {
    internal class Program {
        static void Main(string[] args) {
            var a = new YearMonth(2000, 12);
            var b = new YearMonth(2000, 12);

            #region class
            //別のオブジェクトのため、等しくない
            if (a == b) {
                Console.WriteLine("aとbは等しい");
            } else {
                Console.WriteLine("aとbは等しくない");
            }

            b = a;

            //同じ参照のため、等しい
            if (a == b) {
                Console.WriteLine("aとbは等しい");
            } else {
                Console.WriteLine("aとbは等しくない");
            }
            #endregion

            #region record
            //値が同じであるため、等しい
            if (a == b) {
                Console.WriteLine("aとbは等しい");
            } else {
                Console.WriteLine("aとbは等しくない");
            }
            #endregion
        }
    }
}
