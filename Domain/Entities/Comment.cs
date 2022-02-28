using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        [MaxLength(500)]
        public string Message { get; set; }
        [MaxLength(100)]
        public string Email { get; set; }
        public int? ReplyId { get; set; }
        public int BlogId { get; set; }
        public virtual Order Order { get; set; }
        public virtual  Comment Reply { get; set; }
    }
}