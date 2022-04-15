using Microsoft.Win32.SafeHandles;

namespace Domain.Entities
{
    public class LoadCourseRelation
    {
        public int LoadId { get; set; }
        public Load Load { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}