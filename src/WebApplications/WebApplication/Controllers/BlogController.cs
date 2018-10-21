using Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Extensions;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class BlogController : Controller
    {
        private IBlogRepository BlogRepository { get; }

        public BlogController(IBlogRepository blogRepository)
        {
            BlogRepository = blogRepository;
        }
        
        [HttpGet]
        public IActionResult Index()
        {
            return View(BlogRepository.GetAll().ToBlog().ToList());
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(new BlogModel());
        }

        [HttpPost]
        public IActionResult Create(string title, string text)
        {
            var blog = new BlogModel();
            blog.Title = title;
            blog.Text = text;

            BlogRepository.Save(blog.ToBlog());


            return RedirectToAction("Index");
        }
    }
}
