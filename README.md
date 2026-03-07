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

## Mục tiêu tuần 3

Tuần 3 tập trung vào việc xây dựng chức năng quản lý và hiển thị sản phẩm cà phê trên website.

## Các chức năng đã thực hiện
### 1. Thiết kế bảng Products

- Tạo bảng Products trong SQL Server để lưu thông tin sản phẩm.

- Các trường chính của bảng gồm:

- ProductID

- Name

- Price

- Image

- Description

### 2. Thêm dữ liệu sản phẩm

- Thêm một số sản phẩm cà phê mẫu vào database.

- Các sản phẩm được sử dụng để hiển thị trên website.

### 3. Xây dựng trang hiển thị sản phẩm

- Tạo trang Products.aspx

- Lấy dữ liệu từ bảng Products trong database

- Hiển thị danh sách sản phẩm gồm:

- Tên sản phẩm

- Hình ảnh

- Giá sản phẩm

### 4. Xây dựng trang chi tiết sản phẩm

- Tạo trang ProductDetail.aspx

- Khi người dùng chọn một sản phẩm, hệ thống hiển thị thông tin chi tiết của sản phẩm đó.

## Kết quả đạt được

- Website có thể hiển thị danh sách các loại cà phê.

- Người dùng có thể xem thông tin chi tiết của từng sản phẩm.

## Mục tiêu tuần 4

Tuần 4 tập trung vào việc xây dựng chức năng đặt hàng và quản lý giỏ hàng.

## Các chức năng đã thực hiện

### 1. Thiết kế bảng Orders

- Tạo bảng Orders để lưu thông tin đơn hàng của người dùng.

- Các trường chính:

- OrderID

- UserID

- OrderDate

### 2. Thiết kế bảng OrderDetails

- Tạo bảng OrderDetails để lưu chi tiết sản phẩm trong từng đơn hàng.

- Các trường chính:

- OrderDetailID

- OrderID

- ProductID

- Quantity

### 3. Xây dựng chức năng giỏ hàng

- Tạo trang Cart.aspx

- Cho phép người dùng:

- Thêm sản phẩm vào giỏ hàng

- Xem danh sách sản phẩm trong giỏ hàng

### 4. Lưu đơn hàng vào database

- Khi người dùng đặt hàng:

- Hệ thống tạo một bản ghi trong bảng Orders

- Lưu các sản phẩm trong bảng OrderDetails

## Kết quả đạt được

- Người dùng có thể chọn sản phẩm và thêm vào giỏ hàng.

- Hệ thống lưu thông tin đơn hàng vào cơ sở dữ liệu.

## Mục tiêu tuần 5

Tuần 5 tập trung vào việc hoàn thiện hệ thống và bổ sung chức năng quản lý đơn hàng.

## Các chức năng đã thực hiện

### 1. Xem đơn hàng của người dùng

- Tạo trang MyOrders.aspx

- Hiển thị danh sách đơn hàng mà người dùng đã đặt.

### 2. Xem chi tiết đơn hàng

- Tạo trang OrderDetails.aspx

- Hiển thị danh sách sản phẩm trong từng đơn hàng.

### 3. Quản lý đơn hàng cho Admin

- Tạo trang AdminOrders.aspx

- Cho phép quản trị viên xem danh sách tất cả các đơn hàng trong hệ thống.

### 4. Thống kê đơn hàng

- Tạo trang AdminStatistics.aspx

- Hiển thị số lượng đơn hàng và các thông tin thống kê cơ bản.

## Kết quả đạt được

- Người dùng có thể xem lịch sử đặt hàng của mình.

- Quản trị viên có thể quản lý và theo dõi các đơn hàng trong hệ thống.