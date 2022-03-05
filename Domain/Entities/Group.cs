using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
    public class Group
    {
        public Group()
        {
           
        }
        public int Id { get; set; }
        [MaxLength(30)]
        public string Title { get; set; }
        public int LoadId { get; set; }
        public Load Load { get; set; }
    }
}
