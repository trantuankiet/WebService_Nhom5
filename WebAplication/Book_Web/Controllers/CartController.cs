using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book_Web.Models;
using System.ServiceModel;
namespace Book_Web.Controllers
{
    public class CartController : Controller
    {
        Book_Services.Book_ServiceClient sv;
        //
        // GET: /Cart/
        [HttpPost]
        public ActionResult ViewCart(int Masp, int soluong)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizSach sach = new Book_Services.BizSach
            {
                MaSach = Masp,
                SoLuong = soluong
            };
            Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
            if (pdh == null)
            {
                pdh = new Book_Services.BizPhieuDatHang();
            }
            int ketqua = sv.ThemGioHang(ref pdh,sach);
            if (ketqua == 0)
            {

                Session["thongbao"] = 3;
                return RedirectToAction("Index", "Product");
            }
            else if (ketqua == 1)
            {

                Session.Add("GioHang", pdh);
                return RedirectToAction("Index", "Product", new {id = 1});
            }
            else if (ketqua == 2)
            {

                Session["thongbao"] = 4;
                return RedirectToAction("Index", "Product");
            }
            else
            {

                Session["thongbao"] = 5;
                return RedirectToAction("Index", "Product");
            }
        }
        public ActionResult ViewCart()
        {
            ViewBag.Co = Session["thongbao"];
            Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
            if (pdh.ChiTietDonHangs.Count > 0)
            {
                ViewData.Model = pdh.ChiTietDonHangs;
                return View();

            }
            else
            {
                Session["thongbao"] = 6;
                return RedirectToAction("Index", "Product");
            }

        }
        public ActionResult ErrorCart()
        {
            return View();
        }
        public ActionResult ErrorQuantity()
        {
            return View();
        }
        public ActionResult AddCart(int id)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizSach sach = new Book_Services.BizSach
            {
                MaSach = id,
                SoLuong = 1
            };
            Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
            if (pdh == null)
            {
                pdh = new Book_Services.BizPhieuDatHang();
            }
            int ketqua = sv.ThemGioHang(ref pdh, sach);
            if (ketqua == 0)
            {
                Session["thongbao"] = 3;
                return RedirectToAction("Index", "Product");
            }
            else if (ketqua == 1)
            {
                Session.Add("GioHang", pdh);
                return RedirectToAction("Index", "Product", new { id = 1 });
            }
            else if (ketqua == 2)
            {

                Session["thongbao"] = 4;
                return RedirectToAction("Index", "Product");
            }
            else
            {

                Session["thongbao"] = 5;
                return RedirectToAction("Index", "Product");
            }
        }
        [HttpGet]
        public ActionResult Checkout()
        {
            if (Request.IsAuthenticated)
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
                pdh.NguoiDung = sv.LayThongTinND(User.Identity.Name);
                ViewBag.Tongtien = sv.TinhTongTienPhieuDatHang(pdh);
                ViewData.Model = CartModel.ChuyenDoiPDH(pdh);
                return View();
            }
            else
            {
                return RedirectToAction("Signup", "Account");
            }
        
        }
        [HttpPost]
        public ActionResult Checkout(CartModel PDH)
        {
            sv = new Book_Services.Book_ServiceClient();
            
            if (ModelState.IsValid)
            {
                Book_Services.BizPhieuDatHang pdh = PDH.ChuyenDoiPDHThem((Book_Services.BizPhieuDatHang)Session["GioHang"]);
                pdh.ChiTietDonHangs = pdh.ChiTietDonHangs;
                pdh.NguoiDung = sv.LayThongTinND(User.Identity.Name);
                sv.ThemPDH(pdh);
                sv.GuiMail_ThanhToan(pdh);
                Session["GioHang"] = null;
                return RedirectToAction("CheckoutThanhCong");
            }
            else
            {
                Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
                PDH.ChiTietDonHangs = pdh.ChiTietDonHangs;
                ViewBag.Tongtien = sv.TinhTongTienPhieuDatHang(pdh);
                return View(PDH);
            }
        }
        public ActionResult CheckoutThanhCong()
        {
            return View();
        }
        public ActionResult ErrorLogin()
        {
            return View();
        }
        public ActionResult HistoryCart()
        {
            if (Request.IsAuthenticated)
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNguoiDung nd = new Book_Services.BizNguoiDung
                {
                    TenDN = User.Identity.Name
                };
                ViewData.Model = sv.LayListPDHND(nd);

                return View();
            }
            else
            {
                return RedirectToAction("Signup", "Account");
            }
        }
        public ActionResult HistoryDetail(int MaPDH)
        {
            if (Request.IsAuthenticated)
            {

                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizPhieuDatHang pdh = sv.LayPDH(MaPDH);
                ViewBag.Tongtien = sv.TinhTongTienPhieuDatHang(pdh);

                ViewData.Model = pdh;
                return View();
            }
            else
            {
                return RedirectToAction("Signup", "Account");
            }
        }

        public ActionResult DeleteCart(int masp)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizSach sach = new Book_Services.BizSach
            {
                MaSach = masp,
            };
            Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
            sv.XoaGioHang(ref pdh, sach);

            Session.Add("GioHang", pdh);
            return RedirectToAction("ViewCart");
        }
         [HttpPost]
         public ActionResult EditCart(int masp, int soluong)
         {
             if (soluong <= 5)
             {
                 sv = new Book_Services.Book_ServiceClient();
                 Book_Services.BizSach sach = new Book_Services.BizSach
                 {
                     MaSach = masp,
                     SoLuong = soluong
                 };
                 if (sv.KiemTraTonKho(sach) == true)
                 {
                     Book_Services.BizPhieuDatHang pdh = (Book_Services.BizPhieuDatHang)Session["GioHang"];
                     sv.CapNhatGioHang(ref pdh, sach);

                     Session.Add("GioHang", pdh);
                     return RedirectToAction("ViewCart");
                 }
                 else
                 {
                     Session["thongbao"] = 0;
                     return RedirectToAction("ViewCart");

                 }
             }
             else
             {
                 Session["thongbao"] = 1;
                 return RedirectToAction("ViewCart");

             }
         }

    }
}
