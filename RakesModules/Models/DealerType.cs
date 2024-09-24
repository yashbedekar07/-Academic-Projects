using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class DealerType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Dealer> Dealers { get; set; } = new List<Dealer>();
}
