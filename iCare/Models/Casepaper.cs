using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iCare.Models;

public partial class Casepaper
{
    [Key]
    [Display(Name = "Case Paper ID")]
    public int CasepaperId { get; set; }

    [Display(Name = "Patient ID")]
    public int? PatientId { get; set; }

    [Display(Name = "Mobile Number")]
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "Mobile Number is required.")]

    public string? MobileNumber { get; set; }
    [Display(Name = "Right Eye Spherical Distance Vision")]
    public string? RightEyeSphdv { get; set; }

    [Display(Name = "Right Eye Spherical Near Vision")]
    public string? RightEyeSphnv { get; set; }

    [Display(Name = "Right Eye Cylindrical Distance Vision")]
    public string? RightEyeCyldv { get; set; }

    [Display(Name = "Right Eye Cylindrical Near Vision")]
    public string? RightEyeCylnv { get; set; }

    [Display(Name = "Right Eye Axis Distance Vision")]
    public string? RightEyeAxisdv { get; set; }

    [Display(Name = "Right Eye Axis Near Vision")]
    public string? RightEyeAxisnv { get; set; }

    [Display(Name = "Left Eye Spherical Distance Vision")]
    public string? LeftEyeSphdv { get; set; }

    [Display(Name = "Left Eye Spherical Near Vision")]
    public string? LeftEyeSphnv { get; set; }

    [Display(Name = "Left Eye Cylindrical Distance Vision")]
    public string? LeftEyeCyldv { get; set; }

    [Display(Name = "Left Eye Cylindrical Near Vision")]
    public string? LeftEyeCylnv { get; set; }

    [Display(Name = "Left Eye Axis Distance Vision")]
    public string? LeftEyeAxisdv { get; set; }

    [Display(Name = "Left Eye Axis Near Vision")]
    public string? LeftEyeAxisnv { get; set; }

    [Display(Name = "Frame ID")]
    public int? FrameId { get; set; }

    [Display(Name = "Glass ID")]
    public int? GlassId { get; set; }

    [Display(Name = "Frame Type ID")]
    public int? FrameTypesId { get; set; }

    [StringLength(500, ErrorMessage = "Remarks cannot exceed 500 characters.")]
    [Display(Name = "Remarks")]
    public string? Remarks { get; set; }

    public int? GlassTypesId { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Created Date")]
    public DateTime? CreatedDate { get; set; }

    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Amount must be a positive value.")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")] // Adjust the precision and scale as needed
    [Display(Name = "Amount")]
    public decimal Amount { get; set; }

    [Display(Name = "Frame")]
    public virtual Frame? Frame { get; set; }

    [Display(Name = "Frame Type")]
    public virtual FrameType? FrameTypes { get; set; }

    [Display(Name = "Glass")]
    public virtual Glass? Glass { get; set; }

    [Display(Name = "Glass Type")]
    public virtual GlassType? GlassTypes { get; set; }

    [Display(Name = "Patient")]
    public virtual Patient? Patient { get; set; }

}
