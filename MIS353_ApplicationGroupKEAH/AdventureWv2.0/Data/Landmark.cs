using System;
using System.Collections.Generic;

namespace AdventureWv2._0.Data;

public partial class Landmark
{
    public int Lid { get; set; }

    public string Lname { get; set; } = null!;

    public string Ltype { get; set; } = null!;
}
