using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models {
    public enum IncludedUserRoles {
        [EnumMember(Value = "all")]
        All,
        [EnumMember(Value = "privilegedAdmin")]
        PrivilegedAdmin,
        [EnumMember(Value = "admin")]
        Admin,
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
