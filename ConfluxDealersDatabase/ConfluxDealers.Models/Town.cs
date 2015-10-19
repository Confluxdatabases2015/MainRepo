namespace ConfluxDealers.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Town
    {
        private ICollection<Shop> shops;

        public Town()
        {
            this.shops = new HashSet<Shop>();
        }

        [Key]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Shop> Shops
        {
            get { return this.shops; }
            set { this.shops = value; }
        }
    }
}
