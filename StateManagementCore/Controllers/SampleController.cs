using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementCore.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            TempData["Name"] = "Sam";
            ViewBag.name = "Sam";
            return View();
        }
        public IActionResult Index1()
        {
            ViewBag.name = TempData["Name"].ToString();
            TempData.Keep();
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
    }
}
