using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Models;
using Persistence;

namespace Services.Services.Class
{
    public class CourseService:ICourseService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CourseService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<CourseViewModel> GetCourseList()
        {
            return _mapper.Map<List<CourseViewModel>>(_context.Courses.ToList());
        }

        public CourseViewModel GetCourseById(int id)
        {
            return _mapper.Map<CourseViewModel>(_context.Courses.Find(id));
        }
        
    }
}