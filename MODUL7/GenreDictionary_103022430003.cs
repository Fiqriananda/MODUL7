using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace MODUL7
{ 
    class Genre
    {
        public GenreDictionary genre;
    }
    class GenreDictionary
    {
        public string category {  get; set; }
        public GenreInfo GenreInfo { get; set; }
    }

    class GenreInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public List<string> popularMovies { get; set; }
    }
    internal class GenreDictionary_103022430003
    {
        public void ReadJSON()
        {
            string JSONPath = "jurnal7_3_103022430003.json";
            if (File.Exists(JSONPath))
            {
                string jsonData = File.ReadAllText(JSONPath);
                var genre = JsonSerializer.Deserialize<Genre>(jsonData);
                Console.WriteLine($"ID: {genre.genre.category}");
                Console.WriteLine($"Name: {genre.genre.GenreInfo.id}");
                Console.WriteLine($"Name: {genre.genre.GenreInfo.description}");
                Console.Write($"Popular Movies");
                foreach (string movies in genre.genre.GenreInfo.popularMovies)
                {
                    Console.Write(movies);
                }
            }
            else
            {
                Console.WriteLine("File tidak ditemukan");
            }
        }
    }
}
