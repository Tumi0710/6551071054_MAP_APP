# HƯỚNG DẪN CHẠY DEMO & QUAY VIDEO NỘP BÀI LAB 2
**Môn học:** Lập trình trực quan (LTTQ)  
**Đề tài:** Ứng dụng Quản lý khách sạn (Hotel Management System - WinForms)  
**Tài liệu đặc tả:** `Doc/TH_LTTQ_B2.pdf`  
**GitHub Repository:** [https://github.com/Tumi0710/6551071054_MAP_APP](https://github.com/Tumi0710/6551071054_MAP_APP)  

---

## I. THÔNG TIN CHUẨN BỊ TRƯỚC KHI QUAY

### 1. Phím tắt quay video màn hình (Windows)
- Bấm tổ hợp phím: **`Windows + Alt + R`** để Bắt đầu / Kết thúc quay (Xbox Game Bar có sẵn của Windows).
- Video quay xong sẽ tự động được lưu tại thư mục: `C:\Users\<Tên_User>\Videos\Captures`.
- *(Hoặc bạn có thể sử dụng OBS Studio, Bandicam, CapCut nếu quen dùng)*.

### 2. Tài khoản đăng nhập demo (Có sẵn trong CSDL)
- **Tài khoản:** `admin` (hoặc `Quanly`)
- **Mật khẩu:** `1234`

### 3. Khởi chạy ứng dụng
- Mở Terminal/CMD tại thư mục dự án và chạy:
  ```bash
  dotnet run
  ```
- Hoặc nhấn **F5** (hoặc nút **Start**) trong Visual Studio.

---

## II. KỊCH BẢN QUAY VIDEO DEMO (THỜI LƯỢNG 3 – 5 PHÚT)

Thực hiện lần lượt 6 phần theo đúng thứ tự tài liệu thực hành Lab 2:

### 0. Đăng nhập hệ thống
- Mở ứng dụng, nhập `admin` / mật khẩu `1234`.
- Bấm **Đăng nhập** -> Ứng dụng hiển thị Form chính (`FormMain`).
- Rê chuột vào tên người dùng hiển thị ở góc trên bên phải để chứng minh đã lấy đúng thông tin đăng nhập từ CSDL.

---

### 1. Quản lý Dịch vụ (Phần III.1 - Trang 3–25 trong PDF)
- Bấm vào menu **Dịch vụ** ở thanh menu bên trái.
- **Tìm kiếm:** Gõ từ khóa vào ô tìm kiếm (ví dụ `Nước` hoặc `DV`) để thấy lưới lọc động tức thời.
- **Xuất Excel:** Bấm nút **Xuất Excel** -> Chọn nơi lưu file (Desktop) -> Bấm **Yes** mở file để thấy dữ liệu được xuất ra file Excel bằng thư viện ClosedXML.
- **Thêm mới dịch vụ:**
  - Bấm nút **Thêm mới** -> Form `FormThemDichVu` mở lên.
  - Nhập:
    - Mã DV: `DV99`
    - Tên DV: `Nước cam ép`
    - Loại dịch vụ: `Thức uống`
    - Đơn giá: `35000`
    - Số lượng còn lại: `50`
  - Bấm **Thêm mới** -> Báo thành công và dịch vụ xuất hiện trên bảng.
- **Sửa & Xóa:**
  - Bấm icon **Sửa** (cây bút) ở dòng `DV99` -> Đổi đơn giá thành `40000` -> Bấm **Cập nhật**.
  - Bấm icon **Xóa** (thùng rác) ở dòng `DV99` -> Chọn **Yes** xác nhận -> Dịch vụ bị xóa khỏi bảng.

---

### 2. Quản lý Tiện nghi (Phần III.2 - Trang 26–41 trong PDF)
- Bấm vào menu **Tiện nghi**.
- **Tìm kiếm & Xuất Excel:** Gõ thử tên tiện nghi để lọc, bấm nút **Xuất Excel**.
- **Thêm mới:**
  - Bấm **Thêm mới** -> Nhập Tên tiện nghi: `Máy sấy tóc cao cấp`.
  - Bấm **Thêm mới** -> Báo thành công.
- **Sửa & Xóa:**
  - Bấm icon **Sửa** ở dòng tiện nghi vừa thêm -> Đổi tên thành: `Máy sấy tóc Panasonic` -> Bấm **Cập nhật**.
  - Bấm icon **Xóa** -> Chọn **Yes** xác nhận xóa.

---

### 3. Quản lý Khách hàng (Phần III.3 - Trang 42–64 trong PDF)
- Bấm vào menu **Khách hàng**.
- **Tìm kiếm & Xuất Excel:** Gõ CCCD hoặc Tên vào ô tìm kiếm, bấm **Xuất Excel**.
- **Thêm mới khách hàng:**
  - Bấm **Thêm mới** -> Nhập thông tin:
    - Họ và tên: `Nguyễn Văn An`
    - Số CCCD/Passport: `079204001234`
    - Số điện thoại: `0901234567`
    - Quốc tịch: `Việt Nam`
    - Giới tính: chọn `Nam`
  - Bấm **Thêm mới** -> Khách hàng mới xuất hiện trên danh sách.
- **Sửa & Xóa:**
  - Bấm icon **Sửa** dòng khách hàng vừa thêm -> Đổi số điện thoại -> Bấm **Cập nhật**.
  - Bấm icon **Xóa** -> Xác nhận xóa khách hàng.

---

### 4. Quản lý Nhân viên (Phần III.4 - Trang 65–92 trong PDF)
- Bấm vào menu **Nhân viên**.
- **Tìm kiếm & Xuất Excel:** Thao tác tìm kiếm nhanh và bấm nút **Xuất Excel**.
- **Thêm mới nhân viên:**
  - Bấm **Thêm mới** -> Nhập: Tên nhân viên, chức vụ (`Lễ tân`), lương, số điện thoại, CCCD, ngày sinh, giới tính.
  - Bấm **Thêm mới** -> Thông báo thành công.
- **Sửa:**
  - Bấm icon **Sửa** nhân viên vừa tạo -> Thay đổi chức vụ hoặc lương -> Bấm **Cập nhật**.

---

### 5. Quản lý Tiện nghi loại phòng - CTTN (Phần III.5 - Trang 93–114 trong PDF)
- Bấm vào menu **Loại Phòng**.
- Bấm vào biểu tượng ở cột **Tiện nghi** (`colTienNghi`) của một loại phòng bất kỳ (ví dụ: `Phòng Standard` hoặc `Phòng Deluxe`).
- **FormDanhSachChiTietTienNghi** mở ra hiển thị các tiện nghi của riêng loại phòng đó.
- Bấm **Thêm mới** -> Chọn tiện nghi từ ComboBox, nhập Số lượng: `2` -> Bấm **Cập nhật**.
- Bấm icon **Sửa** -> Sửa số lượng thành `3`.
- Bấm icon **Xóa** -> Xóa tiện nghi đó khỏi loại phòng -> Bấm **Thoát**.

---

### 6. Nghiệp vụ Đặt phòng khách sạn (Phần III.6 - Trang 115–134 trong PDF)
- Bấm vào menu **Sơ đồ phòng**.
- Bấm nút **Đặt phòng** ở góc trên bên phải -> Form `FormDatPhong` mở ra:
  1. **Nhập thông tin khách:**
     - Họ và tên: `Trần Tuấn Minh`
     - CCCD: `079204009999`
     - Số điện thoại: `0987654321`
     - Quốc tịch: `Việt Nam`, Giới tính: `Nam`
  2. **Chọn thời gian:** Ngày đến, Giờ đến (mặc định 02:00 PM), Ngày đi, Giờ đi (12:00 PM).
     - Lưới bên trái tự động truy vấn và hiển thị các phòng còn trống.
  3. **Chọn phòng:** Bấm nút **`+`** (cột Thêm) ở một phòng trống (ví dụ `P101`) -> Phòng sẽ được chuyển sang bảng "Danh sách phòng đã chọn" bên phải.
  4. **Lưu phiếu thuê:** Bấm nút **Đặt phòng** -> Hộp thoại thông báo *"Đặt phòng thành công!"* xuất hiện.
  5. Form đóng lại, màn hình quay về **Sơ đồ phòng**: Phòng vừa đặt (ví dụ `P101`) ngay lập tức đổi trạng thái sang màu cam (**"Đã đặt"**).

---

## III. HƯỚNG DẪN XUẤT FILE & NỘP BÀI LÊN LMS

1. **Lưu video:** Đổi tên file video thành: **`Video LAB2.mp4`** (đúng cú pháp quy định trong file PDF).
2. **Upload lên Drive:**
   - Upload file video lên Google Drive hoặc OneDrive cá nhân.
   - Bấm chuột phải vào file video -> Chọn **Chia sẻ (Share)** -> Đặt quyền: **"Bất kỳ ai có đường liên kết đều có thể xem" (Anyone with the link can view)** -> **Sao chép liên kết**.
3. **Điền thông tin nộp bài:**
   - Mở file template Word/Excel giảng viên cung cấp trên hệ thống LMS.
   - Điền link GitHub Repository:
     ```text
     https://github.com/Tumi0710/6551071054_MAP_APP
     ```
   - Điền link video Google Drive:
     ```text
     [Dán link Google Drive bạn vừa sao chép]
     ```
   - Nộp file template lên LMS đúng hạn.
