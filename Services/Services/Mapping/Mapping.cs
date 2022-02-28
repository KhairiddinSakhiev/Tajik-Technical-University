using AutoMapper;
using Domain.Models;

namespace Services.Services.Mapping
{
    public class Mapping:Profile
    {
        public Mapping()
        {
            CreateMap<Domain.Entities.Teacher, TeacherViewModel>();
            CreateMap<Domain.Entities.Course, CourseViewModel>();
        }
    }
}