using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class ScienceWork
    {
        public ScienceWork()
        {           
            CreatedAt = DateTime.Now;       

        }
        public int Id { get; set; }
        public int TeacherId { get; set; }      
        public string NameOfWork { get; set; }
        public Output Output { get; set; }
        public int TypeOfWorkId { get; set; }
        public TypeOfWork TypeOfWork { get; set; }
        public string PublishedPlace  { get; set; }
        public DateTime Created { get; set; }
        public int CountofPages { get; set; }
        public string Number { get; set; }
        public string Workload { get; set; }
        public DateTime CreatedAt { get; set; }

       
    }

    public enum Output
    {
        Menuscript,
        Print
    }
}
