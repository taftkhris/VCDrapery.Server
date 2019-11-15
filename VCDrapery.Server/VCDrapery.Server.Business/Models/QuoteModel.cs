using System;
using System.Collections.Generic;
using System.Text;

namespace VCDrapery.Server.Business
{
    public class QuoteModel
    {
        public int CustomerId { get; set; }
        public int QuoteId { get; set; }
        public decimal QuotePrice { get; set; }
        DateTime DateAdded { get; set; }
        public virtual ICollection<QuoteLineItemModel> LineItems { get; set; }
        //public virtual CustomerModel Customer { get; set; }
    }
}
