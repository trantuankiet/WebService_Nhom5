using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizCTPhieuNhap
    {
        #region Khai Báo
        private BizPhieuNhap phieuNhap;

        public BizPhieuNhap PhieuNhap
        {
            get { return phieuNhap; }
            set { phieuNhap = value; }
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

        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        #endregion
        #region Phuong thức


        #endregion

        public static void ThemCTPN(List<BizCTPhieuNhap> LCT)
        {
            foreach(BizCTPhieuNhap PN in LCT)
            {
                DalCTPhieuNhap.ThemCTPN(PN);
            }
        }

        public static BizCTPhieuNhap KiemTraTonTaiSP(BizCTPhieuNhap CT, List<BizCTPhieuNhap> ListCT)
        {
            foreach (BizCTPhieuNhap ct in ListCT)
            {
                if (ct.Sach.MaSach == CT.Sach.MaSach)
                {
                    return ct;
                }
            }
            return new BizCTPhieuNhap();
        }
    }
}
