using Microsoft.AspNetCore.Mvc;

namespace samPharma.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
