namespace ConfluxApplication
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using ConfluxDealer.Data;
    using ConfluxDealer.Data.Migrations;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConfluxDbContext, Configuration>());

            var db = new ConfluxDbContext();

            Console.WriteLine(db.Cars.Count());
        }
    }
}
