using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.data.mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");

            //chave primaria
            builder.HasKey(x => x.Id);

            //Identity
            builder.Property(x => x.Id).ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }
}
