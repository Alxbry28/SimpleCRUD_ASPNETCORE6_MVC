using ASPNETMVCCRUD.Data;
using ASPNETMVCCRUD.Models;
using ASPNETMVCCRUD.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNETMVCCRUD.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly MVCDemoDbContext mVCDemoDbContext;

        public EmployeesController(MVCDemoDbContext mVCDemoDbContext)
        {
            this.mVCDemoDbContext = mVCDemoDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()

        {
            List<Employee> employees = await mVCDemoDbContext.Employees.ToListAsync();
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel addEmployeeRequest)
        {
            Employee employee = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = addEmployeeRequest.Name,
                Email = addEmployeeRequest.Email,
                Salary = addEmployeeRequest.Salary,
                Birthday = addEmployeeRequest.Birthday,
                Department = addEmployeeRequest.Department
            };
            await mVCDemoDbContext.Employees.AddAsync(employee);
            await mVCDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> View(Guid id)
        {
            Employee? employee = await mVCDemoDbContext.Employees.FirstOrDefaultAsync(emp => emp.Id.Equals(id));
            if (employee == null)
            {
                //return NotFound();
                return RedirectToAction("Index");
            }

            UpdateEmployeeViewModel viewModel = new UpdateEmployeeViewModel()
            {
                Id = employee.Id,
                Name = employee.Name,
                Email = employee.Email,
                Salary = employee.Salary,
                Birthday = employee.Birthday,
                Department = employee.Department
            };

            return View(viewModel);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(UpdateEmployeeViewModel model)
        {
            Employee existEmployee = await mVCDemoDbContext.Employees.FindAsync(model.Id);
            if (existEmployee == null)
            {
                return Content("Not Found");
            }
            existEmployee.Name = model.Name;
            existEmployee.Email = model.Email;
            existEmployee.Salary = model.Salary;
            existEmployee.Birthday = model.Birthday;
            existEmployee.Department = model.Department;

            await mVCDemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
            //return Content($"Edit: {existEmployee.Name}");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateEmployeeViewModel model)
        {
            Employee existEmployee = await mVCDemoDbContext.Employees.FindAsync(model.Id);
            if (existEmployee != null)
            {
                mVCDemoDbContext.Employees.Remove(existEmployee);
                await mVCDemoDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return Content("Not Found");

            //return Content($"Edit: {existEmployee.Name}");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            Employee existEmployee = await mVCDemoDbContext.Employees.FindAsync(id);
            if (existEmployee != null)
            {
                mVCDemoDbContext.Employees.Remove(existEmployee);
                await mVCDemoDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return Content("Not Found");

            //return Content($"Edit: {existEmployee.Name}");
        }

    }
}
