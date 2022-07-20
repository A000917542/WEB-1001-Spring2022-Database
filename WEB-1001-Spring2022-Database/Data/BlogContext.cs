using Microsoft.EntityFrameworkCore;
using WEB_1001_Spring2022_Database.Models;

namespace WEB_1001_Spring2022_Database.Data
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions<BlogContext> options)
            : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}
