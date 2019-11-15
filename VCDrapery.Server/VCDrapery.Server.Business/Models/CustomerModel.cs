using System;
using System.Collections.Generic;
using System.Text;

namespace VCDrapery.Server.Business
{
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public virtual ICollection<QuoteModel> Quotes { get; set; }
    }
}
