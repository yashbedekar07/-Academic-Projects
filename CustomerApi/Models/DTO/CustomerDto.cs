namespace CustomerApi.Models.DTO
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; } = null!;

        public string CustomerAge { get; set; } = null!;

        public string CustomerEmail { get; set; } = null!;

        public string CustomerPhone { get; set; } = null!;

        public string CustomerAddress { get; set; } = null!;

      //  public DateTime DateOfBirth { get; set; }

        public string City { get; set; } = null!;

        public string State { get; set; } = null!;
    }
}
