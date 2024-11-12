using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MIS353_ApplicationGroupKEAH.Data;

public partial class Hospitality
{
    [Key]
    public int Hid { get; set; }

    public string Hname { get; set; } = null!;

    public string Htype { get; set; } = null!;

    public int? Hrating { get; set; }

    public int Lid { get; set; }

    public virtual Landmark LidNavigation { get; set; } = null!;

    public virtual ICollection<Travelplan> Travelplans { get; set; } = new List<Travelplan>();
}
