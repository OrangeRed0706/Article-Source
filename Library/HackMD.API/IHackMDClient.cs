using HackMarkdown.API.Model.Request;
using HackMarkdown.API.Model.Response;

namespace HackMarkdown.API;

public interface IHackMarkdownClient
{
    Task<IEnumerable<NotesResponse>?> GetNotes();
    Task<NoteResponse?> GetNote(string noteId);
    Task<NoteResponse?> CreateNote(CreateNoteModel createNoteModel);
    Task<bool> UpdateNote(string noteId, UpdateNoteModel updateNoteModel);
    Task<bool> DeleteNote(string noteId);
}
