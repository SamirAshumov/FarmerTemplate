using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class FeatureController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
