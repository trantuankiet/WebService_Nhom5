using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizPhieuDatHang
    {
        #region Khai báo
        private int maPDH;

        public int MaPDH
        {
            get { return maPDH; }
            set { maPDH = value; }
        }

        private List<BizCTPhieuDatHang> chiTietDonHangs;

        public List<BizCTPhieuDatHang> ChiTietDonHangs
        {
            get { return chiTietDonHangs; }
            set { chiTietDonHangs = value; }
        }

        private BizNhanVien nhanVien;

        public BizNhanVien NhanVien
        {
            get { return nhanVien; }
            set { nhanVien = value; }
        }

        private BizNguoiDung nguoiDung;

        public BizNguoiDung NguoiDung
        {
            get { return nguoiDung; }
            set { nguoiDung = value; }
        }
      
        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Họ tên người nhận")]
        private string hoTenNN;
        [Required(ErrorMessage="Hãy nhập họ tên người nhận")]
        [Display(Name = "Họ tên người nhận")]
        public string HoTenNN
        {
            get { return hoTenNN; }
            set { hoTenNN = value; }
        }

        private string email;
        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Địa chỉ người nhận")]
        private string diaChiNN;

        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Địa chỉ người nhận")]
        public string DiaChiNN
        {
            get { return diaChiNN; }
            set { diaChiNN = value; }
        }

        private DateTime ngayDH;

        public DateTime NgayDH
        {
            get { return ngayDH; }
            set { ngayDH = value; }
        }

        private DateTime ngayDuyetHang;

        public DateTime NgayDuyetHang
        {
            get { return ngayDuyetHang; }
            set { ngayDuyetHang = value; }
        }

        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Số điện thoại liên lạc khi nhận")]
        private string sDT;
        [Required(ErrorMessage = "Hãy nhập họ tên người nhận")]
        [Display(Name = "Số điện thoại liên lạc khi nhận")]
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        private int trangThai;

        public int TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        #region Phương thức
        public static List<BizPhieuDatHang> LayListPDH()
        {
            return DalPhieuDatHang.LaylistPDH();
        }
        
        
        public static void ThemPDH(BizPhieuDatHang PDH)
        {
             PDH.MaPDH = DalPhieuDatHang.ThemPDH(PDH);
             BizCTPhieuDatHang.ThemCTPDH(PDH);
            
        }
        public static void ThemPDHTT(BizPhieuDatHang PDH)
        {
            PDH.MaPDH = DalPhieuDatHang.ThemPDHTT(PDH);
            BizCTPhieuDatHang.ThemCTPDH(PDH);
         
        }

        public static void CapNhatTinhTrang(BizPhieuDatHang PDH)
        {
            
            DalPhieuDatHang.CapNhatTinhTrang(PDH);
            if (PDH.TrangThai == -1)
            {
                foreach (BizCTPhieuDatHang ct in PDH.ChiTietDonHangs)
                {
                    BizSach.SuaSPDonHangDH(ct);
                }
            }
        }

        public static decimal TongTienDonHang(BizPhieuDatHang PDH)
        {
            decimal tongtien = 0;
            foreach (BizCTPhieuDatHang ct in PDH.ChiTietDonHangs)
            {
                tongtien += ct.GiaTien;
            }
            return tongtien;
        }

        public int ThemGioHang(BizSach sach)
        {
            bool co = false;
            if (ChiTietDonHangs == null)
            {
                ChiTietDonHangs = new List<BizCTPhieuDatHang>();
            }
            BizCTPhieuDatHang Chitiet = new BizCTPhieuDatHang();
            foreach (BizCTPhieuDatHang ct in ChiTietDonHangs)
            {
                if (sach.MaSach == ct.Sach.MaSach)
                {
                    co = true;
                    Chitiet = ct;
                    break;
                }
            }
            if (co == true)
            {
                sach.SoLuong += Chitiet.SoLuong;
                if (sach.SoLuong > 5)
                {
                    return 2; // mua vượt quá số lượng 5 trên 1 măt hàng
                }
                else
                {
                    if (BizSach.KtraTonKho(sach))
                    {
                        Chitiet.SoLuong = sach.SoLuong;
                        if (Chitiet.Sach.KhuyenMai == null)
                        {
                            Chitiet.GiaTien = Chitiet.Sach.Gia * Chitiet.SoLuong;
                        }
                        else
                        {
                            Chitiet.GiaTien = (Chitiet.Sach.Gia - (Chitiet.Sach.Gia * Convert.ToDecimal(Chitiet.Sach.KhuyenMai.GiaTriGiam / Convert.ToDecimal(100)))) * Chitiet.SoLuong;
                      
                        }
                        return 1; // mua sách thành công nhưng sách đã có trong giỏ hàng
                    }
                    else
                    {
                        return 0; // Không đủ tồn kho
                    }
                }
            }
            else
            {
                if (ChiTietDonHangs.Count + 1 > 7)
                {
                    return 3; // số sách mua vượt quá 7 cuốn sách
                }
                else
                {
                    if (BizSach.KtraTonKho(sach))
                    {
                        Chitiet = new BizCTPhieuDatHang
                        {
                            SoLuong = sach.SoLuong,
                            Sach = BizSach.LayListSach().Single(t => t.MaSach == sach.MaSach)
                        };
                        if (Chitiet.Sach.KhuyenMai == null)
                        {
                            Chitiet.GiaTien = Chitiet.Sach.Gia * Chitiet.SoLuong;
                        }
                        else
                        {
                            Chitiet.GiaTien = (Chitiet.Sach.Gia - (Chitiet.Sach.Gia * Convert.ToDecimal(Chitiet.Sach.KhuyenMai.GiaTriGiam / Convert.ToDecimal(100)))) * Chitiet.SoLuong;

                        }
                        ChiTietDonHangs.Add(Chitiet);
                        return 1; // mua sách thành công nhưng chưa có trong giỏ hàng
                    }
                    else
                    {
                        return 0; // không đủ tồn kho
                    }
                }
            }
        }
        public void XoaGioHang(BizSach sach)
        {
            foreach (BizCTPhieuDatHang ct in ChiTietDonHangs)
            {
                if (sach.MaSach == ct.Sach.MaSach)
                {
                    ChiTietDonHangs.Remove(ct);
                    break;
                }
            }
           
        }
        public void CapNhatGioHang(BizSach sach)
        {
            
            foreach (BizCTPhieuDatHang Chitiet in ChiTietDonHangs)
            {
                if (sach.MaSach == Chitiet.Sach.MaSach)
                {
                    Chitiet.SoLuong = sach.SoLuong;
                    if (Chitiet.Sach.KhuyenMai == null)
                    {
                        Chitiet.GiaTien = Chitiet.Sach.Gia * Chitiet.SoLuong;
                    }
                    else
                    {
                        Chitiet.GiaTien = (Chitiet.Sach.Gia - (Chitiet.Sach.Gia * Convert.ToDecimal(Chitiet.Sach.KhuyenMai.GiaTriGiam / Convert.ToDecimal(100)))) * Chitiet.SoLuong;

                    }
                    break;
                }
            }
        }
        #endregion


    }
}
