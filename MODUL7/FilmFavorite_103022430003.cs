using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7
{

    class Film
    {
        public string title { get; set; }
        public string director { get; set; }
        public string year { get; set; }
        public string genre { get; set; }
        public int rating { get; set; }
        public int durationMinutes { get; set; }
        public bool isWatched { get; set; }

    }
    internal class FilmFavorite_103022430003
    {
        public void ReadJSON()
        {
            string JSONPath = "jurnal7_1_103022430003.json";
            if (File.Exists(JSONPath))
            {
                string jsonData = File.ReadAllText(JSONPath);
                var filmFavorite = JsonSerializer.Deserialize<Film>(jsonData);
                Console.WriteLine($"Title: {filmFavorite.title}\nDirector: {filmFavorite.director}\nYear: {filmFavorite.year}\nGenre: {filmFavorite.genre}" +
                    $"\nRating: {filmFavorite.rating.ToString()}\nDuration Minutes: {filmFavorite.durationMinutes.ToString()}" +
                    $"\nIs Watched: {filmFavorite.isWatched.ToString()} ");
            }
            else
            {
                Console.WriteLine("File tidak ditemukan");
            }
        }
    }
}
