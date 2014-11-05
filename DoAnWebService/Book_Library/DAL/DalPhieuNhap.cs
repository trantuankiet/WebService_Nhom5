using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalPhieuNhap
    {
        static DbWSDataContext db ;
        public static List<BizPhieuNhap> LayListPhieuNhap()
        {
            db = new DbWSDataContext();
            List<BizPhieuNhap> ListPN = (from pn in db.PhieuNhapKhos
                                         select new BizPhieuNhap
                                         {
                                             MaPN = pn.MaPN,
                                             NhanVien = new BizNhanVien
                                             {
                                                 MaNV = pn.NhanVien.MaNV,
                                                 TenNV = pn.NhanVien.TenNV
                                             },
                                             NgayNhap = pn.NgayNhap,
                                             ChiTietPhieuNhaps = (from ct in db.CTPhieuNhapKhos
                                                                  where ct.MaPN == pn.MaPN
                                                                  select new BizCTPhieuNhap
                                                                  {
                                                                      Sach = new BizSach
                                                                      {
                                                                          Tensach = ct.Sach.TenSach,
                                                                          SoLuong = ct.Sach.SoLuong == null ? 0 : Convert.ToInt32(ct.Sach.SoLuong),
                                                                          MaSach = ct.Sach.MaSach,
                                                                          Gia = ct.Sach.Gia
                                                                      },
                                                                      DonGia = ct.DonGia,
                                                                      SoLuong = ct.SoLuong

                                                                  }).ToList<BizCTPhieuNhap>(),


                                         }).ToList<BizPhieuNhap>();
            return ListPN;
        }
        public static int ThemPN(BizPhieuNhap Pn)
        {
            db = new DbWSDataContext();
           PhieuNhapKho pnk = new PhieuNhapKho
           {
               MaNV = Pn.NhanVien.MaNV,
               NgayNhap = DateTime.Now
           };
           db.PhieuNhapKhos.InsertOnSubmit(pnk);
           db.SubmitChanges();
           return pnk.MaPN;
        }
        
    }


}
