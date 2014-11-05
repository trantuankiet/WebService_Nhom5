using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalCTPhieuVanChuyen
    {
        static DbWSDataContext db;
        
        public static void ThemCTPVC(BizCTPhieuVanChuyen CTPVC)
        {
            db = new DbWSDataContext();
             CTPhieuGiaoHang CT = new CTPhieuGiaoHang()
                {
                    MaPGH = CTPVC.PhieuVanChuyen.MaPGH,
                    MaPDH = CTPVC.PhieuDatHang.MaPDH,
                    GiaTienVC = CTPVC.GiaTienVC,
                    Trangthai = CTPVC.TrangThai
                };
                db.CTPhieuGiaoHangs.InsertOnSubmit(CT);
                db.SubmitChanges();
        }
        public static void CapNhatCTPVC(BizCTPhieuVanChuyen CTPVC)
        {
            db = new DbWSDataContext();
            CTPhieuGiaoHang CTPGH = (from ct in db.CTPhieuGiaoHangs
                                     where ct.PhieuDatHang.MaPDH == CTPVC.PhieuDatHang.MaPDH && ct.PhieuGiaoHang.MaPGH == CTPVC.PhieuVanChuyen.MaPGH
                                     select ct).FirstOrDefault<CTPhieuGiaoHang>();
            CTPGH.Trangthai = CTPVC.TrangThai;
            db.SubmitChanges();
        }
        
    }
}
