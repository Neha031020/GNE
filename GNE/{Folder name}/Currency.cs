using System;
using System.Collections.Generic;

namespace Api;

public partial class Currency
{
    public int CurrencyId { get; set; }

    public string CurrencyCode { get; set; } = null!;

    public string CurrencyName { get; set; } = null!;

    public string Symbol { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTimeOffset CreatedOn { get; set; }

    public virtual ICollection<GiverModel> GiverModels { get; } = new List<GiverModel>();
}
