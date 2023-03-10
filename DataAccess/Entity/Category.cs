using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryType { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
