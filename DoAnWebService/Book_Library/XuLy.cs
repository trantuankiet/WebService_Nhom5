using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Reflection;
using System.Collections;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace Book_Library.BLL
{

    public static class XuLyMaHoa
    {

        public static string Decrypt(string toDecrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Convert.FromBase64String(toDecrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public static string Encrypt(string toEncrypt, string key, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }


    }
    public static class XuLySendMail
    {
        public static bool SendMail_QuenMatKhau(string to,string TenDN, string MatKhau)
        {
            string Subject = "Cửa Hàng T4 Book Thông Báo Đã Cấp Lại Mật Khẩu Của Bạn";


            string str = "<html>"
                       + "<P>Xin chào,tên đăng nhập của bạn  là : " + TenDN + "</P></br>"
                       
                       + "<P>Mật khẩu mới của bạn được cấp là : "+ MatKhau +"</P></br>"
                       
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;
                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SendMail_BaoXoaTK(string to, string HoTen, string TenDN)
        {
            string Subject = "Cửa Hàng T4 Book Thông Báo Đã Xóa Tài Khoản Của Bạn";


            string str = "<html>"
                       + "<P>Xin chào " + HoTen + " tài khoản của bạn sử dụng đã bị xóa là :</P></br>"
                       + "<P> Tên Đăng Nhập :" + TenDN + "</P></br>"
                       + "<P>Đã Bị Xóa Vì Những Lý Do Vi Phạm Quy Định Cửa Hàng</P></br>"
                       + "<P></P>"
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;
                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SendMail_NhanVien(string to, string HoTen, string TenDN, string matkhau)
        {
            string Subject = "Chúc Mừng Bạn Đã Là Nhân Viên Của Cửa Hàng T4 Book";


            string str = "<html>"
                       + "<P>Xin chào " + HoTen + " bạn sẽ sử dụng tài khoàn đăng nhập như sau:</P></br>"
                       + "<P>Bạn Sẽ Đăng Nhập Với Tên Đăng Nhập Là :" + TenDN + "</P></br>"
                       + "<P>Mật Khẩu Là :" + matkhau + "</P></br>"
                       + "<P>Bạn Vui Lòng <a href='http://localhost:1049'>Bấm Vào Đây</a> Để Thay Đổi Mất Khẩu </P></br>"
                       + "<P></P>"
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SendMail_NguoiDung(string to, string Hoten)
        {
            string Subject = "Chúc Mừng Bạn Đã Đăng Ký Thành Công Tài Khoản Tại Trang Web Của Cửa Hàng T4 Book";


            string str = "<html>"
                       + "<P>Xin chào " + Hoten + "</P></br>"
                       + "<P>Bạn Đã Đăng Ký Thành Công Tài Khoản</P></br>"
                       + "<P>Bạn Sẽ Nhận Được Nhận Ưu Đãi Tốt Nhất Từ Web của Chúng tối</P></br>"
                       + "<P>Chúc Bạn Mua Sắm Vui Vẻ</P></br>"
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public static bool SendMail_ThanhToan(string to, string sosp, decimal tongtien)
        {
            string Subject = "Chúc Mừng Bạn Đã Đặt Hàng Thành Công Tại Trang Web Của Cửa Hàng T4 Book";


            string str = "<html>"
                       + "<P>Xin chào </P></br>"
                       + "<P>Bạn Đã Mua Hàng Thành Công</P></br>"
                       + "<P>Với Số Sản Phẩm " + sosp + "</P></br>"
                       + "<P>Và Với Số Tiền Là " + string.Format("{0:0,0 VNĐ}", tongtien) + "</P></br>"
                       + "<P>Các bạn vui lòng chờ  sẽ có nhân viên liên hệ với bạn trong vòng 24h</P></br>"
                       + "<P>Cám Ơn Bạn Đã Mua Hàng Tại Website</P></br>"
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static bool SendMail_BaoKhuyenMai(string to, string HoTen, string TenKM, DateTime NgayBatDau, DateTime NgayKetThuc, int GiaTriGiam)
        {
            string Subject = "Thông Báo Khuyến Mãi Tại Trang Web Của Cửa Hàng T4 Book";


            string str = "<html>"
                       + "<P>Xin chào :"+ HoTen + "</P></br>"
                       + "<P>Chúng Tôi Xin Thông Báo Đến Bạn Chương Trình Khuyễn Mãi Của Cửa Hàng Chúng Tôi</P></br>"
                       + "<P>Với Giá Trị Giảm Đến " + GiaTriGiam.ToString() + "% </P></br>"
                       + "<P>Chương Trình Được Bắt Đầu Từ Ngày: "+NgayBatDau.ToShortDateString()+" Đến Ngày :"+NgayKetThuc.ToShortDateString()+"</P></br>"
                       + "<P>Bạn Vui Lòng <a href='http://localhost:1049'>Bấm Vào Đây</a> Để Vào Web Chúng Tôi Mua Hàng </P></br>"
                       + "<P>Chúc Bạn 1 ngày vui vẽ</P></br>"
                       + "</html>";

            MailMessage mail = new MailMessage("tfourbook@gmail.com", to, Subject, str);
            mail.IsBodyHtml = true;
            try
            {
                SmtpClient client = new SmtpClient();
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.EnableSsl = true;
                client.Host = "smtp.gmail.com";
                client.Port = 587;

                // setup Smtp authentication
                NetworkCredential credentials = new NetworkCredential("tfourbook@gmail.com", "0938613461");
                client.UseDefaultCredentials = false;
                client.Credentials = credentials;

                client.Send(mail);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

   
    public static class XuLyKhac
    {
        private static readonly string[] VietNamChar = new string[] 
            {
                "aAeEoOuUiIdDyY", 
                "áàạảãâấầậẩẫăắằặẳẵ", 
                "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", 
                "éèẹẻẽêếềệểễ", 
                "ÉÈẸẺẼÊẾỀỆỂỄ", 
                "óòọỏõôốồộổỗơớờợởỡ", 
                "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", 
                "úùụủũưứừựửữ", 
                "ÚÙỤỦŨƯỨỪỰỬỮ", 
                "íìịỉĩ", 
                "ÍÌỊỈĨ", 
                "đ", 
                "Đ", 
                "ýỳỵỷỹ", 
                "ÝỲỴỶỸ" 
            };
        public static string LocDau(string str)
        {
            //Thay thế và lọc dấu từng char      
            for (int i = 1; i < VietNamChar.Length; i++)
            {
                for (int j = 0; j < VietNamChar[i].Length; j++)
                    str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
            }
            return str;
        }
        public static string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public static bool CheckFileType(string fileName)
        {

            string ext = Path.GetExtension(fileName);

            switch (ext.ToLower())
            {

                case ".gif":

                    return true;

                case ".png":

                    return true;

                case ".jpg":

                    return true;

                case ".jpeg":

                    return true;

                default:

                    return false;

            }

        }
    
    }
}