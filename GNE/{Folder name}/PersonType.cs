using System;
using System.Collections.Generic;

namespace Api;

public partial class PersonType
{
    public int PersonTypeId { get; set; }

    public string PersonType1 { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual ICollection<GiverRecipient> GiverRecipients { get; } = new List<GiverRecipient>();

    public virtual ICollection<ReceiverRecipient> ReceiverRecipients { get; } = new List<ReceiverRecipient>();

    public virtual ICollection<Threshold> Thresholds { get; } = new List<Threshold>();
}
