using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class DestRateMaster
{
    public int Id { get; set; }

    public int? StartKm { get; set; }

    public int? EndKm { get; set; }

    public decimal? Rate { get; set; }

    public string? RateType { get; set; }
}
