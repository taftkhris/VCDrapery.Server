using AutoMapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VCDrapery.Server.Data;
using VCDrapery.Server.Data.Models;

namespace VCDrapery.Server.Business
{
    public class DraperyService : IDraperyService
    {
        private readonly IDraperyRepository _repository;
        private readonly IMapper _mapper;

        public DraperyService(IDraperyRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public CustomerModel GetCustomer(int id)
        {
            //CustomerModel customer = _mapper.Map<CustomerModel>(_repository.GetCustomer(x => x.CustomerId == id));
            return _mapper.Map<CustomerModel>(_repository.GetCustomer(x => x.CustomerId == id));
        }
        public CustomerModel GetCustomer(string name)
        {
            //CustomerModel customer = _mapper.Map<CustomerModel>(_repository.GetCustomer(x => x.Name.Contains(name)));
            return _mapper.Map<CustomerModel>(_repository.GetCustomer(x => x.Name.Contains(name)));
        }

        public CustomerModel UpsertCustomer(CustomerModel customer)
        {
            return _mapper.Map<CustomerModel>(_repository.UpsertCustomer(_mapper.Map<Customers>(customer)));
        }

        public List<QuoteLineItemModel> UpsertQuoteLineItem(List<QuoteLineItemModel> lineItems)
        {
            return _mapper.Map<List<QuoteLineItemModel>>(_repository.UpsertQuoteLineItem(_mapper.Map<List<QuoteLineItem>>(lineItems)));
        }

        public QuoteModel UpsertQuote(QuoteModel quote)
        {
            return _mapper.Map<QuoteModel>(_repository.AddQuote(_mapper.Map<Quote>(quote)));
        }

        public QuoteModel UpsertQuote(List<QuoteLineItemModel> items)
        {
            QuoteModel quote = items.ToQuoteModel();
            return UpsertQuote(quote);
        }

        public QuoteModel GetQuote(int id)
        {
            return _mapper.Map<QuoteModel>(_repository.GetQuote(x => x.QuoteId == id));
        }
    }
}
