using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelloWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyTestController : ControllerBase
    {
        private readonly ILogger<MyTestController> _logger;

        public MyTestController(ILogger<MyTestController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello. This is my controller.";
        }
    }
}
