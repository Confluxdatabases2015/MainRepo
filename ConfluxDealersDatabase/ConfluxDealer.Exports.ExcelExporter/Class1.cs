namespace ConfluxDealer.Data.MySql.Exporters
{
    using System;
    using System.IO;
    using ConfluxDealer.Data.SQLite;

    public class ExcelExporter
    {
        public void GenerateCompositeAirlinesReport(string path)
        {
            Console.WriteLine("Generating merged report from SQLite and MySql...");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

           
        }
    }
}