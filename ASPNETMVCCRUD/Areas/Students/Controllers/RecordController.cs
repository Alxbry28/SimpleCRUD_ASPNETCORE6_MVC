using ASPNETMVCCRUD.Areas.Students.Models;
using ASPNETMVCCRUD.Areas.Students.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCCRUD.Areas.Students.Controllers
{
    [Area("Students")]
    public class RecordController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public RecordController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
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

            Student newStudent = new Student()
            {
                Id = Guid.NewGuid(),
                LRN = newRecord.LRN,
                FirstName = newRecord.FirstName,
                MiddleName = newRecord.MiddleName,
                LastName = newRecord.LastName,
                Grade = newRecord.Grade,
                Section = newRecord.Section,
                Address = newRecord.Address,
                Birthday = newRecord.Birthday,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
            };

            if(_studentRepository.Create(newStudent)) return RedirectToAction("Index");
            return Content("Failed");

        }
    }
}
