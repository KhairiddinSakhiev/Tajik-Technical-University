using Microsoft.AspNetCore.Mvc;
using Services.Services.Blog;

namespace Web.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET
        public IActionResult Index()
        {
            return View(_orderService.GetBlogList());
        }
        
        // GET
        public IActionResult SingleBlog([FromQuery] int id)
        {
            return View(_orderService.GetBlogById(id));
        }
    }
}