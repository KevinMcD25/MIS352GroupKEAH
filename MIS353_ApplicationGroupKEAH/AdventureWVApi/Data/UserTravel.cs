using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AdventureWVApi.Data;

public partial class UserTravel
{
    [Key]
    public int Utid { get; set; }

    public int Pid { get; set; }

    public int Uid { get; set; }

    public virtual Travelplan PidNavigation { get; set; } = null!;

    public virtual Userdatum UidNavigation { get; set; } = null!;
}
