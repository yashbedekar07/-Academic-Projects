using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models.Domain;

public partial class Supplier
{
    [Key]
    [Display(Name = "Supplier ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Supplier Name is required")]
    [Display(Name = "Supplier Name")]
    [StringLength(50, ErrorMessage = "Supplier name must be at most 50 characters long")]
    [DataType(DataType.Text)]
    public string? Name { get; set; }

    [Display(Name = "Supplier Email")]
    [Required(ErrorMessage = "Supplier Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }


    [Required(ErrorMessage = "Supplier Number is required")]
    [Display(Name = "Supplier Number")]
    [DataType(DataType.PhoneNumber)]
    [StringLength(12, MinimumLength = 12, ErrorMessage = "Supplier Number be exactly 12 characters long.")]
    public string? PhoneNo { get; set; }

    [Display(Name = "Products")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
