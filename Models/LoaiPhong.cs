using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Models;

public partial class LoaiPhong
{
    public string MaLph { get; set; } = null!;
    public string TenLph { get; set; } = null!;
    public int SoGiuong { get; set; }
    public int SoNguoiToiDa { get; set; }
    public decimal GiaNgay { get; set; }
    public decimal GiaGio { get; set; }
    [NotMapped]
    public bool? DaXoa { get; set; }

    public virtual ICollection<CTTN> Cttns { get; set; } = new List<CTTN>();
    public virtual ICollection<Phong> Phongs { get; set; } = new List<Phong>();

    [NotMapped] public string MaLPH { get => MaLph; set => MaLph = value; }
    [NotMapped] public string TenLPH { get => TenLph; set => TenLph = value; }
    [NotMapped] public virtual ICollection<CTTN> CTTN { get => Cttns; set => Cttns = value; }
    [NotMapped] public virtual ICollection<Phong> Phong { get => Phongs; set => Phongs = value; }
}
