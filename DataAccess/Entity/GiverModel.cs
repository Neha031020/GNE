using System;
using System.Collections.Generic;

namespace DataAccess.Entity;

public partial class GiverModel
{
    public int GiverModelId { get; set; }

    public int FormCode { get; set; }

    public string GiverName { get; set; } = null!;

    public string GiverOrganization { get; set; } = null!;

    public string GiverSubOrganization { get; set; } = null!;

    public DateTime GivenDate { get; set; }

    public string Description { get; set; } = null!;

    public int CurrencyId { get; set; }

    public double CostLocal { get; set; }

    public double MarketLocal { get; set; }

    public bool IsSupplyChainVpapproved { get; set; }

    public string? Comments { get; set; }

    public string CreatedBy { get; set; } = null!;

    public string CreatedOn { get; set; } = null!;

    public int ExchangeRate { get; set; }

    public string BussinessStatus { get; set; } = null!;

    public string ComplienceStatus { get; set; } = null!;

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<GivenDetail> GivenDetails { get; } = new List<GivenDetail>();

    public virtual ICollection<GiverAttachment> GiverAttachments { get; } = new List<GiverAttachment>();

    public virtual ICollection<GiverRecipient> GiverRecipients { get; } = new List<GiverRecipient>();
}
