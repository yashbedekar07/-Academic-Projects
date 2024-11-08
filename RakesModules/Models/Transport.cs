using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Transport
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? Code { get; set; }

    public string? Gstin { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();
}
