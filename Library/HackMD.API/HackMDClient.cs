using System.Net;
using System.Text;
using System.Text.Json;
using HackMD.API.Model.Request;
using HackMD.API.Model.Response;

namespace HackMarkdown.API;

// ReSharper disable once InconsistentNaming
internal class HackMarkdownClient : IHackMarkdownClient
{
    private readonly HttpClient _httpClient;

    public HackMarkdownClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<NotesResponse>?> GetNotes()
    {
        return await GetAsync<IEnumerable<NotesResponse>>("/notes");
    }

    public async Task<NoteResponse?> GetNote(string noteId)
    {
        return await GetAsync<NoteResponse>($"/notes/{noteId}");
    }

    public async Task<NoteResponse?> CreateNote(CreateNoteModel createNoteModel)
    {
        var json = JsonSerializer.Serialize(createNoteModel);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        return await PostAsync<NoteResponse>("/notes", content);
    }

    public async Task<bool> UpdateNote(string noteId, UpdateNoteModel updateNoteModel)
    {
        var json = JsonSerializer.Serialize(updateNoteModel);
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await PatchAsync($"/notes/{noteId}", content);
        return response == HttpStatusCode.Accepted;
    }

    public async Task<bool> DeleteNote(string noteId)
    {
        var response = await DeleteAsync($"/notes{noteId}");
        return response == HttpStatusCode.NoContent;
    }

    private async Task<T?> GetAsync<T>(string url)
    {
        var response = await _httpClient.GetAsync(url);
        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(content);
    }

    private async Task<T?> PostAsync<T>(string url, HttpContent? content)
    {
        var response = await _httpClient.PostAsync(url, content);
        var responseContent = await response.Content.ReadAsStringAsync();
        return JsonSerializer.Deserialize<T>(responseContent);
    }

    private async Task<HttpStatusCode> PatchAsync(string url, HttpContent? content)
    {
        var response = await _httpClient.PatchAsync(url, content);
        return response.StatusCode;
    }

    private async Task<HttpStatusCode> DeleteAsync(string url)
    {
        var response = await _httpClient.DeleteAsync(url);
        return response.StatusCode;
    }
}
