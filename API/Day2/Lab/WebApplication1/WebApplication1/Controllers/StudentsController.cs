using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs.Students;
using WebApplication1.Extension;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ITIContext db;
        private readonly IMapper _map;

        public StudentsController(ITIContext db, IMapper _map)
        {
            this.db = db;
            this._map = _map;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var std = db.Students.Find(id);
            if (std is null)
                return NotFound();
            var studentDTO = _map.Map<ReadStudentDTO>(std);
            return Ok(studentDTO);
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var stds = db.Students.ToList();
            //var size = stds.Count();
            //pageSize = (pageSize < 1) ? 10 : pageSize;
            //page = (page < 0) ? 1 : page;
            //int maxPages = (int)Math.Ceiling((double)size / pageSize);
            //page = (page <= maxPages) ? page : maxPages;
            //var students = stds.Chunk(pageSize).ToList()[page - 1];
            //var studentsDTO = _map.Map<List<ReadStudentDTO>>(students);
            var studentsDTO = stds.Pagination<Student, ReadStudentDTO>(_map).ToList();
            return Ok(studentsDTO);
        }
    }
}
