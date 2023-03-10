using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class CounterParty
{
    public int CounterPartyId { get; set; }

    public string PartyName { get; set; } = null!;

    public string CreatedBy { get; set; } = String.Empty;

    public DateTime CreatedOn { get; set; }= DateTime.Now;

    public string? Status { get; set; } = "Pending";

    public string? StatusBy { get; set; }

    public DateTime? StatusOn { get; set; }

    public virtual ICollection<GiverRecipient> GiverRecipients { get; } = new List<GiverRecipient>();

    public virtual ICollection<ReceiverModel> ReceiverModels { get; } = new List<ReceiverModel>();
}
