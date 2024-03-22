using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class LibrosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}