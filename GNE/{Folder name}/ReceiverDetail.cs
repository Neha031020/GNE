using System;
using System.Collections.Generic;

namespace Api;

public partial class ReceiverDetail
{
    public int Id { get; set; }

    public int ReceiverId { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string CreatedOn { get; set; } = null!;

    public virtual ReceiverModel Receiver { get; set; } = null!;
}
