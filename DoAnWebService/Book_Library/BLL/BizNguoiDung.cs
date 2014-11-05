using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using Book_Library.DAL;

namespace Book_Library.BLL
{
    public class BizNguoiDung
    {

        #region Khai báo
        private string tenDN;

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
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
        private string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
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
        #region Phương thức
        public static List<BizNguoiDung> LaylistND()
        {
            return DalNguoiDung.getList().Where(t=> t.TrangThai == true).ToList<BizNguoiDung>();
        }


        public static void Delete(BizNguoiDung nd)
        {
            DalNguoiDung.delete(nd);
        }
        public static void Insert(BizNguoiDung nd)
        {
            DalNguoiDung.insert(nd);
        }
        public static void Edit(BizNguoiDung nd)
        {
            DalNguoiDung.edit(nd);
        }
        public static int KTraDN(BizNguoiDung nd)
        {
            return DalNguoiDung.KTraDN(nd);
        }
        public static int KtraTonTai(BizNguoiDung nd)
        {
            return DalNguoiDung.KTraTonTai(nd);
        }
        #endregion

        public static void EditMKND(BizNguoiDung nd)
        {
            DalNguoiDung.editMKND(nd);
        }
    }
}
