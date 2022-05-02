using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreWebUI.Controllers
{
    public class BlogController : Controller
    {
        BlogManager manager = new BlogManager(new BlogDal());
        //MakaleContext context = new MakaleContext();    

        public IActionResult Index()
        {
            //var blog = context.Blogs.Include(p => p.Category);
            var blog = manager.GetBlogWithCategory();
            return View(blog);
        }

        public IActionResult BlogDetails(int id)
        {
            var result = manager.GetBlogById(id);

            return View(result);
        }



    }
}
