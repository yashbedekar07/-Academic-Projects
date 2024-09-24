using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFitness.Models.Domain;

public partial class Equipment
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Equipment Name")]
    [Required(ErrorMessage = "Name is required.")]
    public string? Name { get; set; }

    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Display(Name = "Equipment Quantity")]
    public int? Quantity { get; set; }

    [Display(Name = "Purchase Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? PurchaseDate { get; set; }

    [Display(Name = "Warranty Expiration Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? WarrantyExpirationDate { get; set; }

}
