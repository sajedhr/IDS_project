using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("Comment")]
    public partial class Comment
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("content")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Content { get; set; } = null!;

        [Column("createdAt")]
        public DateTime CreatedAt { get; set; }

        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Comments")]
        public virtual User User { get; set; } = null!;

        [Column("postId")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("Comments")]
        public virtual Post Post { get; set; } = null!;
    }
}
