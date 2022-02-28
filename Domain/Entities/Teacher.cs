using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Net.Mime;

namespace Domain.Entities
{
    public class Teacher
    {
        public Teacher()
        {
            Skills = new List<Skill>();
            Experiences = new List<Experience>();
            TeacherCourseRelations = new List<TeacherCourseRelation>();
        }
        public int Id { get; set; }
        [MaxLength(30)]
        public string FirstName { get; set; }
        [MaxLength(30)]
        public string LastName { get; set; }
        [MaxLength(30)]
        public string FatherName { get; set; }
        public string Description { get; set; }
        [MaxLength(9)]
        public string IdCard { get; set; }
        [MaxLength(13)]
        public string PhoneNumber { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(100)]
        public string FacebookAdress { get; set; }
        [MaxLength(100)]
        public string InstagramAdress { get; set; }
        [MaxLength(100)]
        public string LinkedIn { get; set; }
        public virtual ICollection<Skill> Skills { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }
        public virtual ICollection<TeacherCourseRelation> TeacherCourseRelations { get; set; }
                        
    }
}