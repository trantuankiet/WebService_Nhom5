using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Book_Library.BLL;
namespace WcfService_Book
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBook_Service" in both code and config file together.
    [ServiceContract]
    public interface IBook_Service
    {
        #region Các dịch vụ khác
        [OperationContract]
        string Layfilepath();
     
        [OperationContract]
        string Matkhaungaunhien();
        [OperationContract]
        string Mahoa(string Chuoimahoa);
        [OperationContract]
        string Giama(string Chuoigaima);
        [OperationContract]
        void GuiMail_DangKyND(BizNguoiDung nd);
        [OperationContract]
        void GuiMail_DangKyNV(BizNhanVien nd);
        [OperationContract]
        void GuiMail_TBKhuyenMai(List<BizNguoiDung> Listnd, BizKhuyenMai km);
        [OperationContract]
        void GuiMail_CapLaiMatKhau(BizNguoiDung nd);
        [OperationContract]
        void GuiMail_ThanhToan(BizPhieuDatHang pdh);
        [OperationContract]
        void GuiMai_BaoXoaTK(BizNguoiDung nd);
        #endregion

        #region Hiển thị sản phẩm lên web
        [OperationContract]
        List<BizSach> LayListTheoDM(BizTheLoai tl);

        [OperationContract]
        List<BizSach> LayDSMoiNhat();

        [OperationContract]
        BizSach LaySPByID(BizSach s);

        [OperationContract]
        List<BizSach> LayListKeyWord(string keyword);

        [OperationContract]
        List<BizSach> LayListTimKiemNangCao(string tensach, int theloai, decimal giatu, decimal giaden);
        #endregion

        #region Giỏ Hàng
        [OperationContract]
        int ThemGioHang(ref BizPhieuDatHang PDH, BizSach sach);
        [OperationContract]
        void XoaGioHang(ref BizPhieuDatHang PDH, BizSach sach);
        [OperationContract]
        void CapNhatGioHang(ref BizPhieuDatHang PDH, BizSach sach);
        [OperationContract]
        bool KiemTraTonKho(BizSach sach);
        #endregion

        #region "Phân Trang"
        [OperationContract]
        List<BizSach> phantrangsach(int start, int offset, List<BizSach> ListSach);
        #endregion

        #region "Sách"
        [OperationContract]
        List<BizSach> LayListSach();

        [OperationContract]
        List<BizSach> LayListSachDD();

        [OperationContract]
        void ThemSach(BizSach sach);

        [OperationContract]
        void SuaSach(BizSach sach);

        [OperationContract]
        void XoaSach(BizSach sach);

        [OperationContract]
        void KichHoat(BizSach sach);

        [OperationContract]
        void CapNhatKhuyenMai();
        #endregion

        #region "Thể Loại"

        [OperationContract]
        List<BizTheLoai> ListTheLoai();
        [OperationContract]
        List<BizTheLoai> ListTheLoaiDD();
        [OperationContract]
        void DeleteTL(BizTheLoai q);
        [OperationContract]
        void InsertTL(BizTheLoai q);
        [OperationContract]
        void EditTL(BizTheLoai q);
        [OperationContract]
        void KichhoatTL(BizTheLoai q);

        
        #endregion

        #region "Khuyến Mãi"

        [OperationContract]
        List<BizKhuyenMai> ListKhuyenMai();
        [OperationContract]
        void DeleteKM(BizKhuyenMai km);
        [OperationContract]
        bool InsertKM(BizKhuyenMai km);
        [OperationContract]
        bool EditKM(BizKhuyenMai km);
        [OperationContract]
        BizKhuyenMai LayKhuyenMai();

        #endregion

        #region "Nhân Viên"
        [OperationContract]
        BizNhanVien LayThongTinNhanVien(string MaNV);
        [OperationContract]
        bool KiemTraMatKhau(string MaNV,string MatKhau);
        [OperationContract]
        List<BizNhanVien> ListNhanVien();
        [OperationContract]
        List<BizNhanVien> ListNhanVienVC();
        [OperationContract]
        void DeleteNV(BizNhanVien nv);

        [OperationContract]
        void InsertNV1(BizNhanVien nv);

        [OperationContract]
        void InsertNV(BizNhanVien nv);
        [OperationContract]
        void EditTTNVKMK(BizNhanVien nv);// có sửa mật khẩu
        [OperationContract]
        void EditTTNVMK(BizNhanVien nv);// ko sửa mật khẩu
		[OperationContract]
        BizNhanVien KTraDNNV(BizNhanVien nv);
        
        #endregion

        #region "Quyền"


        [OperationContract]
        List<BizQuyen> ListQuyen();
        [OperationContract]
        void DeleteQ(BizQuyen q);
        [OperationContract]
        void InsertQ(BizQuyen q);
        [OperationContract]
        void EditQ(BizQuyen q);
      

        #endregion

        #region "Người Dùng"
        [OperationContract]
        int SoPDHHoanTat(BizNguoiDung nd);
        [OperationContract]
        int SoPDHHuy(BizNguoiDung nd);
        [OperationContract]
        BizNguoiDung LayThongTinNDEmail(string Email);
        [OperationContract]
        BizNguoiDung LayThongTinND(string TenDN);
        [OperationContract]
        List<BizNguoiDung> ListNguoiDung();
        [OperationContract]
        void DeleteND(BizNguoiDung nd);
        [OperationContract]
        void InsertND(BizNguoiDung nd);
        [OperationContract]
        void EditND(BizNguoiDung nd);
        [OperationContract]
        int KTraDN(BizNguoiDung nd);
        [OperationContract]
        int KTraTonTai(BizNguoiDung nd);
        [OperationContract]
        void EditMKND(BizNguoiDung nd);
        [OperationContract]
        bool KtraEmail(string Email);
        [OperationContract]
        bool KtraEmailND(string TenDN, string Email);
        [OperationContract]
        bool KtraMatkhau(string TenDN, string MatKhau);
        #endregion

        #region "Đơn Hàng"
        [OperationContract]
        List<BizPhieuDatHang> LayListPDHCD();// phiếu đặt hàng chưa duyệt

        [OperationContract]
        List<BizPhieuDatHang> LayListPDHDD();// phiếu đặt hàng duyệt

        [OperationContract]
        List<BizPhieuDatHang> LayListPDHDH();// phiếu đặt hàng hủy

        [OperationContract]
        List<BizPhieuDatHang> LayListPDHTT();// phiếu đặt hàng trực tiếp


        [OperationContract]
        List<BizPhieuDatHang> LayListPDHND(BizNguoiDung nd);// phiếu đặt hàng theo người dùng
        
        [OperationContract]
        BizPhieuDatHang LayPDH(int MaPDH); // lây 1 phiếu dat hàng

        [OperationContract]
        List<BizPhieuDatHang> LayListPDHNDHT(BizNguoiDung nd);

        [OperationContract]
        List<BizPhieuDatHang> LayListPDHNDDH(BizNguoiDung nd);
        
        [OperationContract]
        void ThemPDH(BizPhieuDatHang pdh);

        [OperationContract]
        void ThemPDHTT(BizPhieuDatHang pdh);
       
        [OperationContract]
        void CapNhatTinhTrangPDH(BizPhieuDatHang pdh);

        [OperationContract]
        decimal TinhTongTienPhieuDatHang(BizPhieuDatHang pdh);

        #endregion

        #region "Chi Tiết Đơn Hàng"
        #endregion

        #region "Phiếu Nhập"
        [OperationContract]
        List<BizPhieuNhap> LayListPN();

        [OperationContract]
        void ThemPN(List<BizPhieuNhap> LPN);
        #endregion

        #region "Chi Tiết Phiếu Nhập"
        [OperationContract]
        BizCTPhieuNhap KtraTonTaiSP(BizCTPhieuNhap CT, List<BizCTPhieuNhap> ListCT);
        #endregion

        #region "Phiếu Vận Chuyển"
        [OperationContract]
        List<BizPhieuVanChuyen> LayListPVC();

        [OperationContract]
        void ThemPVC(BizPhieuVanChuyen PVC);

        [OperationContract]
        void CapNhatTinhTrangPVCDG(BizPhieuVanChuyen PVC);

        [OperationContract]
        void CapNhatTinhTrangPVCKG(BizPhieuVanChuyen PVC);

        [OperationContract]
        void CapNhatTinhTrangPVCTC(BizPhieuVanChuyen PVC);


        [OperationContract]
        List<BizPhieuDatHang> ChuyenDoiPhieuDatHang(BizPhieuVanChuyen PVC);

        [OperationContract]
        BizPhieuVanChuyen ChuyenDoiPhieuVanChuyen(BizPhieuVanChuyen PVC, List<BizPhieuDatHang> List);

        [OperationContract]
        decimal TongTienPhieuVanChuyen(BizPhieuVanChuyen PVC);
        #endregion

        #region "Chi Tiết Phiếu Vận Chuyển"
        #endregion

        #region Thống kê - Báo cáo
        [OperationContract]
        List<BizSach> ThongKeTonKho(BizSach sach,DateTime NgayThongKe);//thống kê tồn kho

        [OperationContract]
        List<BizSach> ThongKeSoLuongBanRa(BizTheLoai theloai, DateTime NgayBD, DateTime NgayKT);

        [OperationContract]
        List<BizSach> ThongKeTheoSoLuong(int SoLuong, bool kieusosanh, DateTime NgayBD, DateTime NgayKT);

        [OperationContract]
        List<BizSach> ThongKeDoanhThuTungSanPham(DateTime NgayBD, DateTime NgayKT);

        [OperationContract]
        decimal ThongKeTienVanChuyen(DateTime NgayBD, DateTime NgayKT);

        [OperationContract]
        decimal ThongKeTongDoanhThu(DateTime NgayBD, DateTime NgayKT);

        [OperationContract]
        decimal ThongKeTongDoanhThuSanPham(DateTime NgayBD, DateTime NgayKT);
        #endregion


    }
}
