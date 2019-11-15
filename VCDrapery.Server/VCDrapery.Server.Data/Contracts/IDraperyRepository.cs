using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using VCDrapery.Server.Data.Models;

namespace VCDrapery.Server.Data
{
    public interface IDraperyRepository
    {
        Customers GetCustomer(Expression<Func<Customers, bool>> expression);
        Quote GetQuote(Expression<Func<Quote, bool>> expression);
        Customers UpsertCustomer(Models.Customers customer);
        List<Models.QuoteLineItem> UpsertQuoteLineItem(List<Models.QuoteLineItem> lineItems);
        Quote AddQuote(Quote quote);

    }
}