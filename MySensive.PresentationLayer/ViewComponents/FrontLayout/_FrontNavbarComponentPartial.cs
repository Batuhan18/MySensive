using Microsoft.AspNetCore.Mvc;

namespace MySensive.PresentationLayer.ViewComponents.FrontLayout
{
    public class _FrontNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
