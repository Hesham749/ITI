namespace Day1.DTOs.DepartmentDTO
{
    public class ReadDepartmentDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public List<string> studentNames { get; set; } = new List<string>();
    }
}
