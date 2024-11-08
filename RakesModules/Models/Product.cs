using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class Product
{
    public int Id { get; set; }

    public string? ProductName { get; set; }

    public int? ProductCode { get; set; }

    public decimal? BagsInTon { get; set; }

    public decimal? CurrentStockBags { get; set; }

    public decimal? CurrentStockTons { get; set; }

    public virtual ICollection<Despatch> Despatches { get; set; } = new List<Despatch>();

    public virtual ICollection<ProductStockHistory> ProductStockHistories { get; set; } = new List<ProductStockHistory>();

    public virtual ICollection<Rake> Rakes { get; set; } = new List<Rake>();
}
