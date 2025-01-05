using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace IDSProject.DTOs
{
    public class UserDTO
    {
        [Required]
        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Required]
        [Column("username")]
        [StringLength(255)]
        [Unicode(false)]
        public string Username { get; set; } = null!;

        [Required]
        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;

    
    }
}
