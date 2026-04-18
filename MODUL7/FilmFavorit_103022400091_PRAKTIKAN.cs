using System;
using System.IO;
using System.Text.Json;

public class FilmFavorit_103022400091_PRAKTIKAN
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
        string json = File.ReadAllText("jurnal7_1_103022400091.json");
        var data = JsonSerializer.Deserialize<FilmFavorit_103022400091_PRAKTIKAN>(json);

        Console.WriteLine($"Judul Film : {data.title}");
        Console.WriteLine($"Director Film : {data.director}");
        Console.WriteLine($"Tahun Penayangan : {data.year}");
        Console.WriteLine($"Genre Film : {data.genre}");
        Console.WriteLine($"Rating Film : {data.rating}");
        Console.WriteLine($"Durasi Film : {data.durationMinutes}");
        Console.WriteLine($"Status Tonton : {data.isWatched}");
    }
}   
