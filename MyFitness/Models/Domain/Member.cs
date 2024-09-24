using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyFitness.Models.Domain;

public partial class Member
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Member Name")]
    [Required(ErrorMessage = "Member Name is required.")]
    [StringLength(50)]
    public string? Name { get; set; }

    [Display(Name = "Gender")]
    [Required(ErrorMessage = " Gender is required.")]
    public string? Gender { get; set; }

    [Display(Name = "Date of Birth")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? DateOfBirth { get; set; }

    [Display(Name = "Join Date")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime? JoinDate { get; set; }

    [Display(Name = "Membership Type")]
    public int? MembershipTypeId { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required.")]
    [EmailAddress(ErrorMessage = "Invalid email address.")]
    public string? Email { get; set; }

    [Display(Name = "Mobile Number")]
    [Required(ErrorMessage = "Mobile Number is required.")]
    [Phone(ErrorMessage = "Invalid phone number.")]
    public string? Phone { get; set; }

    [Display(Name = "Address")]
    public string? Address { get; set; }

    [Display(Name = "Attendances")]
    public virtual ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

    [Display(Name = "Membership Type")]
    public virtual MembershipType? MembershipType { get; set; }

    [Display(Name = "Memberships")]
    public virtual ICollection<Membership> Memberships { get; set; } = new List<Membership>();

}
