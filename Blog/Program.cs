using Blog.data;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("");
            var ctx = new DataContext();
            ctx.Categories;
        }
    }
}
