using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    // [Id] INT NOT NULL IDENTITY(1, 1),
    // [Name] VARCHAR(80) NOT NULL,
    // [Slug] VARCHAR(80) NOT NULL,

    // CONSTRAINT [PK_Role] PRIMARY KEY([Id]),
    // CONSTRAINT [UQ_Role_Slug] UNIQUE([Slug])
    public class Role
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }
    }
}
