using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserSeniorName { get; set; } = null!;

    public string UserSeniorPosition { get; set; } = null!;
    [EmailAddress]
    public string UserEmail { get; set; } = null!;

    public string UserDepartment { get; set; } = null!;

    public string UserTitle { get; set; } = null!;
}
