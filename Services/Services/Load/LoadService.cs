using AutoMapper;
using Domain.Models;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services.Load
{
    public class LoadService : ILoadService
    {
        private DataContext _context;
        private IMapper _mapper;

        public LoadService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public LoadViewModel GetLoadById(int Id)
        {
            return _mapper.Map<LoadViewModel>(_context.Loads.Find(Id));
        }

        public List<LoadViewModel> GetLoadList()
        {
            return _mapper.Map<List<LoadViewModel>>(_context.Loads.ToList());
        }
    }
}
