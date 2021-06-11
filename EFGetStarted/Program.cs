using System;
using System.Linq;

namespace EFGetStarted
{
    internal class Program
    {
        private static void Main()
        {
            using (var db = new BloggingContext()) {

                Console.WriteLine("Insert a new Blog");
                db.Add(new Blog { Url = "http://blogs.msdn.com/adotnet" });
                db.SaveChanges();

                Console.WriteLine("Querying for a blog");
                var blog = db.Blogs
                    .OrderBy(b => b.BlogId)
                    .First();

                Console.WriteLine("updating a blog and adding a post");
                blog.Url = "https://devblogs.microsoft.com/dotnet";
                blog.Posts.Add(
                    new Post { Title = "Hello World", Content = "I wrote an app using EF Core!" });
                db.SaveChanges();

                Console.WriteLine("Delete the blog");
                db.Remove(blog);
                db.SaveChanges();

            }
        }
    }
}
