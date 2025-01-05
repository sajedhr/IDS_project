using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class CommentDto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("content")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Content { get; set; } = null!;

    }
}
