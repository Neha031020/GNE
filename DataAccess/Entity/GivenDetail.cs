using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class GivenDetail
{
    public short GivenDetailsId { get; set; }

    public int GivenId { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CategoryId { get; set; }

    public virtual GiverModel Given { get; set; } = null!;
}
