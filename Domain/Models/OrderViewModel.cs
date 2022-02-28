using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Models
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public string UserName { get; set; }
        public string CategoryName { get; set; }
        public string Content { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}