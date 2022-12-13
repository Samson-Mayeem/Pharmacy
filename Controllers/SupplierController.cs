using Microsoft.AspNetCore.Mvc;

namespace samPharma.Controllers
{
    public class SupplierController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
