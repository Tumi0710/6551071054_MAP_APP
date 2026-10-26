using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class CTDP
{
    public string MaCtdp { get; set; } = null!;
    public string MaPt { get; set; } = null!;
    public string MaPh { get; set; } = null!;
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public int? SoNguoi { get; set; }
    public decimal DonGia { get; set; }
    public decimal? ThanhTien { get; set; }
    public bool? TheoGio { get; set; }
    public string TrangThai { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTDV> Ctdvs { get; set; } = new List<CTDV>();
    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    public virtual Phong MaPhNavigation { get; set; } = null!;
    public virtual PhieuThue MaPtNavigation { get; set; } = null!;

    [NotMapped] public string MaCTDP { get => MaCtdp; set => MaCtdp = value; }
    [NotMapped] public string MaPT { get => MaPt; set => MaPt = value; }
    [NotMapped] public string MaPH { get => MaPh; set => MaPh = value; }
    [NotMapped] public virtual ICollection<CTDV> CTDV { get => Ctdvs; set => Ctdvs = value; }
    [NotMapped] public virtual ICollection<HoaDon> HoaDon { get => HoaDons; set => HoaDons = value; }
    [NotMapped] public virtual Phong MaPHNavigation { get => MaPhNavigation; set => MaPhNavigation = value; }
    [NotMapped] public virtual PhieuThue MaPTNavigation { get => MaPtNavigation; set => MaPtNavigation = value; }
}
