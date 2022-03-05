using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Load
    {
        public Load()
        {
            groups = new List<Group>();
            TeacherLoadRelations = new List<TeacherLoadRelation>();
            LoadCourseRelations = new List<LoadCourseRelation>();
        }
        public int Id { get; set; }      
        public int Course { get; set; }
        public TypeOfEducation TypeOfEducation { get; set; }
        public ICollection<Group> groups { get; set; }        
        public int CountGroup { get; set; } 
        public int CountSubGroup { get; set; }
        public int CountStudents { get; set; }
        public int WorkCourse { get; set; }
        public int ProjectCourse { get; set; }
        public int Lecture { get; set; }
        public int Experiment { get; set; }
        public int Action { get; set; }
        public int Seminars { get; set; }
        public int KMRO { get; set; }
        public int Exam { get; set; }
        public int Test { get; set; }
        public int Consultation { get; set; }
        public int Internship { get; set; }
        public int StateExam { get; set; }
        public int DiplomProject { get; set; }
        public virtual ICollection<TeacherLoadRelation> TeacherLoadRelations { get; set; }
        public virtual ICollection<LoadCourseRelation> LoadCourseRelations { get; set; }
    }
    public enum TypeOfEducation
    {
        Master,
        Bacholor,
        Phd
    }
}
