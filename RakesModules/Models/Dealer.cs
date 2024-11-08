using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Dealer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Code { get; set; }

    public string? Gstin { get; set; }

    public int? DealerTypeId { get; set; }

    public int? DistrictTypeId { get; set; }

    public virtual DealerType? DealerType { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual District? DistrictType { get; set; }

    public virtual ICollection<Subdealer> Subdealers { get; set; } = new List<Subdealer>();
}
