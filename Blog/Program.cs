﻿using Blog.data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            // var user = new User
            // {
            //     Name = "André Baltieri",
            //     Slug = "andrebaltieri",
            //     Email = "andre@balta.io",
            //     Bio = "9x Microsoft MVP",
            //     Image = "https://balta.io",
            //     PasswordHash = "123098457",
            // };
            // var category = new Category { Name = "Backend", Slug = "Backend" };

            // var post = new Post
            // {
            //     Author = user,
            //     category = category,
            //     Body = "<p>Hello world</p>",
            //     Slug = "comecando-com-ef-core",
            //     Summary = "Neste artigo vamos aprender EF core",
            //     Title = "Começando com EF Core",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            var posts = context
                .Posts.AsNoTracking()
                .Include(x => x.Author)
                .OrderBy(x => x.LastUpdateDate)
                .ToList();
            foreach (var post in posts)
                System.Console.WriteLine($"{post.Title} foi escrito por {post.Author?.Name}");
        }
    }
}
