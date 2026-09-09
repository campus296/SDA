using Microsoft.AspNetCore.Mvc;

namespace Tp2.Controllers
{
    public class MonsterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
