using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizPhieuVanChuyen
    {
        #region Khai báo
        private int maPGH;

        public int MaPGH
        {
            get { return maPGH; }
            set { maPGH = value; }
        }

        private BizNhanVien nhanVien;

        public BizNhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        private DateTime ngayNhanGH;

        public DateTime NgayNhanGH
        {
            get { return ngayNhanGH; }
            set { ngayNhanGH = value; }
        }

        private DateTime ngayDuyetGH;

        public DateTime NgayDuyetGH
        {
            get { return ngayDuyetGH; }
            set { ngayDuyetGH = value; }
        }

        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        private List<BizCTPhieuVanChuyen> chiTietPhieuVCs;

        public List<BizCTPhieuVanChuyen> ChiTietPhieuVCs
        {
            get { return chiTietPhieuVCs; }
            set { chiTietPhieuVCs = value; }
        }
        #endregion
        #region Phương thức
        public static List<BizPhieuVanChuyen> LayListPVC()
        {
            return DalPhieuVanChuyen.ListPVC().Where(t => t.TrangThai == 0).ToList<BizPhieuVanChuyen>();
        }

        public static List<BizPhieuVanChuyen> LayListPVCTK()
        {
            return DalPhieuVanChuyen.ListPVC().Where(t => t.TrangThai == 1 || t.TrangThai == 2).ToList<BizPhieuVanChuyen>();
        }

        public static void ThemPVC(BizPhieuVanChuyen PVC)
        {
            PVC.MaPGH = DalPhieuVanChuyen.ThemPVC(PVC);
            BizCTPhieuVanChuyen.ThemCTPVC(PVC);
        }
        
        public static void CapNhatTinhTrangGH(BizPhieuVanChuyen PVC)
        {
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                ct.PhieuDatHang.TrangThai = 3;
                ct.TrangThai = 1;
                BizCTPhieuVanChuyen.CapNhatCTPVC(ct);
                BizPhieuDatHang.CapNhatTinhTrang(ct.PhieuDatHang);
            }
            PVC.TrangThai = 1;
            DalPhieuVanChuyen.CapNhatTinhTrang(PVC);
        }
        public static void CapNhatTinhTrangKG(BizPhieuVanChuyen PVC)
        {
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                ct.PhieuDatHang.TrangThai = 0;
                ct.TrangThai = -1;

                BizCTPhieuVanChuyen.CapNhatCTPVC(ct);
                BizPhieuDatHang.CapNhatTinhTrang(ct.PhieuDatHang);
            }
            PVC.TrangThai = -1;
            DalPhieuVanChuyen.CapNhatTinhTrang(PVC);
        }
        public static void CapNhatTinhTrangTC(BizPhieuVanChuyen PVC)
        {
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                BizPhieuDatHang.CapNhatTinhTrang(ct.PhieuDatHang);
                BizCTPhieuVanChuyen.CapNhatCTPVC(ct);
            }
            PVC.TrangThai = 2;
            DalPhieuVanChuyen.CapNhatTinhTrang(PVC);
        }
        public static List<BizPhieuDatHang> ChuyenDoiPhieuDatHang(BizPhieuVanChuyen PVC)
        {
            List<BizPhieuDatHang> List = new List<BizPhieuDatHang>();
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                List.Add(ct.PhieuDatHang);
            }
            return List;
        }
        public static BizPhieuVanChuyen ChuyenDoiPhieuVanChuyen(BizPhieuVanChuyen PVC, List<BizPhieuDatHang> List)
        {
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                foreach (BizPhieuDatHang PDH in List)
                {
                    if (PDH.MaPDH == ct.PhieuDatHang.MaPDH)
                    {
                        if (PDH.TrangThai == 3)
                            ct.TrangThai = 1;
                        else
                            ct.TrangThai = -1;
                        ct.PhieuDatHang.TrangThai = PDH.TrangThai;
                    }
                }
            }
            
            return PVC;
        }
        public static decimal TinhTongTienPhieuVanChuyen(BizPhieuVanChuyen PVC)
        {
            decimal tongtien = 0;
            foreach (BizCTPhieuVanChuyen ct in PVC.ChiTietPhieuVCs)
            {
                tongtien = tongtien + ct.GiaTienVC + BizPhieuDatHang.TongTienDonHang(ct.PhieuDatHang);
            }
            return tongtien;
        }
        #endregion
    }
}
