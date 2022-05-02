using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreWebUI.Controllers
{
    public class CommentController : Controller
    {
        CommentManager manager = new CommentManager(new CommentDal());
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListByBlog(int id)
        {
            var result = manager.GetList(id);
            return PartialView(result);
        }
    }
}
