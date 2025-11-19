using Microsoft.EntityFrameworkCore;
using WebApplication13.Models.Domain;

namespace WebApplication13.Data
{
    public class BloggyDbcontext : DbContext
    {
        public BloggyDbcontext(DbContextOptions options) : base(options)
        {
        }

        protected BloggyDbcontext()
        {
        }

        public DbSet<BlogPost> BlogPosts  { get; set; }

        public DbSet<Tagcs> Tagcs { get; set; }
    }
}
