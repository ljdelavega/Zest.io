using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Zest.Models;

namespace Zest.Controllers
{
    public class BlogController : Controller
    {
        private Blog blog = new Blog();

        public IActionResult Blog()
        {
           
            return View(blog);
        }

        //get detailed view of the blogPost
        [HttpGet]
        public IActionResult BlogPost(int id)
        {
            var blogPost = from post in blog.blogposts
                           where post.id == id
                           select post;
            var b = blogPost.First<BlogPost>();
            return View((BlogPost)b);
        }
    }
}
