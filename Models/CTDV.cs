using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class CTDV
{
    public string MaCtdp { get; set; } = null!;
    public string MaDv { get; set; } = null!;
    public int Sl { get; set; }
    public decimal? DonGia { get; set; }
    public decimal? ThanhTien { get; set; }
    public bool? DaXoa { get; set; }

    public virtual CTDP MaCtdpNavigation { get; set; } = null!;
    public virtual DichVu MaDvNavigation { get; set; } = null!;

    [NotMapped] public string MaCTDP { get => MaCtdp; set => MaCtdp = value; }
    [NotMapped] public string MaDV { get => MaDv; set => MaDv = value; }
    [NotMapped] public int SL { get => Sl; set => Sl = value; }
    [NotMapped] public virtual CTDP MaCTDPNavigation { get => MaCtdpNavigation; set => MaCtdpNavigation = value; }
    [NotMapped] public virtual DichVu MaDVNavigation { get => MaDvNavigation; set => MaDvNavigation = value; }
}
