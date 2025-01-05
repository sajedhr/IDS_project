using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class CategoryDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("name")]
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column("description")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Description { get; set; } = null!;
    }
}

