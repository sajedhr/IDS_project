using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("Vote")]
    public partial class Vote
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("type")]
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; } = null!;

        [Column("postId")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("Votes")]
        public virtual Post Post { get; set; } = null!;

        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Votes")]
        public virtual User User { get; set; } = null!;
    }
}
