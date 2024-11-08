using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.data.mappings;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace Blog.data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseSqlServer(
                "Server=localhost,1433;Database=BlogFluentMap;User ID=sa;Password=1q2w3e4r@#$;"
            );

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}
