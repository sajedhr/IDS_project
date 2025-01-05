using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class VoteDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("type")]
        [StringLength(50)]
        [Unicode(false)]
        public string Type { get; set; } = null!;

        [Column("postId")]
        public int PostId { get; set; }

        [Column("userId")]
        public int UserId { get; set; }
    }
}
