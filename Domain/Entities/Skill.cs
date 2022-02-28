using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Domain.Entities
{
    public class Skill
    {
        public int Id { get; set; }
        [MaxLength(300)]
        public string Title { get; set; }
        public int Percent { get; set; }
        public KnownColor  Color { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }

    
}