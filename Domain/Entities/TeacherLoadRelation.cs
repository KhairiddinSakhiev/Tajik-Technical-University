using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TeacherLoadRelation
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int LoadId { get; set; }
        public Load Load { get; set; }
    }
}
