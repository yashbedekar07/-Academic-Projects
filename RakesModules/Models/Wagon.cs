using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Wagon
{
    public int Id { get; set; }

    public int? RakeId { get; set; }

    public string? WagonNo { get; set; }

    public decimal? Cc { get; set; }

    public decimal? Tare { get; set; }

    public decimal? NoOfBagsperRr { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? ActualWeight { get; set; }

    public decimal? PermissibleCc { get; set; }

    public decimal? ChargableWeight { get; set; }

    public int? DespatchTypeId { get; set; }

    public decimal? NoOfBagsReceived { get; set; }

    public virtual DespatchType? DespatchType { get; set; }

    public virtual Rake? Rake { get; set; }
}
