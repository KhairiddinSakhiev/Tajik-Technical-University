using System.Collections.Generic;
using Domain.Models;

namespace Services.Services.Blog
{
    public interface IOrderService
    {
        List<OrderViewModel> GetBlogList();
        OrderViewModel GetBlogById(int id);
    }
}