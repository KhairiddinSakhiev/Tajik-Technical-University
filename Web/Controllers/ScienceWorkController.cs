using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class ScienceWorkController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}