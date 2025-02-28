using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs.Departments;
using WebApplication1.UnitOfWorks;

namespace WebApplication1.Controllers
{
    [Consumes("application/json")]
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMapper _map;

        public DepartmentsController(UnitOfWork Unit, IMapper _map)
        {
            this.Unit = Unit;
            this._map = _map;
        }

        public UnitOfWork Unit { get; }

        [HttpGet("{id}")]
        [EndpointSummary("get department with student count")]
        [EndpointDescription("Get Department using id exURL : api/Department/{id}")]
        //[ProducesResponseType(typeof(ReadDepartmentDTO),200)]
        [ProducesResponseType<ReadDepartmentDTO>(200)]
        [ProducesResponseType(typeof(void), 404)]

        public IActionResult GetById(int id)
        {
            var dept = Unit.Departments.GetById(id);
            if (dept is null)
                return NotFound();
            var deptDTO = _map.Map<ReadDepartmentDTO>(dept);
            return Ok(deptDTO);
        }
    }
}
