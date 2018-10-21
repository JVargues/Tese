using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Domain
{
    public class BlogContext : DbContext
    {
        public BlogContext(DbContextOptions options) 
            : base(options)
        {
            
        }

        public DbSet<Blog> Blog { get; set; }
    }
}
