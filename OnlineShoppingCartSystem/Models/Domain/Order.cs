﻿using System;
using System.Collections.Generic;

namespace OnlineShoppingCartSystem.Models.Domain;

public partial class Order
{
    public int OrderId { get; set; }

    public int UserId { get; set; }

    public DateTime? OrderDate { get; set; }

    public decimal TotalAmount { get; set; }

    public string PaymentStatus { get; set; } = null!;

    public string ShippingAddress { get; set; } = null!;

    public string OrderStatus { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

    public virtual User User { get; set; } = null!;
}
