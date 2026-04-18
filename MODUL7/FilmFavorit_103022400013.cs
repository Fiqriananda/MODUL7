using System;
using System.Collections.Generic;
using System.Text.Json;

namespace MODUL7
{
    internal class FilmFavorit_103022400013
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes {  get; set; }
        public bool isWatched { get; set; }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103022400013.json");
            var data = JsonSerializer.Deserialize<FilmFavorit_103022400013>(json);

            Console.WriteLine($"Judul: {data.title}");
            Console.WriteLine($"Director: {data.director}");
            Console.WriteLine($"year: {data.year}");
            Console.WriteLine($"rating: {data.rating}");
            Console.WriteLine($"durationMinutes: {data.durationMinutes}");
            Console.WriteLine($"isWatched: {data.isWatched}");
        }
    }
}
