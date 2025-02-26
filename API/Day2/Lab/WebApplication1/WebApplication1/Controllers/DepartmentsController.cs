using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOs.Departments;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly ITIContext db;
        private readonly IMapper _map;

        public DepartmentsController(ITIContext db, IMapper _map)
        {
            this.db = db;
            this._map = _map;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var dept = db.Departments.Find(id);
            if (dept is null)
                return NotFound();
            var deptDTO = _map.Map<ReadDepartmentDTO>(dept);
            return Ok(deptDTO);
        }
    }
}
