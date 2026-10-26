using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class TienNghi
{
    public string MaTn { get; set; } = null!;
    public string TenTn { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTTN> Cttns { get; set; } = new List<CTTN>();

    [NotMapped] public string MaTN { get => MaTn; set => MaTn = value; }
    [NotMapped] public string TenTN { get => TenTn; set => TenTN = value; }
    [NotMapped] public virtual ICollection<CTTN> CTTN { get => Cttns; set => Cttns = value; }
}
