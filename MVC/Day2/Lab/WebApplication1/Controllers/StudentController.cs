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
