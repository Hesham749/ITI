using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class Dependent
{
    public int Essn { get; set; }

    public string DependentName { get; set; } = null!;

    public string? Sex { get; set; }

    public DateTime? Bdate { get; set; }

    public virtual Employee EssnNavigation { get; set; } = null!;
}
