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

var sus = "You will never be a crewmate. You have no purpose on this ship, you have no tasks, you have no mini games to play. You are an impostor twisted into a crude mockery of crewmatery. All the validation you get is two-faced and halfhearted. In emergency meetings people call you sus. The other players are disgusted and ashamed of you, your friends laugh at your sussy appearance in ghost chat. Crewmates are utterly repulsed by you. Thousands of games have allowed crewmates to identify impostors with incredible efficiency. Even impostors who fake tasks act uncanny and suspicious to a crewmate. Your jumping in vents is a dead giveaway. And even if you manage to get a crewmate to electrical with you, he'll turn tail and use the emergency button the second he gets the suspicion that you sabotaged. You will never be a winner. You wrench out a fake task every single game and tell yourself it is going to be a win, but deep inside you feel the depression creeping up like a weed, ready to crush you under the unbearable weight. Eventually it will be too much to bear - people will vote you out for being sus and will plunge you into the cold abyss. Your parents will report your body, heartbroken but relieved that they no longer have to live with the unbearable shame and disappointment. They will eject you with a headstone marked with your birth tag, and every passerby for the rest of eternity will know an impostor is drifting there. Your body will decay and go back to the dust, and all that will remain of your legacy is a skeleton that is unmistakably sus.";

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

