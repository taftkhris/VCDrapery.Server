using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VCDrapery.Server.Data.Models
{
    [Table("Quotes")]
    public class Quote
    {
        public int CustomerId { get; set; }
        [Key]
        public int QuoteId { get; set; }
        public decimal QuotePrice { get; set; }
        public decimal? DiscountDollarAmount { get; set; }
        public decimal? DiscountPercentAmount { get; set; }
        //public bool CheckedOut { get; set; }
        public DateTime DateAdded { get; set; }
        public virtual ICollection<QuoteLineItem> LineItems { get; set; }
        public virtual Customers Customer { get; set; }

        public bool IsNew() => QuoteId == 0 ? true : false;
    }
}
