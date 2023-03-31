using Microsoft.AspNetCore.Mvc;

namespace ConsoleToWebAPI.Controller
{
    [ApiController]
    //[Route("test")]
    [Route("test/[action]")]
    public class TestController:ControllerBase
    {       
        public string Get()
        {
            return "Hello";
        }
        public string Get1()
        {
            return "Hello1";
        }
    }
}
