using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Repository;

namespace WebApplication2.Models
{
    [Table("Post")]
    public partial class Post
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("title")]
        [StringLength(255)]
        [Unicode(false)]
        public string Title { get; set; } = null!;

        [Column("description")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Description { get; set; } = null!;

        [Column("tags")]
        [StringLength(255)]
        [Unicode(false)]
        public string Tags { get; set; } = null!;

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Posts")]
        public virtual User User { get; set; } = null!;

        [InverseProperty("Post")]
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        [InverseProperty("Post")]
        public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();

        [InverseProperty("Post")]
        public virtual ICollection<PostCategory> PostCategories { get; set; } = new List<PostCategory>();
    }
}
