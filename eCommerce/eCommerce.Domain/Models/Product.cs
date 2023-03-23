namespace eCommerce.Domain.Models 
{
    public abstract class Product : EntityBase
    {
        public string Name { get; set; }

        public long Price { get; set; }
        
        public long Quantity { get; set; }
    }

}