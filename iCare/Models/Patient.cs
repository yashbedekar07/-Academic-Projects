using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class Patient
{
    [Key]
    public int PatientId { get; set; }

    [Display(Name = "Patient Name")]
    [StringLength(100, ErrorMessage = "Patient Name can't be longer than 100 characters.")]
    public string? PatientName { get; set; }

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateOnly Dob { get; set; }

    [Display(Name = "Gender")]
    [StringLength(10, ErrorMessage = "Gender can't be longer than 10 characters.")]
    public string? Gender { get; set; }

    [Display(Name = "Contact Number")]
    [DataType(DataType.PhoneNumber)]
    [StringLength(15, ErrorMessage = "Contact Number can't be longer than 15 characters.")]
    public string? ContactNumber { get; set; }

    [Display(Name = "Email Address")]
    [DataType(DataType.EmailAddress)]
    [StringLength(100, ErrorMessage = "Email can't be longer than 100 characters.")]
    public string? Email { get; set; }

    [Display(Name = "Home Address")]
    [StringLength(200, ErrorMessage = "Address can't be longer than 200 characters.")]
    public string? Address { get; set; }

    public virtual ICollection<Casepaper> Casepapers { get; set; } = new List<Casepaper>();

}
