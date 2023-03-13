using System;
using System.Collections.Generic;

namespace Api.DataAccess.Entity;

public partial class User
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string UserDepartment { get; set; } = null!;

    public string UserTitle { get; set; } = null!;

    public int? SeniorId { get; set; }

    public virtual ICollection<User> InverseSenior { get; } = new List<User>();

    public virtual User? Senior { get; set; }
}
