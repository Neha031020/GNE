using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class ReceiverModel
{
    public int ReceiverId { get; set; }

    public int FormCode { get; set; }

    public string ReceiverName { get; set; } = null!;

    public string ReceiverOrganization { get; set; } = null!;

    public string ReceiverSubOrganization { get; set; } = null!;

    public DateTime ReceiverDate { get; set; }

    public string Description { get; set; } = null!;

    public int CurrencyId { get; set; }

    public double LocalCost { get; set; }

    public double LocalMarket { get; set; }

    public bool IsSupplyChainVpapproved { get; set; }

    public string Comments { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<ReceiverDetail> ReceiverDetails { get; } = new List<ReceiverDetail>();

    public virtual ICollection<ReceiverRecipient> ReceiverRecipients { get; } = new List<ReceiverRecipient>();
}
