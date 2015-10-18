namespace ConfluxDealers.Models
{
    using System.Collections.Generic;

    public class Dealer
    {
        private ICollection<Shop> shops;

        public Dealer()
        {
            this.shops = new HashSet<Shop>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Shop> Shops
        {
            get { return this.shops; }
            set { this.shops = value; }
        }
    }
}
