using Microsoft.AspNetCore.Mvc;

namespace Template.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
