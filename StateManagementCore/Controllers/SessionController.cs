using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StateManagementCore.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name","John" );
            return View();
        }
        public IActionResult Index2()
        {
            ViewBag.name = HttpContext.Session.GetString("Name");
            return View();
        }
        public IActionResult Index3()
        {
            ViewBag.name = HttpContext.Session.GetString("Name");
            return View();
        }
    }
}
