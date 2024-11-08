using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models.Domain;

public partial class Customer
{
    [Key]
    [Display(Name = "Customer ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Customer Name is required")]
    [Display(Name = "Customer Name")]
    [StringLength(50, ErrorMessage = "Customer name must be at most 50 characters long")]
    [DataType(DataType.Text)]
    public string? Name { get; set; }

    [Display(Name = "Customer Email")]
    [Required(ErrorMessage = "Customer Email is required")]
    [EmailAddress(ErrorMessage = "Invalid email format")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Customer Number is required")]
    [Display(Name = "Customer Number")]
    [DataType(DataType.PhoneNumber)]
    [StringLength(12, MinimumLength = 12, ErrorMessage = "Customer Number be exactly 12 characters long.")]
    public string? MobileNo { get; set; }

    [Required(ErrorMessage = "Customer Address is required")]
    [Display(Name = "Customer Address")]
    [StringLength(100, ErrorMessage = "Customer address must be at most 100 characters long")]
    [DataType(DataType.Text)]
    public string? Address { get; set; }
}
