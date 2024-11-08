using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Taluka
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? DistrictId { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual District? District { get; set; }
}
