using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Table("Tag")]
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Slug { get; set; }
    }
}
