using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class PhieuThue
{
    public string MaPt { get; set; } = null!;
    public DateTime NgPt { get; set; }
    public string MaKh { get; set; } = null!;
    public string MaNv { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTDP> Ctdps { get; set; } = new List<CTDP>();
    public virtual KhachHang MaKhNavigation { get; set; } = null!;
    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    [NotMapped] public string MaPT { get => MaPt; set => MaPt = value; }
    [NotMapped] public DateTime NgPT { get => NgPt; set => NgPt = value; }
    [NotMapped] public string MaKH { get => MaKh; set => MaKh = value; }
    [NotMapped] public string MaNV { get => MaNv; set => MaNv = value; }
    [NotMapped] public virtual ICollection<CTDP> CTDP { get => Ctdps; set => Ctdps = value; }
    [NotMapped] public virtual KhachHang MaKHNavigation { get => MaKhNavigation; set => MaKhNavigation = value; }
    [NotMapped] public virtual NhanVien MaNVNavigation { get => MaNvNavigation; set => MaNvNavigation = value; }
}
