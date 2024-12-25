using Microsoft.AspNetCore.Mvc;

namespace MySensive.PresentationLayer.ViewComponents.FrontLayout
{
    public class _FrontFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
