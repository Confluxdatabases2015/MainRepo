namespace Conflux.Exports
{
    using ConfluxDealer.Data;
    using System.IO;

    public static class JSON
    {
        private const string carId = @"""car-id"" : ";
        private const string carModel = @"""car-model"" : ";
        private const string carMake = @"""car-made"" : ";
        private const string carPrice = @"""car-price"" : ";
        private const string categoryId = @"""category-id"" : ";
        private const string shopId = @"""shop-id"" : ";

        public static void SaveFile(IConfluxDbContext dbContext)
        {
            StreamWriter streamWriter;

            foreach (var car in dbContext.Cars)
            {
                streamWriter = new StreamWriter("../../Json-Reports/" + car.Id + ".txt", false);
                using (streamWriter)
                {
                    streamWriter.WriteLine("{");
                    streamWriter.WriteLine(carId + car.Id + ",");
                    streamWriter.WriteLine(carModel + "\"" + car.Model + "\"" + ",");
                    streamWriter.WriteLine(carMake + "\"" + car.Make + "\"" + ",");
                    streamWriter.WriteLine(carPrice + car.Price + ",");
                    streamWriter.WriteLine(categoryId + car.CategoryId + ",");
                    streamWriter.WriteLine(shopId + car.ShopId + ",");
                    streamWriter.WriteLine("}");
                }
            }
            System.Console.WriteLine("JSON files saved at: '../ConfluxApplication/Json-Reports/'");
        }
    }
}
