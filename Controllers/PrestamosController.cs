using Microsoft.AspNetCore.Mvc;

namespace Mvc.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}