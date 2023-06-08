using ASPNETMVCCRUD.Areas.Students.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCCRUD.Areas.Students.Controllers
{
    [Area("Students")]
    public class RecordController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddRecord(CreateRecordViewModel newRecord)
        {
            if (!ModelState.IsValid) return Content("Invalid");



            return Content("Test");

        }
    }
}
