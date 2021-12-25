using Microsoft.AspNetCore.Mvc;
using RazorClassLibary;

namespace RazorLightSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ForecastController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            var result = new Forecaster().Get().GetAwaiter().GetResult();
            return result;
        }
    }
}
