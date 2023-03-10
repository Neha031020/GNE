using System;
using System.Collections.Generic;

namespace Api;

public partial class Category
{
    public int CategoryId { get; set; }

    public string CategoryType { get; set; } = null!;

    public string CategoryName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<GivenDetail> GivenDetails { get; } = new List<GivenDetail>();
}
