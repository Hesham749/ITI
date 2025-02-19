// Ignore Spelling: Json

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        readonly ITIZagContext context = new();
        [HttpGet]
        public IActionResult Index()
        {
            var model = context.Students.Include(s => s.Department).ToList();
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Departments = context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student st)
        {
            if (ModelState.IsValid && IsUniqueMail(st.Mail, st.Id))
            {
                context.Add(st);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Departments = context.Departments.ToList();
            return View(st);
        }


        [HttpGet]
        public IActionResult Update(int id)
        {
            var std = context.Students.Include(s => s.Department)
                .FirstOrDefault(s => s.Id == id);
            if (std is null)
                return BadRequest();
            ViewBag.Departments = context.Departments.ToList();
            return View(std);
        }


        [HttpPost]
        public IActionResult Update([FromRoute] int id, Student std)
        {
            std.Id = id;
            ModelState.Remove("Password");
            ModelState.Remove("CPassword");
            if (ModelState.IsValid && IsUniqueMail(std.Mail, std.Id))
            {
                UpdateStudentData(std);
                return RedirectToAction("Index");
            }
            return Update(id);
        }


        public void UpdateStudentData(Student std)
        {
            Student stdFromDB = context.Students.AsNoTrackingWithIdentityResolution().FirstOrDefault(s => s.Id == std.Id);
            std.Password = stdFromDB.Password;
            context.Students.Update(std);
            context.SaveChanges();
        }


        [HttpGet]
        public IActionResult MailValidation(string mail, int id)
            => IsUniqueMail(mail, id) ? Json(true) : Json(false);




        public bool IsUniqueMail(string mail, int id)
        {
            var Isunique = context.Students.Any(s => s.Mail == mail && s.Id != id);
            return !Isunique;
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var std = context.Students.FirstOrDefault(s => s.Id == id);
            if (std is not null)
                return View(std);
            return BadRequest();
        }



        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            var std = context.Students.FirstOrDefault(s => s.Id == id);
            if (std is not null)
            {
                context.Students.Remove(std);
                context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


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
