using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models;

public partial class HotelManagementContext : DbContext
{
    private const string ConnectionString = "Server=localhost;Database=HotelManagement;Trusted_Connection=True;TrustServerCertificate=True;";

    public HotelManagementContext()
    {
    }

    public HotelManagementContext(DbContextOptions<HotelManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CTDP> CTDP { get; set; }
    public virtual DbSet<CTDV> CTDV { get; set; }
    public virtual DbSet<CTTN> CTTN { get; set; }
    public virtual DbSet<DichVu> DichVu { get; set; }
    public virtual DbSet<HoaDon> HoaDon { get; set; }
    public virtual DbSet<KhachHang> KhachHang { get; set; }
    public virtual DbSet<LoaiPhong> LoaiPhong { get; set; }
    public virtual DbSet<NhanVien> NhanVien { get; set; }
    public virtual DbSet<PhieuThue> PhieuThue { get; set; }
    public virtual DbSet<Phong> Phong { get; set; }
    public virtual DbSet<TaiKhoan> TaiKhoan { get; set; }
    public virtual DbSet<TienNghi> TienNghi { get; set; }

    public virtual DbSet<CTDP> Ctdps => CTDP;
    public virtual DbSet<CTDV> Ctdvs => CTDV;
    public virtual DbSet<CTTN> Cttns => CTTN;
    public virtual DbSet<DichVu> DichVus => DichVu;
    public virtual DbSet<HoaDon> HoaDons => HoaDon;
    public virtual DbSet<KhachHang> KhachHangs => KhachHang;
    public virtual DbSet<LoaiPhong> LoaiPhongs => LoaiPhong;
    public virtual DbSet<NhanVien> NhanViens => NhanVien;
    public virtual DbSet<PhieuThue> PhieuThues => PhieuThue;
    public virtual DbSet<Phong> Phongs => Phong;
    public virtual DbSet<TaiKhoan> TaiKhoans => TaiKhoan;
    public virtual DbSet<TienNghi> TienNghis => TienNghi;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
            optionsBuilder.UseSqlServer(ConnectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CTDP>(entity =>
        {
            entity.HasKey(e => e.MaCtdp).HasName("PK__CTDP__1E4E40F83E02A030");

            entity.ToTable(tb => tb.HasTrigger("CapNhatGiaCTDP"));

            entity.Property(e => e.MaCtdp).HasColumnName("MaCTDP").HasMaxLength(7);
            entity.Property(e => e.CheckIn).HasColumnType("smalldatetime");
            entity.Property(e => e.CheckOut).HasColumnType("smalldatetime");
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.SoNguoi);
            entity.Property(e => e.DonGia).HasColumnType("money");
            entity.Property(e => e.MaPh)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("MaPH");
            entity.Property(e => e.MaPt)
                .IsRequired()
                .HasMaxLength(5)
                .HasColumnName("MaPT");
            entity.Property(e => e.ThanhTien)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.TheoGio).HasDefaultValue(false);
            entity.Property(e => e.TrangThai)
                .IsRequired()
                .HasMaxLength(20);

            entity.HasOne(d => d.MaPhNavigation).WithMany(p => p.Ctdps)
                .HasForeignKey(d => d.MaPh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDP_Phong");

            entity.HasOne(d => d.MaPtNavigation).WithMany(p => p.Ctdps)
                .HasForeignKey(d => d.MaPt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDP_PhieuThue");
        });

        modelBuilder.Entity<CTDV>(entity =>
        {
            entity.HasKey(e => new { e.MaCtdp, e.MaDv });

            entity.ToTable(tb => tb.HasTrigger("CapNhatGiaDV"));

            entity.Property(e => e.MaCtdp).HasColumnName("MaCTDP").HasMaxLength(7);
            entity.Property(e => e.MaDv).HasColumnName("MaDV").HasMaxLength(5);
            entity.Property(e => e.Sl).HasColumnName("SL");
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.DonGia)
                .HasDefaultValue(0m)
                .HasColumnType("money");
            entity.Property(e => e.ThanhTien)
                .HasDefaultValue(0m)
                .HasColumnType("money");

            entity.HasOne(d => d.MaCtdpNavigation).WithMany(p => p.Ctdvs)
                .HasForeignKey(d => d.MaCtdp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDV_CTDP");

            entity.HasOne(d => d.MaDvNavigation).WithMany(p => p.Ctdvs)
                .HasForeignKey(d => d.MaDv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTDV_DichVu");
        });

        modelBuilder.Entity<CTTN>(entity =>
        {
            entity.HasKey(e => new { e.MaLph, e.MaTn });

            entity.Property(e => e.MaLph).HasColumnName("MaLPH").HasMaxLength(5);
            entity.Property(e => e.MaTn).HasColumnName("MaTN").HasMaxLength(5);
            entity.Property(e => e.Sl).HasColumnName("SL").HasDefaultValue(-1);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);

            entity.HasOne(d => d.MaLphNavigation).WithMany(p => p.Cttns)
                .HasForeignKey(d => d.MaLph)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTTN_LoaiPhong");

            entity.HasOne(d => d.MaTnNavigation).WithMany(p => p.Cttns)
                .HasForeignKey(d => d.MaTn)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CTTN_TienNghi");
        });

        modelBuilder.Entity<DichVu>(entity =>
        {
            entity.HasKey(e => e.MaDv).HasName("PK__DichVu__27258657F40277C5");

            entity.Property(e => e.MaDv).HasColumnName("MaDV").HasMaxLength(5);
            entity.Property(e => e.TenDv).HasColumnName("TenDV").IsRequired().HasMaxLength(20);
            entity.Property(e => e.LoaiDv).HasColumnName("LoaiDV").IsRequired().HasMaxLength(20);
            entity.Property(e => e.SlconLai).HasColumnName("SLConLai").HasDefaultValue(-1);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.DonGia).HasColumnType("money");
        });

        modelBuilder.Entity<HoaDon>(entity =>
        {
            entity.HasKey(e => e.MaHd).HasName("PK__HoaDon__2725A6E06EBC5AB3");

            entity.ToTable(tb => tb.HasTrigger("CapNhatGiaTriHoaDon"));

            entity.Property(e => e.MaHd).HasColumnName("MaHD").HasMaxLength(5);
            entity.Property(e => e.NgHd).HasColumnName("NgHD").HasColumnType("smalldatetime");
            entity.Property(e => e.MaNv).HasColumnName("MaNV").HasMaxLength(5);
            entity.Property(e => e.MaCtdp).HasColumnName("MaCTDP").IsRequired().HasMaxLength(7);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.TrangThai)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.TriGia)
                .HasDefaultValue(0m)
                .HasColumnType("money");

            entity.HasOne(d => d.MaCtdpNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaCtdp)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HoaDon_CTDP");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.HoaDons)
                .HasForeignKey(d => d.MaNv)
                .HasConstraintName("FK_HoaDon_NhanVien");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKh).HasName("PK__KhachHan__2725CF1EA312BD58");

