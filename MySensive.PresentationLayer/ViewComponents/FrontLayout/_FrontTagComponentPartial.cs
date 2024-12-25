using Microsoft.AspNetCore.Mvc;

namespace MySensive.PresentationLayer.ViewComponents.FrontLayout
{
    public class _FrontTagComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
