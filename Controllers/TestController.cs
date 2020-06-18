using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudyTest.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class TestController : ControllerBase
    {
        public class TestModel
        {
            //[FromHeader]
            public string Accept { get;set;}
            [FromHeader]
            public string Host { get;set;}
        }

        [HttpGet]
        public IActionResult GetQuery([FromQuery]TestModel testModel)
        {
            return Ok(testModel);
        }

        [HttpPost]
        public IActionResult PostData(int a,int b)
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetBody([Bind]TestModel testModel)
        {
            return Ok(testModel);
        }
    }
}
