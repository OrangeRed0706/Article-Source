using System.Text.Json.Serialization;
using HackMD.API.Enums;

namespace HackMD.API.Model.Response;
public class NoteResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("title")]
    public string? Title { get; set; }
    [JsonPropertyName("tags")]
    public string[]? Tags { get; set; }
    [JsonPropertyName("createdAt")]
    public long CreatedAt { get; set; }
    [JsonPropertyName("publishType")]
    public string? PublishType { get; set; }
    [JsonPropertyName("publishLink")]
    public string? PublishLink { get; set; }
    [JsonPropertyName("shortId")]
    public string? ShortId { get; set; }
    [JsonPropertyName("content")]
    public string? Content { get; set; }
    public long LastChangedAt { get; set; }
    [JsonPropertyName("lastChangeUser")]
    public User? LastChangeUser { get; set; }
    [JsonPropertyName("readPermission")]
    public ReadWritePermission ReadPermission { get; set; }
    [JsonPropertyName("writePermission")]
    public ReadWritePermission WritePermission { get; set; }
}
