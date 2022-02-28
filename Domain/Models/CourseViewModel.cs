using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Models
{
    public class CourseViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseSize { get; set; }
        public string Duration { get; set; }
        public decimal Price { get; set; }
    }
}