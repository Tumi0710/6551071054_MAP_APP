using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class HoaDon
{
    public string MaHd { get; set; } = null!;
    public DateTime? NgHd { get; set; }
    public decimal? TriGia { get; set; }
    public string MaNv { get; set; } = null!;
    public string? TrangThai { get; set; }
    public string MaCtdp { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual CTDP MaCtdpNavigation { get; set; } = null!;
    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    [NotMapped] public string MaHD { get => MaHd; set => MaHd = value; }
    [NotMapped] public DateTime? NgHD { get => NgHd; set => NgHd = value; }
    [NotMapped] public string MaNV { get => MaNv; set => MaNv = value; }
    [NotMapped] public string MaCTDP { get => MaCtdp; set => MaCtdp = value; }
    [NotMapped] public virtual CTDP MaCTDPNavigation { get => MaCtdpNavigation; set => MaCtdpNavigation = value; }
    [NotMapped] public virtual NhanVien MaNVNavigation { get => MaNvNavigation; set => MaNvNavigation = value; }
}
