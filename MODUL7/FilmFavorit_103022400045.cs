using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7
{
    public class FilmFavorit_103022400045
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
            string json = File.ReadAllText("jurnal7_1_103022400045.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400045>(json);

            Console.WriteLine(
                $"Film Favorit : {data.title} " +
                $"diproduksi oleh :{data.director} " +
                $"dirilis pada tahun : {data.year} " +
                $"Genre : {data.genre} " +
                $"memiliki rating : {data.rating}. " +
                $"Film tersebut memiliki durasi waktu film : {data.durationMinutes} menit " +
                $"dan film : {data.isWatched}");
        }
    }
}