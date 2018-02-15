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
    }
}
