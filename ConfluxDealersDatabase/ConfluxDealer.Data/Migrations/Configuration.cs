namespace ConfluxDealer.Data.Migrations
{
    using ConfluxDealers.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Text;

    public sealed class Configuration : DbMigrationsConfiguration<ConfluxDbContext>
    {
        private static Random Random = new Random((int)DateTime.Now.Ticks);
        private static Random Rand = new Random();

        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ConfluxDbContext context)
        {
            for (int i = 0; i < 10; i++)
            {
                context.Categories.Add(new Category()
                {
                    Name = RandomString(8)
                });
            }

            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                context.Towns.Add(new Town()
                {
                    Name = RandomString(8)
                });
            }

            context.SaveChanges();

            for (int i = 0; i < 10; i++)
            {
                context.Dealers.Add(new Dealer()
                {
                    Name = RandomString(10)
                });
            }

            context.SaveChanges();

            for (int i = 0; i < 20; i++)
            {
                context.Shops.Add(new Shop()
                {
                    Name = RandomString(15),
                    DealerId = Rand.Next(1, 11),
                    TownId = Rand.Next(1, 11)
                });
            }

            context.SaveChanges();

            for (int i = 0; i < 20; i++)
            {
                context.Cars.Add(new Car()
                {
                    Model = RandomString(Rand.Next(2, 10)),
                    Make = RandomString(Rand.Next(2, 10)),
                    Price = (decimal)Rand.Next(10000, 100000),
                    CategoryId = Rand.Next(1, 11),
                    ShopId = Rand.Next(1, 21)
                });
            }

            context.SaveChanges();
            
            for (int i = 0; i < 10; i++)
            {
                context.DealerExpenses.Add(new DealerExpense()
                {
                    Month = RandomDay(),
                    Value = (decimal)Rand.Next(10000, 100000),
                    DealerName = RandomString(10) 
                });

            }

            foreach (var item in context.DealerExpenses)
            {
                Console.WriteLine("month: {0}\tvalue: {1}\tdealerName: {2}", item.Month, item.Value, item.DealerName);  
            }

            context.SaveChanges();
        }

        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 65)));
            builder.Append(ch.ToString());
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * Random.NextDouble() + 97)));
                builder.Append(ch);
            }

            return builder.ToString();
        }

        private DateTime RandomDay()
        {
            int seed = (int)DateTime.Now.Ticks;
            int days = seed % 90;
            return DateTime.Now.AddDays(days);
        }
    }
}
