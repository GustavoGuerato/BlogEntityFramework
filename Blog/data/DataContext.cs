using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Blog.data
{
    public class DataContext : DbContext
    {
        public required DbSet<Category> Categories { get; set; }
        public required DbSet<Post> Posts { get; set; }

        // public DbSet<PostTag> PostTags { get; set; }

        public required DbSet<Role> Roles { get; set; }
        public required DbSet<Tag> Tags { get; set; }
        public required DbSet<User> Users { get; set; }

        //public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;"
            );
            options.LogTo(Console.WriteLine);
        }
    }
}
