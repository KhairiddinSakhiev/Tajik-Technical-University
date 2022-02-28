using System.Collections.Generic;
using Domain.Entities;
using Domain.Models;

namespace Services.Services.Teacher
{
    public interface ITeacherService
    {
        List<TeacherViewModel> GetTeacherList();
        TeacherViewModel GetTeacherById(int id);
    }
}