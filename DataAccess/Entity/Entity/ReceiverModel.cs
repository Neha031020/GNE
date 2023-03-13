using System;
using System.Collections.Generic;

namespace Api.DataAccess.Entity;

public partial class ReceiverModel
{
    public int ReceiverId { get; set; }

    public int FormCode { get; set; }

    public string ReceiverName { get; set; } = null!;

    public DateTime ReceiveDate { get; set; }

    public string Description { get; set; } = null!;

    public string? Comments { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CounterPartyId { get; set; }

    public int PersonTypeId { get; set; }

    public int CurrencyId { get; set; }

    public int LocalCost { get; set; }

    public int LocalMarket { get; set; }

    public int ExchangeRate { get; set; }

    public bool IsSupplyChainVpapproved { get; set; }

    public string BussinessStatus { get; set; } = null!;

    public string ComplienceStatus { get; set; } = null!;

    public virtual CounterParty CounterParty { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    public virtual PersonType PersonType { get; set; } = null!;

    public virtual ICollection<ReceiverAttachment> ReceiverAttachments { get; } = new List<ReceiverAttachment>();

    public virtual ICollection<ReceiverDetail> ReceiverDetails { get; } = new List<ReceiverDetail>();

    public virtual ICollection<ReceiverRecipient> ReceiverRecipients { get; } = new List<ReceiverRecipient>();
}
