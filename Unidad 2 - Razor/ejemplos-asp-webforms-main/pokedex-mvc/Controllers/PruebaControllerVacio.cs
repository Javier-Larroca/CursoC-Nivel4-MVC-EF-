using Microsoft.AspNetCore.Mvc;

namespace pokedex_mvc.Controllers
{
    public class PruebaControllerVacio : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
