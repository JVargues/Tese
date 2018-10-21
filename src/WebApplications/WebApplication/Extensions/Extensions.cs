using Domain.Models;
using System.Collections.Generic;
using System.Linq;
using WebApplication.Models;

namespace WebApplication.Extensions
{
    public static class BlogExtensions
    {
        public static Blog ToBlog(this BlogModel model)
        {
            return new Blog
            {
                Id = model.Id,
                Title = model.Title,
                Text = model.Text
            };
        }

        public static IEnumerable<BlogModel> ToBlog(this IEnumerable<Blog> models)
        {
            foreach (var model in models)
            {
                yield return new BlogModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Text = model.Text
                };
            }
        }
    }
}
