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
    public partial class FrmDuyetPhieuVanChuyen : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        List<Book_Services.BizPhieuDatHang> ListPDH;
        List<Book_Services.BizPhieuDatHang> ListPDHCS;
        public FrmDuyetPhieuVanChuyen()
        {
            InitializeComponent();
            LoadPhieuVC();
          
        }

        public void LoadPhieuVC()
        {
            sv = new Book_Services.Book_ServiceClient();
            gridControlDonVanChuyen.DataSource = null;
            gridControlDonVanChuyen.DataSource = sv.LayListPVC();
        }
        public void LoadPDH()
        {
            gridControlPhieuDatHang.DataSource = null;
            gridControlduyetvahuy.DataSource = null;
            gridControlduyetvahuy.DataSource = ListPDHCS;
            gridControlPhieuDatHang.DataSource = ListPDH;
        }

        public void hienthi()
        {
            try
            {
                if (rdbtuychon.Checked == true)
                {
                    Book_Services.BizPhieuVanChuyen PVC = (Book_Services.BizPhieuVanChuyen)gridViewDonVanChuyen.GetRow(gridViewDonVanChuyen.FocusedRowHandle);
                    if (PVC != null)
                    {
                        sv = new Book_Services.Book_ServiceClient();
                        pnduyethieuchinh.Visible = true;
                        ListPDH = sv.ChuyenDoiPhieuDatHang(PVC);
                        ListPDHCS = new List<Book_Services.BizPhieuDatHang>();
                        gridControlDonVanChuyen.Enabled = false;
                        LoadPDH();
                    }
                    else
                    {
                        XtraMessageBox.Show("Vui Lòng Chọn Phiếu Vận Chuyển", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
                    }
                }
                else
                {
                    ListPDHCS = new List<Book_Services.BizPhieuDatHang>();
                    ListPDH = new List<Book_Services.BizPhieuDatHang>();
                    LoadPDH();
                    pnduyethieuchinh.Visible = false;
                    gridControlDonVanChuyen.Enabled = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
            
        }

        private void rdbduyettatca_CheckedChanged(object sender, EventArgs e)
        {
            hienthi();
        }

        private void rdbhuytatca_CheckedChanged(object sender, EventArgs e)
        {
            hienthi();
        }

        private void rdbtuychon_CheckedChanged(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizPhieuVanChuyen PVC = (Book_Services.BizPhieuVanChuyen)gridViewDonVanChuyen.GetRow(gridViewDonVanChuyen.FocusedRowHandle);
                if (PVC != null)
                {

                    if (rdbduyettatca.Checked == true)
                    {
                        sv.CapNhatTinhTrangPVCDG(PVC);
                        LoadPhieuVC();
                        XoaSach();
                        XtraMessageBox.Show("Duyệt Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    }
                    else if (rdbhuytatca.Checked == true)
                    {
                        sv.CapNhatTinhTrangPVCKG(PVC);
                        LoadPhieuVC();
                        XoaSach();
                        XtraMessageBox.Show("Duyệt Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                    }
                    else
                    {
                        if (ListPDH.Count == 0)
                        {
                            PVC = sv.ChuyenDoiPhieuVanChuyen(PVC, ListPDHCS);
                            sv.CapNhatTinhTrangPVCTC(PVC);
                            ListPDHCS = new List<Book_Services.BizPhieuDatHang>();
                            ListPDH = new List<Book_Services.BizPhieuDatHang>();
                            LoadPDH();
                            rdbduyettatca.Checked = true;
                            pnduyethieuchinh.Visible = false;
                            LoadPhieuVC();
                            gridControlDonVanChuyen.Enabled = true;
                            XoaSach();
                            XtraMessageBox.Show("Duyệt Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                        }
                        else
                        {
                            XtraMessageBox.Show("Vui Lòng Duyệt Hết Phiếu Đặt Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
   
                        }
                    }
                }
                else
                {

                    XtraMessageBox.Show("Vui Lòng Chọn Phiếu Vận Chuyển", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();
          
            this.Close();
        }

        private void btnduyet_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewPhieuDatHang.GetRow(gridViewPhieuDatHang.FocusedRowHandle);
                if (PDH != null)
                {

                    PDH.TrangThai = 3;
                    ListPDHCS.Add(PDH);
                    ListPDH.Remove(PDH);
                    LoadPDH();
                }
                else
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Phiếu Đặt Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }

        private void Btnhuy_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewPhieuDatHang.GetRow(gridViewPhieuDatHang.FocusedRowHandle);
                if (PDH != null)
                {
                    PDH.TrangThai = 0;
                    ListPDHCS.Add(PDH);
                    ListPDH.Remove(PDH);
                    LoadPDH();
                }
                else
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Phiếu Đặt Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            try
            {
                Book_Services.BizPhieuDatHang PDH = (Book_Services.BizPhieuDatHang)gridViewduyevahuy.GetRow(gridViewduyevahuy.FocusedRowHandle);
                if (PDH != null)
                {
                    PDH.TrangThai = 2;
                    ListPDH.Add(PDH);
                    ListPDHCS.Remove(PDH);
                    LoadPDH();
                }
                else
                {
                    XtraMessageBox.Show("Vui Lòng Chọn Phiếu Đặt Hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }
        private void XoaSach()
        {
            txttongtien.Text = null;
            txttongsodonhang.Text = null;
            txtmanvvc.Text = null;
        }
        private void FrmDuyetDonVanChuyen_Load(object sender, EventArgs e)
        {
           
                LoadPhieuVC();
                rdbduyettatca.Checked = true;
                pnduyethieuchinh.Visible = false; 
        }

        private void gridViewDonVanChuyen_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizPhieuVanChuyen PVC = (Book_Services.BizPhieuVanChuyen)gridViewDonVanChuyen.GetRow(gridViewDonVanChuyen.FocusedRowHandle);
                txtmanvvc.Text = PVC.NhanVien.MaNV;
                txttongsodonhang.Text = PVC.ChiTietPhieuVCs.Count.ToString();
                txttongtien.Text = string.Format("{0:0,0 VNĐ}",sv.TongTienPhieuVanChuyen(PVC));
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }

        private void BtnVeHet_Click(object sender, EventArgs e)
        {
            try
            {
                if (ListPDHCS.Count > 0)
                {
                    foreach (Book_Services.BizPhieuDatHang pdh in ListPDHCS)
                    {
                        pdh.TrangThai = 2;
                        ListPDH.Add(pdh);
                    }
                    ListPDHCS = new List<Book_Services.BizPhieuDatHang>();
                    LoadPDH();
                }
                else
                {
                    XtraMessageBox.Show("Không Có Phiếu Đặt Hàng Nào", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
   
            }
        }




        public static Book_Services.BizNhanVien NhanVien { get; set; }
    }
}