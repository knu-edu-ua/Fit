using Microsoft.AspNetCore.Mvc;

namespace Fit.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index(string name)
        {
            return View();
        }
    }
}
