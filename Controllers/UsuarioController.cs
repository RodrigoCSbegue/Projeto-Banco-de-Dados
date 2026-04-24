using Microsoft.AspNetCore.Mvc;

namespace Segundo_App_BancoDados.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
