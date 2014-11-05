namespace Book_WindowsFrom
{
    partial class FrmLapPhieuDatHang
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gridViewChiTietPDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridDSPhieuDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSachPhieuDatHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NgayNhapHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Madonhang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl10 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.CboSanPham = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoLuong = new System.Windows.Forms.TextBox();
            this.panelControl8 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl9 = new DevExpress.XtraEditors.PanelControl();
            this.BtnLuuCTPNK = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSua = new DevExpress.XtraEditors.SimpleButton();
            this.BtnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridDanhSachSPDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSachSPDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.TenSP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoLuongNhap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GiaTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietPDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSPhieuDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).BeginInit();
            this.panelControl10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).BeginInit();
            this.panelControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).BeginInit();
            this.panelControl9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachSPDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachSPDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridViewChiTietPDH
            // 
            this.gridViewChiTietPDH.ChildGridLevelName = "Chi tiết phiếu đặt hàng";
            this.gridViewChiTietPDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewChiTietPDH.GridControl = this.gridDSPhieuDatHang;
            this.gridViewChiTietPDH.Name = "gridViewChiTietPDH";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sản phẩm";
            this.gridColumn1.FieldName = "Sach.Tensach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số lượng";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Đơn Giá";
            this.gridColumn3.DisplayFormat.FormatString = "{0:0,0} VNĐ";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "[GiaTien] / [SoLuong]";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Thành Tiền";
            this.gridColumn4.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn4.FieldName = "GiaTien";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridDSPhieuDatHang
            // 
            this.gridDSPhieuDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridViewChiTietPDH;
            gridLevelNode1.RelationName = "ChiTietDonHangs";
            this.gridDSPhieuDatHang.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridDSPhieuDatHang.Location = new System.Drawing.Point(2, 21);
            this.gridDSPhieuDatHang.MainView = this.gridViewDanhSachPhieuDatHang;
            this.gridDSPhieuDatHang.Name = "gridDSPhieuDatHang";
            this.gridDSPhieuDatHang.Size = new System.Drawing.Size(920, 166);
            this.gridDSPhieuDatHang.TabIndex = 0;
            this.gridDSPhieuDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSachPhieuDatHang,
            this.gridViewChiTietPDH});
            // 
            // gridViewDanhSachPhieuDatHang
            // 
            this.gridViewDanhSachPhieuDatHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NgayNhapHang,
            this.Madonhang});
            this.gridViewDanhSachPhieuDatHang.GridControl = this.gridDSPhieuDatHang;
            this.gridViewDanhSachPhieuDatHang.Name = "gridViewDanhSachPhieuDatHang";
            this.gridViewDanhSachPhieuDatHang.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDanhSachPhieuDatHang.OptionsBehavior.Editable = false;
            this.gridViewDanhSachPhieuDatHang.OptionsDetail.ShowDetailTabs = false;
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.Caption = "Ngày Bán Hàng";
            this.NgayNhapHang.FieldName = "NgayDH";
            this.NgayNhapHang.Name = "NgayNhapHang";
            this.NgayNhapHang.Visible = true;
            this.NgayNhapHang.VisibleIndex = 1;
            // 
            // Madonhang
            // 
            this.Madonhang.Caption = "Mã Phiếu Nhập";
            this.Madonhang.FieldName = "MaPDH";
            this.Madonhang.Name = "Madonhang";
            this.Madonhang.Visible = true;
            this.Madonhang.VisibleIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl3);
            this.panelControl3.Controls.Add(this.groupControl2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 48);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(928, 356);
            this.panelControl3.TabIndex = 5;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridDSPhieuDatHang);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(924, 189);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách phiếu đặt hàng";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl10);
            this.groupControl2.Controls.Add(this.panelControl8);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 191);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(924, 163);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Thông Tin Nhập Phiếu Đặt Hàng";
            // 
            // panelControl10
            // 
            this.panelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl10.Controls.Add(this.panelControl7);
            this.panelControl10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl10.Location = new System.Drawing.Point(2, 21);
            this.panelControl10.Name = "panelControl10";
            this.panelControl10.Size = new System.Drawing.Size(920, 86);
            this.panelControl10.TabIndex = 28;
            // 
            // panelControl7
            // 
            this.panelControl7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl7.Controls.Add(this.CboSanPham);
            this.panelControl7.Controls.Add(this.labelControl2);
            this.panelControl7.Controls.Add(this.labelControl3);
            this.panelControl7.Controls.Add(this.TxtSoLuong);
            this.panelControl7.Location = new System.Drawing.Point(235, 3);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(535, 80);
            this.panelControl7.TabIndex = 26;
            // 
            // CboSanPham
            // 
            this.CboSanPham.FormattingEnabled = true;
            this.CboSanPham.Location = new System.Drawing.Point(118, 31);
            this.CboSanPham.Name = "CboSanPham";
            this.CboSanPham.Size = new System.Drawing.Size(134, 21);
            this.CboSanPham.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 35);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Tên Sản Phẩm";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(292, 35);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 13);
            this.labelControl3.TabIndex = 17;
            this.labelControl3.Text = "Số Lượng";
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.Location = new System.Drawing.Point(346, 30);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.Size = new System.Drawing.Size(147, 21);
            this.TxtSoLuong.TabIndex = 18;
            // 
            // panelControl8
            // 
            this.panelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl8.Controls.Add(this.panelControl9);
            this.panelControl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl8.Location = new System.Drawing.Point(2, 107);
            this.panelControl8.Name = "panelControl8";
            this.panelControl8.Size = new System.Drawing.Size(920, 54);
            this.panelControl8.TabIndex = 27;
            // 
            // panelControl9
            // 
            this.panelControl9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl9.Controls.Add(this.BtnLuuCTPNK);
            this.panelControl9.Controls.Add(this.BtnThoat);
            this.panelControl9.Controls.Add(this.BtnSua);
            this.panelControl9.Controls.Add(this.BtnXoa);
            this.panelControl9.Controls.Add(this.BtnThem);
            this.panelControl9.Location = new System.Drawing.Point(32, 0);
            this.panelControl9.Name = "panelControl9";
            this.panelControl9.Size = new System.Drawing.Size(892, 54);
            this.panelControl9.TabIndex = 0;
            // 
            // BtnLuuCTPNK
            // 
            this.BtnLuuCTPNK.Location = new System.Drawing.Point(629, 6);
            this.BtnLuuCTPNK.Name = "BtnLuuCTPNK";
            this.BtnLuuCTPNK.Size = new System.Drawing.Size(158, 37);
            this.BtnLuuCTPNK.TabIndex = 13;
            this.BtnLuuCTPNK.Text = "Lưu Chi Tiết Phiếu Đặt Hàng";
            this.BtnLuuCTPNK.Click += new System.EventHandler(this.BtnLuuCTPNK_Click);
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(803, 6);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 37);
            this.BtnThoat.TabIndex = 14;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnSua
            // 
            this.BtnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnSua.Location = new System.Drawing.Point(447, 6);
            this.BtnSua.Name = "BtnSua";
            this.BtnSua.Size = new System.Drawing.Size(158, 37);
            this.BtnSua.TabIndex = 23;
            this.BtnSua.Text = "Sửa Chi Tiết Phiếu";
            this.BtnSua.Click += new System.EventHandler(this.BtnSua_Click);
            // 
            // BtnXoa
            // 
            this.BtnXoa.Location = new System.Drawing.Point(264, 6);
            this.BtnXoa.Name = "BtnXoa";
            this.BtnXoa.Size = new System.Drawing.Size(158, 37);
            this.BtnXoa.TabIndex = 22;
            this.BtnXoa.Text = "Xóa Chi Tiết Phiếu";
            this.BtnXoa.Click += new System.EventHandler(this.BtnXoa_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Location = new System.Drawing.Point(78, 6);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(158, 37);
            this.BtnThem.TabIndex = 21;
            this.BtnThem.Text = "Thêm Chi Tiết Phiếu";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 404);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(928, 140);
            this.panelControl2.TabIndex = 6;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridDanhSachSPDatHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(924, 136);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Danh Sách Hàng Nhập Kho";
            // 
            // gridDanhSachSPDatHang
            // 
            this.gridDanhSachSPDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDanhSachSPDatHang.Location = new System.Drawing.Point(2, 21);
            this.gridDanhSachSPDatHang.MainView = this.gridViewDanhSachSPDH;
            this.gridDanhSachSPDatHang.Name = "gridDanhSachSPDatHang";
            this.gridDanhSachSPDatHang.Size = new System.Drawing.Size(920, 113);
            this.gridDanhSachSPDatHang.TabIndex = 0;
            this.gridDanhSachSPDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSachSPDH});
            // 
            // gridViewDanhSachSPDH
            // 
            this.gridViewDanhSachSPDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.TenSP,
            this.SoLuongNhap,
            this.DonGia,
            this.GiaTien});
            this.gridViewDanhSachSPDH.GridControl = this.gridDanhSachSPDatHang;
            this.gridViewDanhSachSPDH.Name = "gridViewDanhSachSPDH";
            this.gridViewDanhSachSPDH.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewDanhSachSPDH_RowClick);
            // 
            // TenSP
            // 
            this.TenSP.Caption = "Tên Sản Phẩm";
            this.TenSP.FieldName = "Sach.Tensach";
            this.TenSP.Name = "TenSP";
            this.TenSP.Visible = true;
            this.TenSP.VisibleIndex = 0;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.Caption = "Số Lượng Mua";
            this.SoLuongNhap.FieldName = "SoLuong";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.Visible = true;
            this.SoLuongNhap.VisibleIndex = 1;
            // 
            // DonGia
            // 
            this.DonGia.Caption = "Đơn Giá";
            this.DonGia.DisplayFormat.FormatString = "{0:0,0} VNĐ";
            this.DonGia.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DonGia.FieldName = "Sach.Gia";
            this.DonGia.Name = "DonGia";
            this.DonGia.Visible = true;
            this.DonGia.VisibleIndex = 2;
            // 
            // GiaTien
            // 
            this.GiaTien.Caption = "Thành Tiền";
            this.GiaTien.DisplayFormat.FormatString = "{0:0,0} VNĐ";
            this.GiaTien.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.GiaTien.FieldName = "GiaTien";
            this.GiaTien.Name = "GiaTien";
            this.GiaTien.Visible = true;
            this.GiaTien.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl6);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(928, 48);
            this.panelControl1.TabIndex = 4;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl6.Controls.Add(this.labelControl1);
            this.panelControl6.Location = new System.Drawing.Point(278, 11);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(479, 33);
            this.panelControl6.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.labelControl1.Location = new System.Drawing.Point(50, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(367, 29);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Quản lý lập phiếu đặt hàng tại chỗ";
            // 
            // FrmLapPhieuDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 544);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FrmLapPhieuDatHang";
            this.Text = "FrmLapPhieuDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridViewChiTietPDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDSPhieuDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachPhieuDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl10)).EndInit();
            this.panelControl10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl8)).EndInit();
            this.panelControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl9)).EndInit();
            this.panelControl9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDanhSachSPDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachSPDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridDSPhieuDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSachPhieuDatHang;
        private DevExpress.XtraGrid.Columns.GridColumn NgayNhapHang;
        private DevExpress.XtraGrid.Columns.GridColumn Madonhang;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.PanelControl panelControl10;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private System.Windows.Forms.ComboBox CboSanPham;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox TxtSoLuong;
        private DevExpress.XtraEditors.PanelControl panelControl8;
        private DevExpress.XtraEditors.PanelControl panelControl9;
        private DevExpress.XtraEditors.SimpleButton BtnLuuCTPNK;
        private DevExpress.XtraEditors.SimpleButton BtnSua;
        private DevExpress.XtraEditors.SimpleButton BtnXoa;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridDanhSachSPDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSachSPDH;
        private DevExpress.XtraGrid.Columns.GridColumn TenSP;
        private DevExpress.XtraGrid.Columns.GridColumn SoLuongNhap;
        private DevExpress.XtraGrid.Columns.GridColumn DonGia;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn GiaTien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewChiTietPDH;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}