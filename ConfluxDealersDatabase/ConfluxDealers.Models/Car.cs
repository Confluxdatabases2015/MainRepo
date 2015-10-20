namespace ConfluxDealers.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Car
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Model { get; set; }

        [MaxLength(50)]
        public string Make { get; set; }

        [Range(10000D, 150000D)]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int ShopId { get; set; }

        public virtual Shop Shop { get; set; }
    }
}
