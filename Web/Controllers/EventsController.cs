using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class EventsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EventsSingle()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult NotFound()
        {
            return View();
        }
        
        public IActionResult Teachers()
        {
            return View();
        }

        
    }
}