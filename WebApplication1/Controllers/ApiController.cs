using Estudo_LogWithSeq;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        Sample sample = new Sample();

        [Route("index")]
        public IActionResult Index()
        {
            sample.LogSample("Index da api");

            return Ok("Esta é a api");
        }

        [Route("exit")]
        public IActionResult Exit()
        {
            sample.LogSample("Fechando log");

            sample.CloseAndFlush();

            return Ok("Fechou o log");
        }
    }
}
