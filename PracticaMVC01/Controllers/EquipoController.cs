using Microsoft.AspNetCore.Mvc;

namespace PracticaMVC01.Controllers
{
    public class EquipoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
