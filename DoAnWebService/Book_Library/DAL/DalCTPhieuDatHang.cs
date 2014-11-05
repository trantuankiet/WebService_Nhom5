using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalCTPhieuDatHang
    {
        static DbWSDataContext db;
        public static void ThemCT(BizCTPhieuDatHang CT)
        {
            db = new DbWSDataContext();
            CTPhieuDatHang ct = new CTPhieuDatHang
            {
                MaPDH = CT.PhieuDatHang.MaPDH,
                 MaSach = CT.Sach.MaSach,
                 SoLuong = CT.SoLuong,
                  GiaTien = CT.GiaTien
            };
            db.CTPhieuDatHangs.InsertOnSubmit(ct);
            db.SubmitChanges();
        }

        internal static List<BizCTPhieuDatHang> LayListCTPDH(CTPhieuGiaoHang ctpvc)
        {
            db = new DbWSDataContext();
            List<BizCTPhieuDatHang> ChiTietDonHangs = (from ct in db.CTPhieuDatHangs
                                                       where ct.MaPDH == ctpvc.PhieuDatHang.MaPDH
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
                                                               Gia = ct.Sach.Gia
                                                           },
                                                           SoLuong = ct.SoLuong,
                                                           GiaTien = ct.GiaTien
                                                       }).ToList<BizCTPhieuDatHang>();
            return ChiTietDonHangs;
        }
    }
}
