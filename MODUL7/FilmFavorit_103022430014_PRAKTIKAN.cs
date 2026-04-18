using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7
{
    public class FilmFavorit_103022430014_PRAKTIKAN
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }
        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022430014.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022430014_PRAKTIKAN>(json);

            Console.WriteLine(
                $"film favorit saya dengan judul film {data.title} yang diproduksi oleh {data.director} " +
                $"dan dirilis pada tahun {data.year} dengan genre {data.genre} memiliki rating {data.rating}. Film tersebut memiliki durasi waktu film {data.durationMinutes} menit dan film {data.isWatched}");
        }
    }
}
