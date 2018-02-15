using Microsoft.AspNetCore.Mvc;
using Template.Models;
using System.Collections.Generic;

namespace Template.Controllers
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
