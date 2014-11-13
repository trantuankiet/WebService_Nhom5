namespace Book_WindowsFrom
{
    partial class FrmThongkeDoanhThuTungSanPham
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
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DateTimeNKT = new System.Windows.Forms.DateTimePicker();
            this.DateTimeNBD = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.BtnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.GridDanhSachDoanhThu = new DevExpress.XtraGrid.GridControl();
            this.gridViewDoanhThu = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl7 = new DevExpress.XtraEditors.PanelControl();
            this.LbTongdoanhthusp = new System.Windows.Forms.Label();
            this.LbTongVC = new DevExpress.XtraEditors.LabelControl();
            this.LbTongTienDoanhThu = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDanhSachDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoanhThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).BeginInit();
            this.panelControl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1040, 43);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panelControl6.Controls.Add(this.labelControl1);
            this.panelControl6.Location = new System.Drawing.Point(246, 6);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(395, 31);
            this.panelControl6.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Location = new System.Drawing.Point(37, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(319, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thống kê doanh thu từng sản phẩm";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.panelControl1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(0, 43);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(318, 332);
            this.panelControl3.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.DateTimeNKT);
            this.groupControl1.Controls.Add(this.DateTimeNBD);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(314, 241);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông Tin Thống Kê";
            // 
            // DateTimeNKT
            // 
            this.DateTimeNKT.CustomFormat = "dd/MM/yyyy";
            this.DateTimeNKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNKT.Location = new System.Drawing.Point(141, 131);
            this.DateTimeNKT.Name = "DateTimeNKT";
            this.DateTimeNKT.Size = new System.Drawing.Size(149, 21);
            this.DateTimeNKT.TabIndex = 16;
            // 
            // DateTimeNBD
            // 
            this.DateTimeNBD.CustomFormat = "dd/MM/yyyy";
            this.DateTimeNBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimeNBD.Location = new System.Drawing.Point(141, 81);
            this.DateTimeNBD.Name = "DateTimeNBD";
            this.DateTimeNBD.Size = new System.Drawing.Size(149, 21);
            this.DateTimeNBD.TabIndex = 15;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(24, 137);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 13);
            this.labelControl3.TabIndex = 10;
            this.labelControl3.Text = "Ngày Kết Thúc";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 82);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Ngày Bắt Đầu";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.BtnThoat);
            this.panelControl1.Controls.Add(this.BtnThongKe);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(2, 243);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(314, 87);
            this.panelControl1.TabIndex = 0;
            // 
            // BtnThoat
            // 
            this.BtnThoat.Location = new System.Drawing.Point(175, 29);
            this.BtnThoat.Name = "BtnThoat";
            this.BtnThoat.Size = new System.Drawing.Size(75, 23);
            this.BtnThoat.TabIndex = 1;
            this.BtnThoat.Text = "Thoát";
            this.BtnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // BtnThongKe
            // 
            this.BtnThongKe.Location = new System.Drawing.Point(53, 29);
            this.BtnThongKe.Name = "BtnThongKe";
            this.BtnThongKe.Size = new System.Drawing.Size(75, 23);
            this.BtnThongKe.TabIndex = 0;
            this.BtnThongKe.Text = "Thống Kê";
            this.BtnThongKe.Click += new System.EventHandler(this.BtnThongKe_Click);
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.groupControl2);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(318, 43);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(722, 332);
            this.panelControl4.TabIndex = 3;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.GridDanhSachDoanhThu);
            this.groupControl2.Controls.Add(this.panelControl5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(718, 328);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Doanh thu của từng sản phẩm";
            // 
            // GridDanhSachDoanhThu
            // 
            this.GridDanhSachDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDanhSachDoanhThu.Location = new System.Drawing.Point(2, 21);
            this.GridDanhSachDoanhThu.MainView = this.gridViewDoanhThu;
            this.GridDanhSachDoanhThu.Name = "GridDanhSachDoanhThu";
            this.GridDanhSachDoanhThu.Size = new System.Drawing.Size(714, 182);
            this.GridDanhSachDoanhThu.TabIndex = 0;
            this.GridDanhSachDoanhThu.UseEmbeddedNavigator = true;
            this.GridDanhSachDoanhThu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDoanhThu});
            // 
            // gridViewDoanhThu
            // 
            this.gridViewDoanhThu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewDoanhThu.GridControl = this.GridDanhSachDoanhThu;
            this.gridViewDoanhThu.GroupCount = 1;
            this.gridViewDoanhThu.Name = "gridViewDoanhThu";
            this.gridViewDoanhThu.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewDoanhThu.OptionsBehavior.Editable = false;
            this.gridViewDoanhThu.OptionsView.ShowFooter = true;
            this.gridViewDoanhThu.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên sách";
            this.gridColumn1.FieldName = "Tensach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Doanh thu sản phẩm";
            this.gridColumn2.DisplayFormat.FormatString = "{0:0,0 VNĐ}";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "Gia";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Gia", "{0:0,0 VNĐ}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trạng thái";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "Iif([TrangThai] == True,\'Còn Bán\'  ,\'Ngừng Bán\' )";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl7);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl5.Location = new System.Drawing.Point(2, 203);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(714, 123);
            this.panelControl5.TabIndex = 0;
            // 
            // panelControl7
            // 
            this.panelControl7.Controls.Add(this.LbTongdoanhthusp);
            this.panelControl7.Controls.Add(this.LbTongVC);
            this.panelControl7.Controls.Add(this.LbTongTienDoanhThu);
            this.panelControl7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl7.Location = new System.Drawing.Point(182, 2);
            this.panelControl7.Name = "panelControl7";
            this.panelControl7.Size = new System.Drawing.Size(530, 119);
            this.panelControl7.TabIndex = 2;
            // 
            // LbTongdoanhthusp
            // 
            this.LbTongdoanhthusp.AutoSize = true;
            this.LbTongdoanhthusp.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LbTongdoanhthusp.Location = new System.Drawing.Point(5, 11);
            this.LbTongdoanhthusp.Name = "LbTongdoanhthusp";
            this.LbTongdoanhthusp.Size = new System.Drawing.Size(0, 23);
            this.LbTongdoanhthusp.TabIndex = 2;
            // 
            // LbTongVC
            // 
            this.LbTongVC.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.LbTongVC.Location = new System.Drawing.Point(88, 50);
            this.LbTongVC.Name = "LbTongVC";
            this.LbTongVC.Size = new System.Drawing.Size(0, 23);
            this.LbTongVC.TabIndex = 1;
            // 
            // LbTongTienDoanhThu
            // 
            this.LbTongTienDoanhThu.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LbTongTienDoanhThu.Location = new System.Drawing.Point(115, 91);
            this.LbTongTienDoanhThu.Name = "LbTongTienDoanhThu";
            this.LbTongTienDoanhThu.Size = new System.Drawing.Size(0, 23);
            this.LbTongTienDoanhThu.TabIndex = 0;
            // 
            // FrmThongkeDoanhThuTungSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 375);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Name = "FrmThongkeDoanhThuTungSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmThongkeDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmThongkeDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDanhSachDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDoanhThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl7)).EndInit();
            this.panelControl7.ResumeLayout(false);
            this.panelControl7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DateTimePicker DateTimeNKT;
        private System.Windows.Forms.DateTimePicker DateTimeNBD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnThoat;
        private DevExpress.XtraEditors.SimpleButton BtnThongKe;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl GridDanhSachDoanhThu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDoanhThu;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.LabelControl LbTongTienDoanhThu;
        private DevExpress.XtraEditors.LabelControl LbTongVC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl7;
        private System.Windows.Forms.Label LbTongdoanhthusp;
    }
}