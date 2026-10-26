using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using HotelManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.ThongKe
{
    public partial class FormThongKe : Form
    {
        private List<(string TenDv, int SoLuong, decimal DoanhThu)> _servicePieData = new();
        private List<(string TenLph, double DoanhThu)> _roomRevBarData = new();
        private List<(string TenLph, double SoLuong)> _roomCountBarData = new();

        private readonly Color[] _pieColors = new Color[]
        {
            Color.FromArgb(41, 128, 185),   // Blue
            Color.FromArgb(230, 126, 34),   // Orange
            Color.FromArgb(231, 76, 60),    // Coral/Red
            Color.FromArgb(26, 188, 156),   // Teal
            Color.FromArgb(155, 89, 182),   // Purple
            Color.FromArgb(241, 196, 15),   // Yellow
            Color.FromArgb(52, 152, 219),   // Light Blue
            Color.FromArgb(46, 204, 113)    // Green
        };

        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            try
            {
                using var db = new HotelManagementContext();
                // Tìm ngày sớm nhất và muộn nhất trong DB để đặt mặc định thuận tiện cho người dùng
                var minDate = db.CTDP.AsNoTracking().Where(c => c.DaXoa != true).Select(c => (DateTime?)c.CheckIn).Min();
                var maxDate = db.CTDP.AsNoTracking().Where(c => c.DaXoa != true).Select(c => (DateTime?)c.CheckIn).Max();

                if (minDate.HasValue)
                {
                    dtpTuNgay.Value = minDate.Value.Date;
                }
                else
                {
                    dtpTuNgay.Value = new DateTime(DateTime.Today.Year, 1, 1);
                }

                if (maxDate.HasValue && maxDate.Value > dtpTuNgay.Value)
                {
                    dtpDenNgay.Value = maxDate.Value.Date.AddDays(7);
                }
                else
                {
                    dtpDenNgay.Value = DateTime.Today;
                }
            }
            catch
            {
                dtpTuNgay.Value = new DateTime(2022, 1, 1);
                dtpDenNgay.Value = DateTime.Today;
            }

            TaiDuLieuThongKe();
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TaiDuLieuThongKe();
        }

        private void TaiDuLieuThongKe()
        {
            try
            {
                DateTime tuNgay = dtpTuNgay.Value.Date;
                DateTime denNgay = dtpDenNgay.Value.Date.AddDays(1).AddTicks(-1);

                using var db = new HotelManagementContext();

                // Lấy toàn bộ CTDP chưa xóa mềm
                var tatCaCtdp = db.CTDP
                    .AsNoTracking()
                    .Include(c => c.MaPhNavigation).ThenInclude(p => p.MaLphNavigation)
                    .Include(c => c.Ctdvs).ThenInclude(dv => dv.MaDvNavigation)
                    .Include(c => c.MaPtNavigation)
                    .Where(c => c.DaXoa != true && c.TrangThai != "Đã hủy")
                    .ToList();

                // Lọc trong khoảng thời gian [tuNgay, denNgay]
                var dsTrongKhoang = tatCaCtdp
                    .Where(c => (c.CheckIn >= tuNgay && c.CheckIn <= denNgay) ||
                                (c.CheckIn <= denNgay && c.CheckOut >= tuNgay))
                    .ToList();

                // 1. Doanh thu thuê phòng
                decimal tongTienPhong = dsTrongKhoang.Sum(c =>
                {
                    if (c.ThanhTien.HasValue && c.ThanhTien.Value > 0)
                        return c.ThanhTien.Value;

                    decimal donGia = c.DonGia > 0 ? c.DonGia : (c.MaPhNavigation?.MaLphNavigation?.GiaNgay ?? 0);
                    int soNgay = Math.Max(1, (c.CheckOut.Date - c.CheckIn.Date).Days);
                    return donGia * soNgay;
                });
                lblVal1.Text = $"{tongTienPhong:N0} VND";

                // 2. Doanh thu dịch vụ
                var allCtdv = dsTrongKhoang.SelectMany(c => c.Ctdvs).Where(dv => dv.DaXoa != true).ToList();
                decimal tongTienDichVu = allCtdv.Sum(dv =>
                {
                    if (dv.ThanhTien.HasValue && dv.ThanhTien.Value > 0)
                        return dv.ThanhTien.Value;

                    decimal donGia = (dv.DonGia.HasValue && dv.DonGia.Value > 0)
                        ? dv.DonGia.Value
                        : (dv.MaDvNavigation?.DonGia ?? 0);
                    return dv.Sl * donGia;
                });
                lblVal2.Text = $"{tongTienDichVu:N0} VND";

                // 3. Số phòng đặt
                int soPhongDat = dsTrongKhoang.Count;
                lblVal3.Text = soPhongDat.ToString();

                // 4. Nhóm theo loại phòng
                var nhomLoaiPhong = dsTrongKhoang
                    .GroupBy(c => c.MaPhNavigation?.MaLphNavigation?.TenLph ?? "Khác")
                    .Select(g => new
                    {
                        TenLph = g.Key,
                        DoanhThu = g.Sum(c =>
                        {
                            if (c.ThanhTien.HasValue && c.ThanhTien.Value > 0)
                                return c.ThanhTien.Value;
                            decimal donGia = c.DonGia > 0 ? c.DonGia : (c.MaPhNavigation?.MaLphNavigation?.GiaNgay ?? 0);
                            int soNgay = Math.Max(1, (c.CheckOut.Date - c.CheckIn.Date).Days);
                            return donGia * soNgay;
                        }),
                        SoLuong = g.Count()
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                var topRevRoom = nhomLoaiPhong.FirstOrDefault();
                lblTopRoomRevVal.Text = topRevRoom != null
                    ? $"{topRevRoom.TenLph} ({topRevRoom.DoanhThu:N0} VND)"
                    : "Chưa có dữ liệu";

                var topCountRoom = nhomLoaiPhong.OrderByDescending(x => x.SoLuong).FirstOrDefault();
                lblTopRoomCountVal.Text = topCountRoom != null
                    ? $"{topCountRoom.TenLph} ({topCountRoom.SoLuong} lượt)"
                    : "Chưa có dữ liệu";

                // 5. Nhóm theo dịch vụ
                var nhomDichVu = allCtdv
                    .GroupBy(dv => dv.MaDvNavigation?.TenDv ?? dv.MaDv)
                    .Select(g => new
                    {
                        TenDv = g.Key,
                        DoanhThu = g.Sum(dv =>
                        {
                            if (dv.ThanhTien.HasValue && dv.ThanhTien.Value > 0)
                                return dv.ThanhTien.Value;
                            decimal donGia = (dv.DonGia.HasValue && dv.DonGia.Value > 0)
                                ? dv.DonGia.Value
                                : (dv.MaDvNavigation?.DonGia ?? 0);
                            return dv.Sl * donGia;
                        }),
                        SoLuong = g.Sum(dv => dv.Sl)
                    })
                    .OrderByDescending(x => x.DoanhThu)
                    .ToList();

                var topRevService = nhomDichVu.FirstOrDefault();
                lblTopServiceRevVal.Text = topRevService != null
                    ? $"{topRevService.TenDv} ({topRevService.DoanhThu:N0} VND)"
                    : "Chưa có dữ liệu";

                // Cập nhật dữ liệu biểu đồ
                _servicePieData = nhomDichVu
                    .Select(x => (x.TenDv, x.SoLuong, x.DoanhThu))
                    .ToList();

                _roomRevBarData = nhomLoaiPhong
                    .Select(x => (x.TenLph, (double)x.DoanhThu))
                    .ToList();

                _roomCountBarData = nhomLoaiPhong
                    .Select(x => (x.TenLph, (double)x.SoLuong))
                    .ToList();

                // Vẽ lại các biểu đồ
                picServicesPieChart.Invalidate();
                picRoomRevBarChart.Invalidate();
                picRoomBookingsBarChart.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu thống kê: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ======================= VẼ PIE CHART DỊCH VỤ =======================
        private void picServicesPieChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picServicesPieChart.Width;
            int h = picServicesPieChart.Height;

            if (_servicePieData == null || _servicePieData.Count == 0 || _servicePieData.Sum(x => x.SoLuong) == 0)
            {
                using var font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
                using var brush = new SolidBrush(Color.DimGray);
                using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Chưa có dữ liệu dịch vụ trong khoảng thời gian này", font, brush, new RectangleF(0, 0, w, h), format);
                return;
            }

            int total = _servicePieData.Sum(x => x.SoLuong);

            // Tọa độ hình tròn bên trái
            int diameter = Math.Min(w / 2 - 40, h - 40);
            if (diameter < 50) diameter = 50;
            int pieX = 30;
            int pieY = (h - diameter) / 2;
            Rectangle pieRect = new Rectangle(pieX, pieY, diameter, diameter);

            float currentAngle = 0;
            for (int i = 0; i < _servicePieData.Count; i++)
            {
                var item = _servicePieData[i];
                float sweepAngle = (float)item.SoLuong / total * 360f;
                Color color = _pieColors[i % _pieColors.Length];

                using (var brush = new SolidBrush(color))
                {
                    g.FillPie(brush, pieRect, currentAngle, sweepAngle);
                }

                // Vẽ viền slice
                using (var pen = new Pen(Color.White, 1.5f))
                {
                    g.DrawPie(pen, pieRect, currentAngle, sweepAngle);
                }

                // Vẽ số lượng lên slice nếu góc đủ lớn
                if (sweepAngle > 15)
                {
                    float midAngle = (currentAngle + sweepAngle / 2) * (float)Math.PI / 180f;
                    float r = diameter * 0.35f;
                    float tx = pieX + diameter / 2f + (float)Math.Cos(midAngle) * r;
                    float ty = pieY + diameter / 2f + (float)Math.Sin(midAngle) * r;

                    using var textFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
                    using var textBrush = new SolidBrush(Color.White);
                    using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(item.SoLuong.ToString(), textFont, textBrush, tx, ty, format);
                }

                currentAngle += sweepAngle;
            }

            // Vẽ Chú thích (Legend) bên phải
            int legendX = pieX + diameter + 30;
            int legendY = 20;
            int boxSize = 14;

            using var legendFont = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular);
            using var legendTextBrush = new SolidBrush(Color.FromArgb(40, 40, 40));

            for (int i = 0; i < _servicePieData.Count; i++)
            {
                var item = _servicePieData[i];
                Color color = _pieColors[i % _pieColors.Length];

                using (var brush = new SolidBrush(color))
                {
                    g.FillRectangle(brush, legendX, legendY + (i * 24), boxSize, boxSize);
                }

                string text = $"{item.TenDv} ({item.SoLuong})";
                g.DrawString(text, legendFont, legendTextBrush, legendX + boxSize + 8, legendY + (i * 24) - 1);
            }
        }

        // ======================= VẼ BAR CHART DOANH THU =======================
        private void picRoomRevBarChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picRoomRevBarChart.Width;
            int h = picRoomRevBarChart.Height;

            if (_roomRevBarData == null || _roomRevBarData.Count == 0)
            {
                using var font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
                using var brush = new SolidBrush(Color.DimGray);
                using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Chưa có dữ liệu thuê phòng trong khoảng thời gian này", font, brush, new RectangleF(0, 0, w, h), format);
                return;
            }

            // Vẽ Chú thích góc trên bên phải
            int legendBox = 14;
            int legendX = w - 210;
            int legendY = 10;
            using (var lBrush = new SolidBrush(Color.FromArgb(51, 153, 255)))
            {
                g.FillRectangle(lBrush, legendX, legendY, legendBox, legendBox);
            }
            using (var lFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular))
            using (var lTextBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
            {
                g.DrawString("Doanh thu theo loại phòng", lFont, lTextBrush, legendX + legendBox + 6, legendY);
            }

            // Vùng biểu đồ
            int padLeft = 85;
            int padRight = 30;
            int padTop = 35;
            int padBottom = 45;

            int chartW = w - padLeft - padRight;
            int chartH = h - padTop - padBottom;
            if (chartW <= 0 || chartH <= 0) return;

            double maxVal = _roomRevBarData.Max(x => x.DoanhThu);
            if (maxVal <= 0) maxVal = 1000000;
            // Làm tròn maxVal lên mốc đẹp (500k, 1M, 2M, 3M...)
            double step = Math.Pow(10, Math.Floor(Math.Log10(maxVal)));
            if (maxVal / step < 3) step /= 2;
            else if (maxVal / step > 7) step *= 2;
            double topScale = Math.Ceiling(maxVal / step) * step;
            if (topScale <= 0) topScale = 1000000;

            int gridSteps = 5;
            double gridStepVal = topScale / gridSteps;

            using var axisPen = new Pen(Color.FromArgb(100, 100, 100), 1.2f);
            using var gridPen = new Pen(Color.FromArgb(215, 215, 215), 1f) { DashStyle = DashStyle.Dot };
            using var labelFont = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular);
            using var labelBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
            using var rightFormat = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
            using var centerFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };

            // Vẽ lưới ngang và nhãn trục Y
            for (int i = 0; i <= gridSteps; i++)
            {
                double val = i * gridStepVal;
                int y = padTop + chartH - (int)((val / topScale) * chartH);

                g.DrawLine(gridPen, padLeft, y, padLeft + chartW, y);
                g.DrawString(val.ToString("N0"), labelFont, labelBrush, padLeft - 6, y, rightFormat);
            }

            // Trục tọa độ
            g.DrawLine(axisPen, padLeft, padTop, padLeft, padTop + chartH);
            g.DrawLine(axisPen, padLeft, padTop + chartH, padLeft + chartW, padTop + chartH);

            // Vẽ các cột (Bars)
            int count = _roomRevBarData.Count;
            int slotWidth = chartW / count;
            int barWidth = Math.Min(65, (int)(slotWidth * 0.55));
            using var barBrush = new SolidBrush(Color.FromArgb(51, 153, 255));
            using var barBorder = new Pen(Color.FromArgb(30, 120, 220), 1f);

            for (int i = 0; i < count; i++)
            {
                var item = _roomRevBarData[i];
                int barH = (int)((item.DoanhThu / topScale) * chartH);
                int bx = padLeft + (i * slotWidth) + (slotWidth - barWidth) / 2;
                int by = padTop + chartH - barH;

                if (barH > 0)
                {
                    g.FillRectangle(barBrush, bx, by, barWidth, barH);
                    g.DrawRectangle(barBorder, bx, by, barWidth, barH);
                }

                // Tên loại phòng dưới trục X
                RectangleF textRect = new RectangleF(padLeft + i * slotWidth, padTop + chartH + 6, slotWidth, padBottom - 6);
                g.DrawString(item.TenLph, labelFont, labelBrush, textRect, centerFormat);
            }
        }

        // ======================= VẼ BAR CHART SỐ PHÒNG ĐẶT =======================
        private void picRoomBookingsBarChart_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int w = picRoomBookingsBarChart.Width;
            int h = picRoomBookingsBarChart.Height;

            if (_roomCountBarData == null || _roomCountBarData.Count == 0)
            {
                using var font = new Font("Microsoft Sans Serif", 11F, FontStyle.Italic);
                using var brush = new SolidBrush(Color.DimGray);
                using var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString("Chưa có dữ liệu đặt phòng trong khoảng thời gian này", font, brush, new RectangleF(0, 0, w, h), format);
                return;
            }

            // Chú thích
            int legendBox = 14;
            int legendX = w - 170;
            int legendY = 10;
            using (var lBrush = new SolidBrush(Color.FromArgb(51, 153, 255)))
            {
                g.FillRectangle(lBrush, legendX, legendY, legendBox, legendBox);
            }
            using (var lFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular))
            using (var lTextBrush = new SolidBrush(Color.FromArgb(50, 50, 50)))
            {
                g.DrawString("Số lượng đặt", lFont, lTextBrush, legendX + legendBox + 6, legendY);
            }

            int padLeft = 60;
            int padRight = 30;
            int padTop = 35;
            int padBottom = 45;

            int chartW = w - padLeft - padRight;
            int chartH = h - padTop - padBottom;
            if (chartW <= 0 || chartH <= 0) return;

            double maxVal = _roomCountBarData.Max(x => x.SoLuong);
            if (maxVal <= 0) maxVal = 4;
            double topScale = Math.Max(3.5, Math.Ceiling(maxVal + 0.5));

            int gridSteps = 7; // ví dụ 0, 0.5, 1, 1.5, 2, 2.5, 3, 3.5...
            double gridStepVal = topScale / gridSteps;

            using var axisPen = new Pen(Color.FromArgb(100, 100, 100), 1.2f);
            using var gridPen = new Pen(Color.FromArgb(215, 215, 215), 1f) { DashStyle = DashStyle.Dot };
            using var labelFont = new Font("Microsoft Sans Serif", 8.5F, FontStyle.Regular);
            using var labelBrush = new SolidBrush(Color.FromArgb(60, 60, 60));
            using var rightFormat = new StringFormat { Alignment = StringAlignment.Far, LineAlignment = StringAlignment.Center };
            using var centerFormat = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };

            for (int i = 0; i <= gridSteps; i++)
            {
                double val = i * gridStepVal;
                int y = padTop + chartH - (int)((val / topScale) * chartH);

                g.DrawLine(gridPen, padLeft, y, padLeft + chartW, y);
                g.DrawString(val % 1 == 0 ? val.ToString("0") : val.ToString("0.0"), labelFont, labelBrush, padLeft - 6, y, rightFormat);
            }

            g.DrawLine(axisPen, padLeft, padTop, padLeft, padTop + chartH);
            g.DrawLine(axisPen, padLeft, padTop + chartH, padLeft + chartW, padTop + chartH);

            int count = _roomCountBarData.Count;
            int slotWidth = chartW / count;
            int barWidth = Math.Min(65, (int)(slotWidth * 0.55));
            using var barBrush = new SolidBrush(Color.FromArgb(51, 153, 255));
            using var barBorder = new Pen(Color.FromArgb(30, 120, 220), 1f);

            for (int i = 0; i < count; i++)
            {
                var item = _roomCountBarData[i];
                int barH = (int)((item.SoLuong / topScale) * chartH);
                int bx = padLeft + (i * slotWidth) + (slotWidth - barWidth) / 2;
                int by = padTop + chartH - barH;

                if (barH > 0)
                {
                    g.FillRectangle(barBrush, bx, by, barWidth, barH);
                    g.DrawRectangle(barBorder, bx, by, barWidth, barH);
                }

                RectangleF textRect = new RectangleF(padLeft + i * slotWidth, padTop + chartH + 6, slotWidth, padBottom - 6);
                g.DrawString(item.TenLph, labelFont, labelBrush, textRect, centerFormat);
            }
        }
    }
}
