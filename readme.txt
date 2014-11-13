DỊCH VỤ WEB VÀ ỨNG DỤNG
1.GIỚI THIỆU
	Website bán sách trực tuyến, sử dụng winform để quản lý và kết nối Web service.
2.KIẾN TRÚC
	2.1.WCFService
	2.2.Web ASP.NET
	2.3.WinForm

3.THIẾT KẾ, CHỨC NĂNG
	3.1.WCFService
	3.2.WEB ASP.NET
		3.2.1 Thiết kế
			Website được viết bằng ASP.NET theo mô hình MVC, dùng để xử lý thao tác người dùng online.
		3.2.2 Chức năng
			3.2.2.1 Sản phẩm
				3.2.2.1.1 Hiển thị sản phẩm 
					Tác giả
					Nội dung
					Hình ảnh
					Giá
					Chi tiết sản phẩm
				3.2.2.1.2 Hiển thị sản phẩm theo danh mục
					Kinh tế
					Văn hóa - Nghệ thuật
					Văn học
					…
				3.2.2.1.3 Tìm kiếm
					Tìm kiếm tên sản phẩm
					*Hiển thị gợi nhắc tên sản phẩm
				3.2.2.1.4 Tìm kiếm nâng cao
					Tìm kiếm theo tên sách
					Tìm kiếm theo thể loại
					Tìm kiếm theo giá (giá từ - giá đến)
				3.2.2.1.5 Quản lý tồn kho
				3.2.2.1.6 Phân trang
			3.2.2.2 Khách hàng
				3.2.2.2.1 Quản lý giỏ hàng
					3.2.2.2.1.1 Thêm giỏ hàng
					3.2.2.2.1.2 Sửa số lượng
					3.2.2.2.1.3 Xóa sản phẩm khỏi giỏ hàng
					3.2.2.2.1.4 Thanh toán
						*Yêu cầu đăng nhập khi thanh toán
				3.2.2.2.2 Đăng ký
					*Có kiểm tra tính hợp lệ số điện thoại, email, cho phép chọn ngày sinh (html5)
				3.2.2.2.3 Đăng nhập
				3.2.2.2.4 Quản lý khách hàng
					3.2.2.2.4.1 Xem lịch sử đơn hàng
					3.2.2.2.4.2 Thay đổi mật khẩu
					3.2.2.2.4.3 Thay đổi thông tin cá nhân
			3.2.2.3 Hỗ trợ khách hàng
				Hỗ trợ trực tuyến: sử dụng tài khoản yahoo

	3.3.WINFORM
		3.3.1.Thiết kế
			Dùng để quản lý nhân viên, quản lý sản phẩm và thống kê báo cáo. Theo nghiệp vụ bán hàng thì có 2 hình thức : Online và Offline. 
			-Online : User đặt hàng => admin, nv duyệt đơn hàng => chuyển cho NV vận chuyển => admin, nv duyệt phiếu vận chuyển.
			-Offline : User đặt hàng và giao hàng tại chỗ.
		3.3.2.Chức năng chính
			3.3.2.1.Đăng nhập, đăng xuất
			3.3.2.2.Quản lý người dùng ( Đối với quyền admin )
				-Xóa
			3.3.2.3.Quản lý nhân viên ( Đối với quyền admin )
				a.Thêm
				b.Sửa
				c.Xóa
			3.3.2.4.Phân quyền ( Đối với quyền admin )
				a.Thêm
				b.Sửa
				c.Xóa
			3.3.2.5.Quản lý sách
				a.Thêm
				b.Sửa
				c.Xóa
				d.Kích hoạt
			3.3.2.6.Quản lý thể loại
				a.Thêm
				b.Sửa
				c.Xóa
			3.3.2.7.Quản lý khuyến mãi
				a.Thêm
				b.Sửa 
				c.Xóa
			3.3.2.8.Quản lý phiếu nhập kho ( PNK )
				a.Thêm PNK, Thêm chi tiết PNK
				b.Sửa PNK, Sửa chi tiết PNK
				c.Xóa PNK, Xóa chi tiết PNK
			3.3.2.9.Quản lý đặt hàng ( Offline )
				a.Thêm
				b.Sửa
				c.Xóa
			3.3.2.10.Quản lý duyệt phiếu đặt hàng ( Online )
				a.Lưu PDH
				b.Xóa PDH
			3.3.2.11.Quản lý lập phiếu vận chuyển
			3.3.2.12.Quản lý duyệt phiếu vận chuyển
				a.Duyệt tất cả
				b.Duyệt tùy chọn từng sản phẩm
				c.Hủy tất cả
			3.3.2.13.	Thống kê, báo cáo
				a.Thống kê tồn kho
				b.Thống kê theo số lượng
				c.Thống kê số lượng bán ra

4.CÁCH CÀI ĐẶT, CẤU HÌNH
	-Cài file DXperience-12.1.4.exe
	-Cài file Crack DevExpress.Registration.Setup.v12.1.4.msi
	-Import Database DbWS ( file DbWS.sql )
	-Cấu hình file App.Config và file Web.Config theo SQL Server

5.OTHER
	Nhóm 5:
		Nguyễn Thiện Khánh – 3110410059
		Trần Tuấn Kiệt – 3110410066
		Trương Hoàng Ẩn - 3110410007
