using System;
using System.Collections.Generic;

namespace MIS353_ApplicationGroupKEAH;

public partial class Travelplan
{
    public int Pid { get; set; }

    public int Hid { get; set; }

    public int Aid { get; set; }

    public DateTime Pdatetime { get; set; }

    public virtual Activity AidNavigation { get; set; } = null!;

    public virtual Hospitality HidNavigation { get; set; } = null!;

    public virtual ICollection<UserTravel> UserTravels { get; set; } = new List<UserTravel>();
}
