using System;
using System.Collections.Generic;

namespace ConsoleApp1.Models;

public partial class WorksFor
{
    public int Essn { get; set; }

    public int Pno { get; set; }

    public int? Hours { get; set; }

    public virtual Employee EssnNavigation { get; set; } = null!;

    public virtual Project PnoNavigation { get; set; } = null!;
}
