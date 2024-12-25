using Microsoft.AspNetCore.Mvc;
using MySensive.BusinessLayer.Abstract;
using MySensive.BusinessLayer.Concrete;
using MySensive.DataAccessLayer.EntityFramework;

namespace MySensive.PresentationLayer.ViewComponents.FrontLayout
{
    public class _FrontBlogComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _FrontBlogComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _articleService.TGetAll();
            return View(value);
        }
    }
}
