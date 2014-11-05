namespace Book_WindowsFrom
{
    partial class FrmThongKeTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeTonKho));
            this.gpThongKeKho = new DevExpress.XtraEditors.GroupControl();
            this.gridThongKeKho = new DevExpress.XtraGrid.GridControl();
            this.gridViewThongKe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.lbNgay = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerTonKho = new System.Windows.Forms.DateTimePicker();
            this.lbTenSP = new DevExpress.XtraEditors.LabelControl();
            this.cboSach = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnThongKe = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gpThongKeKho)).BeginInit();
            this.gpThongKeKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKeKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).BeginInit();
            this.panelControl6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpThongKeKho
            // 
            this.gpThongKeKho.Controls.Add(this.gridThongKeKho);
            this.gpThongKeKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gpThongKeKho.Location = new System.Drawing.Point(2, 277);
            this.gpThongKeKho.Name = "gpThongKeKho";
            this.gpThongKeKho.Size = new System.Drawing.Size(660, 183);
            this.gpThongKeKho.TabIndex = 5;
            this.gpThongKeKho.Text = "Danh Sách Sản Phẩm Tồn Kho";
            // 
            // gridThongKeKho
            // 
            this.gridThongKeKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridThongKeKho.Location = new System.Drawing.Point(2, 21);
            this.gridThongKeKho.MainView = this.gridViewThongKe;
            this.gridThongKeKho.Name = "gridThongKeKho";
            this.gridThongKeKho.Size = new System.Drawing.Size(656, 160);
            this.gridThongKeKho.TabIndex = 0;
            this.gridThongKeKho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThongKe});
            // 
            // gridViewThongKe
            // 
            this.gridViewThongKe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewThongKe.GridControl = this.gridThongKeKho;
            this.gridViewThongKe.GroupCount = 1;
            this.gridViewThongKe.Name = "gridViewThongKe";
            this.gridViewThongKe.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridViewThongKe.OptionsBehavior.Editable = false;
            this.gridViewThongKe.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumn3, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên Sách";
            this.gridColumn1.FieldName = "Tensach";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Số Lượng Tồn Kho";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Trạng Thái";
            this.gridColumn3.FieldName = "gridColumn3";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.UnboundExpression = "Iif([TrangThai] == True,\'Còn Bán\'  ,\'Ngừng Bán\' )";
            this.gridColumn3.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 49);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(660, 228);
            this.groupControl1.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(459, 205);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.lbNgay);
            this.panelControl4.Controls.Add(this.dateTimePickerTonKho);
            this.panelControl4.Controls.Add(this.lbTenSP);
            this.panelControl4.Controls.Add(this.cboSach);
            this.panelControl4.Location = new System.Drawing.Point(83, 36);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(302, 140);
            this.panelControl4.TabIndex = 4;
            // 
            // lbNgay
            // 
            this.lbNgay.Location = new System.Drawing.Point(3, 91);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(25, 13);
            this.lbNgay.TabIndex = 3;
            this.lbNgay.Text = "Ngày";
            // 
            // dateTimePickerTonKho
            // 
            this.dateTimePickerTonKho.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTonKho.Location = new System.Drawing.Point(97, 85);
            this.dateTimePickerTonKho.Name = "dateTimePickerTonKho";
            this.dateTimePickerTonKho.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerTonKho.TabIndex = 2;
            // 
            // lbTenSP
            // 
            this.lbTenSP.Location = new System.Drawing.Point(3, 27);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(44, 13);
            this.lbTenSP.TabIndex = 1;
            this.lbTenSP.Text = "Tên Sách";
            // 
            // cboSach
            // 
            this.cboSach.FormattingEnabled = true;
            this.cboSach.Location = new System.Drawing.Point(97, 24);
            this.cboSach.Name = "cboSach";
            this.cboSach.Size = new System.Drawing.Size(200, 21);
            this.cboSach.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnIn);
            this.panelControl2.Controls.Add(this.btnThongKe);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(461, 21);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(197, 205);
            this.panelControl2.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(61, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(61, 95);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 6;
            this.btnIn.Text = "In";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(61, 31);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 5;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gpThongKeKho);
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(664, 462);
            this.panelControl3.TabIndex = 6;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(660, 47);
            this.panelControl5.TabIndex = 6;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl6.Controls.Add(this.labelControl1);
            this.panelControl6.Location = new System.Drawing.Point(137, 4);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(392, 37);
            this.panelControl6.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Location = new System.Drawing.Point(88, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(209, 33);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Thống kê tồn kho";
            // 
            // FrmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 462);
            this.Controls.Add(this.panelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongKeTonKho";
            this.Text = "Quản Lý Thống Kê Tồn Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gpThongKeKho)).EndInit();
            this.gpThongKeKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridThongKeKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThongKe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl6)).EndInit();
            this.panelControl6.ResumeLayout(false);
            this.panelControl6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gpThongKeKho;
        private DevExpress.XtraGrid.GridControl gridThongKeKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThongKe;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnThongKe;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl lbTenSP;
        private System.Windows.Forms.ComboBox cboSach;
        private DevExpress.XtraEditors.LabelControl lbNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTonKho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}