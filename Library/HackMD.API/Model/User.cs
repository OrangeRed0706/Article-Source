using System.Text.Json.Serialization;

namespace HackMD.API.Model;
public class User
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("photo")]
    public string? Photo { get; set; }
    [JsonPropertyName("biography")]
    public string? Biography { get; set; }
    [JsonPropertyName("userPath")]
    public string? UserPath { get; set; }
}
