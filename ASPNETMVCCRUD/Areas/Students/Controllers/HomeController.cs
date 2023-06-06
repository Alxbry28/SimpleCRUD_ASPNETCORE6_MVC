using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCCRUD.Areas.Students.Controllers
{
    [Area("Students")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
            //return Content("Students Area");
        }
    }
}
