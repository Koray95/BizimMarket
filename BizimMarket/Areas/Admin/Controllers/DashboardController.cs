using Microsoft.AspNetCore.Mvc;

namespace BizimMarket.Areas.Admin.Controllers
{
    [Area("Admin")] //admin areasının kontrolcüsü diye belirtiyoruz
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
