using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;


namespace Book_WindowsFrom
{
    
    public partial class FrmMain : XtraForm
    {
        public static bool check = false;
        public static Book_Services.BizNhanVien nhanvien;
        public Book_Services.Book_ServiceClient sv;
       
        public FrmMain()
        {
            InitializeComponent();
           
            sv = new Book_Services.Book_ServiceClient();
            sv.CapNhatKhuyenMai();
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = this;
            hienthi.Show();
        }

        public void Hienthi()
        {
            if (check == true )
            {
                if (nhanvien.Quyen.MaQuyen == 1)
                {
                    nbUser.Enabled = true;
                    nbPhieuNhap.Enabled = true;
                    nLapPDH.Enabled = true;
                    nbDuyetPDH.Enabled = true;
                    nbNhanVien.Enabled = true;
                    nbquyen.Enabled = true;
                    nbSach.Enabled = true;
                    nbTheLoai.Enabled = true;
                    nbduyetPVC.Enabled = true;
                    nblPVC.Enabled = true;
                    nbKhuyenMai.Enabled = true;
                    nbTKKho.Enabled = true;
                    nbTKSLBR.Enabled = true;
                    nbTKTSL.Enabled = true;
                    nbDTTSP.Enabled = true;
                    nbdangnhap.Enabled = false;
                    nbdangxuat.Enabled = true;
                }
                else if (nhanvien.Quyen.MaQuyen == 2)
                {
                    nbSach.Enabled = true;
                    nbPhieuNhap.Enabled = true;
                    nLapPDH.Enabled = true;
                    nbDuyetPDH.Enabled = true;
                    nbTheLoai.Enabled = true;
                    nbduyetPVC.Enabled = true;
                    nblPVC.Enabled = true;
                    nbKhuyenMai.Enabled = true;
                    nbTKKho.Enabled = true;
                    nbTKSLBR.Enabled = true;
                    nbTKTSL.Enabled = true;
                    nbDTTSP.Enabled = true;
                    nbdangnhap.Enabled = false;
                    nbdangxuat.Enabled = true;
                    nbUser.Enabled = false;
                    nbNhanVien.Enabled = false;
                    nbquyen.Enabled = false;     
                }
                else
                {
                    nbSach.Enabled = false;
                    nbUser.Enabled = false;
                    nLapPDH.Enabled = false;
                    nbPhieuNhap.Enabled = false;
                    nbDuyetPDH.Enabled = false;
                    nbNhanVien.Enabled = false;
                    nbquyen.Enabled = false;
                    nbTheLoai.Enabled = false;
                    nbduyetPVC.Enabled = false;
                    nblPVC.Enabled = false;
                    nbKhuyenMai.Enabled = false;
                    nbTKKho.Enabled = false;
                    nbTKSLBR.Enabled = false;
                    nbTKTSL.Enabled = false;
                    nbDTTSP.Enabled = false;
                    nbdangnhap.Enabled = true;
                    nbdangxuat.Enabled = false;
                }

            }
            else
            {
                nbSach.Enabled = false;
                nbUser.Enabled = false;
                nLapPDH.Enabled = false;
                nbPhieuNhap.Enabled = false;
                nbDuyetPDH.Enabled = false;
                nbNhanVien.Enabled = false;
                nbquyen.Enabled = false;
                nbTheLoai.Enabled = false;
                nbduyetPVC.Enabled = false;
                nblPVC.Enabled = false;
                nbKhuyenMai.Enabled = false;
                nbTKKho.Enabled = false;
                nbTKSLBR.Enabled = false;
                nbTKTSL.Enabled = false;
                nbDTTSP.Enabled = false;    
                nbdangnhap.Enabled = true;
                nbdangxuat.Enabled = false;
            }
        }

        public void ExitsFrom()
        {
            foreach (var frm in this.MdiChildren)
            {
                frm.Close();
            }
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmDangNhap dn = new FrmDangNhap();
            dn.ShowDialog();
            Hienthi();
        }

