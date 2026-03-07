# Progress Report – Tuần 3

## 1. Mục tiêu

Xây dựng chức năng hiển thị sản phẩm từ cơ sở dữ liệu lên website.

## 2. Công việc đã thực hiện

### Thiết kế cơ sở dữ liệu

Tạo bảng Products trong SQL Server để lưu thông tin sản phẩm cà phê.

Các trường của bảng gồm:

* ProductID
* Name
* Price
* Image
* Description

### Kết nối ASP.NET với SQL Server

Cấu hình chuỗi kết nối trong file Web.config để website có thể truy cập dữ liệu từ database.

### Xây dựng trang hiển thị sản phẩm

Tạo trang:

* Products.aspx

Trang này có chức năng:

* Lấy dữ liệu từ bảng Products
* Hiển thị danh sách sản phẩm gồm:

  * Tên sản phẩm
  * Giá
  * Hình ảnh

### Xây dựng trang chi tiết sản phẩm

Tạo trang:

* ProductDetail.aspx

Cho phép người dùng xem thông tin chi tiết của từng sản phẩm.

## 3. Kết quả đạt được

* Website có thể kết nối database thành công.
* Danh sách sản phẩm được hiển thị trên giao diện web.

## 4. Commit GitHub

Các file đã được commit lên repository:

* Products.aspx
* ProductDetail.aspx
* cập nhật README.md
* cập nhật cấu hình Web.config
