﻿using System;
using System.Collections.Generic;

namespace MIS353_ApplicationGroupKEAH.Data;

public partial class Activity
{
    public int Aid { get; set; }

    public string Aname { get; set; } = null!;

    public int Lid { get; set; }

    public virtual Landmark LidNavigation { get; set; } = null!;

    public virtual ICollection<Travelplan> Travelplans { get; set; } = new List<Travelplan>();
}
