using Microsoft.AspNetCore.Mvc;

namespace samPharma.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
