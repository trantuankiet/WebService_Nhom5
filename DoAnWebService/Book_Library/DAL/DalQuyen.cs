using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalQuyen
    {
        static DbWSDataContext db;
        public static List<BizQuyen> getList()
        {
            db = new DbWSDataContext();
            List<BizQuyen> list = (from q in db.Quyens
                                   select new BizQuyen
                                   {
                                       MaQuyen = q.MaQuyen,
                                       TenQuyen = q.TenQuyen,
                                       TrangThai = q.Trangthai
                                   }).ToList<BizQuyen>();
            return list;
        }
        public static void insert(BizQuyen q)
        {
            db = new DbWSDataContext();
            Quyen quyen = new Quyen();
            quyen.TenQuyen = q.TenQuyen;
            quyen.Trangthai = q.TrangThai;
            db.Quyens.InsertOnSubmit(quyen);
            db.SubmitChanges();
        }
        public static void delete(BizQuyen q)
        {
            db = new DbWSDataContext();
            var quyen = (from item in db.Quyens
                         where item.MaQuyen == q.MaQuyen
                         select item).FirstOrDefault();
            quyen.Trangthai = false;
            db.SubmitChanges();
        }
        public static void edit(BizQuyen q)
        {
            db = new DbWSDataContext();
            var quyen = (from item in db.Quyens
                         where item.MaQuyen == q.MaQuyen
                         select item).FirstOrDefault();
            quyen.TenQuyen = q.TenQuyen;
            db.SubmitChanges();
        }

    }
}
