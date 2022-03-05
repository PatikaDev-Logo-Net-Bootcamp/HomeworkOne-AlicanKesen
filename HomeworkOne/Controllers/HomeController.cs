using HomeworkOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkOne.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(InfoViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return Failed();
            }
            return Success();

        }

        public IActionResult Failed()
        {
            return BadRequest(new ResponseViewModel { Data = "null", Error = "Hatalı Giriş" , Success=false});
        }

        public IActionResult Success()
        {
            return Ok(new ResponseViewModel { Data = "Giriş Başarılı", Success = true, Error = "null" });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}
