using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class PostDto
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
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

        [Column("userId")]
        public int UserId { get; set; }
    }
}
