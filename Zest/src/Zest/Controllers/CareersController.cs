using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Zest.Models;

namespace Zest.Controllers
{
    public class CareersController : Controller
    {
        private ApplicationDbContext _context;

        public CareersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Careers
        public IActionResult Index()
        {
            return View(_context.ApplicationUser.ToList());
        }

        public IActionResult Careers()
        {
            return View();
        }

        public IActionResult Postings()
        {
            return View();
        }

        public IActionResult SpecificPosting()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
