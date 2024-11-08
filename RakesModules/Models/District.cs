using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class District
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Dealer> Dealers { get; set; } = new List<Dealer>();

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual ICollection<Taluka> Talukas { get; set; } = new List<Taluka>();
}
