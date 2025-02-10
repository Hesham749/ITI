namespace MigrationDemo.Models
{
    public partial class ClsStudent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte? Age { get; set; }
        public int DeptId { get; set; }
        public virtual ClsDepartment Department { get; set; }
    }
}
