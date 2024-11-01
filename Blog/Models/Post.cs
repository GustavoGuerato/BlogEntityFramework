using System;
using System.Collections.Generic;
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
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int AuthorId { get; set; }

        public required string Title { get; set; }
        public required string Summary { get; set; }
        public required string Body { get; set; }
        public required string Slug { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }
}
