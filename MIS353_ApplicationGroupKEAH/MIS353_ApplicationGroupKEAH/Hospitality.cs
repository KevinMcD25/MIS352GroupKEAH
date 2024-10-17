using System;
using System.Collections.Generic;

namespace MIS353_ApplicationGroupKEAH;

public partial class Hospitality
{
    public int Hid { get; set; }

    public string Hname { get; set; } = null!;

    public string Htype { get; set; } = null!;

    public int? Hrating { get; set; }

    public int Lid { get; set; }

    public virtual Landmark LidNavigation { get; set; } = null!;

    public virtual Travelplan? Travelplan { get; set; }
}
