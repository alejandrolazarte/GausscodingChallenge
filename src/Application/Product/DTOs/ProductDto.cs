namespace Application.Product.DTOs
{
    public class ProductDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal  Price { get; set; }
        public decimal Cost { get; set; }
        public long BrandId { get; set; }
        public string BrandName { get; set; }
    }
}