        private void nbSach_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmSach.NhanVien = nhanvien;
            FrmSach sach = new FrmSach();
            sach.MdiParent = this;
            sach.Show();
        }

        private void nbUser_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();
            FrmNguoiDung.NhanVien = nhanvien;
            FrmNguoiDung nd = new FrmNguoiDung() ;
            nd.MdiParent = this;
            nd.Show();

        }


        
        private void nbTKKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();
            FrmThongKeTonKho.NhanVien = nhanvien;
            FrmThongKeTonKho tk = new FrmThongKeTonKho();
            tk.MdiParent = this;
            tk.Show();
        }

        
        private void nbdangxuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            check = false;
            nhanvien = new Book_Services.BizNhanVien();
            Hienthi();
            ExitsFrom();
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = this;
            hienthi.Show();

        }

        private void nbdangnhap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            FrmDangNhap frm = new FrmDangNhap();
            frm.ShowDialog();
            Hienthi();
        }

        private void nbduyetPVC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {

            ExitsFrom();
            FrmDuyetPhieuVanChuyen.NhanVien = nhanvien;
            FrmDuyetPhieuVanChuyen ddvc = new FrmDuyetPhieuVanChuyen();
            ddvc.MdiParent = this;
            ddvc.Show();

        }

        private void nbTKSLBR_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmThongKeSoLuongBanRa.NhanVien = nhanvien;
            FrmThongKeSoLuongBanRa tkslbr = new FrmThongKeSoLuongBanRa();
            tkslbr.MdiParent = this;
            tkslbr.Show();

        }

        private void nbTKTSL_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmThongKeTheoSoLuong.NhanVien = nhanvien;
            FrmThongKeTheoSoLuong tkts = new FrmThongKeTheoSoLuong();
            tkts.MdiParent = this;
            tkts.Show();

        }

        private void nbDTTSP_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmThongkeDoanhThuTungSanPham.NhanVien = nhanvien;
            FrmThongkeDoanhThuTungSanPham dttsp = new FrmThongkeDoanhThuTungSanPham();
            dttsp.MdiParent = this;
            dttsp.Show();

        }

        private void nbNhanVien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();
            FrmNhanVien.NhanVien = nhanvien;
            FrmNhanVien qlnv = new FrmNhanVien();
            qlnv.MdiParent = this;
            qlnv.Show();

        }

        private void nbquyen_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmQuyen.NhanVien = nhanvien;
            FrmQuyen qlq = new FrmQuyen();
            qlq.MdiParent = this;
            qlq.Show();

        }

        private void nbTheLoai_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmTheLoai.NhanVien = nhanvien;
            FrmTheLoai qltl = new FrmTheLoai();
            qltl.MdiParent = this;
            qltl.Show();

        }

        private void nbKhuyenMai_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmKhuyenMai.NhanVien = nhanvien;
            FrmKhuyenMai qlkm = new FrmKhuyenMai();
            qlkm.MdiParent = this;
            qlkm.Show();

        }

        private void nbPhieuNhap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmPhieuNhapKho.NhanVien = nhanvien;
            FrmPhieuNhapKho qlpnk = new FrmPhieuNhapKho();
            qlpnk.MdiParent = this;
            qlpnk.Show();

        }

        private void nblPVC_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmLapPhieuVanChuyen.NhanVien = nhanvien;
            FrmLapPhieuVanChuyen lpvc = new FrmLapPhieuVanChuyen();
            lpvc.MdiParent = this;
            lpvc.Show();

        }

        private void nbDuyetDH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmDuyetPhieuDatHang.NhanVien = nhanvien;
            FrmDuyetPhieuDatHang qldh = new FrmDuyetPhieuDatHang();
            qldh.MdiParent = this;
            qldh.Show();
        
        }

        private void nLapPDH_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ExitsFrom();

            FrmLapPhieuDatHang.NhanVien = nhanvien;
            FrmLapPhieuDatHang qldh = new FrmLapPhieuDatHang();
            qldh.MdiParent = this;
            qldh.Show();
        
        }

     

    }
}