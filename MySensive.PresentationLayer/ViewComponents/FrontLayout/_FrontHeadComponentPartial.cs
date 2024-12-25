using Microsoft.AspNetCore.Mvc;

namespace MySensive.PresentationLayer.ViewComponents.FrontLayout
{
    public class _FrontHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
