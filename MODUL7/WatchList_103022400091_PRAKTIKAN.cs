using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Reflection.Metadata;

public class WatchList_103022400091_PRAKTIKAN
{
    public string WatchListName { get; set; }

    public string CreatedBy  { get; set; }

    public List<Movie> movies {  get; set; }

    public class Movie
    { 
        public string id { get; set; } 
        public string title { get; set; } 
        public int year { get; set; }
        public string genre { get; set; }
        public double rating { get; set; }
    }

    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103022400091.json");
        var data = JsonSerializer.Deserialize<WatchList_103022400091_PRAKTIKAN>(json);

        Console.WriteLine($"Watch Listnya : {data.WatchListName}");
        Console.WriteLine($"Dibuat Oleh : {data.CreatedBy}");

        int i = 1;
        foreach ( var item in data.movies)
        {
            Console.WriteLine($"List Film {i} {item.id} - {item.title} - {item.year} - {item.genre} - {item.rating}");
            i++;
        }
        
    }
}
