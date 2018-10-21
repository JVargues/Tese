using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class BlogController : Controller
    {
        private static List<BlogModel> blogs = new List<BlogModel>()
        {
            new BlogModel() { Title = "Title 1", Text = "Yada Yada" },
            new BlogModel() { Title = "Title 2", Text = "asgdsg" },
            new BlogModel() { Title = "Title 3", Text = "dfgsywy sdf" },
            new BlogModel() { Title = "Title 4", Text = "sfgwyfg" },
        };

        [HttpGet]
        public IActionResult Blogs()
        {
            ViewData["Blogs"] = blogs;
            
            return View();
        }

        [HttpGet]
        public IActionResult CreateBlog()
        {
            var blog = new BlogModel();
            ViewData["Blog"] = blog;

            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string text)
        {
            var blog = new BlogModel();
            blog.Title = title;
            blog.Text = text;

            blogs.Add(blog);


            return RedirectToAction("Blogs");
        }
    }
}
