using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class Glass
{
    [Key]
    public int GlassId { get; set; }

    [Required]
    [Display(Name = "Glass Type")]
    [StringLength(50, ErrorMessage = "Glass Type can't be longer than 50 characters.")]
    public string GlassType { get; set; } = null!;

    [Display(Name = "Description")]
    public string? Description { get; set; }

    public virtual ICollection<Casepaper> Casepapers { get; set; } = new List<Casepaper>();
}