using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class DepartmentController : Controller
    {

        readonly ITIZagContext _context;
        readonly IService<Department> _department;

        public DepartmentController(IService<Department> department)
        {
            _department = department;
        }

        public IActionResult Index()
        {
            var model = _department.GetAll();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Department dp)
        {
            _department.Add(dp);
            return RedirectToAction("Index");
        }
    }
}
