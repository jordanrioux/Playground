using System.Text.Json.Serialization;

namespace Generics;

public class Nephalem
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("class")]
    public string Class { get; set; }

    [JsonPropertyName("level")]
    public long Level { get; set; }

    [JsonPropertyName("skills")]
    public List<string> Skills { get; set; }

    [JsonPropertyName("items")]
    public List<Item> Items { get; set; }
}

public class Item
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("value")]
    public long Value { get; set; }

    [JsonPropertyName("quantity")]
    public long Quantity { get; set; }
}