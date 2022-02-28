using Domain.Entities;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Services;
using Services.Services.Teacher;

namespace Web.Controllers
{
    public class TeacherController:Controller
    {
        private ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService )
        {
            _teacherService = teacherService;
        }

        public IActionResult Index()
        {
            return View(_teacherService.GetTeacherList());
        }

        public IActionResult singleTeacher([FromQuery] int id)
        {
            return View(_teacherService.GetTeacherById(id));
        }
    }
}