using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    //     [Id] INT NOT NULL IDENTITY(1, 1),
    //     [CategoryId] INT NOT NULL,
    //     [AuthorId] INT NOT NULL,
    //     [Title] VARCHAR(160) NOT NULL,
    //     [Summary] VARCHAR(255) NOT NULL,
    //     [Body] TEXT NOT NULL,
    //     [Slug] VARCHAR(80) NOT NULL,
    //     [CreateDate] DATETIME NOT NULL DEFAULT(GETDATE()),
    //     [LastUpdateDate] DATETIME NOT NULL DEFAULT(GETDATE()),

    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public required Category category { get; set; }

        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public required User Author { get; set; }

        public required string Title { get; set; }
        public required string Summary { get; set; }
        public required string Body { get; set; }
        public required string Slug { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
