using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalTheLoai
    {
        static DbWSDataContext db;
        public static List<BizTheLoai> getList()
        {
            db = new DbWSDataContext();
            List<BizTheLoai> list = (from p in db.TheLoais
                                     select new BizTheLoai
                                     {
                                         MaTL = p.MaTL,
                                         TenDM = p.TenDM,
                                         TrangThai = p.Trangthai,
                                     }).ToList<BizTheLoai>();
            return list;
        }
        public static void insert(BizTheLoai tl)
        {
            db = new DbWSDataContext();
            TheLoai loai = new TheLoai();
            loai.TenDM = tl.TenDM;
            loai.Trangthai = tl.TrangThai;
            db.TheLoais.InsertOnSubmit(loai);
            db.SubmitChanges();
        }
        public static void delete(BizTheLoai tl)
        {
            db = new DbWSDataContext();
            var theloai = (from p in db.TheLoais
                           where p.MaTL == tl.MaTL
                           select p).FirstOrDefault();
            theloai.Trangthai = false;
            db.SubmitChanges();
        }
        public static void edit(BizTheLoai tl)
        {
            db = new DbWSDataContext();
            var theloai = (from p in db.TheLoais
                           where p.MaTL == tl.MaTL
                           select p).FirstOrDefault();
            theloai.TenDM = tl.TenDM;
            db.SubmitChanges();
        }
        public static void KichHoat(BizTheLoai tl)
        {
            db = new DbWSDataContext();
            var theloai = (from p in db.TheLoais
                           where p.MaTL == tl.MaTL
                           select p).FirstOrDefault();
            theloai.Trangthai = true;
            db.SubmitChanges();
        }
    }
}
