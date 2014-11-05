using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalPhieuVanChuyen
    {
        static DbWSDataContext db;

        public static List<BizPhieuVanChuyen> ListPVC()
        {
            db = new DbWSDataContext();
            List<BizPhieuVanChuyen> ListPVC = (from pvc in db.PhieuGiaoHangs
                                               select new BizPhieuVanChuyen
                                               {
                                                   MaPGH = pvc.MaPGH,
                                                   NhanVien = new BizNhanVien
                                                   {
                                                       MaNV = pvc.NhanVien.MaNV,
                                                       TenNV = pvc.NhanVien.TenNV
                                                   },
                                                   NgayDuyetGH = pvc.NgayDuyetGH == null ? DateTime.Now : Convert.ToDateTime(pvc.NgayDuyetGH),
                                                   NgayNhanGH = pvc.NgayNhanGH,
                                                   TrangThai = pvc.TrangThai == null ? 0 : Convert.ToInt32(pvc.TrangThai),
                                                   ChiTietPhieuVCs = (from ct in db.CTPhieuGiaoHangs
                                                                      where ct.MaPGH == pvc.MaPGH
                                                                      select new BizCTPhieuVanChuyen
                                                                      {
                                                                          PhieuDatHang = new BizPhieuDatHang
                                                                          {
                                                                              MaPDH = ct.MaPDH,
                                                                              SDT = ct.PhieuDatHang.SDT,
                                                                              NgayDuyetHang = ct.PhieuDatHang.NgayDuyetHang == null ? DateTime.Now : Convert.ToDateTime(ct.PhieuDatHang.NgayDuyetHang),
                                                                              
                                                                              NgayDH = ct.PhieuDatHang.NgayDH,
                                                                              TrangThai = ct.PhieuDatHang.TrangThai == null ? 0: Convert.ToInt32(ct.PhieuDatHang.TrangThai),
                                                                              HoTenNN = ct.PhieuDatHang.HoTenNN,
                                                                              ChiTietDonHangs = BizCTPhieuDatHang.LayListCTPDH(ct)

                                                                          },
                                                                          PhieuVanChuyen = new BizPhieuVanChuyen
                                                                            {
                                                                                MaPGH = ct.PhieuGiaoHang.MaPGH,
                                                                                NgayDuyetGH = ct.PhieuGiaoHang.NgayDuyetGH == null ? DateTime.Now : Convert.ToDateTime(ct.PhieuGiaoHang.NgayDuyetGH)
                                                                            },
                                                                            GiaTienVC = ct.GiaTienVC,
                                                                            TrangThai = ct.Trangthai
                                                                            }).ToList<BizCTPhieuVanChuyen>()
                                                                }).ToList<BizPhieuVanChuyen>();
            return ListPVC;
        }

        public static int ThemPVC(BizPhieuVanChuyen PVC)
        {
            db = new DbWSDataContext();
            PhieuGiaoHang pgh = new PhieuGiaoHang
            {
                 MaNV = PVC.NhanVien.MaNV,
                 NgayNhanGH = DateTime.Now,
                 TrangThai = 0
            };
            db.PhieuGiaoHangs.InsertOnSubmit(pgh);
            db.SubmitChanges();
            return pgh.MaPGH;
        }
        public static void CapNhatTinhTrang(BizPhieuVanChuyen PVC)
        {
            db = new DbWSDataContext();
            PhieuGiaoHang pgh = (from gh in db.PhieuGiaoHangs
                                 where gh.MaPGH == PVC.MaPGH
                                 select gh).FirstOrDefault<PhieuGiaoHang>();
            pgh.NgayDuyetGH = DateTime.Now;
            pgh.TrangThai = PVC.TrangThai;
            db.SubmitChanges();
        }
    }
}
