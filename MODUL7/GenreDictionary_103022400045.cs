using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GenreInfo
{
    public string id { get; set; }
    public string name { get; set; }
    public string description { get; set; }
    public List<string> popularMovies { get; set; }
}

public class GenreDictionaryWrapper
{
    public string category { get; set; }
    public GenreInfo GenreInfo { get; set; }
}

public class Root
{
    public GenreDictionaryWrapper GenreDictionary { get; set; }
}

public class GenreDictionary_103022400045
{
    public static void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_2_103022400045.json");
        Root data = JsonSerializer.Deserialize<Root>(json);

        var info = data.GenreDictionary.GenreInfo;

        Console.WriteLine("ID : " + info.id);
        Console.WriteLine("Name : " + info.name);
        Console.WriteLine("Description : " + info.description);
        Console.WriteLine("Popular Movies : " + string.Join(", ", info.popularMovies));
    }
}