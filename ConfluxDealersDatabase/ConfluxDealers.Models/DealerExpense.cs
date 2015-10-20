namespace ConfluxDealers.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public class DealerExpense
    {
        [Key]
        public int Id { get; set; }

        public DateTime Month { get; set; }

        public decimal Value { get; set; }

        [MaxLength(50)]
        public string DealerName { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}, Value: {1}, Month: {2}, DealerName: {3}", this.Id, this.Value, this.Month, this.DealerName);
        }
    }
}
