using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizPhieuNhap
    {
        #region Khai Báo
        private int maPN;

        public int MaPN
        {
            get { return maPN; }
            set { maPN = value; }
        }

        private BizNhanVien nhanVien;

        public BizNhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        private List<BizCTPhieuNhap> chiTietPhieuNhaps;

        public List<BizCTPhieuNhap> ChiTietPhieuNhaps
        {
            get { return chiTietPhieuNhaps; }
            set { chiTietPhieuNhaps = value; }
        } 


        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        #endregion

        #region Phương thức

        public static List<BizPhieuNhap> LayListPN()
        {
            return DalPhieuNhap.LayListPhieuNhap();
        }

        public static void ThemPN(List<BizPhieuNhap> ListPhieuNhap)
        {
            foreach (BizPhieuNhap PN in ListPhieuNhap)
            {
                if (PN.MaPN == -1)
                {
                    PN.MaPN = DalPhieuNhap.ThemPN(PN);
                    foreach(BizCTPhieuNhap CT in PN.ChiTietPhieuNhaps)
                    {
                        CT.PhieuNhap.MaPN = PN.MaPN;
                        BizSach.SuaSPNhapKho(CT);
                    }
                    
                    BizCTPhieuNhap.ThemCTPN(PN.ChiTietPhieuNhaps);
                    
                }
            }
        }

        #endregion



    }
}
