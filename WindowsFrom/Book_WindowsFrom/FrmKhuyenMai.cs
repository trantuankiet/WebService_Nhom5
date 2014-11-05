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
    public partial class FrmKhuyenMai : DevExpress.XtraEditors.XtraForm
    {
        public FrmKhuyenMai()
        {
            InitializeComponent();
            Load();
        }
        
        public void Load()
        {
            try
            {
                Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                gridControlKM.DataSource = sv.ListKhuyenMai();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
       
            }
        }

        public void setvalue()
        {
            txtTenKM.Text = null;
            txtGTGiam.Text = null;
            dateTimePickerNAD.Value = DateTime.Now;
            dateTimePickerNHH.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerNAD.Value < dateTimePickerNHH.Value)
                {

                    Book_Services.BizKhuyenMai km = new Book_Services.BizKhuyenMai();
                    km.TenKM = txtTenKM.Text;
                    km.GiaTriGiam = Convert.ToInt32(txtGTGiam.Text);
                    km.NgayApDung = dateTimePickerNAD.Value;
                    km.NgayHetHan = dateTimePickerNHH.Value;
                    Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                    if (sv.InsertKM(km))
                    {
                        Load();
                        XtraMessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setvalue();
                    }
                    else
                    {
                        XtraMessageBox.Show("Khoảng thời gian khuyến mãi đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    XtraMessageBox.Show("Chọn ngày áp dụng nhỏ hơn ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            try
            {
                if (result == DialogResult.Yes)
                {
                    Book_Services.BizKhuyenMai km = (Book_Services.BizKhuyenMai)gridViewKM.GetRow(gridViewKM.FocusedRowHandle);
                    if (km != null)
                    {

                        Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                        sv.DeleteKM(km);
                        Load();
                        XtraMessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                        setvalue();
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizKhuyenMai km = (Book_Services.BizKhuyenMai)gridViewKM.GetRow(gridViewKM.FocusedRowHandle);
                if (km != null)
                {
                    if (dateTimePickerNAD.Value < dateTimePickerNHH.Value)
                    {
                        km.TenKM = txtTenKM.Text;
                        km.GiaTriGiam = Convert.ToInt32(txtGTGiam.Text);
                        km.NgayApDung = dateTimePickerNAD.Value;
                        km.NgayHetHan = dateTimePickerNHH.Value;
                        Book_Services.Book_ServiceClient sv = new Book_Services.Book_ServiceClient();
                        if (sv.EditKM(km))
                        {
                            Load();
                            XtraMessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            setvalue();
                        }
                        else
                        {
                            XtraMessageBox.Show("Khoảng thời gian khuyến mãi đã bị trùng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Chọn ngày áp dụng nhỏ hơn ngày hết hạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();
          
            this.Close();
        }

        private void gridViewKM_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Book_Services.BizKhuyenMai km = (Book_Services.BizKhuyenMai)gridViewKM.GetRow(gridViewKM.FocusedRowHandle);
                txtTenKM.Text = km.TenKM;
                txtGTGiam.Text = km.GiaTriGiam.ToString();
                dateTimePickerNAD.Value = km.NgayApDung;
                dateTimePickerNHH.Value = km.NgayHetHan;
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}