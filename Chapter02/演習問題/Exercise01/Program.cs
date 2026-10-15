namespace Exercise01;

internal class Program {
    static void Main(string[] args) {
        var songs = new List<Song>();

        Console.WriteLine("***** 曲の登録 *****");
        while (true) {
            Console.Write("曲名：");

            string? title = Console.ReadLine()!;

            if (String.Compare(title, "end", ignoreCase: true) == 0) {
                break;
            }

            Console.Write("アーティスト名：");

            string? artistName = Console.ReadLine()!;

            Console.Write("演奏時間（秒）：");
            
            int lenght = int.Parse(Console.ReadLine()!);

            Console.WriteLine();

            var song = new Song(title, artistName, lenght);
            
            songs.Add(song);
        }

        PrintSongs(songs);
    }

    private static void PrintSongs(IEnumerable<Song> songs) {
        foreach (var song in songs) {
            Console.WriteLine($"{song.Title},{song.ArtistName},{song.Lenght / 60}:{(song.Lenght % 60):00}");
        }
    }
}