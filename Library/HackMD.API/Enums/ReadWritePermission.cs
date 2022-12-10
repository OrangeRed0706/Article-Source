using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace HackMD.API.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum ReadWritePermission
{
    [EnumMember(Value = "owner")]
    Owner = 0,

    [EnumMember(Value = "signed_in")]
    // ReSharper disable once InconsistentNaming
    Signed_In = 1,
    [EnumMember(Value = "guest")]
    Guest = 2
}
