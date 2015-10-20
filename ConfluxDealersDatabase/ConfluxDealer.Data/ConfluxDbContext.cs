namespace ConfluxDealer.Data
{
    using ConfluxDealers.Models;
    using System.Data.Entity;

    public class ConfluxDbContext : DbContext, IConfluxDbContext
    {
        public ConfluxDbContext()
            : base("Conflux")
        {
        }
        
        public virtual IDbSet<Dealer> Dealers { get; set; }

        public virtual IDbSet<Shop> Shops { get; set; }

        public virtual IDbSet<Car> Cars { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<Town> Towns { get; set; }

        public virtual IDbSet<DealerExpense> DealerExpenses { get; set; }
    }
}
