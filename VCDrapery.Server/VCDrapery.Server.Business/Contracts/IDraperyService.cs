using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VCDrapery.Server.Data.Models;

namespace VCDrapery.Server.Business
{
    public interface IDraperyService
    {
        CustomerModel GetCustomer(int id);
        CustomerModel GetCustomer(string name);
        QuoteModel GetQuote(int id);
        CustomerModel UpsertCustomer(CustomerModel customer);
        List<QuoteLineItemModel> UpsertQuoteLineItem(List<QuoteLineItemModel> lineItems);
        QuoteModel UpsertQuote(QuoteModel quote);
        QuoteModel UpsertQuote(List<QuoteLineItemModel> items);


    }
}