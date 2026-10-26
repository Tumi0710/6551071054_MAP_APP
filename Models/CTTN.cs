using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class CTTN
{
    public string MaLph { get; set; } = null!;
    public string MaTn { get; set; } = null!;
    public int? Sl { get; set; }
    public bool? DaXoa { get; set; }

    public virtual LoaiPhong MaLphNavigation { get; set; } = null!;
    public virtual TienNghi MaTnNavigation { get; set; } = null!;

    [NotMapped] public string MaLPH { get => MaLph; set => MaLph = value; }
    [NotMapped] public string MaTN { get => MaTn; set => MaTn = value; }
    [NotMapped] public int? SL { get => Sl; set => Sl = value; }
    [NotMapped] public virtual LoaiPhong MaLPHNavigation { get => MaLphNavigation; set => MaLphNavigation = value; }
    [NotMapped] public virtual TienNghi MaTNNavigation { get => MaTnNavigation; set => MaTnNavigation = value; }
}
