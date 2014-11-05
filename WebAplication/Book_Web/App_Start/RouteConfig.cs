using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Book_Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Đăng Ký
            routes.MapRoute(
              "DangKy", // Route name
              "DangKy/{id}", // URL with parameters
              new { controller = "Account", action = "Signup", id = UrlParameter.Optional } // Parameter defaults
              );

            // Thêm 1 Sản Phẩm gio Hàng
            routes.MapRoute(
             "Them1SPGioHang", // Route name
             "ThemSanPhamGH/{id}", // URL with parameters
             new { controller = "Cart", action = "AddCart", id = UrlParameter.Optional } // Parameter defaults
             );
            // Xóa gio Hàng
            routes.MapRoute(
             "XoaGioHang", // Route name
             "XoaSPGH/{id}", // URL with parameters
             new { controller = "Cart", action = "DeleteCart", id = UrlParameter.Optional } // Parameter defaults
             );
            
            //Chi tiết giỏ Hàng
            routes.MapRoute(
             "ChiTietGioHang", // Route name
             "ChiTietLichSuGioHang/{MaPDH}", // URL with parameters
             new { controller = "Cart", action = "HistoryDetail", MaPDH = UrlParameter.Optional } // Parameter defaults
             );
           
            // Lich Sử gio Hàng
            routes.MapRoute(
             "ListSuGioHang", // Route name
             "LichSuGioHang/", // URL with parameters
             new { controller = "Cart", action = "HistoryCart"} // Parameter defaults
             );
            // Thanh Toan gio Hàng
            routes.MapRoute(
             "ThanhToanGioHang", // Route name
             "ThanhToanGioHang/", // URL with parameters
             new { controller = "Cart", action = "CheckOut" } // Parameter defaults
             );
            // Xem gio Hàng
            routes.MapRoute(
             "XemGioHang", // Route name
             "XemGioHang/", // URL with parameters
             new { controller = "Cart", action = "ViewCart" } // Parameter defaults
             );
            // Tim Kiem Sản Phẩm Nâng cao phân trang
            routes.MapRoute(
             "SanPhamTKNCPT", // Route name
             "KetQuaTimKiemNangCao/{tensach}/{matheloai}/{giatu}/{giaden}/{page}", // URL with parameters
             new { controller = "Product", action = "ResultAdvanced", tensach = UrlParameter.Optional, matheloai = UrlParameter.Optional, giatu = UrlParameter.Optional, giaden = UrlParameter.Optional, page = UrlParameter.Optional } // Parameter defaults
             );
            // Tim Kiem Sản Phẩm Nang Cao
            routes.MapRoute(
             "SanPhamTKNK", // Route name
             "KeyQuaTimKiemNangCao/{tensach}/{matheloai}/{giatu}/{giaden}/", // URL with parameters
             new { controller = "Product", action = "ResultAdvanced", tensach = UrlParameter.Optional, matheloai = UrlParameter.Optional, giatu = UrlParameter.Optional, giaden = UrlParameter.Optional } // Parameter defaults
             );
        
            // Tim Kiem Sản Phẩm Nâng cao phân trang
            routes.MapRoute(
             "SanPhamTKNCPT2", // Route name
             "KetQuaTimKiemNangCao2/{matheloai}/{giatu}/{giaden}/{page}", // URL with parameters
             new { controller = "Product", action = "ResultAdvanced2", matheloai = UrlParameter.Optional, giatu = UrlParameter.Optional, giaden = UrlParameter.Optional, page = UrlParameter.Optional } // Parameter defaults
             );
            // Tim Kiem Sản Phẩm Nang Cao
            routes.MapRoute(
             "SanPhamTKNK2", // Route name
             "KeyQuaTimKiemNangCao2/{matheloai}/{giatu}/{giaden}/", // URL with parameters
             new { controller = "Product", action = "ResultAdvanced2", matheloai = UrlParameter.Optional, giatu = UrlParameter.Optional, giaden = UrlParameter.Optional } // Parameter defaults
             );
  
            // Giao dien tim kiem nang cao
            routes.MapRoute(
             "GiaoDienTKNC", // Route name
             "TimKiemNangCao/", // URL with parameters
             new { controller = "Product", action = "SearchAdvanced" } // Parameter defaults
             );
            
            // Tim Kiem Sản Phẩm Phân Trang
            routes.MapRoute(
             "SanPhamTKPT", // Route name
             "KetQuaTimKiem/{keyword}/{page}", // URL with parameters
             new { controller = "Product", action = "Result", keyword = UrlParameter.Optional, page = UrlParameter.Optional } // Parameter defaults
             );
            // Tim Kiem Sản Phẩm
            routes.MapRoute(
             "SanPhamTK", // Route name
             "KeyQuaTimKiem/{keyword}", // URL with parameters
             new { controller = "Product", action = "Result", keyword = UrlParameter.Optional } // Parameter defaults
             );
            // Chi Tiết Sản Phẩm
            routes.MapRoute(
             "SanPhamCT", // Route name
             "ChiTietSanPham/{id}", // URL with parameters
             new { controller = "Product", action = "Detail", id = UrlParameter.Optional } // Parameter defaults
             );
            // Danh Muc Sản Phẩm Phân Trang
            routes.MapRoute(
             "SanPhamDMPT", // Route name
             "DanhMuc/{id}/{page}", // URL with parameters
             new { controller = "Product", action = "Category", id = UrlParameter.Optional, page = UrlParameter.Optional } // Parameter defaults
             );

            // Danh Muc Sản Phẩm
            routes.MapRoute(
             "SanPhamDM", // Route name
             "DanhMuc/{id}", // URL with parameters
             new { controller = "Product", action = "Category", id = UrlParameter.Optional } // Parameter defaults
             );
            // Danh Sach Sản Phẩm Phân Trang
            routes.MapRoute(
             "SanPhamPT", // Route name
             "DSSanPham/{id}", // URL with parameters
             new { controller = "Product", action = "Index", id = UrlParameter.Optional } // Parameter defaults
             );
            // Danh Sach Sản Phẩm
            routes.MapRoute(
            "SanPham", // Route name
            "DSSanPham/", // URL with parameters
            new { controller = "Product", action = "Index" } // Parameter defaults
            );
            // Trang Chủ Phân Trang
            routes.MapRoute(
            "TrangChuPT", // Route name
            "TrangChu/{id}", // URL with parameters
            new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );
            // Trang Chủ
            routes.MapRoute(
            "TrangChu", // Route name
            "TrangChu/", // URL with parameters
            new { controller = "Home", action = "Index" } // Parameter defaults
            );
            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }
    }
}