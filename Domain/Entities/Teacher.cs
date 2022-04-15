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
            Experiences = new List<Experience>();           
            TeacherLoadRelations = new List<TeacherLoadRelation>();
            CreatedAt = DateTime.Now;
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
        public Gender Gender { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(100)]
        public string Job { get; set; }
        [MaxLength(100)]
        public string Degree { get; set; }
        [MaxLength(300)]
        public string Univer { get; set; }
        [MaxLength(100)]
        public string Specialty { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual ICollection<Experience> Experiences { get; set; }                            
        public virtual ICollection<TeacherLoadRelation> TeacherLoadRelations { get; set; }  
        public virtual ICollection<ScienceWork> ScienceWorks { get; set; }
        
    }

    public enum Gender
    {
        Male,
        Female,
    }
   
  
}