using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

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

    public class BlogContextDesignFactory : IDesignTimeDbContextFactory<BlogContext>
    {
        private IConfiguration Configuration { get; }

        public BlogContextDesignFactory()
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
        }

        public BlogContext CreateDbContext() => CreateDbContext(new string[] { });

        public BlogContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<BlogContext>();
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Blogs"),
                x =>
                {
                    x.MigrationsAssembly("Domain");
                });
            return new BlogContext(optionsBuilder.Options);
        }
    }
}
