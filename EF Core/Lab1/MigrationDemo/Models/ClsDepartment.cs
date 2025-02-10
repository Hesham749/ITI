namespace MigrationDemo.Models
{
    public partial class ClsDepartment
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public virtual HashSet<ClsStudent> Students { get; set; }
    }
}
