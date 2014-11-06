using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Book_Library.BLL;
using Book_Library;
namespace WcfService_Book
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Book_Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Book_Service.svc or Book_Service.svc.cs at the Solution Explorer and start debugging.
    public class Book_Service : IBook_Service
    {
        #region Các dịch vụ khác
        public string Layfilepath()
        {
            return HttpContext.Current.Server.MapPath("") + @"\HinhAnh\";
        }
        public string Matkhaungaunhien()
        {
            return XuLyKhac.RandomString(6, true);
        }
        public string Mahoa(string Chuoimahoa)
        {
            return XuLyMaHoa.Encrypt(Chuoimahoa, "john1712", true);
        }
        public string Giama(string Chuoigaima)
        {
            return XuLyMaHoa.Decrypt(Chuoigaima, "john1712", true);
        }
        public void GuiMail_DangKyND(BizNguoiDung nd)
        {
            XuLySendMail.SendMail_NguoiDung(nd.Email, nd.HoTen);
        }
        public void GuiMail_DangKyNV(BizNhanVien nd)
        {
            XuLySendMail.SendMail_NhanVien(nd.Email, nd.TenNV, nd.MaNV, nd.MatKhau);
        }
        public void GuiMail_TBKhuyenMai(List<BizNguoiDung> Listnd,BizKhuyenMai km)
        {
            foreach (BizNguoiDung nd in Listnd)
            {
                XuLySendMail.SendMail_BaoKhuyenMai(nd.Email, nd.HoTen, km.TenKM, km.NgayApDung, km.NgayHetHan, km.GiaTriGiam);
            }
        }
        public void GuiMail_CapLaiMatKhau(BizNguoiDung nd)
        {
            XuLySendMail.SendMail_QuenMatKhau(nd.Email,nd.TenDN ,nd.MatKhau);
        }
        public void GuiMail_ThanhToan(BizPhieuDatHang pdh)
        {
           XuLySendMail.SendMail_ThanhToan(pdh.NguoiDung.Email,pdh.ChiTietDonHangs.Count.ToString(),BizPhieuDatHang.TongTienDonHang(pdh));
        }
        public void GuiMai_BaoXoaTK(BizNguoiDung nd)
        {
            XuLySendMail.SendMail_BaoXoaTK(nd.Email, nd.HoTen, nd.TenDN);
        }
        #endregion

        #region Giỏ Hàng
        public int ThemGioHang(ref BizPhieuDatHang PDH,BizSach sach)
        {
           return PDH.ThemGioHang(sach);
        }
        public void XoaGioHang(ref BizPhieuDatHang PDH, BizSach sach)
        {
            PDH.XoaGioHang(sach);
        }
        public void CapNhatGioHang(ref BizPhieuDatHang PDH, BizSach sach)
        {
            PDH.CapNhatGioHang(sach);  
        }

        public bool KiemTraTonKho(BizSach sach)
        {
            return BizSach.KtraTonKho(sach);
        }
        #endregion

        #region Hiển thị sản phẩm lên web

        public List<BizSach> LayListTheoDM(BizTheLoai tl)
        {
            return BizSach.LayListSach().Where(t => t.TheLoai.MaTL == tl.MaTL).ToList<BizSach>();
        }
        public BizSach LaySPByID(BizSach s)
        {
            return BizSach.LayListSach().Single(t => t.MaSach == s.MaSach);
        }
        public List<BizSach> LayDSMoiNhat()
        {
            return BizSach.LayListSach().OrderByDescending(t => t.MaSach).ToList<BizSach>().Take(15).ToList<BizSach>();
        }

        public List<BizSach> LayListKeyWord(string keyword)
        {
            return BizSach.LayListSach().Where(t=> XuLyKhac.LocDau(t.Tensach).ToUpper().Contains(XuLyKhac.LocDau(keyword).ToUpper())).ToList<BizSach>();
 
        }
        public List<BizSach> LayListTimKiemNangCao(string tensach, int theloai, decimal giatu, decimal giaden)
        {
            List<BizSach> ListSach = BizSach.LayListSach();
            if (tensach != null && theloai !=0 && giatu >= 0 && giaden >= 0)
            {
                ListSach = ListSach.Where(t => XuLyKhac.LocDau(t.Tensach).ToUpper().Contains(XuLyKhac.LocDau(tensach).ToUpper()) && t.TheLoai.MaTL == theloai && t.Gia >= giatu && t.Gia <= giaden ).ToList<BizSach>();
            }
            else if (tensach == null && theloai != 0 && giatu >= 0 && giaden >= 0)
            {
                ListSach = ListSach.Where(t => t.TheLoai.MaTL == theloai && t.Gia >= giatu && t.Gia <= giaden).ToList<BizSach>();
            }
            else if (tensach != null && theloai == 0 && giatu >= 0 && giaden >= 0)
            {
                ListSach = ListSach.Where(t => XuLyKhac.LocDau(t.Tensach).ToUpper().Contains(XuLyKhac.LocDau(tensach).ToUpper()) && t.Gia >= giatu && t.Gia <= giaden).ToList<BizSach>();
            }
            else if (tensach == null && theloai == 0 && giatu >= 0 && giaden >= 0)
            {
                ListSach = ListSach.Where(t => t.Gia >= giatu && t.Gia <= giaden).ToList<BizSach>();
            }
            return ListSach;
        }
        #endregion

        #region "Phân Trang"
        public List<BizSach> phantrangsach(int start,int offset,List<BizSach> ListSach)
        {

            List<BizSach> ListBooks = ListSach.Skip(start).Take(offset).ToList<BizSach>();
            return ListBooks;
        }
        #endregion

        #region "Sách"
        public List<BizSach> LayListSach()
        {
            return BizSach.LayListSach();
        }
        public List<BizSach> LayListSachDD()
        {
            return BizSach.LayListSachDD();
        }
        public void ThemSach(BizSach sach)
        {
            BizSach.ThemSach(sach);
        }
        public void SuaSach(BizSach sach)
        {
            BizSach.SuaSach(sach);
        }
        public void XoaSach(BizSach sach)
        {
            BizSach.XoaSach(sach);
        }
        public void KichHoat(BizSach sach)
        {
            BizSach.KichHoat(sach);
        }
        public void CapNhatKhuyenMai()
        {
            BizSach.CapNhatKhuyenMai();
        }
        #endregion

        #region "Thể Loại"
        public List<BizTheLoai> ListTheLoai()
        {
            return BizTheLoai.getList().Where(t => t.TrangThai == true).ToList() ;
        }
        public List<BizTheLoai> ListTheLoaiDD()
        {
            return BizTheLoai.getList();
        }
        public void DeleteTL(BizTheLoai tl)
        {
            BizTheLoai.Delete(tl);
        }
        public void InsertTL(BizTheLoai tl)
        {
            BizTheLoai.Insert(tl);
        }
        public void EditTL(BizTheLoai tl)
        {
            BizTheLoai.Edit(tl);
        }
        public void KichhoatTL(BizTheLoai tl)
        {
            BizTheLoai.Kichhoat(tl);
        }
        #endregion

        #region "Khuyến Mãi"
        public List<BizKhuyenMai> ListKhuyenMai()
        {
            return BizKhuyenMai.getList();
        }
        public void DeleteKM(BizKhuyenMai km)
        {
            BizKhuyenMai.Delete(km);
        }
        public bool InsertKM(BizKhuyenMai km)
        {
            return BizKhuyenMai.Insert(km);
        }
        public bool EditKM(BizKhuyenMai km)
        {
            return BizKhuyenMai.Edit(km);
        }
        public BizKhuyenMai LayKhuyenMai() // Có KM thi băng khác 0.
        {
            BizKhuyenMai KM = new BizKhuyenMai();
            List<BizKhuyenMai> ListKhuyenMai = BizKhuyenMai.getList();
            foreach (BizKhuyenMai km in ListKhuyenMai)
            {
                if (DateTime.Now >= km.NgayApDung && DateTime.Now <= km.NgayHetHan)
                {
                    return km;
                }
            }
            return KM;
        }
        #endregion

        #region "Nhân Viên"
        public BizNhanVien LayThongTinNhanVien(string MaNV)
        {
            return BizNhanVien.getList().Single(t => t.MaNV == MaNV);
        }
       

        public bool KiemTraMatKhau(string MaNV, string MatKhau)
        {
            List<BizNhanVien> list = BizNhanVien.getList().Where(t => t.MaNV == MaNV && t.MatKhau == t.MatKhau).ToList<BizNhanVien>();
            if (list.Count > 0)
                return true;
            return false;
        }
        public List<BizNhanVien> ListNhanVien()
        {
            return BizNhanVien.getList().Where(t => t.Quyen.MaQuyen != 1).ToList<BizNhanVien>();
        }
        public List<BizNhanVien> ListNhanVienVC()
        {
            return BizNhanVien.getList().Where(t=> t.Quyen.MaQuyen == 3).ToList<BizNhanVien>();
   
        }
        public void DeleteNV(BizNhanVien nv)
        {
            BizNhanVien.Delete(nv);
        }
        public void InsertNV1(BizNhanVien nv)
        {
            BizNhanVien.Insert1(nv);
        }
        public void InsertNV(BizNhanVien nv)
        {
            BizNhanVien.Insert(nv);
        }
        public void EditTTNVKMK(BizNhanVien nv) // ko chỉnh mật khẩu
        {
            nv.MatKhau = "";
            BizNhanVien.Edit(nv);
        }

        public void EditTTNVMK(BizNhanVien nv) // có chỉnh mật khẩu
        {
            BizNhanVien.Edit(nv);
        }
        public BizNhanVien KTraDNNV(BizNhanVien nv)
        {
            return BizNhanVien.KTraDN(nv);
        }
        #endregion

        #region "Quyền"
        public List<BizQuyen> ListQuyen()
        {
            return BizQuyen.getList();
        }
        public void DeleteQ(BizQuyen q)
        {
            BizQuyen.Delete(q);
        }
        public void InsertQ(BizQuyen q)
        {
            BizQuyen.Insert(q);
        }
        public void EditQ(BizQuyen q)
        {
            BizQuyen.Edit(q);
        }
        #endregion

        #region "Người Dùng"

        public int SoPDHHoanTat(BizNguoiDung nd)
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.NguoiDung.TenDN == nd.TenDN && t.TrangThai == 3).ToList<BizPhieuDatHang>().Count;
        }
        public int SoPDHHuy(BizNguoiDung nd)
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.NguoiDung.TenDN == nd.TenDN && t.TrangThai == -1).ToList<BizPhieuDatHang>().Count;
        }
        public BizNguoiDung LayThongTinNDEmail(string Email)
        {
            return BizNguoiDung.LaylistND().Single(t=> t.Email == Email);
        }
        public BizNguoiDung LayThongTinND(string TenDN)
        {
            return BizNguoiDung.LaylistND().Single(t=> t.TenDN == TenDN);
        }
        public List<BizNguoiDung> ListNguoiDung()
        {
            return BizNguoiDung.LaylistND();
        }
        public void DeleteND(BizNguoiDung nd)
        {
            BizNguoiDung.Delete(nd);
        }
        public void InsertND(BizNguoiDung nd)
        {
            BizNguoiDung.Insert(nd);
        }
        public void EditND(BizNguoiDung nd)
        {
            BizNguoiDung.Edit(nd);
        }
        public void EditMKND(BizNguoiDung nd)
        {
            BizNguoiDung.EditMKND(nd);
        }
        public int KTraDN(BizNguoiDung nd)
        {
            return BizNguoiDung.KTraDN(nd);
        }
        public int KTraTonTai(BizNguoiDung nd)
        {
            return BizNguoiDung.KtraTonTai(nd);
        }
        public bool KtraEmail(string Email)
        {
            List<BizNguoiDung> ListND = BizNguoiDung.LaylistND().Where(t=> t.Email == Email).ToList<BizNguoiDung>();
            if (ListND.Count > 0)
                return true;
            return false;
        }
        public bool KtraEmailND(string TenDN, string Email)
        {
            List<BizNguoiDung> ListND = BizNguoiDung.LaylistND().Where(t => t.TenDN != TenDN && t.Email == Email).ToList<BizNguoiDung>();
            if (ListND.Count > 0)
                return true;
            return false;

        }
        public bool KtraMatkhau(string TenDN,string MatKhau)
        {
            List<BizNguoiDung> ListND = BizNguoiDung.LaylistND().Where(t =>t.TenDN == TenDN && t.MatKhau == MatKhau).ToList<BizNguoiDung>();
            if (ListND.Count > 0)
                return true;
            return false;
        }

        #endregion

        #region "Đơn Hàng"

        public List<BizPhieuDatHang> LayListPDHCD()
        {
            return BizPhieuDatHang.LayListPDH().Where(t=>t.TrangThai == 0).ToList<BizPhieuDatHang>();
        }

        public List<BizPhieuDatHang> LayListPDHDD()
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 1).ToList<BizPhieuDatHang>();
        }

        public List<BizPhieuDatHang> LayListPDHDH()
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == -1).ToList<BizPhieuDatHang>();
        }

        public List<BizPhieuDatHang> LayListPDHTT()
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 4).ToList<BizPhieuDatHang>();
    
        }
        public List<BizPhieuDatHang> LayListPDHND(BizNguoiDung nd)
        {
            return BizPhieuDatHang.LayListPDH().Where(t =>t.NguoiDung.TenDN == nd.TenDN).ToList<BizPhieuDatHang>();
        }
        public List<BizPhieuDatHang> LayListPDHNDHT(BizNguoiDung nd)
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.NguoiDung.TenDN == nd.TenDN && t.TrangThai == 3).ToList<BizPhieuDatHang>();
        }
        public List<BizPhieuDatHang> LayListPDHNDDH(BizNguoiDung nd)
        {
            return BizPhieuDatHang.LayListPDH().Where(t => t.NguoiDung.TenDN == nd.TenDN && t.TrangThai == -1).ToList<BizPhieuDatHang>();
        }
        public BizPhieuDatHang LayPDH(int MaPDH)
        {
            return BizPhieuDatHang.LayListPDH().Single(t => t.MaPDH == MaPDH);
        }

        public void ThemPDH(BizPhieuDatHang pdh)
        {
            BizPhieuDatHang.ThemPDH(pdh);
        }

        public void ThemPDHTT(BizPhieuDatHang pdh)
        {
            BizPhieuDatHang.ThemPDHTT(pdh);
        }
        public void CapNhatTinhTrangPDH(BizPhieuDatHang pdh)
        {
            BizPhieuDatHang.CapNhatTinhTrang(pdh);
        }


        public decimal TinhTongTienPhieuDatHang(BizPhieuDatHang pdh)
        {
            return BizPhieuDatHang.TongTienDonHang(pdh);
        }
        #endregion

        #region "Chi Tiết Đơn Hàng"
        #endregion

        #region "Phiếu Nhập"

        public List<BizPhieuNhap> LayListPN()
        {
           return BizPhieuNhap.LayListPN();
        }

         
        public void ThemPN(List<BizPhieuNhap> LPN)
        {
            BizPhieuNhap.ThemPN(LPN);
        }
        #endregion

        #region "Chi Tiết Phiếu Nhập"
        public BizCTPhieuNhap KtraTonTaiSP(BizCTPhieuNhap CT, List<BizCTPhieuNhap> ListCT)
        {
            return BizCTPhieuNhap.KiemTraTonTaiSP(CT ,ListCT);
        }

      
        #endregion

        #region "Phiếu Vận Chuyển"
        public   List<BizPhieuVanChuyen> LayListPVC()
        {
            return BizPhieuVanChuyen.LayListPVC();
        }

        public void ThemPVC(BizPhieuVanChuyen PVC)
        {
            BizPhieuVanChuyen.ThemPVC(PVC);
        }

        public void CapNhatTinhTrangPVCDG(BizPhieuVanChuyen PVC)
        {
            BizPhieuVanChuyen.CapNhatTinhTrangGH(PVC);
        }

        public void CapNhatTinhTrangPVCKG(BizPhieuVanChuyen PVC)
        {
            BizPhieuVanChuyen.CapNhatTinhTrangKG(PVC);
        }

        public void CapNhatTinhTrangPVCTC(BizPhieuVanChuyen PVC)
        {
            BizPhieuVanChuyen.CapNhatTinhTrangTC(PVC);
        }


        public List<BizPhieuDatHang> ChuyenDoiPhieuDatHang(BizPhieuVanChuyen PVC)
        {
            return BizPhieuVanChuyen.ChuyenDoiPhieuDatHang(PVC);
        }

        public BizPhieuVanChuyen ChuyenDoiPhieuVanChuyen(BizPhieuVanChuyen PVC, List<BizPhieuDatHang> List)
        {
            return BizPhieuVanChuyen.ChuyenDoiPhieuVanChuyen(PVC, List);
        }

        public decimal TongTienPhieuVanChuyen(BizPhieuVanChuyen PVC)
        {
            return BizPhieuVanChuyen.TinhTongTienPhieuVanChuyen(PVC);
        }
        #endregion

        #region "Chi Tiết Phiếu Vận Chuyển"
        #endregion

        #region Thống kê - Báo Cáo 
        public List<BizSach> ThongKeTonKho(BizSach sach, DateTime NgayThongKe)//Thống kê tồn kho
        {
            List<BizSach> ListSach = BizSach.LayListSachDD();
            List<BizPhieuVanChuyen> ListPVC = BizPhieuVanChuyen.LayListPVCTK().Where(t =>  t.NgayDuyetGH <= NgayThongKe).ToList<BizPhieuVanChuyen>();
            List<BizPhieuNhap> ListPN = BizPhieuNhap.LayListPN().Where(t => t.NgayNhap <= NgayThongKe).ToList<BizPhieuNhap>();
            List<BizPhieuDatHang> ListPDHTT = BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 4 && t.NgayDH <= NgayThongKe).ToList<BizPhieuDatHang>(); 
            if (sach.MaSach != 0)
            {
                ListSach = ListSach.Where(t => t.MaSach == sach.MaSach).ToList<BizSach>();
            }
           
            foreach (BizSach s in ListSach)
            {
                s.SoLuong = 0;
                foreach (BizPhieuNhap pn in ListPN)
                {
                    foreach (BizCTPhieuNhap ctpn in pn.ChiTietPhieuNhaps)
                    {
                        if (s.MaSach == ctpn.Sach.MaSach)
                            s.SoLuong += ctpn.SoLuong;
                    }
                 
                }
                foreach (BizPhieuVanChuyen pvc in ListPVC)
                {
                    foreach (BizCTPhieuVanChuyen ctpvc in pvc.ChiTietPhieuVCs)
                    {
                        if (ctpvc.TrangThai == 1)
                        {
                            foreach (BizCTPhieuDatHang ctpdh in ctpvc.PhieuDatHang.ChiTietDonHangs)
                            {
                                if (s.MaSach == ctpdh.Sach.MaSach)
                                {
                                    s.SoLuong -= ctpdh.SoLuong;
                                }
                            }
                        }
                    }
                }
                foreach (BizPhieuDatHang pdh in ListPDHTT)
                {
                    foreach (BizCTPhieuDatHang ctpdh in pdh.ChiTietDonHangs)
                    {
                        if (s.MaSach == ctpdh.Sach.MaSach)
                        {
                            s.SoLuong -= ctpdh.SoLuong;
                        }
                    }
                }
            }
            return ListSach;
        }

        public List<BizSach> ThongKeSoLuongBanRa(BizTheLoai theloai, DateTime NgayBD, DateTime NgayKT) // Báo cáo số lượng ra
        {
            List<BizSach> ListSach = BizSach.LayListSachDD();
            List<BizPhieuVanChuyen> ListPVC = BizPhieuVanChuyen.LayListPVCTK().Where(t => t.NgayDuyetGH >= NgayBD && t.NgayDuyetGH <= NgayKT).ToList<BizPhieuVanChuyen>();
            List<BizPhieuDatHang> ListPDHTT = BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 4  && t.NgayDH >= NgayBD && t.NgayDH <= NgayKT).ToList<BizPhieuDatHang>(); 
           
            if (theloai.MaTL != 0)
            {
                ListSach = ListSach.Where(t => t.TheLoai.MaTL == theloai.MaTL).ToList<BizSach>();
            }

            foreach (BizSach s in ListSach)
            {
                s.SoLuong = 0;
                foreach (BizPhieuVanChuyen pvc in ListPVC)
                {
                    foreach (BizCTPhieuVanChuyen ctpvc in pvc.ChiTietPhieuVCs)
                    {
                        if (ctpvc.TrangThai == 1)
                        {
                            foreach (BizCTPhieuDatHang ctpdh in ctpvc.PhieuDatHang.ChiTietDonHangs)
                            {
                                if (s.MaSach == ctpdh.Sach.MaSach)
                                {
                                    s.SoLuong += ctpdh.SoLuong;
                                }
                            }
                        }
                    }
                }
                foreach (BizPhieuDatHang pdh in ListPDHTT)
                {
                    foreach (BizCTPhieuDatHang ctpdh in pdh.ChiTietDonHangs)
                    {
                        if (s.MaSach == ctpdh.Sach.MaSach)
                        {
                            s.SoLuong += ctpdh.SoLuong;
                        }
                    }
                }
        
            }
            return ListSach;
        }

        public List<BizSach> ThongKeTheoSoLuong(int SoLuong,bool kieusosanh, DateTime NgayBD, DateTime NgayKT) // Báo cáo  theo tổng số lượng bán ra 
        {
            List<BizSach> ListSach = BizSach.LayListSachDD();
            List<BizPhieuVanChuyen> ListPVC = BizPhieuVanChuyen.LayListPVCTK().Where(t => t.NgayDuyetGH >= NgayBD && t.NgayDuyetGH <= NgayKT).ToList<BizPhieuVanChuyen>();
            List<BizPhieuDatHang> ListPDHTT = BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 4 && t.NgayDH >= NgayBD && t.NgayDH <= NgayKT).ToList<BizPhieuDatHang>(); 
           
            foreach (BizSach s in ListSach)
            {
                s.SoLuong = 0;
                foreach (BizPhieuVanChuyen pvc in ListPVC)
                {
                    foreach (BizCTPhieuVanChuyen ctpvc in pvc.ChiTietPhieuVCs)
                    {
                        if (ctpvc.TrangThai == 1)
                        {
                            foreach (BizCTPhieuDatHang ctpdh in ctpvc.PhieuDatHang.ChiTietDonHangs)
                            {
                                if (s.MaSach == ctpdh.Sach.MaSach)
                                {
                                    s.SoLuong += ctpdh.SoLuong;
                                }
                            }
                        }
                    }
                }
                foreach (BizPhieuDatHang pdh in ListPDHTT)
                {
                    foreach (BizCTPhieuDatHang ctpdh in pdh.ChiTietDonHangs)
                    {
                        if (s.MaSach == ctpdh.Sach.MaSach)
                        {
                            s.SoLuong += ctpdh.SoLuong;
                        }
                    }
                }
        
                
            }
            if (kieusosanh == true)
            {
                ListSach = ListSach.Where(t => t.SoLuong >= SoLuong).ToList<BizSach>();
            }
            else
            {
                ListSach = ListSach.Where(t => t.SoLuong <= SoLuong).ToList<BizSach>();
            }
            return ListSach;
        }

        public List<BizSach> ThongKeDoanhThuTungSanPham(DateTime NgayBD, DateTime NgayKT)//Doanh Thu Từng Sản Phẩm
        {
            List<BizSach> ListSach = BizSach.LayListSachDD();
            decimal TongTienBanSanPham;
            decimal TongTienNhapHang;
            List<BizPhieuVanChuyen> ListPVC = BizPhieuVanChuyen.LayListPVCTK().Where(t => t.NgayDuyetGH >= NgayBD && t.NgayDuyetGH <= NgayKT).ToList<BizPhieuVanChuyen>();
            List<BizPhieuNhap> ListPN = BizPhieuNhap.LayListPN().Where(t => t.NgayNhap >= NgayBD && t.NgayNhap <= NgayKT).ToList<BizPhieuNhap>();
            List<BizPhieuDatHang> ListPDHTT = BizPhieuDatHang.LayListPDH().Where(t => t.TrangThai == 4 && t.NgayDH >= NgayBD && t.NgayDH <= NgayKT).ToList<BizPhieuDatHang>(); 
       
            foreach (BizSach s in ListSach)
            {

                s.Gia = 0;
                TongTienBanSanPham = 0;
                TongTienNhapHang = 0;

                foreach (BizPhieuNhap pn in ListPN)
                {
                    foreach (BizCTPhieuNhap ctpn in pn.ChiTietPhieuNhaps)
                    {
                        if (ctpn.Sach.MaSach == s.MaSach)
                        {
                            TongTienNhapHang += ctpn.DonGia * ctpn.SoLuong;
                        }
                    }
                }
                foreach (BizPhieuVanChuyen pvc in ListPVC)
                {

                    foreach (BizCTPhieuVanChuyen ctpvc in pvc.ChiTietPhieuVCs)
                    {
                        if (ctpvc.TrangThai == 1)
                        {
                            foreach (BizCTPhieuDatHang ctpdh in ctpvc.PhieuDatHang.ChiTietDonHangs)
                            {
                                if (ctpdh.Sach.MaSach == s.MaSach)
                                    TongTienBanSanPham += ctpdh.GiaTien;
                            }
                        }
                    }
                }
                foreach (BizPhieuDatHang pdh in ListPDHTT)
                {
                    foreach (BizCTPhieuDatHang ctpdh in pdh.ChiTietDonHangs)
                    {
                        if (s.MaSach == ctpdh.Sach.MaSach)
                        {
                            TongTienBanSanPham += ctpdh.GiaTien;
                        }
                    }
                }

                s.Gia = TongTienBanSanPham - TongTienNhapHang;

            }
            return ListSach;
        }

        public decimal ThongKeTienVanChuyen(DateTime NgayBD, DateTime NgayKT)
        {
            decimal tongtienvanchuyen = 0;
            List<BizPhieuVanChuyen> ListPVC = BizPhieuVanChuyen.LayListPVCTK().Where(t => t.NgayDuyetGH >= NgayBD && t.NgayDuyetGH <= NgayKT).ToList<BizPhieuVanChuyen>();
            foreach (BizPhieuVanChuyen pvc in ListPVC)
            {
                    foreach (BizCTPhieuVanChuyen ctpvc in pvc.ChiTietPhieuVCs)
                    {
                        if (ctpvc.TrangThai == 1)
                        {
                            tongtienvanchuyen += ctpvc.GiaTienVC;
                        }
                    }
            }
      
            return tongtienvanchuyen;
        }
        public decimal ThongKeTongDoanhThuSanPham(DateTime NgayBD, DateTime NgayKT)
        {
            decimal tongtiendoanhthusanpham = 0;
         
            List<BizSach> List = ThongKeDoanhThuTungSanPham(NgayBD, NgayKT);
            foreach (BizSach sach in List)
            {
                tongtiendoanhthusanpham += sach.Gia;
            }
            return tongtiendoanhthusanpham;
        }
        public decimal ThongKeTongDoanhThu(DateTime NgayBD, DateTime NgayKT)
        {
            decimal tongtiendoanhthu = 0;
            tongtiendoanhthu =ThongKeTongDoanhThuSanPham(NgayBD,NgayKT) + ThongKeTienVanChuyen(NgayBD, NgayKT);
            return tongtiendoanhthu;
        }
        #endregion
    }
}
