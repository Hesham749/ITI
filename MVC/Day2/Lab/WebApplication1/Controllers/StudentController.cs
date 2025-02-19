// Ignore Spelling: Json

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        ITIZagContext context = new();
        public IActionResult Index()
        {
            var model = context.Students.Include(s => s.Department).ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Departments = context.Departments.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student st)
        {
            context.Add(st);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


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
        public IActionResult Update(Student std)
        {
            if (std.Password is null)
            {
                ModelState.Remove("Password");
                ModelState.Remove("CPassword");
            }
            if (ModelState.IsValid)
            {
                UpdateStudentData(std);
                return RedirectToAction("Index");
            }
            return Update(std.Id);
        }

        public void UpdateStudentData(Student std)
        {
            var CurrentStd = context.Students.FirstOrDefault(s => s.Id == std.Id);
            CurrentStd.Name = std.Name ?? CurrentStd.Name;
            CurrentStd.Password = std.Password ?? CurrentStd.Password;
            CurrentStd.Mail = std.Mail ?? CurrentStd.Mail;
            context.Students.Update(CurrentStd);
            context.SaveChanges();
        }

       
        public IActionResult MailValidation(string mail, int id)
        {
            return IsUniqueMail(mail, id) ? Json(true) : Json(false);
        }



        public bool IsUniqueMail(string mail, int id)
        {
            var Isunique = context.Students.Any(s => s.Mail == mail && s.Id != id);
            return !Isunique;
        }

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
