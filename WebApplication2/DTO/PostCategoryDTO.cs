using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class PostCategoryDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("postId")]
        public int PostId { get; set; }

        [Column("categoriesID")]
        public int CategoriesID { get; set; }
    }
}
