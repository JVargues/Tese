using Domain;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class BlogRepository : IBlogRepository
    {
        private BlogContext BlogContext { get; }

        public BlogRepository(BlogContext blogContext)
        {
            BlogContext = blogContext;
        }

        public IEnumerable<Blog> GetAll()
        {
            return BlogContext.Blog;
        }

        public Blog GetById(long id)
        {
            return BlogContext.Blog.FirstOrDefault(o => o.Id == id);
        }

        public void Save(Blog blog)
        {
            BlogContext.Add(blog);
            BlogContext.SaveChanges();
        }

        public void Update(Blog blog)
        {
            BlogContext.Update(blog);
            BlogContext.SaveChanges();
        }
        public void Delete(Blog blog)
        {
            BlogContext.Remove(blog);
            BlogContext.SaveChanges();
        }
    }
}
