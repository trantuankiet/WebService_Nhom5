using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Book_Web.Models;
using System.ServiceModel;
namespace Book_Web.Controllers
{
    public class AccountController : Controller
    {
        Book_Services.Book_ServiceClient sv;
        //
        
        [HttpPost]
        public ActionResult Login(string TenDN,string Pass)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizNguoiDung nd = new Book_Services.BizNguoiDung
            {
                TenDN = TenDN,
                MatKhau = sv.Mahoa(Pass)
            };
            int Co = sv.KTraDN(nd);
            Session["thongbao"] = Co;
            if (Co == 0)
            {
                FormsAuthentication.SetAuthCookie(nd.TenDN, false);
                return RedirectToAction("Index", "Product");
            }
            else if (Co == 2)
            {
               
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return RedirectToAction("Index","Product");
            }
        }
        
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index","Product");
        }
        [HttpGet]
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Signup(SignupModel nguoidung)
        {
            if (ModelState.IsValid)
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNguoiDung nd = nguoidung.ChuyenDoiND();
                if (sv.KTraTonTai(nd) == 0)
                {
                    sv.InsertND(nd);
                    nd.MatKhau = nguoidung.MatKhau;
                    sv.GuiMail_DangKyND(nd);
                    FormsAuthentication.SetAuthCookie(nd.TenDN, false);
                    return RedirectToAction("Index", "Product");

                }
                else if (sv.KTraTonTai(nd) == 1)
                {
                    ViewBag.Co = 1;
                    return View();
                }
                else
                {
                    ViewBag.Co = 2;
                    return View();
                }
            }
            else
            {
                return View(nguoidung);
            }
        }
        [HttpPost]
        public ActionResult EditAccount(EditAccountModel nd)
        {
            if(ModelState.IsValid)
            {
                sv = new Book_Services.Book_ServiceClient();
                if (!sv.KtraEmailND(nd.Email, nd.TenDN))
                {
                    nd.TenDN = User.Identity.Name;
                    sv.EditND(nd.ChuyenDoiND());
                    Session["thongbao"] = 6;
                    return RedirectToAction("Product", "Index");
                }
                else
                {
                    ViewBag.Co = 0;
                
                    return View(nd);
                }
              
            }
            else
              return View(nd);
        }
        [HttpGet]
        public ActionResult EditAccount()
        {
            if (Request.IsAuthenticated)
            {
                sv = new Book_Services.Book_ServiceClient();
                return View(EditAccountModel.ChuyendoiModel(sv.LayThongTinND(User.Identity.Name)));
            }
            else
            {
                return RedirectToAction("Signup");
            }
        }
        [HttpPost]
        public ActionResult ChangePass(ChangePassModel nd)
        {
            if (ModelState.IsValid)
            {
                sv = new Book_Services.Book_ServiceClient();
                nd.TenDN = User.Identity.Name;
                if (!sv.KtraMatkhau(nd.TenDN, sv.Mahoa(nd.MatKhau)))
                {
                    sv.EditMKND(nd.ChuyenDoiND());
                    Session["thongbao"] = 7;
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ViewBag.Co = 0;
                
                    return View(nd);
                }

            }
            else
                return View(nd);
        }
        [HttpGet]
        public ActionResult ChangePass()
        {
            if (Request.IsAuthenticated)
            {
                sv = new Book_Services.Book_ServiceClient();
                return View(ChangePassModel.ChuyendoiModel(sv.LayThongTinND(User.Identity.Name)));
            }
            else
            {
                return RedirectToAction("Signup");
            }
        }
        [HttpPost]
        public ActionResult ForgotPass(ForgotPassModel nd)
        {
            if (ModelState.IsValid)
            {
                sv = new Book_Services.Book_ServiceClient();
                if (sv.KtraEmail(nd.Email))
                {
                    Book_Services.BizNguoiDung nguoidung = sv.LayThongTinNDEmail(nd.Email);
                    string luulai = sv.Matkhaungaunhien();
                    nguoidung.MatKhau = sv.Mahoa(luulai);
                    sv.EditMKND(nguoidung);
                    nguoidung.MatKhau = luulai;
                    sv.GuiMail_CapLaiMatKhau(nguoidung);
                    Session["thongbao"] = 8;
                    return RedirectToAction("Index", "Product");


                }
                else
                {
                    ViewBag.Co = 0;
                    return View(nd);
                }
            }
            else
            {
                return View(nd);
            }
        }
        [HttpGet]
        public ActionResult ForgotPass()
        {
            if (!Request.IsAuthenticated)
            {
                return View();
            }
            else
                return RedirectToAction("Index", "Product");

        }
    }
}
