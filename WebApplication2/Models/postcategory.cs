using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("PostCategory")]
    public partial class PostCategory
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("postId")]
        public int PostId { get; set; }

        [ForeignKey("PostId")]
        [InverseProperty("PostCategories")]
        public virtual Post Post { get; set; } = null!;

        [Column("categoriesID")]
        public int CategoriesID { get; set; }

        [ForeignKey("CategoriesID")]
        [InverseProperty("PostCategories")]
        public virtual Category Category { get; set; } = null!;
    }
}
