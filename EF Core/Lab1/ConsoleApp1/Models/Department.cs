using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Department
{
    public string? Dname { get; set; }

    public int Dnum { get; set; }

    public int? Mgrssn { get; set; }

    public DateTime? MgrstartDate { get; set; }

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual Employee? MgrssnNavigation { get; set; }

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
