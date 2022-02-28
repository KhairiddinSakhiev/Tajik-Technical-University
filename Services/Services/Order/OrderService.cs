using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Domain.Models;
using Microsoft.EntityFrameworkCore.Query;
using Persistence;

namespace Services.Services.Blog
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public OrderService(DataContext context, IMapper mapper
        )
        {
            _context = context;
            _mapper = mapper;
        }


        public List<OrderViewModel> GetBlogList()
        {
            return _mapper.Map<List<OrderViewModel>>(_context.Blogs.ToList());
        }

        public OrderViewModel GetBlogById(int id)
        {
            return _mapper.Map<OrderViewModel>(_context.Blogs.Find(id));
        }
    }
}