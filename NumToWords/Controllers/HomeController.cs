using Microsoft.AspNetCore.Mvc;
using NumToWords.Models;
using System;
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
          long newLong = Convert.ToInt64(Request.Form["input-number"]);
          Conversion newConversion = new Conversion(newLong);
          newConversion.CreateWordList();
          return View(newConversion);
        }
    }
}
