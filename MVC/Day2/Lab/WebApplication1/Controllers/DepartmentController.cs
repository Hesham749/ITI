using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {
        ITIZagContext context = new();
        public IActionResult Index()
        {
            var model = context.Departments.ToList();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department dp)
        {
            context.Add(dp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
