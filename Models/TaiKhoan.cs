using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class TaiKhoan
{
    public string TenTk { get; set; } = null!;
    public string Password { get; set; } = null!;
    public int CapDoQuyen { get; set; }
    public string MaNv { get; set; } = null!;
    public bool? DaXoa { get; set; }

    public virtual NhanVien MaNvNavigation { get; set; } = null!;

    [NotMapped] public string TenTK { get => TenTk; set => TenTk = value; }
    [NotMapped] public string MaNV { get => MaNv; set => MaNv = value; }
    [NotMapped] public virtual NhanVien MaNVNavigation { get => MaNvNavigation; set => MaNvNavigation = value; }
}
