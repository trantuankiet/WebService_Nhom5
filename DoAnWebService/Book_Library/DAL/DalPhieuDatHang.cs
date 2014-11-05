using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalPhieuDatHang
    {
        static DbWSDataContext db;

        public static List<BizPhieuDatHang> LaylistPDH()
        {
            db = new DbWSDataContext();
            List<BizPhieuDatHang> List = (from pdh in db.PhieuDatHangs
                                          select new BizPhieuDatHang
                                          {
                                              MaPDH = pdh.MaPDH,
                                              NhanVien = db.NhanViens == null ? new BizNhanVien
                                                                                {
                                                                                    MaNV = null
                                                                                } :
                                                                                new BizNhanVien
                                                                                {
                                                                                    MaNV = pdh.NhanVien.MaNV,
                                                                                    TenNV = pdh.NhanVien.TenNV
                                                                                },
                                              NguoiDung = db.NguoiDungs == null ? new BizNguoiDung
                                                                                  {
                                                                                      TenDN = null
                                                                                  } :
                                                                                  new BizNguoiDung
                                                                                  {
                                                                                      TenDN = pdh.NguoiDung.TenDN,
                                                                                      HoTen = pdh.NguoiDung.HoTen
                                                                                  },
                                              HoTenNN = pdh.HoTenNN,
                                              DiaChiNN = pdh.DiaChi,
                                              Email = pdh.Email,
                                              NgayDuyetHang = pdh.NgayDuyetHang == null ? DateTime.Now : Convert.ToDateTime(pdh.NgayDuyetHang),
                                              NgayDH = pdh.NgayDH,
                                              TrangThai = pdh.TrangThai == null ? 0 : Convert.ToInt32(pdh.TrangThai),
                                              SDT = pdh.SDT,
                                              ChiTietDonHangs = (from ct in db.CTPhieuDatHangs
                                                                 where ct.MaPDH == pdh.MaPDH
                                                                 select new BizCTPhieuDatHang
                                                                 {
                                                                     PhieuDatHang = new BizPhieuDatHang
                                                                     {
                                                                         MaPDH = ct.MaPDH
                                                                     },
                                                                     Sach = new BizSach
                                                                     {
                                                                         MaSach = ct.Sach.MaSach,
                                                                         Tensach = ct.Sach.TenSach,
                                                                         SoLuong = ct.Sach.SoLuong == null ? 0 : Convert.ToInt32(ct.Sach.SoLuong),
                                                                         Gia =  ct.Sach.Gia 
                                                                     },
                                                                     SoLuong = ct.SoLuong,
                                                                     GiaTien = ct.GiaTien
                                                                 }).ToList<BizCTPhieuDatHang>()
                                          }).ToList<BizPhieuDatHang>();
            return List;
        }

        public static int ThemPDH(BizPhieuDatHang pdh)
        {
            db = new DbWSDataContext();
            PhieuDatHang PDH = new PhieuDatHang
            {
                TaiKhoanNM = pdh.NguoiDung.TenDN,
                NgayDH = DateTime.Now,
                HoTenNN = pdh.HoTenNN,
                SDT = pdh.SDT,
                Email = pdh.Email,
                DiaChi = pdh.DiaChiNN,
                TrangThai = 0
            };
            db.PhieuDatHangs.InsertOnSubmit(PDH);
            db.SubmitChanges();
            return PDH.MaPDH;
        }

        public static int ThemPDHTT(BizPhieuDatHang pdh)
        {
            db = new DbWSDataContext();
            PhieuDatHang PDH = new PhieuDatHang
            {
                MaNV = pdh.NhanVien.MaNV,
                NgayDH = DateTime.Now,
                TrangThai = 4
            };
            db.PhieuDatHangs.InsertOnSubmit(PDH);
            db.SubmitChanges();
            return PDH.MaPDH;
        }
        public static void CapNhatTinhTrang(BizPhieuDatHang pdh)
        {
            db = new DbWSDataContext();
            PhieuDatHang PDH = (from p in db.PhieuDatHangs
                                where p.MaPDH == pdh.MaPDH
                                select p).FirstOrDefault<PhieuDatHang>();
            PDH.NgayDuyetHang = DateTime.Now;
            PDH.TrangThai = pdh.TrangThai;
            db.SubmitChanges();
        }
    }
}
