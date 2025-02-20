// Ignore Spelling: Json

using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        readonly IService<Student> _students;
        readonly IService<Department> _departments;

        public StudentController(IService<Student> students, IService<Department> departments)
        {
            _students = students;
            _departments = departments;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var model = _students.GetAll(s => true);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = _departments.GetAll(d => d.Status == true).ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid)  //&& IsUniqueMail(st.Mail, st.Id)
            {
                _students.Add(st);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _departments.GetAll(d => d.Status == true).ToList();
            return View(st);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var std = _students.GetById(id);
            if (std is null)
                return BadRequest();
            ViewBag.Departments = _departments.GetAll(d => d.Status == true);
            return View(std);
        }


        [HttpPost]
        public IActionResult Update([FromRoute] int id, Student std)
        {
            std.Id = id;
            ModelState.Remove("Password");
            ModelState.Remove("CPassword");
            if (ModelState.IsValid) //&& IsUniqueMail(std.Mail, std.Id)
            {
                _students.Update(std);
                return RedirectToAction("Index");
            }
            ViewBag.Departments = _departments.GetAll(d => d.Status == true);
            return View(std);
        }


        public void UpdateStudentData(Student std)
        {
            Student stdFromDB = _students.GetById(std.Id);
            std.Password = stdFromDB.Password;
            _students.Update(std);
        }


        //[HttpGet]
        //public IActionResult MailValidation(string mail, int id)
        //    => IsUniqueMail(mail, id) ? Json(true) : Json(false);




        //public bool IsUniqueMail(string mail, int id)
        //{
        //    var Isunique = context.Students.Any(s => s.Mail == mail && s.Id != id);
        //    return !Isunique;
        //}

        //[HttpGet]
        //public IActionResult Delete(int id)
        //{
        //    var std = context.Students.FirstOrDefault(s => s.Id == id);
        //    if (std is not null)
        //        return View(std);
        //    return BadRequest();
        //}



        //[HttpPost]
        //[ActionName("Delete")]
        //public IActionResult ConfirmDelete(int id)
        //{
        //    var std = context.Students.FirstOrDefault(s => s.Id == id);
        //    if (std is not null)
        //    {
        //        context.Students.Remove(std);
        //        context.SaveChanges();
        //    }
        //    return RedirectToAction("Index");
        //}


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
