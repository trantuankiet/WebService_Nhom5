using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalNguoiDung
    {
        static DbWSDataContext db;
        public static List<BizNguoiDung> getList()
        {
            db = new DbWSDataContext();
            List<BizNguoiDung> list = (from item in db.NguoiDungs
                                       select new BizNguoiDung
                                       {
                                           TenDN = item.TenDN,
                                           MatKhau = item.MatKhau,
                                           HoTen = item.HoTen,
                                           DiaChi = item.DiaChi,
                                           Email = item.Email,
                                           Sdt = item.SDT,
                                           NgaySinh = item.NgaySinh,
                                           TrangThai = item.Trangthai
                                       }).ToList<BizNguoiDung>();
            return list;
        }
        public static void insert(BizNguoiDung biznd)
        {
            db = new DbWSDataContext();
            NguoiDung nd = new NguoiDung();
            nd.TenDN = biznd.TenDN;
            nd.MatKhau = biznd.MatKhau;
            nd.HoTen = biznd.HoTen;
            nd.DiaChi = biznd.DiaChi;
            nd.Email = biznd.Email;
            nd.SDT = biznd.Sdt;
            nd.NgaySinh = biznd.NgaySinh;
            nd.Trangthai = true;
            db.NguoiDungs.InsertOnSubmit(nd);
            db.SubmitChanges();
        }
        public static void delete(BizNguoiDung biznd)
        {
            db = new DbWSDataContext();
            NguoiDung nd = (from item in db.NguoiDungs
                      where item.TenDN == biznd.TenDN
                      select item).FirstOrDefault<NguoiDung>();
            nd.Trangthai = false;
            db.SubmitChanges();
        }
        public static void edit(BizNguoiDung biznd)
        {
            db = new DbWSDataContext();
            NguoiDung nd = (from item in db.NguoiDungs
                      where item.TenDN == biznd.TenDN
                      select item).FirstOrDefault<NguoiDung>();
            nd.HoTen = biznd.HoTen;
            nd.DiaChi = biznd.DiaChi;
            nd.Email = biznd.Email;
            nd.SDT = biznd.Sdt;
            nd.NgaySinh = biznd.NgaySinh;
            db.SubmitChanges();
        }
        public static int KTraDN(BizNguoiDung nd)
        {
            db = new DbWSDataContext();
            var s = (from p in db.NguoiDungs
                     where p.TenDN == nd.TenDN  && p.Trangthai == true
                     select p).ToList<NguoiDung>();
            if (s.Count > 0)
            {
                var q = (from t in db.NguoiDungs
                         where t.MatKhau == nd.MatKhau
                         select t).ToList<NguoiDung>();
                if (q.Count > 0)
                {
                    return 0;
                }
                return 1;
            }
            return 2;
        }
        public static int KTraTonTai(BizNguoiDung nd)
        {
            db = new DbWSDataContext();
            var s = (from p in db.NguoiDungs
                     where p.TenDN == nd.TenDN 
                     select p).ToList<NguoiDung>();
            if (s.Count == 0)
            {
                var q = (from t in db.NguoiDungs
                         where t.Email == nd.Email 
                         select t).ToList<NguoiDung>();
                if (q.Count == 0)
                {
                    return 0;
                }
                return 1;
            }
            return 2;
        }


        public static void editMKND(BizNguoiDung biznd)
        {
            db = new DbWSDataContext();
            NguoiDung nd = (from item in db.NguoiDungs
                      where item.TenDN == biznd.TenDN
                      select item).FirstOrDefault<NguoiDung>();
            nd.MatKhau = biznd.MatKhau;
            db.SubmitChanges();
        }
    }
}
