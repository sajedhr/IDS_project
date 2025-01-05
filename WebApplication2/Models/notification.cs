using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Models
{
    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("message")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Message { get; set; } = null!;

        [Column("isRead")]
        public bool IsRead { get; set; }

        [Column("userId")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Notifications")]
        public virtual User User { get; set; } = null!;
    }
}
