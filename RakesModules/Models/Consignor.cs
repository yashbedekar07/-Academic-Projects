using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Consignor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Code { get; set; }

    public string? Gstin { get; set; }

    public string? ConsignorNumber { get; set; }

    public int? Distance { get; set; }

    public virtual ICollection<Rake> Rakes { get; set; } = new List<Rake>();
}
