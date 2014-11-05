using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Valentica.Libraries;
using System.ServiceModel;
using Book_Web.Models;
namespace Book_Web.Controllers
{
    public class ProductController : Controller
    {
        Book_Services.Book_ServiceClient sv;
        //
        // GET: /Product/

        public ActionResult Index()
        {
            sv = new Book_Services.Book_ServiceClient();
            ViewBag.Co = Session["thongbao"];
        
            List<Book_Services.BizSach> ListSach = sv.LayListSach();
            string request = "";
            try
            {
                request = Request.Url.Segments[2];
            }
            catch (Exception)
            {
                request = null;
            }
            int page = (String.IsNullOrEmpty(request)) ? 1 : Int32.Parse(request);
            if (ListSach.Count / 6 < page - 1)
            {
                return RedirectToAction("Index", new { id = 1 });
            }
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
            pagination.BaseUrl = "/DSSanPham/";
            pagination.TotalRows = totalBooks;
            pagination.CurPage = page;
            pagination.PerPage = 6;
            pagination.LastLink = "Cuối";
            pagination.PrevLink = "Trước";
            pagination.NextLink = "Sau";
            pagination.FirstLink = "Đầu";
            int start = (page - 1) * pagination.PerPage;
            int offset = pagination.PerPage;
            string pageLinks = pagination.GetPageLinks();
            ViewBag.totalBooks = ListSach.Count;
            ViewBag.Pagelink = pageLinks;
            return View(sv.phantrangsach(start, offset, ListSach));
        }
        public ActionResult Detail(int id)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizSach sach = new Book_Services.BizSach
            {
                MaSach = id
            };
            return View(sv.LaySPByID(sach));
        }
        public ActionResult Category(int id)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizTheLoai TL = new Book_Services.BizTheLoai
            {
                MaTL = id
            };
            List<Book_Services.BizSach> ListSach = sv.LayListTheoDM(TL);
            string request = "";
            try
            {
                request = Request.Url.Segments[3];
            }
            catch (Exception)
            {
                request = null;
            }
            int page = (String.IsNullOrEmpty(request)) ? 1 : Int32.Parse(request);
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
            pagination.BaseUrl = "/DanhMuc/"+id.ToString()+"/";
            pagination.TotalRows = totalBooks;
            pagination.CurPage = page;
            pagination.PerPage = 6;
            pagination.LastLink = "Cuối";
            pagination.PrevLink = "Trước";
            pagination.NextLink = "Sau";
            pagination.FirstLink = "Đầu";
            int start = (page - 1) * pagination.PerPage;
            int offset = pagination.PerPage;
            string pageLinks = pagination.GetPageLinks();
            ViewBag.totalBooks = ListSach.Count;
            ViewBag.Pagelink = pageLinks;
            return View(sv.phantrangsach(start, offset, ListSach));
        }
        [HttpPost]
        public ActionResult Search(string keyword)
        {
            return RedirectToAction("Result", "Product", new {keyword = keyword });
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult Result(string keyword)
        {
            sv = new Book_Services.Book_ServiceClient();
            List<Book_Services.BizSach> ListSach = sv.LayListKeyWord(keyword);
            string request = "";
            try
            {
                request = Request.Url.Segments[3];
            }
            catch (Exception)
            {
                request = null;
            }
            int page = (String.IsNullOrEmpty(request)) ? 1 : Int32.Parse(request);
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
            pagination.BaseUrl = "/KetQuaTimKiem/" + keyword + "/";
            pagination.TotalRows = totalBooks;
            pagination.CurPage = page;
            pagination.PerPage = 6;
            pagination.LastLink = "Cuối";
            pagination.PrevLink = "Trước";
            pagination.NextLink = "Sau";
            pagination.FirstLink = "Đầu";
            int start = (page - 1) * pagination.PerPage;
            int offset = pagination.PerPage;
            string pageLinks = pagination.GetPageLinks();
            ViewBag.totalBooks = ListSach.Count;
            ViewBag.Pagelink = pageLinks;
            return View(sv.phantrangsach(start, offset, ListSach));
        }
        [HttpPost]
        public ActionResult SearchAdvanced(SearchAdvancedModel dt)
        {
            if (dt.Tensach != null)
            {
                return RedirectToAction("ResultAdvanced", "Product", new { tensach = dt.Tensach, matheloai = dt.MaTheLoai, giatu = dt.GiaTu, giaden = dt.GiaDen });
            }
            else
            {
                return RedirectToAction("ResultAdvanced2", "Product", new { matheloai = dt.MaTheLoai, giatu = dt.GiaTu, giaden = dt.GiaDen });
            
            }
        
        }
        [HttpGet]
        public ActionResult SearchAdvanced()
        {
            SearchAdvancedModel model = new SearchAdvancedModel();
            sv = new Book_Services.Book_ServiceClient();
            List<SelectListItem> list = new List<SelectListItem>();
            List<Book_Services.BizTheLoai> ListTL = sv.ListTheLoai();
            Book_Services.BizTheLoai tl = new Book_Services.BizTheLoai { MaTL = 0, TenDM ="Tất cả" };
            ListTL.Insert(0, tl);
            foreach (Book_Services.BizTheLoai item in ListTL)
            {
                list.Add(new SelectListItem { Text = item.TenDM.ToString(),Value = item.MaTL.ToString() });
            }
            model.ListTheLoai = new SelectList(list,"Value","Text");
            return View(model);
        }
        [HttpGet]
        public ActionResult ResultAdvanced(string tensach,int matheloai,decimal giatu,decimal giaden)
        {
            sv = new Book_Services.Book_ServiceClient();
            List<Book_Services.BizSach> ListSach = sv.LayListTimKiemNangCao(tensach,matheloai,giatu,giaden);
            string request = "";
            try
            {
                
                    request = Request.Url.Segments[6];
                
            }
            catch (Exception)
            {
                request = null;
            }
            int page = (String.IsNullOrEmpty(request)) ? 1 : Int32.Parse(request);
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
            
                pagination.BaseUrl = "/KetQuaTimKiemNangCao/" + tensach + "/" + matheloai.ToString() + "/" + giatu.ToString() + "/" + giaden.ToString() + "/";
           
            pagination.TotalRows = totalBooks;
            pagination.CurPage = page;
            pagination.PerPage = 6;
            pagination.LastLink = "Cuối";
            pagination.PrevLink = "Trước";
            pagination.NextLink = "Sau";
            pagination.FirstLink = "Đầu";
            int start = (page - 1) * pagination.PerPage;
            int offset = pagination.PerPage;
            string pageLinks = pagination.GetPageLinks();
            ViewBag.totalBooks = ListSach.Count;
            ViewBag.Pagelink = pageLinks;
            return View(sv.phantrangsach(start, offset, ListSach));

        }
        [HttpGet]
        public ActionResult ResultAdvanced2(int matheloai, decimal giatu, decimal giaden)
        {
            sv = new Book_Services.Book_ServiceClient();
            List<Book_Services.BizSach> ListSach = sv.LayListTimKiemNangCao(null, matheloai, giatu, giaden);
            string request = "";
            try
            {
               
                request = Request.Url.Segments[5];

                
            }
            catch (Exception)
            {
                request = null;
            }
            int page = (String.IsNullOrEmpty(request)) ? 1 : Int32.Parse(request);
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
                pagination.BaseUrl = "/KetQuaTimKiemNangCao2/" + matheloai.ToString() + "/" + giatu.ToString() + "/" + giaden.ToString() + "/";

            pagination.TotalRows = totalBooks;
            pagination.CurPage = page;
            pagination.PerPage = 6;
            pagination.LastLink = "Cuối";
            pagination.PrevLink = "Trước";
            pagination.NextLink = "Sau";
            pagination.FirstLink = "Đầu";
            int start = (page - 1) * pagination.PerPage;
            int offset = pagination.PerPage;
            string pageLinks = pagination.GetPageLinks();
            ViewBag.totalBooks = ListSach.Count;
            ViewBag.Pagelink = pageLinks;
            return View("ResultAdvanced", sv.phantrangsach(start, offset, ListSach));

        }
    }
}
