using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    //     [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] NVARCHAR(80) NOT NULL,
    // [Email] VARCHAR(200) NOT NULL,
    // [PasswordHash] VARCHAR(255) NOT NULL,
    // [Bio] TEXT NOT NULL,
    // [Image] VARCHAR(2000) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required string Name { get; set; }

        public required string Email { get; set; }

        public required string PasswordHash { get; set; }

        public required string Bio { get; set; }

        public required string Image { get; set; }

        public required string Slug { get; set; }
    }
}
