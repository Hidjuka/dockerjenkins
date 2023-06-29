using Microsoft.AspNetCore.Mvc;
using System;

namespace testKubernetes.Controllers
{
    [ApiController]
    [Route("demo")]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public String Get()
        {
            return "Welcome to the Docker World!";
        }
    }
}
