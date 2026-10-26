using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class DichVu
{
    public string MaDv { get; set; } = null!;
    public string TenDv { get; set; } = null!;
    public decimal DonGia { get; set; }
    public int? SlconLai { get; set; }
    public string? LoaiDv { get; set; }
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTDV> Ctdvs { get; set; } = new List<CTDV>();

    [NotMapped] public string MaDV { get => MaDv; set => MaDv = value; }
    [NotMapped] public string TenDV { get => TenDv; set => TenDv = value; }
    [NotMapped] public int? SLConLai { get => SlconLai; set => SlconLai = value; }
    [NotMapped] public string? LoaiDV { get => LoaiDv; set => LoaiDv = value; }
    [NotMapped] public virtual ICollection<CTDV> CTDV { get => Ctdvs; set => Ctdvs = value; }
}
