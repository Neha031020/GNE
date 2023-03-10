using System;
using System.Collections.Generic;

namespace Api;

public partial class ApprovalLevel
{
    public int ApprovalLevelId { get; set; }

    public string ApprovalLevel1 { get; set; } = null!;

    public string ApprovalPosition { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<Threshold> Thresholds { get; } = new List<Threshold>();
}
