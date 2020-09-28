namespace Domain.Entities
{
    public class Product : EntityBase
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public decimal Price { get; set; }
        public long BrandId { get; set; }

        //=================== Navigations properties ===================//

        public Brand Brand { get; set; }
    }
}
