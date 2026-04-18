using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7
{
    class Watchlist
    {
        public string watchlistName { get; set; }
        public string createdBy { get; set; }
        public List<movies> movies { get; set; }
    }
    class movies
    {
        public string id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string genre { get; set; }
        public float rating { get; set; }
    }
    internal class Watchlist_103022430003
    {
        public void ReadJSON()
        {
            string JSONPath = "jurnal7_2_103022430003.json";
            if (File.Exists(JSONPath))
            {
                string jsonData = File.ReadAllText(JSONPath);
                var watchList = JsonSerializer.Deserialize<Watchlist>(jsonData);
                Console.WriteLine($"Watch List Name: {watchList.watchlistName}");
                Console.WriteLine($"Created By: { watchList.createdBy}");
                Console.WriteLine("Movies: ");
                foreach (movies movies in watchList.movies)
                {
                    Console.WriteLine($"{movies.id} {movies.title} ({movies.year} - {movies.rating})");
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan");
            }
        }
    }
}
