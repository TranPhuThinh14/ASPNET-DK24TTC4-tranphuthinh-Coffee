# ASPNET-DK24TTC4-tranphuthinh-Webbancoffee

# CoffeeShop ASP.NET Web Forms

## Thông tin sinh viên
- Họ tên: Trần Phú Thịnh
- Lớp: DK24TTC4
- Môn học: ASP.NET
- Đề tài: Website bán cà phê
- Giảng viên hướng dẫn: TS. Đoàn Phước Miền

## Mô tả đồ án
Xây dựng website bán cà phê sử dụng ASP.NET Web Forms (.NET Framework) và SQL Server.
Hệ thống cho phép:
- Quản lý sản phẩm cà phê
- Đăng nhập / đăng ký người dùng
- Đặt hàng và quản lý đơn hàng

## Công nghệ sử dụng
- ASP.NET Web Forms (.NET Framework)
- SQL Server
- Entity Framework Core
- HTML, CSS, Bootstrap

## Tiến độ thực hiện
- Tuần 1: Cài đặt môi trường, tạo database, tạo project ASP.NET MVC
- Tuần 2: Thiết kế database, chức năng đăng nhập
- Tuần 3: Quản lý sản phẩm
- Tuần 4: Đặt hàng
- Tuần 5: Hoàn thiện & báo cáo

## Hướng dẫn chạy dự án
1. Clone repository
2. Mở bằng Visual Studio 2022
3. Cấu hình connection string
4. Run project

## Mục tiêu tuần 2
Tuần 2 tập trung vào việc xây dựng nền tảng hệ thống người dùng, bao gồm:
- Thiết kế cơ sở dữ liệu
- Xây dựng chức năng đăng nhập
- Kết nối ứng dụng ASP.NET với SQL Server


## Các chức năng đã thực hiện

### 1. Thiết kế cơ sở dữ liệu
- Tạo database cho website bán cà phê trên SQL Server
- Tạo bảng `Users` để lưu thông tin người dùng
- Chuẩn bị dữ liệu mẫu phục vụ cho chức năng đăng nhập

### 2. Xây dựng trang đăng nhập
- Tạo trang `Login.aspx`
- Xây dựng form đăng nhập gồm:
  - Username
  - Password
  - Nút Login

### 3. Kiểm tra đăng nhập
- Kiểm tra thông tin đăng nhập từ bảng `Users`
- So sánh Username và Password với dữ liệu trong database
- Thông báo khi đăng nhập sai

### 4. Điều hướng sau đăng nhập
- Nếu đăng nhập thành công:
  - Điều hướng sang trang `Users.aspx`
- Lưu thông tin đăng nhập bằng `Session`


## Công nghệ sử dụng
- ASP.NET WebForm
- C# (.NET Framework)
- SQL Server
- ADO.NET


## Hướng dẫn chạy dự án
1. Chạy file SQL trong thư mục `database` để tạo database
2. Mở project bằng Visual Studio
3. Kiểm tra chuỗi kết nối trong `Web.config`
4. Chạy project và truy cập trang `Login.aspx`


## Tiến độ
- Hoàn thành đúng kế hoạch đề ra cho tuần 2
- Hệ thống đăng nhập hoạt động ổn định
