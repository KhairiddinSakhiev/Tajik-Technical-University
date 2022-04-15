using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class LoadViewModel
    {
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
        public DateTime CreatedAt { get; set; }
    }
}
