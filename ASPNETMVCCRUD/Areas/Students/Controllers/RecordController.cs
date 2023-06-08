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
        public async Task<IActionResult> Index()
        {
            IndexRecordViewModel indexRecordViewModel = new IndexRecordViewModel()
            {
                Students = await _studentRepository.GetAll()
            };
          
            return View(indexRecordViewModel);
        }

        public IActionResult Create()
        {
            return View();

        }

        public async Task<IActionResult> ViewRecord(Guid id)
        {
            Student? student = await _studentRepository.GetByGuidAsync(id);
            return View(student);
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
