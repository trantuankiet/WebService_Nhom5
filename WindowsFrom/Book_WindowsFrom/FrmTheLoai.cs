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
    public partial class FrmTheLoai : DevExpress.XtraEditors.XtraForm
    {
        public FrmTheLoai()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                gridControl1.DataSource = sv.ListTheLoaiDD();
            }
            catch
            {
                   XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void btnKichhoat_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizTheLoai theloai = (Book_Services.BizTheLoai)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (theloai.TrangThai == false)
                {
                    sv.KichhoatTL(theloai);
                    MessageBox.Show("Kích hoạt thành công thể loại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Thể loại này đang hoạt động!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LoadGrid();
                TxtTenDM.Text = null;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizTheLoai tl = new Book_Services.BizTheLoai();
                tl.TenDM = TxtTenDM.Text;
                tl.TrangThai = true;
                sv.InsertTL(tl);
                LoadGrid();
                MessageBox.Show("Thêm thành công thể loại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TxtTenDM.Text = null;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizTheLoai theloai = (Book_Services.BizTheLoai)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (theloai != null)
                {
                    if (theloai.TrangThai == true)
                    {
                        sv.DeleteTL(theloai);
                        MessageBox.Show("Xóa thành công thể loại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thể loại này đã được xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadGrid();
                    TxtTenDM.Text = null;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thể loại để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizTheLoai theloai = (Book_Services.BizTheLoai)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (theloai != null)
                {
                    if (theloai.TrangThai == true)
                    {
                        theloai.TenDM = TxtTenDM.Text;
                        sv.EditTL(theloai);
                        MessageBox.Show("Sửa thành công thể loại!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Thể loại này đã bị xóa!", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    LoadGrid();
                    TxtTenDM.Text = null;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn thể loại để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
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
          
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Book_Services.BizTheLoai theloai = (Book_Services.BizTheLoai)gridView1.GetRow(gridView1.FocusedRowHandle);
            TxtTenDM.Text = theloai.TenDM;
        }

        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}