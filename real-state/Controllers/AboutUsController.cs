using Microsoft.AspNetCore.Mvc;

namespace real_state.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
