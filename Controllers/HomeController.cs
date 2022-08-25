using Microsoft.AspNetCore.Mvc;

namespace UdemyAspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Yusuf()
        {
            return View();
        }
    }
}
