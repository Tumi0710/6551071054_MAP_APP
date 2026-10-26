using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class Phong
{
    public string MaPh { get; set; } = null!;
    public string? Ttph { get; set; }
    public string? Ttdd { get; set; }
    public string? GhiChu { get; set; }
    public string MaLph { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTDP> Ctdps { get; set; } = new List<CTDP>();
    public virtual LoaiPhong MaLphNavigation { get; set; } = null!;

    [NotMapped] public string MaPH { get => MaPh; set => MaPh = value; }
    [NotMapped] public string? TTPH { get => Ttph; set => Ttph = value; }
    [NotMapped] public string? TTDD { get => Ttdd; set => Ttdd = value; }
    [NotMapped] public string MaLPH { get => MaLph; set => MaLph = value; }
    [NotMapped] public virtual ICollection<CTDP> CTDP { get => Ctdps; set => Ctdps = value; }
    [NotMapped] public virtual LoaiPhong MaLPHNavigation { get => MaLphNavigation; set => MaLphNavigation = value; }
}
