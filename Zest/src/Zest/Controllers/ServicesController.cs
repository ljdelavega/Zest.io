using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Zest.Models;

namespace Zest.Controllers
{
    public class ServicesController : Controller
    {
        private ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Careers
        public IActionResult Index()
        {
            return View(_context.ApplicationUser.ToList());
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult ExampleService()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
