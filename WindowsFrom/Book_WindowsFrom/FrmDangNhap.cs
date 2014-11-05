using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.ServiceModel;
namespace Book_WindowsFrom
{
    public partial class FrmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            Book_Services.Book_ServiceClient sv= new Book_Services.Book_ServiceClient();
            Book_Services.BizNhanVien nv = new Book_Services.BizNhanVien
            {
                 MaNV = txtTenDN.Text,
                 MatKhau = sv.Mahoa(txtMK.Text)
            };
            nv = sv.KTraDNNV(nv);
            if (nv.MaNV != "")
            {
                FrmMain.check = true;
                FrmMain.nhanvien = nv;
                this.Close();

            }
            else
            {
                MessageBox.Show("Bạn sai tên đăng nhập hoặc mật khẩu, vui lòng kiểm tra lại!!","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtMK.Text = null;
            }
        }
    }
}