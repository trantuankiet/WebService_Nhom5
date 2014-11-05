using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalKhuyenMai
    {
        static DbWSDataContext db;
        public static List<BizKhuyenMai> getList()
        {
            db = new DbWSDataContext();
            List<BizKhuyenMai> list = (from p in db.KhuyenMais
                                     select new BizKhuyenMai
                                     {
                                         MaKM = p.MaKM,
                                         TenKM = p.TenKM,
                                         GiaTriGiam = p.GiaTriGiam,
                                         NgayApDung = p.NgayApDung,
                                         NgayHetHan = p.NgayHetHan
                                     }).ToList<BizKhuyenMai>();
            return list;
        }
        public static void insert(BizKhuyenMai km)
        {
            db = new DbWSDataContext();
            KhuyenMai kmai = new KhuyenMai();
            kmai.TenKM = km.TenKM;
            kmai.GiaTriGiam = km.GiaTriGiam;
            kmai.NgayApDung = km.NgayApDung;
            kmai.NgayHetHan = km.NgayHetHan;
            db.KhuyenMais.InsertOnSubmit(kmai);
            db.SubmitChanges();
        }
        public static void delete(BizKhuyenMai km)
        {
            db = new DbWSDataContext();
            KhuyenMai khuyenmai = (from p in db.KhuyenMais
                            where p.MaKM==km.MaKM
                            select p).FirstOrDefault<KhuyenMai>();
            db.KhuyenMais.DeleteOnSubmit(khuyenmai);
            db.SubmitChanges();
        }
        public static void edit(BizKhuyenMai km)
        {
            db = new DbWSDataContext();
            KhuyenMai kmai = (from p in db.KhuyenMais
                                   where p.MaKM == km.MaKM
                                   select p).FirstOrDefault<KhuyenMai>();
            kmai.TenKM = km.TenKM;
            kmai.GiaTriGiam = km.GiaTriGiam;
            kmai.NgayApDung = km.NgayApDung;
            kmai.NgayHetHan = km.NgayHetHan;
            db.SubmitChanges();
        }
    }
}
