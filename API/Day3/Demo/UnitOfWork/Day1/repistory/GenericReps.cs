using Day1.Models;
namespace Day1.repistory
{
    public class GenericReps<TEntity> where TEntity :class 
    {
       public ITIContext db;
        public GenericReps(ITIContext db)
        {
            this.db = db;
        }
        public List<TEntity> getall()
        {
            return db.Set<TEntity>().ToList();
        }

        public TEntity getbyid(int id)
        {
            return db.Set<TEntity>().Find(id);
        }


        public void add(TEntity entity)
        {
            db.Set<TEntity>().Add(entity);
        }

        public void edit(TEntity entity)
        {
            db.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void delete(int id) {

           // TEntity t = db.Set<TEntity>().Find(id);
            TEntity t = getbyid(id);
             db.Set<TEntity>().Remove(t);
        }

        
       
    }
}
