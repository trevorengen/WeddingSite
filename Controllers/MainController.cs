using System.Net;
using Microsoft.AspNetCore.Mvc;
using Wedding_Site.Models;

namespace Wedding_Site.Controllers
{
    public class MainController : Controller
    {
        private Context _context;
        public MainController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("Event")]
        public IActionResult Event()
        {
            return View();
        }

        [HttpGet]
        [Route("Faq")]
        public IActionResult Faq()
        {
            return View();
        }

        [HttpGet]
        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet]
        [Route("Rsvp")]
        public IActionResult Rsvp()
        {
            return View();
        }

        [HttpGet]
        [Route("Registry")]
        public IActionResult Registry()
        {
            return View();
        }

        [HttpPost]
        [Route("UsrRsvp")]
        public IActionResult UsrRsvp(Guest guest)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guest);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View("Rsvp");
        }
    }
}