using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalSach
    {
        static DbWSDataContext db;
      
        public static List<BizSach> LayListSach()
        {
            db = new DbWSDataContext();
            List<BizSach> ListSach = (from s in db.Saches
                                      select new BizSach
                                      {
                                          MaSach = s.MaSach,
                                          Tensach = s.TenSach,
                                          KhuyenMai = s.KhuyenMai == null ? new BizKhuyenMai
                                                                            {
                                                                                MaKM = 0
                                                                            }
                                                                            : new BizKhuyenMai
                                                                            {
                                                                                MaKM = s.KhuyenMai.MaKM,
                                                                                TenKM = s.KhuyenMai.TenKM,
                                                                                GiaTriGiam = s.KhuyenMai.GiaTriGiam,
                                                                                NgayApDung = s.KhuyenMai.NgayApDung,
                                                                                NgayHetHan = s.KhuyenMai.NgayHetHan
                                                                            },
                                          TheLoai = new BizTheLoai
                                          {
                                               MaTL = s.TheLoai.MaTL,
                                               TenDM = s.TheLoai.TenDM,
                                               TrangThai = s.Trangthai
                                          },
                                          TenTacGia = s.TenTacGia,
                                          NoiDung = s.NoiDung,
                                          Gia = s.Gia ,
                                          HinhAnh = s.HinhAnh,
                                          LoaiBia = s.LoaiBia,
                                          NamXuatBan = s.NamXuatBan,
                                          NhaXuatBan = s.NhaXuatBan,
                                          SoLuong = s.SoLuong == null ? 0 : Convert.ToInt32(s.SoLuong),
                                          SoTrang = s.SoTrang,
                                          GiaVon = s.GiaVon == null ? 0 : Convert.ToDecimal(s.GiaVon),
                                          PhanTramLoi = s.PhanTramLoi == null ? 30 : (int)s.PhanTramLoi,
                                          TrangThai = s.Trangthai
                                      }).ToList<BizSach>();
            return ListSach;
        }

        public static int LaySoLuong(BizSach sach)
        {
            db = new DbWSDataContext();
            Sach s = (from sc in db.Saches
                      where sc.MaSach == sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            return s.SoLuong == null ? 0 : Convert.ToInt32(s.SoLuong);
        }

        
        public static void ThemSach(BizSach sach)
        {
            db = new DbWSDataContext();
            Sach s = new Sach
            {
                TenSach = sach.Tensach,
                MaTL = sach.TheLoai.MaTL,
                TenTacGia = sach.TenTacGia,
                NoiDung = sach.NoiDung,
                Gia = sach.GiaVon + sach.GiaVon * Convert.ToDecimal(Convert.ToDecimal(sach.PhanTramLoi) / Convert.ToDecimal(100)),
                GiaVon = sach.GiaVon,
                HinhAnh = sach.HinhAnh,
                LoaiBia = sach.LoaiBia,
                NamXuatBan = sach.NamXuatBan,
                NhaXuatBan = sach.NhaXuatBan,
                SoLuong = 0,
                PhanTramLoi = sach.PhanTramLoi,
                SoTrang = sach.SoTrang,
                Trangthai = true

            };
            db.Saches.InsertOnSubmit(s);
            db.SubmitChanges();

        }

        public static void SuaSach(BizSach sach)
        {
            db = new DbWSDataContext();
            Sach s = (from sc in db.Saches
                      where sc.MaSach == sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            s.TenSach = sach.Tensach;
            s.MaTL = sach.TheLoai.MaTL;
            s.TenTacGia = sach.TenTacGia;
            s.NoiDung = sach.NoiDung;
            s.Gia = sach.GiaVon + sach.GiaVon * Convert.ToDecimal(Convert.ToDecimal(sach.PhanTramLoi) / Convert.ToDecimal(100));
            s.GiaVon = sach.GiaVon; 
            s.HinhAnh = sach.HinhAnh;
            s.LoaiBia = sach.LoaiBia;
            s.NamXuatBan = sach.NamXuatBan;
            s.NhaXuatBan = sach.NhaXuatBan;
            s.PhanTramLoi = sach.PhanTramLoi;
            s.SoTrang = sach.SoTrang;
            db.SubmitChanges();
        }

        public static void SuaSPNhapKho(BizCTPhieuNhap CT)
        {
    	    db = new DbWSDataContext();
            Sach s = (from sc in db.Saches
                      where sc.MaSach == CT.Sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            if (s.PhanTramLoi != null)
            {
                s.Gia = CT.DonGia + CT.DonGia * Convert.ToDecimal(Convert.ToDecimal(s.PhanTramLoi) / Convert.ToDecimal(100));
            }
            else
            {
                s.Gia = CT.DonGia + CT.DonGia * Convert.ToDecimal(0.3);

            }
            s.GiaVon = CT.DonGia;
            s.SoLuong += CT.SoLuong;
            db.SubmitChanges();
        }

        public static void SuaSPDonHangDH(BizCTPhieuDatHang CT)
        {
            db = new DbWSDataContext();
       
            Sach s = (from sc in db.Saches
                      where sc.MaSach == CT.Sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            s.SoLuong += CT.SoLuong;
            db.SubmitChanges();
        }
        public static void SuaSPDonHang(BizCTPhieuDatHang CT)
        {
            db = new DbWSDataContext();
       
            Sach s = (from sc in db.Saches
                      where sc.MaSach == CT.Sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            s.SoLuong -= CT.SoLuong;
            db.SubmitChanges();
        }
        public static void XoaSach(BizSach sach)
        {
            db = new DbWSDataContext();
       
            Sach s = (from sc in db.Saches
                      where sc.MaSach == sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            s.Trangthai = false;
            db.SubmitChanges();
        }

        public static void KichHoat(BizSach sach)
        {
            db = new DbWSDataContext();
       
            Sach s = (from sc in db.Saches
                      where sc.MaSach == sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            s.Trangthai = true;
            db.SubmitChanges();
        }
        public static void CapNhatKhuyenMai(BizSach sach, BizKhuyenMai Km)
        {
            db = new DbWSDataContext();
            Sach s = (from sc in db.Saches
                      where sc.MaSach == sach.MaSach
                      select sc).FirstOrDefault<Sach>();
            if (Km.MaKM == 0)
            {
                s.KhuyenMai = null;
                s.MaKM = null;
            }
            else
            {
                KhuyenMai khuyenmai = db.KhuyenMais.Single(t => t.MaKM == Km.MaKM);
                s.KhuyenMai = khuyenmai;
                s.MaKM = khuyenmai.MaKM;
            }
            db.SubmitChanges();
        }

    }
}
