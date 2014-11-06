using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.BLL;
namespace Book_Library.DAL
{
    public class DalNhanVien
    {
        static DbWSDataContext db;
        public static List<BizNhanVien> getList()
        {
            db = new DbWSDataContext();
            List<BizNhanVien> nv = (from p in db.NhanViens
                                    select new BizNhanVien
                                    {
                                        MaNV = p.MaNV,
                                        Quyen = new BizQuyen
                                        {
                                            MaQuyen = p.MaQuyen,
                                            TenQuyen = p.Quyen.TenQuyen
                                        },
                                        MatKhau = p.MatKhau,
                                        TenNV = p.TenNV,
                                        DiaChi = p.DiaChi,
                                        Email = p.Email,
                                        SDT = p.SDT,
                                        NgaySinh = p.NgaySinh,
                                        TrangThai = p.Trangthai
                                    }).ToList<BizNhanVien>();
            return nv;
        }
      

        public static void insert(BizNhanVien nv)
        {
            db = new DbWSDataContext();
            NhanVien nhanvien = new NhanVien();
            nhanvien.MaNV = nv.MaNV;
            nhanvien.MaQuyen = nv.Quyen.MaQuyen;
            nhanvien.MatKhau = nv.MatKhau;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.DiaChi = nv.DiaChi;
            nhanvien.Email = nv.Email;
            nhanvien.SDT = nv.SDT;
            nhanvien.NgaySinh = nv.NgaySinh;
            nhanvien.Trangthai = true;
            db.NhanViens.InsertOnSubmit(nhanvien);
            db.SubmitChanges();
        }
        public static void delete(BizNhanVien nv)
        {
            db = new DbWSDataContext();
            var nhanvien = (from p in db.NhanViens
                            where p.MaNV == nv.MaNV
                            select p).FirstOrDefault();
            nhanvien.Trangthai = false;
            db.SubmitChanges();
        }
        public static void edit(BizNhanVien nv)
        {
            db = new DbWSDataContext();
            var nhanvien = (from p in db.NhanViens
                            where p.MaNV == nv.MaNV
                            select p).FirstOrDefault();
            if(nv.Quyen != null)
               nhanvien.MaQuyen = nv.Quyen.MaQuyen;
            nhanvien.TenNV = nv.TenNV;
            nhanvien.DiaChi = nv.DiaChi;
            nhanvien.Email = nv.Email;
            nhanvien.SDT = nv.SDT;
            nhanvien.NgaySinh = nv.NgaySinh;
            if (nv.MatKhau != "")
            {
                nhanvien.MatKhau = nv.MatKhau;
            }
            db.SubmitChanges();
        }
       
        public static BizNhanVien KTraDN(BizNhanVien nv)
        {
            db = new DbWSDataContext();
            NhanVien nhanvien = (from p in db.NhanViens
                                    where p.MaNV == nv.MaNV && p.MatKhau == nv.MatKhau && p.Trangthai == true && (p.MaQuyen == 1 || p.MaQuyen ==2 ) 
                                    select p).FirstOrDefault<NhanVien>();
            if (nhanvien != null)
            {
               return new BizNhanVien
                    {
                        MaNV = nhanvien.MaNV,
                        Quyen = new BizQuyen
                        {
                            MaQuyen = nhanvien.MaQuyen,
                            TenQuyen = nhanvien.Quyen.TenQuyen
                        },
                        MatKhau = nhanvien.MatKhau,
                        TenNV = nhanvien.TenNV,
                        DiaChi = nhanvien.DiaChi,
                        Email = nhanvien.Email,
                        SDT = nhanvien.SDT,
                        NgaySinh = nhanvien.NgaySinh
                    }; 
            }
            return new BizNhanVien
                {
                    MaNV = ""
                };
        }

        public static void insert1(BizNhanVien nv)
        {
            db = new DbWSDataContext();
            NhanVien nhanvien1 = new NhanVien();
            nhanvien1.MaNV = nv.MaNV;
            nhanvien1.MaQuyen = nv.Quyen.MaQuyen;
            nhanvien1.MatKhau = nv.MatKhau;
            nhanvien1.TenNV = nv.TenNV;
            nhanvien1.DiaChi = nv.DiaChi;
            nhanvien1.Email = nv.Email;
            nhanvien1.SDT = nv.SDT;
            nhanvien1.NgaySinh = nv.NgaySinh;
            nhanvien1.Trangthai = true;
            db.NhanViens.InsertOnSubmit(nhanvien1);
            db.SubmitChanges();
        }

        
    }
}
