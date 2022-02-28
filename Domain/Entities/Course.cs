using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Course
    {
        public Course()
        {
            TeacherCourseRelations = new List<TeacherCourseRelation>();
            TimeTables = new List<TimeTable>();
        }
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CourseSize { get; set; }
        public int Duration { get; set; }
        public decimal Price { get; set; }
        
        public virtual ICollection<TimeTable> TimeTables { get; set; }
        public virtual ICollection<TeacherCourseRelation> TeacherCourseRelations { get; set; }
    }
}