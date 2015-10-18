namespace ConfluxDealers.Models
{
    using System.Collections.Generic;

    public class Shop
    {
        private ICollection<Car> cars;

        public Shop()
        {
            this.cars = new HashSet<Car>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }

        public virtual Town Town { get; set; }

        public int DealerId { get; set; }

        public virtual Dealer Dealer { get; set; }

        public virtual ICollection<Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
    }
}
