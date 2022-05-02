using Microsoft.AspNetCore.Mvc;

namespace CoreWebUI.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
