using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Course
    {
        public Course()
        {
            LoadCourseRelations = new List<LoadCourseRelation>();            
        }
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }        
                    
        public virtual ICollection<LoadCourseRelation> LoadCourseRelations { get; set; }
    }
}