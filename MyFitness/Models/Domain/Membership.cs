using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFitness.Models.Domain;

public partial class Membership
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Members Name")]
    [Required]
    public int? MemberId { get; set; }

    [Display(Name = "Start Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime? StartDate { get; set; }

    [Display(Name = "End Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [Required]
    public DateTime? EndDate { get; set; }

    [Display(Name = "Amount")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    public decimal? Amount { get; set; }

    [Display(Name = "Payment Status")]
    public string? PaymentStatus { get; set; }

    [Display(Name = "Members Name")]
    public virtual Member? Member { get; set; }

}
