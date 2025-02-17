using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Show()
        {
            return View();
        }

        public IActionResult ShowAdd()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public string AddStudent(Student st)
        {
            return st.ToString();
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
        public string Display()
        {
            return "Welcome";
        }
    }
}
