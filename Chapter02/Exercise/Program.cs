using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            //2.1.3
            // List<Song> songs = new List<Song>();

            // var song1 = new Song("Let it be", "The Beatles", 243);
            // songs.Add(song1);

            // var song2 = new Song("Let it be", "The Beatles", 243);
            // songs.Add(song2);

            // var song3 = new Song("Let it be", "The Beatles", 243);
            // songs.Add(song3);

            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
                new Song("ABC","DEF",293),
                new Song("GHI","JKL",276),
                new Song("MNO","PQR",231),
                new Song("STU","VWX",273),

            };

            PrintSongs(songs);
        }

        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {

                Console.WriteLine("[0],[1],[2]",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}