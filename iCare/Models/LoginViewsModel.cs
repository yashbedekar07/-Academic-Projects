using System.ComponentModel.DataAnnotations;

namespace iCare.Models
{
    public class LoginViewsModel
    {
        [Key]
        public int LoginId { get; set; }


        public string Username { get; set; } 


        public string Password { get; set; } 


        public string Role { get; set; }

       
    }
}
