﻿using System;
using System.Collections.Generic;

namespace Api.DataAccess.Entity;

public partial class ReceiverRecipient
{
    public int Id { get; set; }

    public int GiftCost { get; set; }

    public int EntCost { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string CreatedOn { get; set; } = null!;

    public int ReceiverId { get; set; }

    public string Email { get; set; } = null!;

    public virtual ReceiverModel Receiver { get; set; } = null!;
}
