using HackMD.API.Enums;

namespace HackMD.API.Model;
public class UpdateNoteModel
{
    public string? Content { get; set; }
    public ReadWritePermission ReadPermission { get; set; }
    public ReadWritePermission WritePermission { get; set; }
    public CommentPermission CommentPermission { get; set; }
    public string? Permalink { get; set; }
}
