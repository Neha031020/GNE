﻿using System;
using System.Collections.Generic;

namespace Api;

public partial class GiverRecipient
{
    public int GiverRecipientsId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int CounterpartyId { get; set; }

    public string Title { get; set; } = null!;

    public int PersonTypeId { get; set; }

    public int GiftCost { get; set; }

    public int EntCost { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int GiverId { get; set; }

    public virtual GiverModel Giver { get; set; } = null!;

    public virtual PersonType PersonType { get; set; } = null!;
}
