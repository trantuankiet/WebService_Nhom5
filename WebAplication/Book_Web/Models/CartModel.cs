using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.ServiceModel;

namespace Book_Web.Models
{
    public class CartModel
    {
        #region Khai báo
        
        private List<Book_Services.BizCTPhieuDatHang> chiTietDonHangs;

        public List<Book_Services.BizCTPhieuDatHang> ChiTietDonHangs
        {
            get { return chiTietDonHangs; }
            set { chiTietDonHangs = value; }
        }

        private string hoTenNN;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Họ tên người nhận")]
        public string HoTenNN
        {
            get { return hoTenNN; }
            set { hoTenNN = value; }
        }

        private string email;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui lòng nhập đúng Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Vui lòng nhập đúng Email")]
        [Display(Name = "Email người nhận")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string diaChiNN;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Địa chỉ người nhận")]
        public string DiaChiNN
        {
            get { return diaChiNN; }
            set { diaChiNN = value; }
        }

        private string sDT;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Vui lòng nhập đúng số phone")]
        [Display(Name = "Số điện thoại người nhận")]
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        
        #endregion

        #region Phương thức
        public static CartModel ChuyenDoiPDH(Book_Services.BizPhieuDatHang pdh)
        {
            return new CartModel
            {
                HoTenNN = pdh.NguoiDung.HoTen,
                DiaChiNN = pdh.NguoiDung.DiaChi,
                Email = pdh.NguoiDung.Email,
                SDT = pdh.NguoiDung.Sdt,
                ChiTietDonHangs = pdh.ChiTietDonHangs
            };
        }
        public Book_Services.BizPhieuDatHang ChuyenDoiPDHThem(Book_Services.BizPhieuDatHang PDH)
        {
            return new Book_Services.BizPhieuDatHang
            {
                HoTenNN = HoTenNN,
                DiaChiNN = DiaChiNN,
                Email = Email,
                SDT = SDT,          
                ChiTietDonHangs = PDH.ChiTietDonHangs
            };
        }
        #endregion
    }
}