using Day1.Models;
using Day1.repistory;
using Day1.UnitOfWorks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class studentDepartmentController : ControllerBase
    {
        //public studentDepartmentController(GenericReps<Department> deptReps ,GenericReps<Student> studReps)
        //{
        //    DeptReps = deptReps;
        //    StudReps = studReps;
        //}

        //public GenericReps<Department> DeptReps { get; }
        //public GenericReps<Student> StudReps { get; }

        UnitOFWork unit;
        public studentDepartmentController(UnitOFWork unit)
        {
            this.unit = unit;
        }

        [HttpPost]
        public ActionResult add(Student s)
        {
            unit.DeptReps.add(s.dept);
           
            unit.StudReps.add(s);
            unit.save();

            return Ok();

        }


    }
}
