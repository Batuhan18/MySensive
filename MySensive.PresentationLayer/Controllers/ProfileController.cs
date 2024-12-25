using Microsoft.AspNetCore.Mvc;
using MySensive.BusinessLayer.Abstract;
using MySensive.PresentationLayer.Models;

namespace MySensive.PresentationLayer.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserService _userService;

        public ProfileController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            UserEditViewModel model = new UserEditViewModel();
          
            return View();
        }
    }
}
