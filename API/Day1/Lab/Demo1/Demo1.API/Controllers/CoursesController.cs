using Demo1.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Demo1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly Lab1ApiContext context;

        public CoursesController(Lab1ApiContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult get()
        {
            List<Course> courses = context.Courses.ToList();
            if (courses.Count == 0)
                return NotFound();
            return Ok(courses);
        }
        [HttpDelete("{id}")]
        public IActionResult deleteCourse(int id)
        {
            var crs = context.Courses.Find(id);
            if (crs is null)
                return NotFound();
            context.Remove(crs);
            context.SaveChanges();
            List<Course> courses = context.Courses.ToList();
            return Ok(courses);
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Course course)
        {
            if (course is null) return BadRequest();
            if (id != course.id)
                return BadRequest();
            var crs = context.Courses.AsNoTracking().FirstOrDefault(c => c.id == id);
            if (crs is null)
                return NotFound();
            if (ModelState.IsValid)
            {
                context.Update(course);
                context.SaveChanges();
                return NoContent();
            }
            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult post(Course course)
        {
            if (course is null)
                return BadRequest();
            if (ModelState.IsValid)
            {
                context.Add(course);
                context.SaveChanges();
                return CreatedAtAction(nameof(getById), new { course.id }, course);
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var crs = context.Courses.Find(id);
            if (crs is null)
                return NotFound();
            return Ok(crs);
        }
        [HttpGet("/api/sts/{name}")]
        public IActionResult courseByName(string name)
        {
            if (name is null)
                return BadRequest();
            var crs = context.Courses.FirstOrDefault(c => c.crs_name == name);
            if (crs is null)
                return NotFound();
            return Ok(crs);
        }

    }
}
