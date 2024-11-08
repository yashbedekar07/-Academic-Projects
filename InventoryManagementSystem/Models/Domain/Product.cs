using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models.Domain;

public partial class Product
{
    [Key]
    [Display(Name = "Product ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "Product Name is required")]
    [Display(Name = "Product Name")]
    [StringLength(50, ErrorMessage = "Product name must be at most 50 characters long")]
    [DataType(DataType.Text)]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Product Price is required")]
    [DisplayName("Product Price")]
    [Range(1, double.MaxValue, ErrorMessage = "Product Price must be a positive integer")]
    [Column(TypeName = "decimal(18,2)")]
    public decimal? Price { get; set; }

    [Display(Name = "Quantity On Hand")]
    [Range(0, int.MaxValue, ErrorMessage = "Quantity must be a positive number")]
    public int? QuantityOnHand { get; set; }

    [Display(Name = "Reorder Level")]
    [Range(0, int.MaxValue, ErrorMessage = "Reorder level must be a positive number")]
    public int? ReorderLevel { get; set; }

    [Display(Name = "Supplier ID")]
    public int? SupplierId { get; set; }

    [Display(Name = "Supplier")]
    public virtual Supplier? Supplier { get; set; }
}
