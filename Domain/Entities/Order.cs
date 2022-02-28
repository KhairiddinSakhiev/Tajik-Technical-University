using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities
{
    public class Order
    {

        public Order()
        {
            Comments = new List<Comment>();
        }
        public int Id { get; set; }
        [MaxLength(200)]
        public string Title { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string Content { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        
        
    }
}