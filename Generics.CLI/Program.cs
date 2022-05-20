using System;
using System.Text.Json;
using System.Threading.Channels;
using Generics;
using Generics.CLI;

var jsonString = @"{
    ""name"": ""Nirvana"",
    ""founded"": 1987,
    ""members"": [
        ""Kurt Kobain"",
        ""Dave Grohl"",
        ""Krist Novoselic""
    ]
}";

Console.WriteLine("Hello wolrd first commit - Mathis");
Console.WriteLine("Hello wolrd second commit - Mathis");

// JSON to POCO
var album = JsonSerializer.Deserialize<Artist>(jsonString);
Console.WriteLine(album.Founded);
Console.WriteLine(album.Name);
foreach (var member in album.Members)
{
    Console.WriteLine(member);
}

// POCO to JSON
var newJson = JsonSerializer.Serialize(album);
Console.WriteLine(newJson);


var doc = JsonDocument.Parse(jsonString);
var root = doc.RootElement;
foreach (var prop in root.EnumerateObject())
{
     Console.WriteLine($"{prop.Name}: {prop.Value} ({prop.Value.ValueKind})");
}

// var json = "{\"name\" \"Jay\", \"name\": \"Test\", \"class\": \"Paladin\", \"level\": 92 }";
// var nephalem = JsonSerializer.Deserialize<Nephalem>(json);
// Console.WriteLine(nephalem.Name);
// Console.WriteLine(nephalem.Class);
// Console.WriteLine(nephalem.Level);

// var newJson = JsonSerializer.Serialize(nephalem);
// Console.WriteLine(newJson);
//
// var doc = JsonDocument.Parse(json);
// var root = doc.RootElement;
// foreach (var prop in root.EnumerateObject())
// {
//     Console.WriteLine($"{prop.Name} {prop.Value.ValueKind}");
//     var propName = $"public {prop.Value.ValueKind} {prop.Name}";
// }

// var numbers = new MyList<int>();
// numbers.Add(5);
// numbers.Add(2);
//
// var strings = new MyList<string>();
// strings.Add("Jordan");
// strings.Add("Jay");
//
// Console.WriteLine(numbers.Get(0));
// Console.WriteLine(strings[0]);

