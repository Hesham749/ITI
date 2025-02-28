using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController : ControllerBase
    {
        [HttpGet]
        //api/test
        public string getsttring()
        {
            return "welcome to API";
        }
        [HttpGet("{id}")]
        //[Route("{id}")]
        //api/test/2
        public string getbyid(int id)
        {
            return "welcome" + id;
        }
    }
}
