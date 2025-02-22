// Ignore Spelling: Json

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Filters;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        readonly IStudentService _students;
        readonly IDepartmentService _departments;

        public StudentController(IStudentService students, IDepartmentService departments)
        {
            _students = students;
            _departments = departments;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _students.GetAll();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departments.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)
            {
                _students.Add(st);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _departments.GetAll();
            return View(st);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var std = _students.GetById(id);
            if (std is null)
                return BadRequest();
            ViewBag.Departments = _departments.GetAll();
            return View(std);
        }


        [HttpPost]
        public IActionResult Update([FromRoute] int id, Student std)
        {
            ModelState.Remove("Password");
            ModelState.Remove("CPassword");
            if (id != std.Id)
            {
                std.Id = id;
                ModelState.AddModelError("Mail", "Mail is invalid");
            }
            else if (ModelState.IsValid)
            {
                _students.Update(std);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _departments.GetAll();
            return View(std);
        }


        public void UpdateStudentData(Student std)
        {
            Student stdFromDB = _students.GetById(std.Id);
            std.Password = stdFromDB.Password;
            _students.Update(std);
        }


        [HttpGet]
        public IActionResult MailValidation(string mail, int id)
            => _students.IsUniqueMail(mail, id) ? Json(true) : Json("Try another mail");


        [HttpPost]
        public IActionResult Delete(int id)
        {
            if (_students.RemoveById(id))
                return RedirectToAction("Index");
            return BadRequest();
        }

        [MyExceptionFilter]
        public IActionResult Download()
        {
            return File("Branches.txt", "text/plain", "Branches.txt");
        }

        public IActionResult Json()
        {
            return Json(new Student { Id = 1, Name = "karem", DeptID = 100 });
        }
    }
}
