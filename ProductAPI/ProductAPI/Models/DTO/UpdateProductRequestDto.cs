namespace ProductAPI.Models.DTO
{
    public class UpdateProductRequestDto
    {
        public string ProductName { get; set; } = null!;

        public string ProductCode { get; set; } = null!;
    }
}
