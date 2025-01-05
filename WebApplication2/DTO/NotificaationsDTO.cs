using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class NotificationDTO
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("message")]
        [StringLength(1000)]
        [Unicode(false)]
        public string Message { get; set; } = null!;

        [Column("isRead")]
        public bool IsRead { get; set; }

        [Column("userId")]
        public int UserId { get; set; }
    }
}
