using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ConferencePlanner.Api.Models;
using ConferencePlanner.Abstraction.Repository;
using ConferencePlanner.Abstraction.Model;

namespace ConferencePlanner.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetDemoRepository _getDemoRepository;

        public HomeController(ILogger<HomeController> logger, IGetDemoRepository getDemoRepository)
        {
            _logger = logger;
            _getDemoRepository = getDemoRepository;
        }

        [HttpGet]
        [Route("{DemoName}")]
        public IActionResult GetDemo([FromRoute] string demoName)
        {
            List<DemoModel> demoModels = _getDemoRepository.GetDemo(demoName);
            return Ok(demoModels);
        }

        [HttpPost]
        [Route("{DemoName}")]
        public IActionResult UpdateDemo()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("{DemoName}")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult DeleteDemo()
        {
            return Ok();
        }
    }
}
