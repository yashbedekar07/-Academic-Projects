using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFitness.Models.Domain;

public partial class MembershipType
{
    [Key]
    public int MembershipTypeId { get; set; }

    [Display(Name = "Membership Type Name")]
    [Required(ErrorMessage = "Type Name is required.")]
    public string? TypeName { get; set; }

    [Display(Name = "Description")]
    public string? Description { get; set; }

    [Display(Name = "Price")]
    [DisplayFormat(DataFormatString = "{0:C}")]
    public decimal? Price { get; set; }

    [Display(Name = "Members")]
    public virtual ICollection<Member> Members { get; set; } = new List<Member>();

}
