using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNhanVien;
using System.ServiceModel;
namespace WebNhanVien.usercontrol
{
    public partial class Login : System.Web.UI.UserControl
    {
        Book_Services.Book_ServiceClient sv;
          
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPanel();
            }
            catch
            {
               ClientMessageBox.Show("Bị Lỗi !!!", this);
    
            }

        }
        public void LoadPanel()
        {
            if (Session["MaNV"] != null)
            {

                CDN.Visible = false;
                DNR.Visible = true;

            }
            else
            {
                CDN.Visible = true;
                DNR.Visible = false;
            }
        }
        protected void btntendangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNhanVien nv = new Book_Services.BizNhanVien { MaNV = txttendangnhap.Text,MatKhau = sv.Mahoa(TxtMatKhau.Text) };
                nv = sv.KTraDNNV(nv);
                if (nv.MaNV != "")
                {
                    Session["MaNV"] = txttendangnhap.Text;
                    Response.Redirect(Request.UrlReferrer.AbsoluteUri);
                }
                else
                {
                    ClientMessageBox.Show("Bạn sai tên đăng nhập hoặc mật khẩu, vui lòng kiểm tra lại!!", this);
               
                }
               
            }
            catch
            {
                ClientMessageBox.Show("Bị Lỗi !!!", this);
    
            }
                
        }

        protected void LinkDNR_Click(object sender, EventArgs e)
        {
            try
            {
                Session["MaNV"] = null;
                Response.Redirect(Request.UrlReferrer.AbsoluteUri);
            }
            catch
            {
                ClientMessageBox.Show("Bị Lỗi !!!", this);
    
            }
        }

       

    }
}