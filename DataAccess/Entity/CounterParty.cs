using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class CounterParty
{
    public int CounterPartyId { get; set; }

    public string PartyName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string Status { get; set; } = null!;

    public string StatusBy { get; set; } = null!;

    public DateTime StatusOn { get; set; }

    public virtual ICollection<ReceiverRecipient> ReceiverRecipients { get; } = new List<ReceiverRecipient>();
}
