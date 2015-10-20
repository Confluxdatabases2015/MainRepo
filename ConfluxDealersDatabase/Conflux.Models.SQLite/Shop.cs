namespace ConfluxDealer.Models.SQLite
{
    using System.ComponentModel.DataAnnotations;

    public class Shop
    {
        [Key]
        public int Id { get; set; }

        public string Model { get; set; }

        public string SalesmanName { get; set; }

        public string FoundationYear { get; set; }
    }
}

