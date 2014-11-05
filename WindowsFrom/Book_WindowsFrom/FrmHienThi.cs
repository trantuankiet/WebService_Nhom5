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
    public partial class FrmHienThi : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmHienThi()
        {
            InitializeComponent();
            HienThi();
        }
        public void HienThi()
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizKhuyenMai KM = sv.LayKhuyenMai();
            if (KM.MaKM != 0)
            {
                labelKM.Text = "Đang có đợt khuyến mãi sản phẩm từ ngày : " + KM.NgayApDung.ToShortDateString() + " đến ngày : " + KM.NgayHetHan.ToShortDateString();
                panelKm.Visible = true;

            }
            else
            {
                panelKm.Visible = false;
            }


        }
        private void BtnKichHoat_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                List<Book_Services.BizNguoiDung> List = sv.ListNguoiDung();
                Book_Services.BizKhuyenMai KM = sv.LayKhuyenMai();
                sv.GuiMail_TBKhuyenMai(List, KM);
                MessageBox.Show("Gửi mail cho các người dùng thành công!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }
    }
}