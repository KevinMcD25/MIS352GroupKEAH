﻿using System;
using System.Collections.Generic;

namespace MIS353_ApplicationGroupKEAH;

public partial class Userdatum
{
    public int Uid { get; set; }

    public string Ufname { get; set; } = null!;

    public string Ulname { get; set; } = null!;

    public string Uemail { get; set; } = null!;

    public string Uphone { get; set; } = null!;

    public virtual ICollection<UserTravel> UserTravels { get; set; } = new List<UserTravel>();
}
