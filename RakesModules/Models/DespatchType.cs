using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class DespatchType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual ICollection<Wagon> Wagons { get; set; } = new List<Wagon>();
}
