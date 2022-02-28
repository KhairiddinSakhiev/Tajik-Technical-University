using Microsoft.Win32.SafeHandles;

namespace Domain.Entities
{
    public class TeacherCourseRelation
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}