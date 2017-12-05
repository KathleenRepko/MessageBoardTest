using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MessageBoardTutorial.Models
{
    public class MessageBoardContext : DbContext
    {
        public DbSet<post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }

    public class post
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public DateTime DatePosted { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        [Key]
        public int Id { get; set; }
        public string Message { get; set; }
        public string Username { get; set; }
        public DateTime DatePosted { get; set; }
        public virtual post ParentPost { get; set; }
    }
}