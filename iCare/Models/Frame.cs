using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class Frame
{
    [Key]
    public int FrameId { get; set; }

    [Required]
    [Display(Name = "Frame Type")]
    [StringLength(50, ErrorMessage = "Frame Type can't be longer than 50 characters.")]
    public string FrameType { get; set; } = null!;

    [Display(Name = "Description")]
    public string? Description { get; set; }

    public virtual ICollection<Casepaper> Casepapers { get; set; } = new List<Casepaper>();
}