using System;
using System.Collections.Generic;
using Domain.Entities;

namespace Domain.Models
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Message { get; set; }
        public int? ReplyId { get; set; }
        public int BlogId { get; set; }
        public   List<CommentViewModel> Replies { get; set; }
    }
}