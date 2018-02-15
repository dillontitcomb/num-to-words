using Microsoft.AspNetCore.Mvc;
using NumToWords.Models;
using System.Collections.Generic;

namespace NumToWords.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }
        [HttpPost("/results")]
        public ActionResult Results()
        {
          Conversion newConversion = new Conversion(5);
          return View();
        }
    }
}
