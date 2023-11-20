using Microsoft.AspNetCore.Mvc;

namespace SitInMonitoring.Controllers
{
    public class LogINController1 : Controller
    {
        public IActionResult LoginForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(Users user)
        {

        }
    }
}
