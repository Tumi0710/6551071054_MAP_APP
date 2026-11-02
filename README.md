# 6551071054_MAP_APP - Quản Lý Khách Sạn (Hotel Management System)

Dự án bài tập thực hành môn **Lập trình trực quan (LTTQ)**.

---

## 🛠 Công nghệ sử dụng
- **Ngôn ngữ & Nền tảng:** C# (.NET 10.0 Windows Forms)
- **Cơ sở dữ liệu & ORM:** SQL Server, Entity Framework Core 8.0 (Code First / Scaffold)
- **Thư viện bổ trợ:** ClosedXML (xuất báo cáo Excel), iTextSharp

---

## 📌 Nội dung thực hiện

### Buổi 1 (LAB 1)
- Xây dựng giao diện đăng nhập (`FormDangNhap`)
- Xây dựng giao diện chính MDI (`FormMain`)
- Quản lý tài khoản hệ thống (`TaiKhoan`: Thêm, Sửa, Xóa mềm, Đổi mật khẩu)
- Quản lý thông tin phòng (`Phong`: Danh sách, Thêm, Sửa)
- Quản lý loại phòng (`LoaiPhong`: Danh sách, Thêm, Sửa)
- Quản lý tiện nghi cơ bản (`TienNghi`)

### Buổi 2 (LAB 2)
1. **Quản lý thông tin dịch vụ (`DichVu`):** Danh sách, Thêm mới, Sửa, Xóa, Tìm kiếm, Xuất Excel.
2. **Quản lý thông tin tiện nghi (`TienNghi`):** Danh sách, Thêm mới, Sửa, Xóa, Tìm kiếm, Xuất Excel.
3. **Quản lý thông tin khách hàng (`KhachHang`):** Danh sách, Thêm mới, Sửa, Xóa, Tìm kiếm, Xuất Excel.
4. **Quản lý thông tin nhân viên (`NhanVien`):** Danh sách, Thêm mới, Sửa, Xóa mềm đồng bộ tài khoản, Xuất Excel.
5. **Quản lý tiện nghi cho loại phòng (`ChiTietTienNghi`):** Xem danh sách tiện nghi theo từng loại phòng, Thêm, Sửa, Xóa tiện nghi trong loại phòng (tích hợp trực tiếp từ danh sách loại phòng).
6. **Nghiệp vụ Đặt phòng (`SoDoPhong` & `FormDatPhong`):** Chọn phòng trống theo khoảng thời gian đến/đi, chọn nhiều phòng, tự động điền thông tin khách hàng, lưu phiếu thuê & chi tiết đặt phòng, cập nhật trạng thái trực quan trên sơ đồ phòng.

---

## 📂 Tài liệu đính kèm
- `Doc/TH_LTTQ_B1.pdf`: Đề bài thực hành Lab 1.
- `Doc/TH_LTTQ_B2.pdf`: Đề bài thực hành Lab 2.