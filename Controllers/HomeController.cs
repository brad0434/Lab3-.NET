using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            
            return View();

        }
        public IActionResult Razor()
        {
            return View();

        }
        public IActionResult Count()
        {
            //ViewData.Add(new KeyValuePair<string, object>("quantity", Request.Form["quantity"]));
            ViewBag.numOfBottles = int.Parse(Request.Form["quantity"]);
            return View();

        }
        public IActionResult CreatePerson()
        {

            return View();

        }
        public IActionResult DisplayPerson()
        {
            ViewBag.fName = Request.Form["fName"].ToString();
            ViewBag.lName = Request.Form["lName"].ToString();
            ViewBag.age = int.Parse(Request.Form["age"]);
            ViewBag.email = Request.Form["emailAddress"].ToString();
            ViewBag.password = Request.Form["password"].ToString();
            ViewBag.description = Request.Form["description"].ToString();
            return View();

        }
        public IActionResult Error()
        {

            return View();

        }
    }
}
