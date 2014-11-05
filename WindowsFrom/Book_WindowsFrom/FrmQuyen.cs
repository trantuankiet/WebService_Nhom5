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
    public partial class FrmQuyen : DevExpress.XtraEditors.XtraForm
    {
        public static Book_Services.BizNhanVien nhanvien;
        public FrmQuyen()
        {
            InitializeComponent();
            LoadGrid();
        }
        public void LoadGrid()
        {
            Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
            gridControl1.DataSource = sv.ListQuyen();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizQuyen quyen = new Book_Services.BizQuyen();
                quyen.TenQuyen = TxtQuyen.Text;
                quyen.TrangThai = true;
                sv.InsertQ(quyen);
                LoadGrid();
                XtraMessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                TxtQuyen.Text = null;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Book_Services.BizQuyen row = (Book_Services.BizQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
            TxtQuyen.Text = row.TenQuyen;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (result == DialogResult.Yes)
                {
                    Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                    Book_Services.BizQuyen row = (Book_Services.BizQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
                    if (row != null)
                    {
                        row.TrangThai = false;
                        sv.DeleteQ(row);
                        LoadGrid();
                        XtraMessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        TxtQuyen.Text = null;
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn quyền để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
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
                Book_Services.BizQuyen row = (Book_Services.BizQuyen)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (row != null)
                {
                    row.TenQuyen = TxtQuyen.Text;
                    sv.EditQ(row);
                    LoadGrid();
                    XtraMessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                    TxtQuyen.Text = null;
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn quyền để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}