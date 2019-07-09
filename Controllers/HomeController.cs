using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        // Requests
        // localhost: 5000/
        // [Route("")]
        [HttpGet("")]

        public IActionResult Index()
        {
            //ViewResult myView = View();
            return View("Index");
        }
        [HttpPost("Result")]
        public IActionResult Result(string name, string dojo, string lang, string comment) 
        {
            ViewBag.name = name;
            ViewBag.dojo = dojo;
            ViewBag.lang = lang;
            ViewBag.comment = comment;

            return View("Result");
        }
    }
}