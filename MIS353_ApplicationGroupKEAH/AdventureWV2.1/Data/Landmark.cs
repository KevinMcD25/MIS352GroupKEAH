﻿using System;
using System.Collections.Generic;

namespace AdventureWV2._1.Data;

public partial class Landmark
{
    public int Lid { get; set; }

    public string Lname { get; set; } = null!;

    public string Ltype { get; set; } = null!;

    // public virtual ICollection<Activity> Activities { get; set; } = new List<Activity>();

   // public virtual ICollection<Hospitality> Hospitalities { get; set; } = new List<Hospitality>();
}
