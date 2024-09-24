using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Destination
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();
}
