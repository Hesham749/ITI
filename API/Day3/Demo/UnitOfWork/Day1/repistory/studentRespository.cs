using Day1.Models;

namespace Day1.repistory
{
    public class studentRespository:GenericReps<Student>
    {
     
        public studentRespository(ITIContext db):base(db) 
        {
            
        }
       

        public Student getbyname( string name)
        {
            return db.Students.FirstOrDefault(n => n.name == name);
        }

    }
}
