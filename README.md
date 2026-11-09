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

### Buổi 3 (LAB 3)
1. **Quản lý dịch vụ sử dụng cho phòng đang thuê (`PhieuThue/FormThemDichVuPhongDaDung`):** Thêm dịch vụ cho phòng ở trạng thái "Đang thuê", kiểm tra tồn kho còn lại, tự động tính thành tiền, cập nhật số lượng và tổng tiền dịch vụ.
2. **Quản lý phiếu đặt/thuê phòng (`PhieuThue`):**
   - `FormDanhSachPhieuThue`: Xem danh sách phiếu thuê, tìm kiếm theo mã phiếu hoặc tên khách hàng, xuất danh sách ra file Excel bằng ClosedXML, mở đặt phòng mới.
   - `FormChiTietPhieuThue`: Xem thông tin chi tiết phiếu thuê, hiển thị danh sách phòng với các nút thao tác ngữ cảnh trực quan (Huỷ/Sửa đối với phòng "Đã đặt", Thêm dịch vụ/Thanh toán đối với phòng "Đang thuê").
   - `FormSuaChiTietPhieuThue`: Cập nhật trạng thái phòng ("Đang thuê", "Đã thanh toán"), đồng bộ tự động trạng thái phòng trên sơ đồ khách sạn.
   - `FormDanhSachDichVuPhongDaDung`: Xem danh sách và tổng hợp các dịch vụ đã sử dụng theo từng phòng.
   - Thanh toán và tạo hóa đơn tự động (`HoaDon`) khi kết thúc thuê phòng.
3. **Quản lý hóa đơn thanh toán (`HoaDon`):**
   - `FormDanhSachHoaDon`: Tra cứu danh sách hóa đơn theo mã HĐ, tên KH, số CCCD/Passport, lọc hóa đơn theo ngày lập, xuất danh sách hóa đơn ra Excel bằng ClosedXML.
   - `FormHoaDon`: Xem chi tiết hóa đơn gồm tiền thuê phòng (theo giờ hoặc ngày) và tiền các dịch vụ đi kèm; in/xuất hóa đơn ra file PDF hỗ trợ chuẩn Unicode tiếng Việt qua iTextSharp; tự động chuyển trạng thái hóa đơn thành "Đã thanh toán".
4. **Quản lý tài khoản & Phân quyền hệ thống (`TaiKhoan`):**
   - `FormDanhSachTaiKhoan`: Danh sách tài khoản người dùng, phân cấp quyền hạn (Cấp 1 - Nhân viên, Cấp 2 - Quản lý, Cấp 3 - Admin), tìm kiếm, xuất Excel, xóa mềm (ngăn chặn xóa tài khoản đang đăng nhập).
   - `FormThemTaiKhoan`: Thêm tài khoản mới liên kết với mã nhân viên, mật khẩu và cấp độ quyền (tự động khôi phục nếu tài khoản từng bị xóa mềm).
   - `FormSuaTaiKhoan`: Cập nhật mật khẩu, cấp độ quyền của tài khoản.
5. **Dashboard Báo cáo & Thống kê kinh doanh (`ThongKe/FormThongKe`):**
   - Thống kê doanh thu thuê phòng, doanh thu dịch vụ, tổng số lượt đặt phòng theo khoảng thời gian tùy chọn (Từ ngày - Đến ngày).
   - Thống kê top loại phòng có doanh thu cao nhất, top loại phòng được đặt nhiều nhất, top dịch vụ có doanh thu cao nhất.
   - Trực quan hóa dữ liệu bằng đồ họa GDI+: Biểu đồ tròn (Pie Chart) cơ cấu dịch vụ được sử dụng và 2 Biểu đồ cột (Bar Chart) doanh thu & số lượt đặt theo từng loại phòng.

