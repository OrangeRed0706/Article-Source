namespace HackMarkdown.API.Options;

internal class HackMarkdownOptions
{
    public const string HackMarkdown = "HackMarkdown";
    public Uri? BaseUrl { get; set; }
    public string? Token { get; set; }
}
