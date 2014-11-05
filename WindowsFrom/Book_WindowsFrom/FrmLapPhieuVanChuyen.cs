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
    public partial class FrmLapPhieuVanChuyen : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        List<Book_Services.BizPhieuDatHang> ListPDHDD;
        List<Book_Services.BizCTPhieuVanChuyen> ListPDHTPVC;

        public FrmLapPhieuVanChuyen()
        {
            sv = new Book_Services.Book_ServiceClient();
            InitializeComponent();
            ListPDHTPVC = new List<Book_Services.BizCTPhieuVanChuyen>();
            ListPDHDD = sv.LayListPDHDD();
            Load();
            LoadPVC();
            LoadCboNV();
        }
        public void Load()
        {
            gridControlDonHang.DataSource = null;
            gridControlPhieuVC.DataSource = null;
            gridControlPhieuVC.DataSource = ListPDHTPVC;
            gridControlDonHang.DataSource = ListPDHDD;
        }
        public void LoadPVC()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridControlDSPhieuVC.DataSource = null;
            gridControlDSPhieuVC.DataSource = sv.LayListPVC();
        }
        public void LoadCboNV()
        {
            sv = new Book_Services.Book_ServiceClient();
            cbnhanvienvc.DataSource = sv.ListNhanVienVC();
            cbnhanvienvc.DisplayMember = "HoTen";
            cbnhanvienvc.ValueMember = "MaNV";
        }

        private void Btnqua1_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewDonHang.GetRow(gridViewDonHang.FocusedRowHandle);
                Book_Services.BizCTPhieuVanChuyen CT = new Book_Services.BizCTPhieuVanChuyen
                {
                    PhieuDatHang = PDH,
                    GiaTienVC = Convert.ToDecimal(txtsotien.Text)
                };
                ListPDHDD.Remove(PDH);
                ListPDHTPVC.Add(CT);
                Load();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnquahet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Book_Services.BizPhieuDatHang PDH in ListPDHDD)
                {
                    Book_Services.BizCTPhieuVanChuyen CT = new Book_Services.BizCTPhieuVanChuyen
                    {
                        PhieuDatHang = PDH,
                        GiaTienVC = Convert.ToDecimal(txtsotien.Text)
                    };
                    ListPDHTPVC.Add(CT);

                }
                ListPDHDD = new List<Book_Services.BizPhieuDatHang>();
                Load();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnve1_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizCTPhieuVanChuyen CTPVC = (Book_Services.BizCTPhieuVanChuyen)gridViewPhieuVC.GetRow(gridViewPhieuVC.FocusedRowHandle);
                ListPDHDD.Add(CTPVC.PhieuDatHang);
                ListPDHTPVC.Remove(CTPVC);
                Load();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnvehet_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Book_Services.BizCTPhieuVanChuyen CTPVC in ListPDHTPVC)
                {
                    ListPDHDD.Add(CTPVC.PhieuDatHang);
                }
                ListPDHTPVC = new List<Book_Services.BizCTPhieuVanChuyen>();
                Load();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizPhieuVanChuyen PVC = new Book_Services.BizPhieuVanChuyen()
                {
                    NhanVien = (Book_Services.BizNhanVien)cbnhanvienvc.SelectedItem,
                    ChiTietPhieuVCs = ListPDHTPVC
                };
                sv.ThemPVC(PVC);
                LoadPVC();
                gridControlPhieuVC.DataSource = null;
                ListPDHTPVC = new List<Book_Services.BizCTPhieuVanChuyen>();
                XtraMessageBox.Show("Lưu Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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





        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}