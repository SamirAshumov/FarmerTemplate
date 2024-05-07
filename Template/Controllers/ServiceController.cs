using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
