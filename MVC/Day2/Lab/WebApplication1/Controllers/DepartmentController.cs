using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.Services;

namespace WebApplication1.Controllers
{

    public class DepartmentController : Controller
    {

        readonly ITIZagContext _context;
        readonly IDepartmentService _department;

        public DepartmentController(IDepartmentService department)
        {
            _department = department;
        }
        [Authorize(Roles = "Admin,Instructor")]
        public IActionResult Index()
        {
            var model = _department.GetAll();
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Create(Department dp)
        {

            if (ModelState.IsValid)
            {
                _department.Add(dp);
                return RedirectToAction("Index");

            }
            return View(dp);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult Update(int id)
        {
            id = 100;
            HttpContext.Session.SetInt32("id", id);
            var model = _department.GetById(id);
            return View(model);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult SaveUpdate([FromRoute] int id, Department dp)
        {
            dp.Id = id;
            if (ModelState.IsValid)
            {
                return (_department.Update(dp)) ? RedirectToAction("Index") : View("Update", dp);

            }
            return View("Update", dp);
        }


        [Authorize(Roles = "Admin")]
        public IActionResult Delete(int id)
        {
            _department.RemoveById(id);
            return RedirectToAction("index");

        }

        public IActionResult IsUniqueId(int id)
            => (_department.IsUniqueID(id)) ? Json(true) : Json("Invalid ID");

        public IActionResult IsUniqueName(string Name)
        {
            var id = HttpContext.Session.GetInt32("id") ?? 0;
            return (_department.IsUniqueName(Name, id)) ? Json(true) : Json("Try Another Name");
        }

    }
}
