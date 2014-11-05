using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizSach
    {
        #region Khai Báo
        private int maSach;

        public int MaSach
        {
            get { return maSach; }
            set { maSach = value; }
        }

        private string tensach;

        public string Tensach
        {
            get { return tensach; }
            set { tensach = value; }
        }

        private BizTheLoai theLoai;

        public BizTheLoai TheLoai
        {
            get { return theLoai; }
            set { theLoai = value; }
        }

        private BizKhuyenMai khuyenMai;

        public BizKhuyenMai KhuyenMai
        {
            get { return khuyenMai; }
            set { khuyenMai = value; }
        }

        private string tenTacGia;

        public string TenTacGia
        {
            get { return tenTacGia; }
            set { tenTacGia = value; }
        }

        private string nhaXuatBan;

        public string NhaXuatBan
        {
            get { return nhaXuatBan; }
            set { nhaXuatBan = value; }
        }

        private int soTrang;

        public int SoTrang
        {
            get { return soTrang; }
            set { soTrang = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private int namXuatBan;

        public int NamXuatBan
        {
            get { return namXuatBan; }
            set { namXuatBan = value; }
        }

        private string noiDung;

        public string NoiDung
        {
            get { return noiDung; }
            set { noiDung = value; }
        }

        private decimal gia;

        public decimal Gia
        {
            get { return gia; }
            set { gia = value; }
        }

        private string loaiBia;

        public string LoaiBia
        {
            get { return loaiBia; }
            set { loaiBia = value; }
        }

        private string hinhAnh;

        public string HinhAnh
        {
            get { return hinhAnh; }
            set { hinhAnh = value; }
        }

        private int phanTramLoi;

        public int PhanTramLoi
        {
            get { return phanTramLoi; }
            set { phanTramLoi = value; }
        }

        private decimal giaVon;

        public decimal GiaVon
        {
            get { return giaVon; }
            set { giaVon = value; }
        }


        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        #region Phương thức

        public static int LaySoLuong(BizSach sach)
        {
            return DalSach.LaySoLuong(sach);
        }
        public static bool KtraTonKho(BizSach sachmua)
        {
            if (sachmua.SoLuong <= LaySoLuong(sachmua))
                return true;
            return false;
        }
        public static void XoaSach(BizSach sach)
        {
            DalSach.XoaSach(sach);
        }

        public static void SuaSach(BizSach sach)
        {
            DalSach.SuaSach(sach);
        }

        public static List<BizSach> LayListSach()
        {
           return DalSach.LayListSach().Where(t=> t.TrangThai == true).ToList<BizSach>();
        }

        public static List<BizSach> LayListSachDD()
        {
            return DalSach.LayListSach();
        }
        public static void ThemSach(BizSach sach)
        {
            DalSach.ThemSach(sach);
        }
        public static void KichHoat(BizSach sach)
        {
            if (sach.TheLoai.TrangThai == false)
            {
                BizTheLoai.Kichhoat(sach.TheLoai);
            }
            DalSach.KichHoat(sach);
            
        }

        public static void SuaSPDonHang(BizCTPhieuDatHang CT)
        {
            DalSach.SuaSPDonHang(CT);
        }
        public static void SuaSPDonHangDH(BizCTPhieuDatHang CT)
        {
            DalSach.SuaSPDonHangDH(CT);
        }
        public static void SuaSPNhapKho(BizCTPhieuNhap CT)
        {
            DalSach.SuaSPNhapKho(CT);
        }
        public static void CapNhatKhuyenMai()
        {
            List<BizSach> list = BizSach.LayListSachDD();
            BizKhuyenMai KM = BizKhuyenMai.KtraKhuyenMai();
            foreach (BizSach s in list)
            {
                DalSach.CapNhatKhuyenMai(s, KM);
            }

        }

        
        #endregion
    }
}
