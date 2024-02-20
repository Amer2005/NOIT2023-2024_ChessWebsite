using Microsoft.AspNetCore.Mvc;

namespace ChessWebsite.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Chess()
        {
            return View();
        }
    }
}
