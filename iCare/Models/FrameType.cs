using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class FrameType
{
    [Key]
    public int FrameTypesId { get; set; }

    [Required]
    [Display(Name = "Frame Type Name")]
    [StringLength(50, ErrorMessage = "Frame Type Name can't be longer than 50 characters.")]
    public string FrameTypeName { get; set; } = null!;

    [Display(Name = "Description")]
    public string? Description { get; set; }

    public virtual ICollection<Casepaper> Casepapers { get; set; } = new List<Casepaper>();
}