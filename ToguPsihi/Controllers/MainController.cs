using Microsoft.AspNetCore.Mvc;
using ToguPsihi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToguPsihi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        // GET: api/<MainController>
        [Route("testOne")]
        [HttpPost]
        public IActionResult BlockOne([FromBody]TestOne model)
        {
           
            TestOneResult result = new TestOneResult(model);
            return Ok(result.results.ToHashSet());
        }
        [Route("testTwo")]
        [HttpPost]
        public IActionResult BlockTwo()
        {

           return Ok(new TestTwo());
        }

        


    }
}
