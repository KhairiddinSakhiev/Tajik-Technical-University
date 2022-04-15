using Microsoft.AspNetCore.Mvc;
using Services.Services.Load;

namespace Web.Controllers
{
    public class LoadController:Controller
    {
        private ILoadService _loadService;

        public LoadController(ILoadService loadService)
        {
            _loadService = loadService;
        }

        public IActionResult Index()
        {
            return View(_loadService.GetLoadList());
        }

        public IActionResult SingleLoad([FromQuery] int id)
        {
            return View(_loadService.GetLoadById(id));
        }
    }
}
