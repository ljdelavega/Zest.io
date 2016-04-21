using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace Zest.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult About()
        {

            return View();
        }
    }
}
