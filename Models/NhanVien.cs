using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class NhanVien
{
    public string MaNv { get; set; } = null!;
    public string TenNv { get; set; } = null!;
    public string? ChucVu { get; set; }
    public decimal Luong { get; set; }
    public string? Sdt { get; set; }
    public string? Cccd { get; set; }
    public DateOnly NgaySinh { get; set; }
    public string? GioiTinh { get; set; }
    public string? DiaChi { get; set; }
    public string? Email { get; set; }
    public bool? DaXoa { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
    public virtual ICollection<PhieuThue> PhieuThues { get; set; } = new List<PhieuThue>();
    public virtual ICollection<TaiKhoan> TaiKhoans { get; set; } = new List<TaiKhoan>();

    [NotMapped] public string MaNV { get => MaNv; set => MaNv = value; }
    [NotMapped] public string TenNV { get => TenNv; set => TenNv = value; }
    [NotMapped] public string? SDT { get => Sdt; set => Sdt = value; }
    [NotMapped] public string? CCCD { get => Cccd; set => Cccd = value; }
    [NotMapped] public virtual ICollection<HoaDon> HoaDon { get => HoaDons; set => HoaDons = value; }
    [NotMapped] public virtual ICollection<PhieuThue> PhieuThue { get => PhieuThues; set => PhieuThues = value; }
    [NotMapped] public virtual ICollection<TaiKhoan> TaiKhoan { get => TaiKhoans; set => TaiKhoans = value; }
}
