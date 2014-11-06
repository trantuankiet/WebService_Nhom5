using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Book_WindowsFrom
{
    public partial class FrmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmNguoiDung()
        {
            InitializeComponent();
            Load();
        }

        public void setvalue()
        {
            txtSoPDHDH.Text = null;
            txtSoPDHHT.Text = null;
        }
        public void Load()
        {
            sv = new Book_Services.Book_ServiceClient();
            GridNguoiDung.DataSource = sv.ListNguoiDung();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (result == DialogResult.Yes)
                {

                    Book_Services.BizNguoiDung nd = (Book_Services.BizNguoiDung)gridND.GetRow(gridND.FocusedRowHandle);
                    if (nd != null)
                    {
                        sv = new Book_Services.Book_ServiceClient();
                        sv.DeleteND(nd);
                        setvalue();
                        Load();
                        sv.GuiMai_BaoXoaTK(nd);
                        XtraMessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn người dùng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setvalue();
                  
                    }
                }
               
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();
          
           // this.Close();
        }
        
        private void gridND_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Book_Services.BizNguoiDung nd = (Book_Services.BizNguoiDung)gridND.GetRow(gridND.FocusedRowHandle);
                sv = new Book_Services.Book_ServiceClient();
                txtSoPDHHT.Text = sv.LayListPDHNDHT(nd).Count.ToString();
                txtSoPDHDH.Text = sv.LayListPDHNDDH(nd).Count.ToString();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


       

        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}