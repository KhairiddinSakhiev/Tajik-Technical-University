using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class TypeOfWork
    {
        public TypeOfWork()
        {
            ScienceWorks = new List<ScienceWork>();
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<ScienceWork> ScienceWorks { get; set; }
    }
}
