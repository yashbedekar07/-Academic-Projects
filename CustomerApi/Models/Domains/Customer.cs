using System;
using System.Collections.Generic;

namespace CustomerApi.Models.Domains;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string CustomerName { get; set; } = null!;

    public string Age { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Address { get; set; } = null!;

   // public DateTime DateOfBirth { get; set; }

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;
}
