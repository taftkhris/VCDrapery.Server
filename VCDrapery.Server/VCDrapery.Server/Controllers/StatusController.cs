using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VCDrapery.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusController : ControllerBase
    {
        [HttpGet]
        public IActionResult IsAlive()
        {
            return new JsonResult(new { IsAlive = true, Status = "Ready. Listening to incoming requests." });
        }
    }
}