            entity.HasIndex(e => e.CccdPassport, "UQ__KhachHan__F7905DCD921DBD7F").IsUnique();

            entity.Property(e => e.MaKh).HasColumnName("MaKH").HasMaxLength(5);
            entity.Property(e => e.TenKh).HasColumnName("TenKH").IsRequired().HasMaxLength(50);
            entity.Property(e => e.Sdt).HasColumnName("SDT").HasMaxLength(10);
            entity.Property(e => e.CccdPassport)
                .IsRequired()
                .HasMaxLength(12)
                .HasColumnName("CCCD/Passport");
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.GioiTinh)
                .IsRequired()
                .HasMaxLength(3);
            entity.Property(e => e.QuocTich)
                .IsRequired()
                .HasMaxLength(30);
        });

        modelBuilder.Entity<LoaiPhong>(entity =>
        {
            entity.HasKey(e => e.MaLph).HasName("PK__LoaiPhon__3B9BD79292AF0CE2");

            entity.Property(e => e.MaLph).HasColumnName("MaLPH").HasMaxLength(5);
            entity.Property(e => e.TenLph).HasColumnName("TenLPH").IsRequired().HasMaxLength(20);
            entity.Property(e => e.GiaGio).HasColumnType("money");
            entity.Property(e => e.GiaNgay).HasColumnType("money");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNv).HasName("PK__NhanVien__2725D70A81C6503F");

            entity.HasIndex(e => e.Cccd, "UQ__NhanVien__A955A0AA05909B7D").IsUnique();
            entity.HasIndex(e => e.Email, "UQ__NhanVien__A9D10534CDE3E882").IsUnique();
            entity.HasIndex(e => e.Sdt, "UQ__NhanVien__CA1930A5B54F4A9F").IsUnique();

            entity.Property(e => e.MaNv).HasColumnName("MaNV").HasMaxLength(5);
            entity.Property(e => e.TenNv).HasColumnName("TenNV").IsRequired().HasMaxLength(50);
            entity.Property(e => e.Sdt).HasColumnName("SDT").IsRequired().HasMaxLength(10);
            entity.Property(e => e.Cccd)
                .IsRequired()
                .HasMaxLength(12)
                .HasColumnName("CCCD");
            entity.Property(e => e.ChucVu)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.DiaChi)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.GioiTinh)
                .IsRequired()
                .HasMaxLength(3);
            entity.Property(e => e.Luong).HasColumnType("money");
        });

        modelBuilder.Entity<PhieuThue>(entity =>
        {
            entity.HasKey(e => e.MaPt).HasName("PK__PhieuThu__2725E7F65D1AC700");

            entity.Property(e => e.MaPt).HasColumnName("MaPT").HasMaxLength(5);
            entity.Property(e => e.NgPt).HasColumnName("NgPT").HasColumnType("smalldatetime");
            entity.Property(e => e.MaKh).HasColumnName("MaKH").IsRequired().HasMaxLength(5);
            entity.Property(e => e.MaNv).HasColumnName("MaNV").IsRequired().HasMaxLength(5);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);

            entity.HasOne(d => d.MaKhNavigation).WithMany(p => p.PhieuThues)
                .HasForeignKey(d => d.MaKh)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhieuThue_KhachHang");

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.PhieuThues)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PhieuThue_NhanVien");
        });

        modelBuilder.Entity<Phong>(entity =>
        {
            entity.HasKey(e => e.MaPh).HasName("PK__Phong__2725E7FA8CC86FED");

            entity.Property(e => e.MaPh).HasColumnName("MaPH").HasMaxLength(5);
            entity.Property(e => e.Ttph).HasColumnName("TTPH").IsRequired().HasMaxLength(20);
            entity.Property(e => e.Ttdd).HasColumnName("TTDD").IsRequired().HasMaxLength(20);
            entity.Property(e => e.MaLph).HasColumnName("MaLPH").IsRequired().HasMaxLength(5);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
            entity.Property(e => e.GhiChu).HasMaxLength(100);

            entity.HasOne(d => d.MaLphNavigation).WithMany(p => p.Phongs)
                .HasForeignKey(d => d.MaLph)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Phong_LoaiPhong");
        });

        modelBuilder.Entity<TaiKhoan>(entity =>
        {
            entity.HasKey(e => e.TenTk).HasName("PK__TaiKhoan__4CF9E776CE58B3CF");

            entity.Property(e => e.TenTk).HasColumnName("TenTK").HasMaxLength(50);
            entity.Property(e => e.MaNv).HasColumnName("MaNV").IsRequired().HasMaxLength(5);
            entity.Property(e => e.Password).IsRequired().HasMaxLength(1000);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);

            entity.HasOne(d => d.MaNvNavigation).WithMany(p => p.TaiKhoans)
                .HasForeignKey(d => d.MaNv)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_TaiKhoan_NhanVien");
        });

        modelBuilder.Entity<TienNghi>(entity =>
        {
            entity.HasKey(e => e.MaTn).HasName("PK__TienNghi__27250073AFA1EF1D");

            entity.Property(e => e.MaTn).HasColumnName("MaTN").HasMaxLength(5);
            entity.Property(e => e.TenTn).HasColumnName("TenTN").IsRequired().HasMaxLength(50);
            entity.Property(e => e.DaXoa).HasDefaultValue(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
