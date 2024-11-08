using System;
using System.Collections.Generic;

namespace RakesModules.Models;

public partial class ProductStockHistory
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public decimal? Quantity { get; set; }

    public int? DespatchId { get; set; }

    public int? Rakeid { get; set; }

    public DateTime? TransactionDateTime { get; set; }

    public virtual Product? Product { get; set; }
}
