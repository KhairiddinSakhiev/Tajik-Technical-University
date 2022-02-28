using System.Collections.Generic;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Services.Class;

namespace Web.Controllers
{
    public class CourseController:Controller
    {
        private readonly ICourseService _service;

        public CourseController(ICourseService service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            return View(_service.GetCourseList());
        }

        public IActionResult CourseSingle([FromQuery] int id)
        {
            return View(_service.GetCourseById(id));
        }
    }
}