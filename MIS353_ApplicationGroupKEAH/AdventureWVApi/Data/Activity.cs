using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWVApi.Data;

public partial class Activity
{
    [Key]
    public int Aid { get; set; }

    public string Aname { get; set; } = null!;

    public int Lid { get; set; }

   public virtual Landmark LidNavigation { get; set; } = null!;

    public virtual Travelplan? Travelplan { get; set; }
}
