# Progress Report – Tuần 4

## 1. Mục tiêu

Xây dựng chức năng đặt hàng và quản lý giỏ hàng cho website.

## 2. Công việc đã thực hiện

### Thiết kế bảng Orders

Tạo bảng Orders để lưu thông tin đơn hàng.

Các trường gồm:

* OrderID
* UserID
* OrderDate

### Thiết kế bảng OrderDetails

Tạo bảng OrderDetails để lưu chi tiết sản phẩm trong từng đơn hàng.

Các trường gồm:

* OrderDetailID
* OrderID
* ProductID
* Quantity

### Xây dựng chức năng giỏ hàng

Tạo trang:

* Cart.aspx

Chức năng của trang:

* Hiển thị sản phẩm đã thêm vào giỏ hàng
* Cho phép người dùng kiểm tra lại sản phẩm trước khi đặt hàng

### Lưu đơn hàng vào database

Khi người dùng đặt hàng:

* Hệ thống tạo bản ghi trong bảng Orders
* Các sản phẩm trong đơn hàng được lưu vào bảng OrderDetails

## 3. Kết quả đạt được

* Người dùng có thể thêm sản phẩm vào giỏ hàng.
* Hệ thống có thể lưu đơn hàng vào cơ sở dữ liệu.

## 4. Commit GitHub

Các file được cập nhật:

* Cart.aspx
* Orders.aspx
* OrderDetails.aspx
* cập nhật README.md
