using System;
using System.Collections.Generic;

namespace Api;

public partial class ReceiverRecipient
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CounterPartyId { get; set; }

    public string Title { get; set; } = null!;

    public int PersonTypeId { get; set; }

    public int GiftCost { get; set; }

    public int EntCost { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string CreatedOn { get; set; } = null!;

    public int ReceiverId { get; set; }

    public virtual CounterParty CounterParty { get; set; } = null!;

    public virtual PersonType PersonType { get; set; } = null!;

    public virtual ReceiverModel Receiver { get; set; } = null!;
}
