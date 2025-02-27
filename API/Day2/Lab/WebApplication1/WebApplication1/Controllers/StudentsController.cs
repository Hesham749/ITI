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
            if (stds.Count == 0) return NotFound();
            var studentsDTO = stds.Pagination<Student, ReadStudentDTO>(_map, page, pageSize)
                                  .ToList();
            if (studentsDTO.Count == 0) return NotFound();
            return Ok(studentsDTO);
        }
    }
}
