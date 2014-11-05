using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizCTPhieuDatHang
    {
        #region Khai báo
        private BizPhieuDatHang phieuDatHang;

        public BizPhieuDatHang PhieuDatHang
        {
            get { return phieuDatHang; }
            set { phieuDatHang = value; }
        }

        private BizSach sach;

        public BizSach Sach
        {
            get { return sach; }
            set { sach = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private decimal giaTien;

        public decimal GiaTien
        {
            get { return giaTien; }
            set { giaTien = value; }
        }
        #endregion

        public static void ThemCTPDH(BizPhieuDatHang PDH)
        {
            foreach (BizCTPhieuDatHang ct in PDH.ChiTietDonHangs)
            {
                ct.PhieuDatHang = new BizPhieuDatHang
                {
                    MaPDH = PDH.MaPDH
                };
                DalCTPhieuDatHang.ThemCT(ct);
                BizSach.SuaSPDonHang(ct);
            }
        }

        public static List<BizCTPhieuDatHang> LayListCTPDH(CTPhieuGiaoHang ct)
        {
            return DalCTPhieuDatHang.LayListCTPDH(ct);
        }
    }
}
