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
        public DbSet<Category> Categories { get; set; }
    }
}
