using System;
using System.Collections.Generic;

namespace Api;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserPosition { get; set; } = null!;

    public string UserSeniorName { get; set; } = null!;

    public string UserSeniorPosition { get; set; } = null!;
}
