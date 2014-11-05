using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizCTPhieuVanChuyen
    {
        #region Khai báo
        private BizPhieuVanChuyen phieuVanChuyen;

        public BizPhieuVanChuyen PhieuVanChuyen
        {
            get { return phieuVanChuyen; }
            set { phieuVanChuyen = value; }
        }

        private BizPhieuDatHang phieuDatHang;

        public BizPhieuDatHang PhieuDatHang
        {
            get { return phieuDatHang; }
            set { phieuDatHang = value; }
        }

        private decimal giaTienVC;

        public decimal GiaTienVC
        {
            get { return giaTienVC; }
            set { giaTienVC = value; }
        }
        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        #region Phương thức
        public static void ThemCTPVC(BizPhieuVanChuyen PVC)
        {
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                ct.PhieuVanChuyen = new BizPhieuVanChuyen
                {
                    MaPGH = PVC.MaPGH
                };
                ct.TrangThai = 0;
                DalCTPhieuVanChuyen.ThemCTPVC(ct);
                ct.PhieuDatHang.TrangThai = 2;
                BizPhieuDatHang.CapNhatTinhTrang(ct.PhieuDatHang);
            }
        }

        public static void CapNhatCTPVC(BizCTPhieuVanChuyen ct)
        {
            DalCTPhieuVanChuyen.CapNhatCTPVC(ct);
        }
    
        
        #endregion

        
    }
}
