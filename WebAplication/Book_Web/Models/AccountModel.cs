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
    public class SignupModel
    {
        #region Khai báo

        private string tenDN;

        [Required(ErrorMessage="Vui lòng nhập thông tin")]
        [Display(Name="Tên đăng nhập")]
        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }


        
        private string matKhau;
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "{0} tối thiểu là {2} ký tự", MinimumLength = 6)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string nhapLaiMatKhau;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "{0} tối thiểu là {2} ký tự", MinimumLength = 6)]
        [Compare("MatKhau",ErrorMessage ="Mật khấu nhập lại không trùng")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string NhapLaiMatKhau
        {
            get { return nhapLaiMatKhau; }
            set { nhapLaiMatKhau = value; }
        }

        private string hoTen;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Họ tên người dùng")]
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string diaChi;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Địa chỉ người dùng")]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string email;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.EmailAddress,ErrorMessage = "Vui lòng nhập đúng Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Vui lòng nhập đúng Email")]
        [Display(Name = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string sdt;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.PhoneNumber,ErrorMessage="Vui lòng nhập đúng số phone")]
        [Display(Name = "Số điện thoại")]
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private DateTime ngaySinh;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DisplayFormat(DataFormatString ="dd/MM/yyyy")]
        [DataType(DataType.Date,ErrorMessage ="Vui lòng nhập đúng ngày tháng")]
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        
        #endregion
        #region Phương thức

        public Book_Services.BizNguoiDung ChuyenDoiND()
        {
            Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
            return new Book_Services.BizNguoiDung
            {
                TenDN = TenDN,
                DiaChi = DiaChi,
                MatKhau = sv.Mahoa(MatKhau),
                Email = Email,
                NgaySinh = NgaySinh,
                HoTen = HoTen,
                Sdt = Sdt
            };
        }
   
        #endregion
    }
    public class EditAccountModel
    {
        #region Khai báo

        private string tenDN;
        [Display(Name = "Tên đăng nhập")]
        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }


        
        private string hoTen;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Họ tên người dùng")]
        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        private string diaChi;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [Display(Name = "Địa chỉ người dùng")]
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private string email;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui lòng nhập đúng Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Vui lòng nhập đúng Email")]
        [Display(Name = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string sdt;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Vui lòng nhập đúng số phone")]
        [Display(Name = "Số điện thoại")]
        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        private DateTime ngaySinh;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Date, ErrorMessage = "Vui lòng nhập đúng ngày tháng")]
        [DisplayFormat(DataFormatString = "dd/MM/yyyy")]
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        #endregion
        #region Phương thức

        public Book_Services.BizNguoiDung ChuyenDoiND()
        {
            return new Book_Services.BizNguoiDung
            {
                TenDN = TenDN,
                DiaChi = DiaChi,
                Email = Email,
                NgaySinh = NgaySinh,
                HoTen = HoTen,
                Sdt = Sdt
            };
        }


        public static EditAccountModel ChuyendoiModel(Book_Services.BizNguoiDung nd)
        {
            return new EditAccountModel
            {
                TenDN = nd.TenDN,
                DiaChi = nd.DiaChi,
                Email = nd.Email,
                NgaySinh = nd.NgaySinh,
                HoTen = nd.HoTen,
                Sdt = nd.Sdt
            };
        }
        #endregion
    }
    public class ChangePassModel
    {
        #region Khai báo

        private string tenDN;
        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }


        private string matKhauCu;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "{0} tối thiểu là {2} ký tự", MinimumLength = 6)]
        [Display(Name = "Mật khẩu Cũ")]
        public string MatKhauCu
        {
            get { return matKhauCu; }
            set { matKhauCu = value; }
        }

        private string matKhau;
        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "{0} tối thiểu là {2} ký tự", MinimumLength = 6)]
        [Display(Name = "Mật khẩu")]
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string nhapLaiMatKhau;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.Password)]
        [StringLength(30, ErrorMessage = "{0} tối thiểu là {2} ký tự", MinimumLength = 6)]
        [Compare("MatKhau", ErrorMessage = "Mật khấu nhập lại không trùng")]
        [Display(Name = "Nhập lại mật khẩu")]
        public string NhapLaiMatKhau
        {
            get { return nhapLaiMatKhau; }
            set { nhapLaiMatKhau = value; }
        }


        #endregion
        public Book_Services.BizNguoiDung ChuyenDoiND()
        {
            Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
            return new Book_Services.BizNguoiDung
            {
                TenDN = TenDN,
                MatKhau = sv.Mahoa(MatKhau),
            };
        }
        public static ChangePassModel ChuyendoiModel(Book_Services.BizNguoiDung nd)
        {
            return new ChangePassModel
            {
                TenDN = nd.TenDN,
                MatKhauCu = null,
                MatKhau = null,
                NhapLaiMatKhau = null
            };
        }

    }
    public class ForgotPassModel
    {
        #region Khai báo

   
        
        private string email;


        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui lòng nhập đúng Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Vui lòng nhập đúng Email")]
        [Display(Name = "Email")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string emailNhapLai;

        [Required(ErrorMessage = "Vui lòng nhập thông tin")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Vui lòng nhập đúng Email")]
        [RegularExpression(@"^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$", ErrorMessage = "Vui lòng nhập đúng Email")]
        [Compare("Email", ErrorMessage = "Email nhập lại không trùng")]
        [Display(Name = "Nhập lại Email")]
        public string EmailNhapLai
        {
            get { return emailNhapLai; }
            set { emailNhapLai = value; }
        }


        #endregion
    }




}