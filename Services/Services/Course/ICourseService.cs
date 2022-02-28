using System.Collections.Generic;
using Domain.Models;

namespace Services.Services.Class
{
    public interface ICourseService
    {
        List<CourseViewModel> GetCourseList();
        CourseViewModel GetCourseById(int id);
    }
}