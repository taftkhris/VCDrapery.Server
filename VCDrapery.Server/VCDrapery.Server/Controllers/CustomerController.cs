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
    public class CustomerController : Controller
    {
        private readonly IDraperyService _service;

        public CustomerController(IDraperyService service)
        {
            _service = service;
        }
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet]
        [Route("GetCustomerById/{id}")]
        public IActionResult GetCustomerById(int id)
        {
            IActionResult result = null;

            result = this.Ok(_service.GetCustomer(id));
            return result;
        }

        [HttpGet]
        [Route("GetCustomerByName/{name}")]
        public IActionResult GetCustomerById(string name)
        {
            IActionResult result = null;
            return this.Ok(_service.GetCustomer(name));
        }

        // POST api/<controller>
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        // PUT api/<controller>/5
        [HttpPost]
        [Route("EditCustomer")]
        public IActionResult EditCustomer([FromBody]CustomerModel customer)
        {
            return this.Ok(_service.UpsertCustomer(customer));
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
