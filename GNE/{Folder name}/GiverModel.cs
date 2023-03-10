using System;
using System.Collections.Generic;

namespace Api;

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

    public string Comments { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public string CreatedOn { get; set; } = null!;

    public virtual ICollection<Approval> Approvals { get; } = new List<Approval>();

    public virtual Currency Currency { get; set; } = null!;

    public virtual ICollection<GivenDetail> GivenDetails { get; } = new List<GivenDetail>();

    public virtual ICollection<GiverRecipient> GiverRecipients { get; } = new List<GiverRecipient>();
}
