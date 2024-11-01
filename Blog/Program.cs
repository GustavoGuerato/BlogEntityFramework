using Blog.data;
using Blog.Models;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                var tag = new Tag { Name = "Asp.NET", Slug = "aspnet" };
                context.Tags.Add(tag);
                context.SaveChanges(); 
            }
        }
    }
}
