namespace Conflux.Exports
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Xml;
    using System.Xml.Linq;
    using ConfluxDealers.Models;
    using ConfluxDealer.Data;

    public class XmlReport
    {
        public bool GenerateXmlReport(string name)
        {
            using (var db = new ConfluxDbContext())
            {
                try
                {
                    XDocument xmlDocument = new XDocument(
                        new XDeclaration("1.0", "utf-8", "no"),
                        new XProcessingInstruction("xml-stylesheet", @"type=""text/xsl"" href=""SalesStyle.xslt"""));
                    var dealerExpenses = from dealer in db.DealerExpenses select dealer;
                    var dealerByName = dealerExpenses.GroupBy(x => x.DealerName);
                    var exp = new XElement("Expenses-By-Month");
                    xmlDocument.Add(exp);
                    foreach (var item in dealerByName)
                    {
                        var saleInMonth = new XElement("dealer");
                        exp.Add(saleInMonth);
                        var dealer = new XAttribute("name", item.Key);
                        saleInMonth.Add(dealer);
                        foreach (var date in item)
                        {
                            //// TODO Get date for sum of price  and  calculate total sum 
                            saleInMonth.Add(
                                new XElement(
                                    "expenses",
                                    new XAttribute("date", (date.Month).ToString("MMM yyyy")), 
                                    date.Value));
                        }
                    }

                    xmlDocument.Save(name);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error when generating XML report! Error: {0}", e.InnerException.Message);
                    return false;
                }

                return true;
            }
        }
    }
}

