using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementCore.Controllers
{
    public class TempdataDemoController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "Mark";
            TempData["Name"] = "John";
            return View();
        }
        public IActionResult Index2()
        {

            if(TempData.ContainsKey("Name"))
                ViewBag.name = TempData["Name"].ToString();
            TempData.Keep();    
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.name = TempData["Name"].ToString();
            
            return View();
        }
    }
}
