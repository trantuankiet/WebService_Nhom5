namespace Book_WindowsFrom
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.imageListBig = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nbHeThong = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbdangxuat = new DevExpress.XtraNavBar.NavBarItem();
            this.nbdangnhap = new DevExpress.XtraNavBar.NavBarItem();
            this.nbQuanLy = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbUser = new DevExpress.XtraNavBar.NavBarItem();
            this.nbNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.nbquyen = new DevExpress.XtraNavBar.NavBarItem();
            this.nbSach = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTheLoai = new DevExpress.XtraNavBar.NavBarItem();
            this.nbKhuyenMai = new DevExpress.XtraNavBar.NavBarItem();
            this.nbPhieuNhap = new DevExpress.XtraNavBar.NavBarItem();
            this.nbDuyetPDH = new DevExpress.XtraNavBar.NavBarItem();
            this.nblPVC = new DevExpress.XtraNavBar.NavBarItem();
            this.nbduyetPVC = new DevExpress.XtraNavBar.NavBarItem();
            this.nbThongKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbTKKho = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTKSLBR = new DevExpress.XtraNavBar.NavBarItem();
            this.nbTKTSL = new DevExpress.XtraNavBar.NavBarItem();
            this.nbDTTSP = new DevExpress.XtraNavBar.NavBarItem();
            this.nLapPDH = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageListBig
            // 
            this.imageListBig.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListBig.ImageStream")));
            this.imageListBig.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListBig.Images.SetKeyName(0, "Brainy-icon.png");
            this.imageListBig.Images.SetKeyName(1, "Clumsy-icon.png");
            this.imageListBig.Images.SetKeyName(2, "Grouchy-icon.png");
            this.imageListBig.Images.SetKeyName(3, "Gusty-icon.png");
            this.imageListBig.Images.SetKeyName(4, "Papa-icon.png");
            this.imageListBig.Images.SetKeyName(5, "Smurfette-2-icon.png");
            this.imageListBig.Images.SetKeyName(6, "Smurfette-icon.png");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Brainy-icon.png");
            this.imageListSmall.Images.SetKeyName(1, "Clumsy-icon.png");
            this.imageListSmall.Images.SetKeyName(2, "Grouchy-icon.png");
            this.imageListSmall.Images.SetKeyName(3, "Gusty-icon.png");
            this.imageListSmall.Images.SetKeyName(4, "Papa-icon.png");
            this.imageListSmall.Images.SetKeyName(5, "Smurfette-2-icon.png");
            this.imageListSmall.Images.SetKeyName(6, "Smurfette-icon.png");
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nbHeThong;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbHeThong,
            this.nbQuanLy,
            this.nbThongKe});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbSach,
            this.nbUser,
            this.nbPhieuNhap,
            this.nbDuyetPDH,
            this.nbTKKho,
            this.nbTKSLBR,
            this.nbdangxuat,
            this.nbdangnhap,
            this.nbNhanVien,
            this.nbTheLoai,
            this.nbquyen,
            this.nblPVC,
            this.nbduyetPVC,
            this.nbKhuyenMai,
            this.nbTKTSL,
            this.nbDTTSP,
            this.nLapPDH});
            this.navBarControl1.LargeImages = this.imageListBig;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 192;
            this.navBarControl1.Size = new System.Drawing.Size(192, 595);
            this.navBarControl1.SmallImages = this.imageListSmall;
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // nbHeThong
            // 
            this.nbHeThong.Caption = "Hệ Thống";
            this.nbHeThong.Expanded = true;
            this.nbHeThong.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbdangxuat),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbdangnhap)});
            this.nbHeThong.LargeImageIndex = 1;
            this.nbHeThong.Name = "nbHeThong";
            // 
            // nbdangxuat
            // 
            this.nbdangxuat.Caption = "Đăng Xuất";
            this.nbdangxuat.Name = "nbdangxuat";
            this.nbdangxuat.SmallImageIndex = 6;
            this.nbdangxuat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbdangxuat_LinkClicked);
            // 
            // nbdangnhap
            // 
            this.nbdangnhap.Caption = "Đăng Nhập";
            this.nbdangnhap.Name = "nbdangnhap";
            this.nbdangnhap.SmallImageIndex = 5;
            this.nbdangnhap.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbdangnhap_LinkClicked);
            // 
            // nbQuanLy
            // 
            this.nbQuanLy.Caption = "Quản Lý";
            this.nbQuanLy.Expanded = true;
            this.nbQuanLy.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbUser),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbNhanVien),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbquyen),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbSach),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTheLoai),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbKhuyenMai),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbPhieuNhap),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nLapPDH),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDuyetPDH),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nblPVC),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbduyetPVC)});
            this.nbQuanLy.LargeImageIndex = 0;
            this.nbQuanLy.Name = "nbQuanLy";
            // 
            // nbUser
            // 
            this.nbUser.Caption = "Người Dùng";
            this.nbUser.Name = "nbUser";
            this.nbUser.SmallImageIndex = 1;
            this.nbUser.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbUser_LinkClicked);
            // 
            // nbNhanVien
            // 
            this.nbNhanVien.Caption = "Nhân Viên";
            this.nbNhanVien.Name = "nbNhanVien";
            this.nbNhanVien.SmallImageIndex = 6;
            this.nbNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbNhanVien_LinkClicked);
            // 
            // nbquyen
            // 
            this.nbquyen.Caption = "Quyền";
            this.nbquyen.Name = "nbquyen";
            this.nbquyen.SmallImageIndex = 5;
            this.nbquyen.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbquyen_LinkClicked);
            // 
            // nbSach
            // 
            this.nbSach.Caption = "Sách";
            this.nbSach.Name = "nbSach";
            this.nbSach.SmallImageIndex = 3;
            this.nbSach.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbSach_LinkClicked);
            // 
            // nbTheLoai
            // 
            this.nbTheLoai.Caption = "Thể Loại";
            this.nbTheLoai.Name = "nbTheLoai";
            this.nbTheLoai.SmallImageIndex = 3;
            this.nbTheLoai.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTheLoai_LinkClicked);
            // 
            // nbKhuyenMai
            // 
            this.nbKhuyenMai.Caption = "Khuyến Mãi";
            this.nbKhuyenMai.Name = "nbKhuyenMai";
            this.nbKhuyenMai.SmallImageIndex = 3;
            this.nbKhuyenMai.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbKhuyenMai_LinkClicked);
            // 
            // nbPhieuNhap
            // 
            this.nbPhieuNhap.Caption = "Phiếu Nhập";
            this.nbPhieuNhap.Name = "nbPhieuNhap";
            this.nbPhieuNhap.SmallImageIndex = 2;
            this.nbPhieuNhap.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbPhieuNhap_LinkClicked);
            // 
            // nbDuyetPDH
            // 
            this.nbDuyetPDH.Caption = "Duyệt Phiếu Đặt Hàng";
            this.nbDuyetPDH.Name = "nbDuyetPDH";
            this.nbDuyetPDH.SmallImageIndex = 4;
            this.nbDuyetPDH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDuyetDH_LinkClicked);
            // 
            // nblPVC
            // 
            this.nblPVC.Caption = "Lập Phiếu Vận Chuyển";
            this.nblPVC.Name = "nblPVC";
            this.nblPVC.SmallImageIndex = 2;
            this.nblPVC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nblPVC_LinkClicked);
            // 
            // nbduyetPVC
            // 
            this.nbduyetPVC.Caption = "Duyệt Phiếu Vận Chuyển";
            this.nbduyetPVC.Name = "nbduyetPVC";
            this.nbduyetPVC.SmallImageIndex = 0;
            this.nbduyetPVC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbduyetPVC_LinkClicked);
            // 
            // nbThongKe
            // 
            this.nbThongKe.Caption = "Thống Kê, Báo Cáo";
            this.nbThongKe.Expanded = true;
            this.nbThongKe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTKKho),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTKSLBR),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbTKTSL),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbDTTSP)});
            this.nbThongKe.LargeImageIndex = 5;
            this.nbThongKe.Name = "nbThongKe";
            // 
            // nbTKKho
            // 
            this.nbTKKho.Caption = "Tồn Kho";
            this.nbTKKho.Name = "nbTKKho";
            this.nbTKKho.SmallImageIndex = 2;
            this.nbTKKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTKKho_LinkClicked);
            // 
            // nbTKSLBR
            // 
            this.nbTKSLBR.Caption = "Tổng Số Lượng Bán Ra";
            this.nbTKSLBR.Name = "nbTKSLBR";
            this.nbTKSLBR.SmallImageIndex = 4;
            this.nbTKSLBR.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTKSLBR_LinkClicked);
            // 
            // nbTKTSL
            // 
            this.nbTKTSL.Caption = "Theo Số Lượng Bán Ra";
            this.nbTKTSL.Name = "nbTKTSL";
            this.nbTKTSL.SmallImageIndex = 5;
            this.nbTKTSL.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbTKTSL_LinkClicked);
            // 
            // nbDTTSP
            // 
            this.nbDTTSP.Caption = "Doanh Thu Từng Sản Phẩm";
            this.nbDTTSP.Name = "nbDTTSP";
            this.nbDTTSP.SmallImageIndex = 0;
            this.nbDTTSP.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbDTTSP_LinkClicked);
            // 
            // nLapPDH
            // 
            this.nLapPDH.Caption = "Lập phiếu đặt hàng";
            this.nLapPDH.Name = "nLapPDH";
            this.nLapPDH.SmallImageIndex = 2;
            this.nLapPDH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nLapPDH_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 595);
            this.Controls.Add(this.navBarControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Hệ thống quản lý bán sách";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageListBig;
        private System.Windows.Forms.ImageList imageListSmall;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nbQuanLy;
        private DevExpress.XtraNavBar.NavBarItem nbSach;
        private DevExpress.XtraNavBar.NavBarItem nbUser;
        private DevExpress.XtraNavBar.NavBarItem nbPhieuNhap;
        private DevExpress.XtraNavBar.NavBarItem nbDuyetPDH;
        private DevExpress.XtraNavBar.NavBarGroup nbThongKe;
        private DevExpress.XtraNavBar.NavBarItem nbTKKho;
        private DevExpress.XtraNavBar.NavBarItem nbTKSLBR;
        private DevExpress.XtraNavBar.NavBarGroup nbHeThong;
        private DevExpress.XtraNavBar.NavBarItem nbdangxuat;
        private DevExpress.XtraNavBar.NavBarItem nbdangnhap;
        private DevExpress.XtraNavBar.NavBarItem nbNhanVien;
        private DevExpress.XtraNavBar.NavBarItem nbquyen;
        private DevExpress.XtraNavBar.NavBarItem nbTheLoai;
        private DevExpress.XtraNavBar.NavBarItem nbKhuyenMai;
        private DevExpress.XtraNavBar.NavBarItem nblPVC;
        private DevExpress.XtraNavBar.NavBarItem nbduyetPVC;
        private DevExpress.XtraNavBar.NavBarItem nbTKTSL;
        private DevExpress.XtraNavBar.NavBarItem nbDTTSP;
        private DevExpress.XtraNavBar.NavBarItem nLapPDH;

    }
}
