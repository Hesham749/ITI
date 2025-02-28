using AutoMapper;
using Day1.DTOs.StudentDTO;
using Day1.Models;
using Day1.repistory;
using Day1.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class studentsController : ControllerBase
    {
        UnitOFWork unit;    
        IMapper _map;
        public studentsController(UnitOFWork unit, IMapper _map)
        {
            this.unit = unit;
            this._map = _map;
        }

        [HttpGet]
        [EndpointSummary("select all students")]
        [EndpointDescription("read all students from database  ex:/api/students")]
        
        public ActionResult Getall()
        {
            //List<Student> sts = _reps.getall();

          
            List<ReadStudentDTO> stsDTO = _map.Map<List<ReadStudentDTO>>(unit.StudReps.getall());
            return Ok(stsDTO);
        }
        
        [HttpGet("{id:int}")]
        // [Produces("application/json")]
       [Produces("text/xml")]
        //MIME types
        [ProducesResponseType(200,Type =typeof(ReadStudentDTO))]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
       [ProducesErrorResponseType(typeof(void))]
        public ActionResult getbyid(int id)
        {
           Student s= unit.StudReps.getbyid(id);
            if (s == null) return NotFound();
          
          ReadStudentDTO stDTO =  _map.Map<ReadStudentDTO>(s);
             return Ok(stDTO);
        }
      //  [HttpGet("/api/sts/{name}")]
        //[HttpGet("{name:alpha}")]

        //public ActionResult getbyname(string name)
        //{
        //    Student s =_reps.getbyname(name);
        //    if (s == null) return NotFound();
        //    ReadStudentDTO stDTO = new ReadStudentDTO()
        //    {
        //        id = s.ID,
        //        name = s.name,
        //        age = s.age,
        //        address = s.adddress,
        //        departmentName = s.dept.name
        //    };

        //    return Ok(stDTO);
        //}

        [HttpPost]
        [Consumes("application/json")]
        public ActionResult add(AddStudentDTO sdto)
        {
            if (sdto == null) return BadRequest();
            if(!ModelState.IsValid) return BadRequest(ModelState);
            Student s = new Student()
            {
                name = sdto.name,
                age = sdto.age,
                adddress = sdto.address,
                deptid = sdto.deptid
            };

            unit.StudReps.add(s);
          unit.save();


            // return Created("ay7aga", s);
            return CreatedAtAction("getbyid", new { id = s.ID },sdto);
        }
        [HttpPut("{id}")]
        public ActionResult update(int id ,Student s) { 
        
        if(s == null) return BadRequest();
        if(id!=s.ID) return BadRequest();

            if (ModelState.IsValid)
            {
                unit.StudReps.edit(s);
                unit.save();


                return NoContent();
            }
            else return BadRequest(ModelState);
        
        }


        [HttpDelete("{id}")]
        public ActionResult delete(int id)
        {
            Student s = unit.StudReps.getbyid(id);
            if (s == null) return NotFound();
            unit.StudReps.delete(id);
            unit.save();
            return Ok(s);
        }


        [HttpPost("{id}")]
        public ActionResult test([FromQuery]int id ,[FromBody] string name )
        {
            return Ok();
        }

    }
}
