using AutoMapper;
using Day1.DTOs.DepartmentDTO;
using Day1.Models;
using Day1.repistory;
using Day1.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public DepartmentController(UnitOFWork unit,IMapper _map)
        {
            this.Unit=unit;
            Map = _map;
        }

        public UnitOFWork Unit { get; }

        public IMapper Map { get; }

        [HttpGet]
        public ActionResult getall()
        {
            return Ok(Map.Map<List<ReadDepartmentDTO>>(Unit.DeptReps.getall()));
        }
        [HttpGet("{id}")]
        public ActionResult getbyid(int id)
        {
            
            return Ok(Map.Map<ReadDepartmentDTO>(Unit.DeptReps.getbyid(id)));
        }
    }
}
