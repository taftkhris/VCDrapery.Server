using System;
using System.Collections.Generic;
using System.Text;

using AutoMapper;

namespace VCDrapery.Server.Business
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CustomerModel, Data.Models.Customers>().ReverseMap();
            CreateMap<QuoteLineItemModel, Data.Models.QuoteLineItem>().ReverseMap();
            CreateMap<QuoteModel, Data.Models.Quote>().ReverseMap();
        }
    }
}
