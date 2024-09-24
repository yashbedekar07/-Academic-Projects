using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFitness.Models.Domain;

public partial class Trainers
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Trainer Name")]
    [Required(ErrorMessage = "Trainer Name is required.")]
    public string? Name { get; set; }

    [Display(Name = "Gender")]
    [Required(ErrorMessage = "Trainer Name is required.")]

    public string? Gender { get; set; }

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    public DateTime? DateOfBirth { get; set; }

    [Display(Name = "Hire Date")]
    [DataType(DataType.Date)]
    [Required(ErrorMessage = "Hire Date is required.")]

    public DateTime? HireDate { get; set; }

    [Display(Name = "Specialization")]
    [Required(ErrorMessage = "Specialization is required.")]

    public string? Specialization { get; set; }

    [Display(Name = "Email")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    [Required(ErrorMessage = "Email is required.")]

    public string? Email { get; set; }

    [Display(Name = "Mobile Number")]
    [Phone(ErrorMessage = "Invalid phone number.")]
    [Required(ErrorMessage = "Mobile Number is required.")]

    public string? Phone { get; set; }

    [Display(Name = "Address")]
    public string? Address { get; set; }

    //[Display(Name = "Classes")]
    //[Required(ErrorMessage = "Trainer Name is required.")]

    //public virtual ICollection<Classes> Classes { get; set; } = new List<Classes>();

}
