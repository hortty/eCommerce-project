namespace eCommerce.Domain.DTOs 
{
    public class UpdateProductDto : BaseDto
    {
        public string Name { get; set; }

        public long Price { get; set; }
        
        public long Quantity { get; set; }
    }
}