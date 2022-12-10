using HackMD.API.Model;

namespace HackMD.API;

public interface IHackMDClient
{
    Task<IEnumerable<NotesResponse>?> GetNotes();
    Task<NoteResponse?> GetNote(string noteId);
    Task<NoteResponse?> CreateNote(CreateNoteModel createNoteModel);
    Task<bool> UpdateNote(string noteId, UpdateNoteModel updateNoteModel);
    Task<bool> DeleteNote(string noteId);
}
