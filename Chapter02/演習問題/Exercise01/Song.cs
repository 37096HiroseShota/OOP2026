using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    public class Song {
        public string Title { get; set; } = string.Empty;
        public string ArtistName { get; set; } = string.Empty;
        public int Lenght { get; set; }

        public Song(string title, string artistname, int lenght) {
            Title = title;
            ArtistName = artistname;
            Lenght = lenght;
        }
    }
}