using System.Text.Json.Serialization;

namespace Generics.CLI;

public class Album
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("artist")]
    public Artist Artist { get; set; }

    [JsonPropertyName("tracks")]
    public List<Track> Tracks { get; set; }
}

public class Artist
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("founded")]
    public long Founded { get; set; }

    [JsonPropertyName("members")]
    public List<string> Members { get; set; }
}

public class Track
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("duration")]
    public long Duration { get; set; }
}