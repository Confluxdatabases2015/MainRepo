namespace ConfluxDealers.Models
{
    public class Car
    {
        public int Id { get; set; }

        public string Model { get; set; }

        public string Make { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
