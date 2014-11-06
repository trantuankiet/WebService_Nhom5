using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizNhanVien
    {
        #region khai báo
        private string maNV;

        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        private BizQuyen quyen;

        public BizQuyen Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string tenNV;

        public string TenNV
        {
            get { return tenNV; }
            set { tenNV = value; }
        }
        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string sDT;

        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }
        private DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        private Boolean trangThai;

        public Boolean TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        public static List<BizNhanVien> getList()
        {
            return DalNhanVien.getList().Where(t => t.TrangThai == true).ToList<BizNhanVien>() ;
        }
        
        public static void Delete(BizNhanVien nv)
        {
            DalNhanVien.delete(nv);
        }

        public static void Insert(BizNhanVien nv)
        {
            DalNhanVien.insert(nv);
        }

        public static void Edit(BizNhanVien nv)
        {
            DalNhanVien.edit(nv);
        }
        public static BizNhanVien KTraDN(BizNhanVien nv)
        {
            return DalNhanVien.KTraDN(nv);
        }

        public static void Insert1(BizNhanVien nv)
        {
            DalNhanVien.insert1(nv);
        }
    }
}
