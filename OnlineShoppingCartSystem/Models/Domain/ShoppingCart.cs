using System;
using System.Collections.Generic;

namespace OnlineShoppingCartSystem.Models.Domain;

public partial class ShoppingCart
{
    public int CartId { get; set; }

    public int UserId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public bool? IsCheckedOut { get; set; }

    public virtual ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    public virtual User User { get; set; } = null!;
}
