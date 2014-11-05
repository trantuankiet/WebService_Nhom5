using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using System.IO;
namespace Book_WindowsFrom
{
    public partial class FrmSach : DevExpress.XtraEditors.XtraForm
    {

        static Book_Services.Book_ServiceClient sv;
        static string filepath = "";
        public FrmSach()
        {
            
            InitializeComponent();
            sv = new Book_Services.Book_ServiceClient();
            Load();
            LoadCbo();
        }

        public void Load()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridSach.DataSource = sv.LayListSachDD();
        }
        public void LoadCbo()
        {
            sv = new Book_Services.Book_ServiceClient();
            cboTheLoai.DataSource = sv.ListTheLoai();
            cboTheLoai.DisplayMember = "TenDM";
            cboTheLoai.ValueMember = "MaTL";
        }
        private void btnBrowser_Click(object sender, EventArgs e)
        {
            sv = new Book_Services.Book_ServiceClient();
            OpenFileDialog MoThoai = new OpenFileDialog();
            MoThoai.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png|Gif Image|*.gif";
            MoThoai.Title = "Chen Hinh";
            if (MoThoai.ShowDialog() == DialogResult.OK)
            {
                filepath = MoThoai.FileName;
                PirtureSach.ImageLocation = filepath;
                this.txtHinh.Text = System.IO.Path.GetFileName(MoThoai.FileName);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizSach sach = new Book_Services.BizSach
                {
                    Tensach = txtTenSach.Text,
                    GiaVon = Convert.ToDecimal(txtGia.Text),
                    LoaiBia = cboHinhThucBia.Text,
                    NoiDung = txtND.Text,
                    NamXuatBan = Convert.ToInt32(cboNamXB.Text),
                    SoTrang = Convert.ToInt32(txtSoTrang.Text),
                    TenTacGia = txtTacGia.Text,
                    NhaXuatBan = txtNhaXB.Text,
                    PhanTramLoi = Convert.ToInt32(CboPTL.Text),
                    TheLoai = new Book_Services.BizTheLoai
                    {
                        MaTL = Convert.ToInt32(cboTheLoai.SelectedValue)
                    },
                    HinhAnh = txtHinh.Text
                };
                if (filepath != "")
                {
                    File.Copy(filepath, sv.Layfilepath() + sach.HinhAnh, true);
                }
                sv.ThemSach(sach);
                XtraMessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load();
                XoaSach();
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
                    sv = new Book_Services.Book_ServiceClient();
                    
                    Book_Services.BizSach s = (Book_Services.BizSach)gridviewSach.GetRow(gridviewSach.FocusedRowHandle);
                    
                    if (s != null)
                    {
                        if (s.TrangThai == true)
                        {
                            sv.XoaSach(s);
                            Load();
                            XtraMessageBox.Show("Bạn đã xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaSach();
                        }
                        else
                        {
                            XtraMessageBox.Show("Vui lòng chọn sách còn bán để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            XoaSach();

                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn sách để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     
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
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizSach s = (Book_Services.BizSach)gridviewSach.GetRow(gridviewSach.FocusedRowHandle);
                if (s != null)
                {
                    if (s.TrangThai == true)
                    {
                        Book_Services.BizSach sach = new Book_Services.BizSach
                        {
                            MaSach = s.MaSach,
                            Tensach = txtTenSach.Text,
                            GiaVon = Convert.ToDecimal(txtGia.Text),
                            LoaiBia = cboHinhThucBia.Text,
                            NoiDung = txtND.Text,
                            NamXuatBan = Convert.ToInt32(cboNamXB.Text),
                            SoTrang = Convert.ToInt32(txtSoTrang.Text),
                            TenTacGia = txtTacGia.Text,
                            NhaXuatBan = txtNhaXB.Text,
                            PhanTramLoi = Convert.ToInt32(CboPTL.Text),
                            TheLoai = new Book_Services.BizTheLoai
                            {
                                MaTL = Convert.ToInt32(cboTheLoai.SelectedValue)
                            },
                            HinhAnh = txtHinh.Text
                        };
                        if (filepath != "")
                        {
                            File.Copy(filepath, sv.Layfilepath() + sach.HinhAnh, true);
                        }
                        sv.SuaSach(sach);
                        Load();
                        XtraMessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XoaSach();
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn sách còn bán để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XoaSach();

                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn sách để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void gridviewSach_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Book_Services.BizSach s = (Book_Services.BizSach)gridviewSach.GetRow(gridviewSach.FocusedRowHandle);
            txtTacGia.Text = s.TenTacGia;
            txtTenSach.Text = s.Tensach;
            txtSoTrang.Text = s.SoTrang.ToString();
            txtNhaXB.Text = s.NhaXuatBan;
            txtND.Text = s.NoiDung;
            txtHinh.Text = s.HinhAnh;
            txtGia.Text = string.Format("{0:0}", s.GiaVon);
            cboNamXB.Text = s.NamXuatBan.ToString();
            cboTheLoai.SelectedValue = s.TheLoai.MaTL;
            cboHinhThucBia.Text = s.LoaiBia;
            CboPTL.Text = s.PhanTramLoi.ToString();
            sv = new Book_Services.Book_ServiceClient();
            PirtureSach.ImageLocation = sv.Layfilepath() + txtHinh.Text;
       
        }
        public void XoaSach()
        {
            txtTacGia.Text = null;
            txtTenSach.Text = null;
            txtSoTrang.Text = null;
            txtNhaXB.Text = null;
            txtND.Text = null;
            txtHinh.Text = null;
            txtGia.Text = null;
            cboNamXB.Text = null;
            cboTheLoai.SelectedIndex = -1;
            cboHinhThucBia.Text = null;
            CboPTL.Text = "30";
        }

        private void BtnKichHoat_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizSach s = (Book_Services.BizSach)gridviewSach.GetRow(gridviewSach.FocusedRowHandle);
                if (s != null)
                {
                    if (s.TrangThai == false)
                    {
                        sv.KichHoat(s);
                        Load();
                        XtraMessageBox.Show("Kích hoạt lại thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        XoaSach();

                    }
                    else
                    {
                        XtraMessageBox.Show("Vui lòng chọn sách ở tình trạng ngừng bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
                    }
                }
                else
                {
                    XtraMessageBox.Show("Vui lòng chọn sách để kích hoạt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}