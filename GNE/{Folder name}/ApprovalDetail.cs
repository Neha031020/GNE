using System;
using System.Collections.Generic;

namespace Api;

public partial class ApprovalDetail
{
    public int ApprovalDetailId { get; set; }

    public int ApprovalId { get; set; }

    public string ApprovarName { get; set; } = null!;

    public string ApprovarTitle { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string StatusBy { get; set; } = null!;

    public DateTime StatusOn { get; set; }

    public string Comments { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual Approval Approval { get; set; } = null!;
}
