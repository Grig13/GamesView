using Microsoft.AspNetCore.Mvc;

namespace GamesView.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
