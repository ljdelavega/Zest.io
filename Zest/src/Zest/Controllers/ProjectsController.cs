using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;


namespace Zest.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Projects()
        {

            return View();
        }
    }
}
