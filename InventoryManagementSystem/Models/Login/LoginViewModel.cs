namespace InventoryManagementSystem.Models.Login
{
    public class LoginViewModel
    {
        public int UserId { get; set; }

        public string Username { get; set; } = null!;

        public string Password { get; set; } = null!;
    }
}
