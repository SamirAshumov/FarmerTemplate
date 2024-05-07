using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class DetailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
