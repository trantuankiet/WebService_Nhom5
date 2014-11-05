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
    public partial class FrmPhieuNhapKho : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        List<Book_Services.BizPhieuNhap> ListPhieuNhap;
        List<Book_Services.BizCTPhieuNhap> ListCTPhieuNhap;
        Book_Services.BizPhieuNhap PhieuNhapSua;
        public static bool t = false;
        public bool CapNhat = false;
        bool Co = false;
        public FrmPhieuNhapKho()
        {
            InitializeComponent();
        }

        private void FrmNhapKho_Load(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                ListPhieuNhap = sv.LayListPN();
                LoadPhieuNK();
                LoadCombo();
                HienThi();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
        public void LoadCombo()
        {
            sv = new Book_Services.Book_ServiceClient();
            List<Book_Services.BizSach> ListSP =  sv.LayListSach();
            CboSanPham.DataSource = ListSP;
            CboSanPham.DisplayMember = "Tensach";
            CboSanPham.ValueMember = "MaSach";
            CboSanPham.SelectedValue = -1;
            
        }
        public void LoadPhieuNK()
        {
            gridDSPhieuNhapKho.DataSource = null;
            gridDSPhieuNhapKho.DataSource = ListPhieuNhap;    

        }
       
        private void BtnThemPNK_Click(object sender, EventArgs e)
        {
            try
            {
                XoaTruong();
                gridDanhSachSPNK.DataSource = null;
                ListCTPhieuNhap = new List<Book_Services.BizCTPhieuNhap>();
                t = true;
                HienThi();
                if (t == true)
                {
                    BtnSuaPNK.Enabled = false;
                    BtnXoaPNK.Enabled = false;
                    BtnLuuPNK.Enabled = false;
                    BtnThemPNK.Enabled = false;
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        
          
        }
        private void XoaTruong()
        {
            TxtSoLuong.Text = "";
            TxtGia.Text = "";
            CboSanPham.SelectedValue = -1;
         
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizCTPhieuNhap ct = new Book_Services.BizCTPhieuNhap
                {
                    PhieuNhap = new Book_Services.BizPhieuNhap
                    {
                        MaPN = -1
                    },
                    Sach = (Book_Services.BizSach)CboSanPham.SelectedItem,
                    SoLuong = Convert.ToInt32(TxtSoLuong.Text),
                    DonGia = Convert.ToDecimal(TxtGia.Text)
                };
                Book_Services.BizCTPhieuNhap CT = sv.KtraTonTaiSP(ct, ListCTPhieuNhap);
                if (CT.Sach == null)
                {
                    ListCTPhieuNhap.Add(ct);
                }
                else
                {
                    foreach (Book_Services.BizCTPhieuNhap CTDH in ListCTPhieuNhap)
                    {
                        if (CTDH.Sach.MaSach == CT.Sach.MaSach)
                        {
                            CTDH.SoLuong += ct.SoLuong;
                            CTDH.DonGia = ct.DonGia;
                        }
                    }
                }
                XtraMessageBox.Show("Thêm Sản Phẩm Vào Phiểu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadList();
                XoaTruong();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnTh_Click(object sender, EventArgs e)
        {
            

        }

        
        
        
        public void LoadList()
        {
            gridDanhSachSPNK.DataSource = null;
            gridDanhSachSPNK.DataSource = ListCTPhieuNhap;
        }

        private void gridViewDanhSachSPNK_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Co = true;
            Book_Services.BizCTPhieuNhap ChiTiet = (Book_Services.BizCTPhieuNhap)gridViewDanhSachSPNK.GetRow(gridViewDanhSachSPNK.FocusedRowHandle);
            TxtGia.Text = ChiTiet.DonGia.ToString();
            TxtSoLuong.Text = ChiTiet.SoLuong.ToString();
            CboSanPham.SelectedValue = ChiTiet.Sach.MaSach;
            CboSanPham.Enabled = false;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (Co == true)
                {
                    DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        Book_Services.BizCTPhieuNhap ChiTiet = (Book_Services.BizCTPhieuNhap)gridViewDanhSachSPNK.GetRow(gridViewDanhSachSPNK.FocusedRowHandle);
                        ListCTPhieuNhap.Remove(ChiTiet);
                   
                        XtraMessageBox.Show("Xóa Sản Phẩm Trong Phiểu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadList();
                    }
                    CboSanPham.Enabled = true;
                    Co = false;
                    XoaTruong();
                }
                else
                    XtraMessageBox.Show("Vui Lòng Chọn Sản Phẩm Để Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              

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
                if (Co == true)
                {

                    Book_Services.BizCTPhieuNhap ChiTiet = (Book_Services.BizCTPhieuNhap)gridViewDanhSachSPNK.GetRow(gridViewDanhSachSPNK.FocusedRowHandle);
                    ChiTiet.SoLuong = Convert.ToInt32(TxtSoLuong.Text);
                    ChiTiet.DonGia = Convert.ToInt32(TxtGia.Text);
                    XtraMessageBox.Show("Sửa Sản Phẩm Trong Phiểu Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadList();
                    CboSanPham.Enabled = true;
                    Co = false;
                    XoaTruong();
                }
                else
                    XtraMessageBox.Show("Vui Lòng Chọn Sản Phẩm Để Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
         
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
                if (t == true)
                {
                    if (ListCTPhieuNhap.Count > 0)
                    {
                        if (CapNhat == false)
                        {
                            Book_Services.BizPhieuNhap PNK = new Book_Services.BizPhieuNhap
                            {
                                MaPN = -1,
                                ChiTietPhieuNhaps = ListCTPhieuNhap,
                                NhanVien = NhanVien,
                                NgayNhap = DateTime.Now
                            };
                            ListPhieuNhap.Add(PNK);
                        }
                        else
                        {

                            PhieuNhapSua.ChiTietPhieuNhaps = ListCTPhieuNhap;
                            CapNhat = false;
                            PhieuNhapSua = new Book_Services.BizPhieuNhap();
                        }
                        XtraMessageBox.Show("Bạn Đã Lưu Phiểu Nhập Kho  Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
                        LoadPhieuNK();
                        t = false;
                        gridDanhSachSPNK.DataSource = null;
                        BtnThemPNK.Enabled = true;
                        BtnXoaPNK.Enabled = true;
                        BtnSuaPNK.Enabled = true;
                        BtnLuuPNK.Enabled = true;
                        HienThi();
                        XoaTruong();
                    }
                    else
                    {
                        XtraMessageBox.Show("Hãy Thêm Sản Phẩm Vào Phiếu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
        private void HienThi()
        {
            if (t == false)
            {
                TxtGia.ReadOnly = true;
                TxtSoLuong.ReadOnly = true;
                CboSanPham.Enabled = false;
                BtnThem.Enabled = false;
                BtnSua.Enabled = false;
                BtnXoa.Enabled = false;
                BtnLuuCTPNK.Enabled = false;
            }
            else
            {
                TxtGia.ReadOnly = false;
                TxtSoLuong.ReadOnly = false;
                CboSanPham.Enabled = true;
                BtnThem.Enabled = true;
                BtnSua.Enabled = true;
                BtnXoa.Enabled = true;
                BtnLuuCTPNK.Enabled = true;
            }
        }

        private void BtnXoaPNK_Click(object sender, EventArgs e)
        {
            try
            {
                    Book_Services.BizPhieuNhap PNK = (Book_Services.BizPhieuNhap)gridViewDanhSachPhieuNhapKho.GetRow(gridViewDanhSachPhieuNhapKho.FocusedRowHandle);
                    if (PNK.MaPN == -1)
                    {
                        DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Xóa Không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            ListPhieuNhap.Remove(PNK);
                            LoadPhieuNK();
                        }

                    }
                    else
                    {
                        XtraMessageBox.Show("Phiếu Nhập Kho Này Không Cho Phép Bạn Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }

            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void gridViewDanhSachPhieuNhapKho_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            
        }

        private void BtnSuaPNK_Click(object sender, EventArgs e)
        {
            try
            {
                PhieuNhapSua = (Book_Services.BizPhieuNhap)gridViewDanhSachPhieuNhapKho.GetRow(gridViewDanhSachPhieuNhapKho.FocusedRowHandle);
                if (PhieuNhapSua.MaPN == -1)
                {
                    t = true;
                    HienThi();
                    if (t == true)
                    {
                        CapNhat = true;
                        gridDanhSachSPNK.DataSource = PhieuNhapSua.ChiTietPhieuNhaps;
                        ListCTPhieuNhap = PhieuNhapSua.ChiTietPhieuNhaps;
                        BtnThemPNK.Enabled = false;
                        BtnXoaPNK.Enabled = false;
                        BtnLuuPNK.Enabled = false;
                        BtnSuaPNK.Enabled = false;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Phiếu Nhập Kho Này Không Cho Phép Bạn Chỉnh Sửa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }

        private void BtnLuuPNK_Click(object sender, EventArgs e)
        {
            try
            {
               
                DialogResult result = XtraMessageBox.Show("Bạn Có Chắc Muốn Lưu Các Phiếu Nhập Kho Vừa Thuc Hiện", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sv = new Book_Services.Book_ServiceClient();
                    sv.ThemPN(ListPhieuNhap);
                    ListPhieuNhap = sv.LayListPN();
                    LoadPhieuNK();

                    XtraMessageBox.Show("Lưu Phiếu thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                   
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