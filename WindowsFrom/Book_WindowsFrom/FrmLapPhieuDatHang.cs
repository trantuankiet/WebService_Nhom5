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
    public partial class FrmLapPhieuDatHang : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        List<Book_Services.BizCTPhieuDatHang> ListChiTietDH= new List<Book_Services.BizCTPhieuDatHang>();
        public FrmLapPhieuDatHang()
        {
            InitializeComponent();
            LoadCBSach();
            LoadDS();
        }
        public void LoadCBSach()
        {
            sv = new Book_Services.Book_ServiceClient();
            CboSanPham.DataSource = sv.LayListSach();
            CboSanPham.DisplayMember = "Tensach";
            CboSanPham.ValueMember = "MaSach";
        }
        public void LoadDS()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridDSPhieuDatHang.DataSource = sv.LayListPDHTT();
        }
        public void LoadDSCT()
        {
            gridDanhSachSPDatHang.DataSource = null;
            gridDanhSachSPDatHang.DataSource = ListChiTietDH;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                Book_Services.BizCTPhieuDatHang ct = new Book_Services.BizCTPhieuDatHang
                {
                    SoLuong = Convert.ToInt32(TxtSoLuong.Text),
                    Sach = (Book_Services.BizSach)CboSanPham.SelectedItem
                };
                foreach (Book_Services.BizCTPhieuDatHang item in ListChiTietDH)
                {
                    if (item.Sach.MaSach == ct.Sach.MaSach)
                        check = true;
                };
                if (check == false)
                {
                    ct.GiaTien = ct.SoLuong * ct.Sach.Gia;
                    ct.Sach.SoLuong = ct.SoLuong;
                    if (sv.KiemTraTonKho(ct.Sach) == true)
                    {
                        ListChiTietDH.Add(ct);
                        LoadDSCT();
                        XoaSach();
                        XtraMessageBox.Show("Thêm Chi Tiết Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        XtraMessageBox.Show("Sách tồn kho không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                else
                {
                    XtraMessageBox.Show("Sách đã tồn tại trong danh sách", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    Book_Services.BizCTPhieuDatHang ct = (Book_Services.BizCTPhieuDatHang)gridViewDanhSachSPDH.GetRow(gridViewDanhSachSPDH.FocusedRowHandle);
                    ListChiTietDH.Remove(ct);
                    XtraMessageBox.Show("Xóa Chi Tiết Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDSCT();
                    XoaSach();
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizCTPhieuDatHang ct = (Book_Services.BizCTPhieuDatHang)gridViewDanhSachSPDH.GetRow(gridViewDanhSachSPDH.FocusedRowHandle);
                foreach (Book_Services.BizCTPhieuDatHang chitiet in ListChiTietDH)
                {
                    if (ct.Sach.MaSach == chitiet.Sach.MaSach)
                    {
                        ct = chitiet;
                    }
                }
                ct.Sach.SoLuong = Convert.ToInt32(TxtSoLuong.Text);
                if (sv.KiemTraTonKho(ct.Sach) == true)
                {

                    ct.Sach = (Book_Services.BizSach)CboSanPham.SelectedItem;
                    ct.SoLuong = Convert.ToInt32(TxtSoLuong.Text);
                    ct.GiaTien = ct.SoLuong * ct.Sach.Gia;
                    XtraMessageBox.Show("Sửa Chi Tiết Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDSCT();
                    XoaSach();

                }
                else
                {
                    XtraMessageBox.Show("Sách tồn kho không đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
         
        }

        private void BtnLuuCTPNK_Click(object sender, EventArgs e)
        {
            try
            {
                   DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Lưu phiếu Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                   if (result == DialogResult.Yes)
                   {

                       sv = new Book_Services.Book_ServiceClient();
                       Book_Services.BizPhieuDatHang pdh = new Book_Services.BizPhieuDatHang
                       {
                           ChiTietDonHangs = ListChiTietDH,
                           NhanVien = NhanVien
                       };
                       sv.ThemPDHTT(pdh);
                       XtraMessageBox.Show("Lưu Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       ListChiTietDH = new List<Book_Services.BizCTPhieuDatHang>();
                       LoadDS();
                       LoadDSCT();
                       XoaSach();
                   }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
    
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();
          
            this.Close();
        }
        public void XoaSach()
        {
            CboSanPham.SelectedIndex = -1;
            TxtSoLuong.Text = null;
        }

        private void gridViewDanhSachSPDH_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Book_Services.BizCTPhieuDatHang ct = (Book_Services.BizCTPhieuDatHang)gridViewDanhSachSPDH.GetRow(gridViewDanhSachSPDH.FocusedRowHandle);
            CboSanPham.SelectedValue = ct.Sach.MaSach;
            TxtSoLuong.Text = ct.SoLuong.ToString();
        }


        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}