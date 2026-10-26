using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class KhachHang
{
    public string MaKh { get; set; } = null!;
    public string TenKh { get; set; } = null!;
    public string? Sdt { get; set; }
    public string? CccdPassport { get; set; }
    public string? QuocTich { get; set; }
    public string? GioiTinh { get; set; }
    public bool? DaXoa { get; set; }

    public virtual ICollection<PhieuThue> PhieuThues { get; set; } = new List<PhieuThue>();

    [NotMapped] public string MaKH { get => MaKh; set => MaKh = value; }
    [NotMapped] public string TenKH { get => TenKh; set => TenKh = value; }
    [NotMapped] public string? SDT { get => Sdt; set => Sdt = value; }
    [NotMapped] public string? CCCD_Passport { get => CccdPassport; set => CccdPassport = value; }
    [NotMapped] public virtual ICollection<PhieuThue> PhieuThue { get => PhieuThues; set => PhieuThues = value; }
}
