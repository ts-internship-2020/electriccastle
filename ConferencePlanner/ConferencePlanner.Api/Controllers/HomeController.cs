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
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetDemoRepository _getDemoRepository;

        public HomeController(ILogger<HomeController> logger, IGetDemoRepository getDemoRepository)
        {
            _logger = logger;
            _getDemoRepository = getDemoRepository;
        }

        public IActionResult Index()
        {
            List<DemoModel> demoModels = _getDemoRepository.GetDemo("");
            return View(demoModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
