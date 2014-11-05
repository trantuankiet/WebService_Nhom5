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
    public partial class FrmDuyetPhieuDatHang : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmDuyetPhieuDatHang()
        {
            InitializeComponent();
            LoadPDHCD();
            LoadPDHDD();
            LoadPDHDH();
        }
        public void LoadPDHCD()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridcontrolChuaXacNhan.DataSource = sv.LayListPDHCD();
        }
        public void LoadPDHDD()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridControlDaXacNhan.DataSource = sv.LayListPDHDD();
        }
        public void LoadPDHDH()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridControlDaHuy.DataSource = sv.LayListPDHDH();
        }

        private void gridViewChuaXacNhan_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewChuaXacNhan.GetRow(gridViewChuaXacNhan.FocusedRowHandle);
            txtDiachi.Text = PDH.DiaChiNN;
            txtdiachinhan.Text = PDH.DiaChiNN;
            txtHoTen.Text = PDH.HoTenNN;
            txtSdt.Text = PDH.SDT;
            txtEmail.Text = PDH.Email;
            txtngay.Text = PDH.NgayDH.ToShortDateString();
            txtTongTien.Text = String.Format("{0:0,0 VNĐ}", sv.TinhTongTienPhieuDatHang(PDH).ToString());
            TxtSoLuongSP.Text = PDH.ChiTietDonHangs.Count.ToString();
            gridControlCTChuaXacNhan.DataSource = PDH.ChiTietDonHangs;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();
          
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Duyệt Đơn Hàng Này", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    sv = new Book_Services.Book_ServiceClient();
                    if (rbXacNhan.Checked == true)
                    {

                        Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewChuaXacNhan.GetRow(gridViewChuaXacNhan.FocusedRowHandle);
                        PDH.TrangThai = 1;
                        sv.CapNhatTinhTrangPDH(PDH);
                        LoadPDHDD();
                    }
                    else
                    {

                        Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewChuaXacNhan.GetRow(gridViewChuaXacNhan.FocusedRowHandle);
                        PDH.TrangThai = -1;
                        sv.CapNhatTinhTrangPDH(PDH);
                        LoadPDHDH();
                    }
                    LoadPDHCD();
                    XoaSach();

                    XtraMessageBox.Show("Duyệt phiếu đặt hàng thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
        public void XoaSach()
        {
            txtDiachi.Text = null;
            txtdiachinhan.Text = null;
            txtHoTen.Text = null;
            txtSdt.Text =null;
            txtEmail.Text = null;
            txtngay.Text = null;
            txtTongTien.Text = null;
            TxtSoLuongSP.Text = null;
            gridControlCTChuaXacNhan.DataSource = null;
        }
        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}