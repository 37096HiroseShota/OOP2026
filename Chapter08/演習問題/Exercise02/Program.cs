namespace Exercise02 {
    internal class Program {
        static void Main(string[] args) {
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核拡散防止条約");

            // 8.2.3 (Countの呼び出し例)
            // 上のAddメソッドで、２つのオブジェクトを追加しているので、読み込んだ単語数+2が、Countの値になる。
            Console.WriteLine($"用語数:{abbrs.Count}");
            
            Console.WriteLine();   //改行

            // 8.2.3 (Removeの呼び出し例)
            RemovCheck(abbrs, "IOC");
            RemovCheck(abbrs, "NPT");

            // すでに削除してあるので、falseが返る
            RemovCheck(abbrs, "NPT");
            
            Console.WriteLine();   //改行

            // 8.2.4
            // 新たなGetAllメソッドを追加済みなので、使用してLINQで処理を行う
            foreach (var data in abbrs.GetAll().Where(s => s.Key.Length == 3)) {
                Console.WriteLine($"{data.Key}={data.Value}");
            }
        }

        public static void RemovCheck(Abbreviations abbreviations, string abb) {
            if (abbreviations.Remove(abb)) {
                Console.WriteLine("削除しました");
            } else {
                Console.WriteLine("削除できません");
            }
        }
    }
}