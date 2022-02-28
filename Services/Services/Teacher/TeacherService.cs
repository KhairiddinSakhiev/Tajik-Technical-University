using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using AutoMapper;
using Domain.Entities;
using Domain.Models;
using Persistence;

namespace Services.Services.Teacher
{
    public class TeacherService:ITeacherService
    {
        private DataContext _context;
        private IMapper _mapper;

        public TeacherService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<TeacherViewModel> GetTeacherList()
        {
            return _mapper.Map<List<TeacherViewModel>>(_context.Teachers.ToList());
        }
        public TeacherViewModel GetTeacherById(int id)
        {
            return _mapper.Map<TeacherViewModel>(_context.Teachers.Find(id));
        }
    }
}