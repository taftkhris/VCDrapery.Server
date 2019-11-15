using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VCDrapery.Server.Business;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VCDrapery.Server.Controllers
{
    [Route("api/[controller]")]
    public class QuoteController : Controller
    {
        IDraperyService _service;

        public QuoteController(IDraperyService service)
        {
            _service = service;
        }

        // POST api/<controller>
        [HttpPost]
        [Route("AddLineItem")]
        public IActionResult AddLineItem([FromBody]List<QuoteLineItemModel> quoteLineItems)
        {
            IActionResult result = null;

            try
            {
                result = this.Ok(_service.UpsertQuote(quoteLineItems));
            }
            catch(ArgumentException cause)
            {
                result = this.BadRequest(cause.Message);
            }
            catch(Exception cause)
            {
                result = this.BadRequest(cause.InnerException);
            }

            return result;
        }

        [HttpGet]
        [Route("GetQuote/{id}")]
        public IActionResult GetQuote(int id)
        {
            IActionResult result = null;

            try
            {
                result = this.Ok(_service.GetQuote(id));
            }
            catch(ArgumentException cause)
            {
                result = this.BadRequest(cause.Message);
            }
            catch(Exception cause)
            {
                result = this.BadRequest(cause.Message);
            }

            return result;
        }

        [HttpPost]
        [Route("AddQuote")]
        public IActionResult AddQuote([FromBody]QuoteModel quote)
        {
            IActionResult result = null;

            try
            {
                result = this.Ok(_service.UpsertQuote(quote));
            }
            catch(ArgumentException cause)
            {
                result = this.BadRequest(cause.Message);
            }
            catch(Exception cause)
            {
                result = this.BadRequest(cause.Message);
            }

            return result;
        }

        // PUT api/<controller>/5
        [HttpPatch]
        [Route("UpdateQuote")]
        public void Put([FromBody]QuoteModel quote)
        {
            IActionResult result = null;
            try
            {
                result = this.Ok(_service.UpsertQuote(quote));
            }
            catch(ArgumentException cause)
            {
                result = this.BadRequest(cause.Message);
            }
            catch(Exception cause)
            {
                result = this.BadRequest(cause.Message);
            }
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
