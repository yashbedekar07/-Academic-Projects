namespace ProductAPI.Models.DTO
{
    public class ProductDto
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; } = null!;

        public string ProductCode { get; set; } = null!;
    }
}
