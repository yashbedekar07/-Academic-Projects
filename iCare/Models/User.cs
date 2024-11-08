using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace iCare.Models;

public partial class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "Username")]
    [StringLength(50, ErrorMessage = "Username can't be longer than 50 characters.")]
    public string Username { get; set; } = null!;

    [Required]
    [Display(Name = "Password")]
    [StringLength(100, ErrorMessage = "Password can't be longer than 100 characters.")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Required]
    [Display(Name = "Role")]
    [StringLength(50, ErrorMessage = "Role can't be longer than 50 characters.")]
    public string Role { get; set; } = null!;

}
