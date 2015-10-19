namespace ConfluxDealers.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Dealer
    {
        private ICollection<Shop> shops;

        public Dealer()
        {
            this.shops = new HashSet<Shop>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Shop> Shops
        {
            get { return this.shops; }
            set { this.shops = value; }
        }
    }
}
