using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HackMD.API.Enums;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CommentPermission
{
    [EnumMember(Value = "disabled")]
    Disabled = 0,
    [EnumMember(Value = "forbidden")]
    Forbidden = 1,
    [EnumMember(Value = "owners")]
    Owners = 2,
    [EnumMember(Value = "signed_in_users")]
    // ReSharper disable once InconsistentNaming
    Signed_In_Users = 3,
    [EnumMember(Value = "everyone")]
    Everyone = 4
}
