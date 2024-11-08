using System;
using System.Collections.Generic;

namespace ProductAPI.Models.Domains;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Code { get; set; } = null!;
}
