using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Employee
{
    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public int Ssn { get; set; }

    public DateTime? Bdate { get; set; }

    public string? Address { get; set; }

    public string? Sex { get; set; }

    public int? Salary { get; set; }

    public int? Superssn { get; set; }

    public int? Dno { get; set; }

    public virtual ICollection<Department> Departments { get; set; } = new List<Department>();

    public virtual ICollection<Dependent> Dependents { get; set; } = new List<Dependent>();

    public virtual Department? DnoNavigation { get; set; }

    public virtual ICollection<Employee> InverseSuperssnNavigation { get; set; } = new List<Employee>();

    public virtual Employee? SuperssnNavigation { get; set; }

    public virtual ICollection<WorksFor> WorksFors { get; set; } = new List<WorksFor>();
}
