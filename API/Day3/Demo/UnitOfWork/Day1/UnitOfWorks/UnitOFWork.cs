using Day1.Models;
using Day1.repistory;

namespace Day1.UnitOfWorks
{
    public class UnitOFWork
    {
        ITIContext db;
         GenericReps<Department> deptReps;
         GenericReps<Student> studReps;
        
        public UnitOFWork(ITIContext db)
        {
            this.db = db;

           // DeptReps = new GenericReps<Department>(db);
            //StudReps = new GenericReps<Student>(db);
        }
        public GenericReps<Student> StudReps { 
            get { 
             if(studReps == null) 
                    studReps = new GenericReps<Student>(db);
             return studReps;
            } 
        }

        public GenericReps<Department> DeptReps
        {
            get
            {
                if(deptReps == null)
                    deptReps = new GenericReps<Department>(db);
                return deptReps;
            }
        }
        public void save()
        {
            db.SaveChanges();
        }
    }
}
