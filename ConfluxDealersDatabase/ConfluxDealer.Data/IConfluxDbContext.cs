using System.Data.Entity;
using ConfluxDealers.Models;

namespace ConfluxDealer.Data
{
    public interface IConfluxDbContext
    {
        IDbSet<Car> Cars { get; set; }
        IDbSet<Category> Categories { get; set; }
        IDbSet<Dealer> Dealers { get; set; }
        IDbSet<Shop> Shops { get; set; }
        IDbSet<Town> Towns { get; set; }
        IDbSet<DealerExpense> DealerExpenses { get; set; }
    }
}