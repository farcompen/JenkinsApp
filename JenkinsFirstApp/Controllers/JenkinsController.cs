using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JenkinsFirstApp.Controllers
{
    [Route("api/v1/")]
    [ApiController]
    public class JenkinsController : ControllerBase
    {

        public IActionResult Get()
        {
            return Ok(new { message = "Up" });
        
        }
    }
}
