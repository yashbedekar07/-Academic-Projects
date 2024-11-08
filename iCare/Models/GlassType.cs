using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class GlassType
{
    [Key]
    public int GlassTypesId { get; set; }

    [Required]
    [Display(Name = "Glass Type Name")]
    [StringLength(50, ErrorMessage = "Glass Type Name can't be longer than 50 characters.")]
    public string GlassTypeName { get; set; } = null!;

    [Display(Name = "Description")]
    public string? Description { get; set; }

    public virtual ICollection<Casepaper> Casepapers { get; set; } = new List<Casepaper>();
}