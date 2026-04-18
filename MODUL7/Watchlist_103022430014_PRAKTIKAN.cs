using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Movie
{
    public string id { get; set; }
    public string title { get; set; }
    public int year { get; set; }
    public string genre { get; set; }
    public double rating { get; set; }
}

public class WatchlistData
{
    public string watchlistName { get; set; }
    public string createdBy { get; set; }
    public List<Movie> movies { get; set; }
}

public class Watchlist_103022430014
{
    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103022430014.json");
        WatchlistData data = JsonSerializer.Deserialize<WatchlistData>(json);

        Console.WriteLine("Watchlist Name : " + data.watchlistName);
        Console.WriteLine("Created By : " + data.createdBy);
        Console.WriteLine("Movies : ");
        foreach (var m in data.movies)
        {
            Console.WriteLine($"{m.id} {m.title} ({m.year} - {m.rating})");
        }
    }
}