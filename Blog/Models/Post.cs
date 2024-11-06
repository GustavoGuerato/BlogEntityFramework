using System;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = new Category();
        public int AuthorId { get; set; }
        public required User author { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Slug { get; set; } = string.Empty;
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime LastUpdateDate { get; set; } = DateTime.Now;

        public List<Tag>? Tags { get; set; } = null;
    }
}
