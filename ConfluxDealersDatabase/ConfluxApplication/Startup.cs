namespace ConfluxApplication
{
    using System;
    using System.Linq;
    using System.Data.Entity;
    using ConfluxDealer.Data;
    using ConfluxDealer.Data.Migrations;
    using Conflux.Exports;
    using ConfluxPDF;

    public class Startup
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ConfluxDbContext, Configuration>());

            var db = new ConfluxDbContext();
            JSON.SaveFile(db);

            var carPrices = db.Cars
                .Select(c => new { c.Model, c.Make, c.Price })
                .ToList();
            PDFReporter.CreateReport(carPrices, "../../PDF-Reports/car-price.pdf", "Car prices report");
            Console.WriteLine("Car prices report created.");

            var carPricesInRange = db.Cars
                .Where(c => c.Price > 15000 && c.Price < 25000)
                .ToList();
            PDFReporter.CreateReport(carPricesInRange, "../../PDF-Reports/car-price-between-15000-and-25000.pdf", "Car prices between 15000 and 25000");
            Console.WriteLine("Car prices between 15000 and 25000 report created.");

            db.Dispose();
        }
    }
}
