using HackMD.API.Enums;

namespace HackMD.API.Model;

public class CreateNoteModel
{
    public string? Title { get; set; }
    public string? Content { get; set; }
    public ReadWritePermission ReadPermission { get; set; }
    public ReadWritePermission WritePermission { get; set; }
    public CommentPermission CommentPermission { get; set; }
}
