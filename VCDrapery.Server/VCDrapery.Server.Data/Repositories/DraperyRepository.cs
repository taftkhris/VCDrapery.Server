using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;


namespace VCDrapery.Server.Data
{
    public class DraperyRepository : IDraperyRepository
    {
        public readonly DraperyContext _context;

        public DraperyRepository(DraperyContext context)
        {
            _context = context;
        }

        public Models.Customers GetCustomer(Expression<Func<Models.Customers, bool>> expression)
        {
            return _context.Customers
                .Include(x => x.Quotes)
                .ThenInclude(x => x.LineItems)
                .FirstOrDefault(expression);
        }

        public Models.Quote GetQuote(Expression<Func<Models.Quote, bool>> expression)
        {
            return _context.Quote
                .Include(x => x.LineItems)
                .FirstOrDefault(expression);
        }

        public List<Models.QuoteLineItem> UpsertQuoteLineItem(List<Models.QuoteLineItem> lineItems)
        {
            try
            {
                foreach (Models.QuoteLineItem lineItem in lineItems)
                {
                    lineItem.DateAdded = DateTime.Now;
                    _context.QuoteLineItems.Add(lineItem);
                }
                
            }
            catch(Exception cause)
            {
                Console.WriteLine(cause.Message);
            }

            _context.SaveChanges();

            return lineItems;
        }

        public Models.Customers UpsertCustomer(Models.Customers customer)
        {              
            if (customer.IsNew())
            {
                customer.DateAdded = DateTime.Now;
                _context.Customers.Add(customer);
            }
            else
            {
                Models.Customers found = GetCustomer(x => x.CustomerId == customer.CustomerId);

                if (found == null) throw new Exception("Customer not found");

                customer.DateUpdated = DateTime.Now;
                customer.DateAdded = found.DateAdded;

                _context.Entry(found).CurrentValues.SetValues(customer);

            }

            _context.SaveChanges();

            return customer;
        }

        public Models.Quote AddQuote(Models.Quote quote)
        {
            if(quote.IsNew())
            {
                if(quote.CustomerId == 0)
                {
                    quote.CustomerId = 2;
                }

                quote.DateAdded = DateTime.Now;
                
                foreach (Models.QuoteLineItem item in quote.LineItems)
                {
                    item.DateAdded = DateTime.Now;
                    item.QuoteId = quote.QuoteId;
                    _context.QuoteLineItems.Add(item);
                }

                _context.Quote.Add(quote);
            }

            _context.SaveChanges();

            return quote;
        }
    }
}
