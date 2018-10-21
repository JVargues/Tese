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
            new BlogModel() { Title = "Mauris elementum", Text = "Maecenas ipsum velit, consectetuer eu lobortis ut, dictum at dui. Aliquam id dolor. Nulla pulvinar eleifend sem. Etiam sapien elit, consequat eget, tristique non, venenatis quis, ante. Donec vitae arcu. Integer tempor. Vivamus luctus egestas leo. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor. Nullam justo enim, consectetuer nec, ullamcorper ac, vestibulum in, elit." },
            new BlogModel() { Title = "Sed convallis", Text = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec vitae arcu. Aliquam ante. Nunc tincidunt ante vitae massa. Aliquam in lorem sit amet leo accumsan lacinia. Duis bibendum, lectus ut viverra rhoncus, dolor nunc faucibus libero, eget facilisis enim ipsum id lacus. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Vestibulum fermentum tortor id mi. Aliquam in lorem sit amet leo accumsan lacinia. Aliquam ornare wisi eu metus. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu. Suspendisse nisl. Aenean id metus id velit ullamcorper pulvinar. Duis sapien nunc, commodo et, interdum suscipit, sollicitudin et, dolor. Phasellus rhoncus. Nullam feugiat, turpis at pulvinar vulputate, erat libero tristique tellus, nec bibendum odio risus sit amet ante. Proin mattis lacinia justo. Maecenas ipsum velit, consectetuer eu lobortis ut, dictum at dui. Duis risus. Mauris dolor felis, sagittis at, luctus sed, aliquam non, tellus." },
            new BlogModel() { Title = "Curabitur ligula sapien", Text = "Donec iaculis gravida nulla. Nunc dapibus tortor vel mi dapibus sollicitudin. Duis bibendum, lectus ut viverra rhoncus, dolor nunc faucibus libero, eget facilisis enim ipsum id lacus. Nulla pulvinar eleifend sem. Aenean vel massa quis mauris vehicula lacinia. Maecenas fermentum, sem in pharetra pellentesque, velit turpis volutpat ante, in pharetra metus odio a lectus. Etiam dictum tincidunt diam. Etiam ligula pede, sagittis quis, interdum ultricies, scelerisque eu. Integer lacinia. Ut tempus purus at lorem. Maecenas ipsum velit, consectetuer eu lobortis ut, dictum at dui. Nunc dapibus tortor vel mi dapibus sollicitudin. In dapibus augue non sapien." },
            new BlogModel() { Title = "Mauris suscipit", Text = "Etiam posuere lacus quis dolor. In dapibus augue non sapien. Mauris dictum facilisis augue. Fusce wisi. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Vivamus porttitor turpis ac leo. Pellentesque pretium lectus id turpis. Fusce tellus. Aliquam erat volutpat. Mauris metus. Proin pede metus, vulputate nec, fermentum fringilla, vehicula vitae, justo. Mauris dictum facilisis augue. Aliquam ornare wisi eu metus. Phasellus rhoncus. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Quisque porta. Nulla accumsan, elit sit amet varius semper, nulla mauris mollis quam, tempor suscipit diam nulla vel leo. Aliquam ante. Cras elementum. Fusce tellus odio, dapibus id fermentum quis, suscipit id erat." },
        };

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Blogs"] = blogs;
            
            return View();
        }

        [HttpGet]
        public IActionResult Create()
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
