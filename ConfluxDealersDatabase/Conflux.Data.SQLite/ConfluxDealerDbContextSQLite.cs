namespace ConfluxDealer.Data.SQLite
{
    using System.Data.Entity;
    using ConfluxDealer.Models.SQLite;
    
    public class ConfluxDealerDbContextSQLite : DbContext
    {
        public ConfluxDealerDbContextSQLite()
            : base("ConfluxDealerSQLiteConnectionString")
        {
        }

        public IDbSet<Shop> Shops { get; set; }
    }
}
