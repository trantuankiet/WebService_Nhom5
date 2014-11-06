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
    public partial class FrmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmNhanVien()
        {
            try
            {
                InitializeComponent();
                if (NhanVien != null)
                {
                    LoadGrid();
                    LoadCboQuyen();
                }
                else
                {
                    this.Close();
                    FrmHienThi hienthi = new FrmHienThi();
                    hienthi.MdiParent = this;
                    hienthi.Show();
                    
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void LoadGrid()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridControl1.DataSource = sv.ListNhanVien();
        }
        public void LoadCboQuyen()
        {
            sv = new Book_Services.Book_ServiceClient();
            CboQuyen.DataSource = sv.ListQuyen();
            CboQuyen.DisplayMember = "TenQuyen";
            CboQuyen.ValueMember = "MaQuyen";
        }
        private void BtnCapNhatQuyen_Click(object sender, EventArgs e)
        {
            FrmQuyen frm = new FrmQuyen();
            frm.ShowDialog();
            LoadCboQuyen();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                string luulai = sv.Matkhaungaunhien();
                Book_Services.BizNhanVien nv = new Book_Services.BizNhanVien();
                nv.MaNV = TxtTenDN.Text;
                nv.Quyen = new Book_Services.BizQuyen
                {             
                    MaQuyen = Convert.ToInt32(CboQuyen.SelectedValue)
                 };
                nv.Email = TxtEmail.Text;
                nv.MatKhau = sv.Mahoa(luulai);
                nv.TenNV = TxtHoten.Text;
                nv.DiaChi = TxtDiaChi.Text;
                nv.NgaySinh = DateTimeNgaySinh.Value;
                nv.SDT = TxtSDT.Text;
               // sv.insertNV1(nv);
                sv.InsertNV(nv);
                nv.MatKhau = luulai;
                sv.GuiMail_DangKyNV(nv);
                XtraMessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (nv.Quyen.MaQuyen == 1)
                {
                    CapNhatQuyen();
                }
                LoadGrid();
                SetValue();
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void CapNhatQuyen()
        {
            sv = new Book_Services.Book_ServiceClient();             
            NhanVien.Quyen.MaQuyen = 2;
            sv.EditTTNVKMK(NhanVien);
            Application.Restart();
        }
        public void SetValue()
        {
            TxtTenDN.Text = null;
            TxtTenDN.Enabled = true;
            CboQuyen.SelectedValue = -1;
            TxtEmail.Text = null;
            TxtHoten.Text = null;
            TxtDiaChi.Text = null;
            DateTimeNgaySinh.Value = DateTime.Now;
            TxtSDT.Text = null;
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                Book_Services.BizNhanVien row = (Book_Services.BizNhanVien)gridView1.GetRow(gridView1.FocusedRowHandle);
                TxtTenDN.Text = row.MaNV;
                TxtTenDN.Enabled = false;
                CboQuyen.SelectedValue = row.Quyen.MaQuyen;
                TxtEmail.Text = row.Email;
                TxtHoten.Text = row.TenNV;
                TxtDiaChi.Text = row.DiaChi;
                DateTimeNgaySinh.Value = row.NgaySinh;
                TxtSDT.Text = row.SDT;
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
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNhanVien row = (Book_Services.BizNhanVien)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (row != null)
                {
                    row.TrangThai = false;
                    sv.DeleteNV(row);
                    LoadGrid();
                    SetValue();
                    XtraMessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn nhân viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
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
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNhanVien row = (Book_Services.BizNhanVien)gridView1.GetRow(gridView1.FocusedRowHandle);
                if (row != null)
                {

                    row.Quyen.MaQuyen = Convert.ToInt32(CboQuyen.SelectedValue);
                    row.Email = TxtEmail.Text;
                    row.TenNV = TxtHoten.Text;
                    row.DiaChi = TxtDiaChi.Text;
                    row.NgaySinh = DateTimeNgaySinh.Value;
                    row.SDT = TxtSDT.Text;
                    sv.EditTTNVKMK(row);
                    LoadGrid();
                    SetValue();
                    XtraMessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (row.Quyen.MaQuyen == 1)
                    {
                        CapNhatQuyen();
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn nhân viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
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



        public static Book_Services.BizNhanVien NhanVien { get; set; }

    }
}