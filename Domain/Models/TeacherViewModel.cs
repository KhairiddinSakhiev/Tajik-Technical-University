using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Models
{
    public class TeacherViewModel
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public DateTime BirthDate { get; set; }
        public string FacebookAccount { get; set; }
        public string InstagramAccount { get; set; }
        public string LinkedIn { get; set; }
        public Gender Gender { get; set; }

    }
}