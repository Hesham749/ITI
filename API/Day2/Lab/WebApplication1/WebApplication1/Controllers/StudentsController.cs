using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs.Students;
using WebApplication1.Extension;
using WebApplication1.Models;
using WebApplication1.UnitOfWorks;

namespace WebApplication1.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IMapper _map;

        public UnitOfWork Unit { get; }

        public StudentsController(UnitOfWork unit, IMapper _map)
        {
            Unit = unit;
            this._map = _map;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(void), 404)]
        public ActionResult<ReadStudentDTO> GetById(int id)
        {
            var std = Unit.Students.GetById(id);
            if (std is null)
                return NotFound();
            var studentDTO = _map.Map<ReadStudentDTO>(std);
            return Ok(studentDTO);
        }

        [HttpGet]
        [EndpointDescription("Get all Students in specific page with page size  exURL : /api/Students/{page}/{pageSize}")]
        [EndpointSummary("Get list of students")]
        public IActionResult GetAll([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
        {
            var stds = Unit.Students.GetAll();
            if (stds.Count == 0) return NotFound();
            var studentsDTO = stds.Pagination<Student, ReadStudentDTO>(_map, page, pageSize)
                                  .ToList();
            if (studentsDTO.Count == 0) return NotFound();
            return Ok(studentsDTO);
        }
    }
}
