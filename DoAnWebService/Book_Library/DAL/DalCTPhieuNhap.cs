using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalCTPhieuNhap
    {
        static DbWSDataContext db;
        public static void ThemCTPN(BizCTPhieuNhap CTPN)
        {
            db = new DbWSDataContext();
            CTPhieuNhapKho CT = new CTPhieuNhapKho
            {
                MaSach = CTPN.Sach.MaSach,
                MaPN = CTPN.PhieuNhap.MaPN,
                SoLuong = CTPN.SoLuong,
                DonGia = CTPN.DonGia

            };
            db.CTPhieuNhapKhos.InsertOnSubmit(CT);
            db.SubmitChanges();
        }

    }
}
