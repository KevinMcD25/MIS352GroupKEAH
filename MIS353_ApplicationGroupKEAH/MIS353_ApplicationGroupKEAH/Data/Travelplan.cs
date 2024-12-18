﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIS353_ApplicationGroupKEAH.Data;

public partial class Travelplan
{
    [Key]
    public int Pid { get; set; }

    public int Hid { get; set; }

    public int Aid { get; set; }

    public virtual Activity AidNavigation { get; set; } 

    public virtual Hospitality HidNavigation { get; set; } 

    public virtual ICollection<UserTravel> UserTravels { get; set; } = new List<UserTravel>();
}
