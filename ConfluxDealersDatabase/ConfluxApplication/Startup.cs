namespace ConfluxApplication
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using ConfluxDealer.Data;
    using ConfluxDealer.Data.Migrations;
    using Conflux.Exports;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConfluxDbContext, Configuration>());

            var db = new ConfluxDbContext();
            JSON.SaveFile(db);
            Console.WriteLine(db.Cars.Count());
        }
    }
}
