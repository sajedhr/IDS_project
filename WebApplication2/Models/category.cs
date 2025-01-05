using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Repository;

namespace WebApplication2.Models
{
    [Table("Category")]
    public partial class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [StringLength(255)]
        [Unicode(false)]
        public string Name { get; set; } = null!;

        [Column("description")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Description { get; set; } = null!;

        [InverseProperty("Category")]
        public virtual ICollection<PostCategory> PostCategories { get; set; } = new List<PostCategory>();
    }
}
