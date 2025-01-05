﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace WebApplication2.Models
{
    [Table("User")]
    public partial class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("username")]
        [StringLength(255)]
        [Unicode(false)]
        public string Username { get; set; } = null!;

        [Column("email")]
        [StringLength(255)]
        [Unicode(false)]
        public string Email { get; set; } = null!;

        [Column("password")]
        [StringLength(50)]
        [Unicode(false)]
        public string Password { get; set; } = null!;

        [Column("role")]
        [StringLength(50)]
        [Unicode(false)]
        public string Role { get; set; } = null!;

        [Column("reputationPoints")]
        public int ReputationPoints { get; set; }
        [InverseProperty("User")]
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        [InverseProperty("User")]
        public virtual ICollection<Comment> Comments { get; set; } = new List<Comment>();

        [InverseProperty("User")]
        public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

        [InverseProperty("User")]
        public virtual ICollection<Vote> Votes { get; set; } = new List<Vote>();
    }
}
