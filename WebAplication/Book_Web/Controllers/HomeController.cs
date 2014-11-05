using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.ServiceModel;
using Valentica.Libraries;
namespace Book_Web.Controllers
{
    public class HomeController : Controller
    {
        Book_Services.Book_ServiceClient sv;
        //
        // GET: /Home/

        public ActionResult Index()
        {
            sv = new Book_Services.Book_ServiceClient();
            sv.CapNhatKhuyenMai();
            List<Book_Services.BizSach> ListSach = sv.LayDSMoiNhat();
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
            if (ListSach.Count / 6 < page -1)
            {
                return RedirectToAction("Index", new {id = 1});
            }
            int totalBooks = ListSach.Count;
            Pagination pagination = new Pagination(true);
            pagination.BaseUrl = "/TrangChu/";
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
            ViewData.Model = sv.phantrangsach(start,offset,ListSach);
            return View();
        }
    }
}
