using System;

namespace Blog.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PasswordHash { get; set; }
        public required string Bio { get; set; }
        public required string Image { get; set; }
        public required string Slug { get; set; }

        public IList<Post> Posts { get; set; } = new List<Post>();
        public IList<Role> Roles { get; set; } = new List<Role>();
    }
}
