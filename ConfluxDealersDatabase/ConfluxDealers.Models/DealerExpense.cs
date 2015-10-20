using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfluxDealers.Models
{
    public class DealerExpense
    {
        public int Id { get; set; }

        public DateTime Month { get; set; }

        public decimal Value { get; set; }

        public string DealerName { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Value: {1}, Month: {2}, DealerName: {3}", this.Id, this.Value, this.Month, this.DealerName);
        }
    }
}
