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
                // var tag = new Tag { Name = "Asp.NET", Slug = "aspnet" };
                // context.Tags.Add(tag);
                // context.SaveChanges();
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                // tag.Name = ".net";
                // tag.Slug = "dotnet";

                // context.Update(tag);
                // context.SaveChanges();

                // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

                // context.Remove(tag);
                // context.SaveChanges();

                var tags = context.Tags.ToList().Where(x => x.Name.Contains(".NET"));
                foreach (var tag in tags)
                {
                    System.Console.WriteLine(tag.Name);
                }
            }
        }
    }
}
