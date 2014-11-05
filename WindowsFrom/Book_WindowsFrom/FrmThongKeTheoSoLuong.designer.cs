namespace Book_WindowsFrom
{
    partial class FrmThongKeTheoSoLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongKeTheoSoLuong));
            this.gridBaoCao = new DevExpress.XtraEditors.GroupControl();
            this.gridKetQua = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdduoi = new System.Windows.Forms.RadioButton();
            this.rdtren = new System.Windows.Forms.RadioButton();
            this.TxtSoLuong = new System.Windows.Forms.TextBox();
            this.dateTimePickerDen = new System.Windows.Forms.DateTimePicker();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateTimePickerTu = new System.Windows.Forms.DateTimePicker();
            this.lbNgayDen = new DevExpress.XtraEditors.LabelControl();
            this.lbNgayTu = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl6 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCao)).BeginInit();
            this.gridBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridKetQua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            // gridBaoCao
            // 
            this.gridBaoCao.Controls.Add(this.gridKetQua);
            this.gridBaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBaoCao.Location = new System.Drawing.Point(2, 283);
            this.gridBaoCao.Name = "gridBaoCao";
            this.gridBaoCao.Size = new System.Drawing.Size(659, 177);
            this.gridBaoCao.TabIndex = 7;
            this.gridBaoCao.Text = "Danh Sách Thông Kê";
            // 
            // gridKetQua
            // 
            this.gridKetQua.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridKetQua.Location = new System.Drawing.Point(2, 21);
            this.gridKetQua.MainView = this.gridView1;
            this.gridKetQua.Name = "gridKetQua";
            this.gridKetQua.Size = new System.Drawing.Size(655, 154);
            this.gridKetQua.TabIndex = 0;
            this.gridKetQua.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView1.GridControl = this.gridKetQua;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
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
            this.gridColumn2.Caption = "Tổng Số Lượng";
            this.gridColumn2.FieldName = "SoLuong";
            this.gridColumn2.Name = "gridColumn2";
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.panelControl1);
            this.groupControl1.Controls.Add(this.panelControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(659, 228);
            this.groupControl1.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl4);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(2, 21);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(458, 205);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl4
            // 
            this.panelControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl4.Controls.Add(this.groupBox1);
            this.panelControl4.Controls.Add(this.TxtSoLuong);
            this.panelControl4.Controls.Add(this.dateTimePickerDen);
            this.panelControl4.Controls.Add(this.labelControl1);
            this.panelControl4.Controls.Add(this.dateTimePickerTu);
            this.panelControl4.Controls.Add(this.lbNgayDen);
            this.panelControl4.Controls.Add(this.lbNgayTu);
            this.panelControl4.Location = new System.Drawing.Point(28, 11);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(417, 179);
            this.panelControl4.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdduoi);
            this.groupBox1.Controls.Add(this.rdtren);
            this.groupBox1.Location = new System.Drawing.Point(74, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // rdduoi
            // 
            this.rdduoi.AutoSize = true;
            this.rdduoi.Location = new System.Drawing.Point(7, 37);
            this.rdduoi.Name = "rdduoi";
            this.rdduoi.Size = new System.Drawing.Size(47, 17);
            this.rdduoi.TabIndex = 1;
            this.rdduoi.Text = "Dưới";
            this.rdduoi.UseVisualStyleBackColor = true;
            // 
            // rdtren
            // 
            this.rdtren.AutoSize = true;
            this.rdtren.Checked = true;
            this.rdtren.Location = new System.Drawing.Point(7, 14);
            this.rdtren.Name = "rdtren";
            this.rdtren.Size = new System.Drawing.Size(47, 17);
            this.rdtren.TabIndex = 0;
            this.rdtren.TabStop = true;
            this.rdtren.Text = "Trên";
            this.rdtren.UseVisualStyleBackColor = true;
            // 
            // TxtSoLuong
            // 
            this.TxtSoLuong.Location = new System.Drawing.Point(74, 81);
            this.TxtSoLuong.Name = "TxtSoLuong";
            this.TxtSoLuong.Size = new System.Drawing.Size(120, 21);
            this.TxtSoLuong.TabIndex = 6;
            // 
            // dateTimePickerDen
            // 
            this.dateTimePickerDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDen.Location = new System.Drawing.Point(282, 31);
            this.dateTimePickerDen.Name = "dateTimePickerDen";
            this.dateTimePickerDen.Size = new System.Drawing.Size(120, 21);
            this.dateTimePickerDen.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 84);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Số Lượng";
            // 
            // dateTimePickerTu
            // 
            this.dateTimePickerTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerTu.Location = new System.Drawing.Point(74, 31);
            this.dateTimePickerTu.Name = "dateTimePickerTu";
            this.dateTimePickerTu.Size = new System.Drawing.Size(120, 21);
            this.dateTimePickerTu.TabIndex = 4;
            // 
            // lbNgayDen
            // 
            this.lbNgayDen.Location = new System.Drawing.Point(223, 37);
            this.lbNgayDen.Name = "lbNgayDen";
            this.lbNgayDen.Size = new System.Drawing.Size(48, 13);
            this.lbNgayDen.TabIndex = 3;
            this.lbNgayDen.Text = "Đến Ngày";
            // 
            // lbNgayTu
            // 
            this.lbNgayTu.Location = new System.Drawing.Point(4, 37);
            this.lbNgayTu.Name = "lbNgayTu";
            this.lbNgayTu.Size = new System.Drawing.Size(41, 13);
            this.lbNgayTu.TabIndex = 1;
            this.lbNgayTu.Text = "Từ Ngày";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnThoat);
            this.panelControl2.Controls.Add(this.btnIn);
            this.panelControl2.Controls.Add(this.btnBaoCao);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(460, 21);
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
            this.btnIn.Text = "Báo Cáo";
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(61, 31);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 5;
            this.btnBaoCao.Text = "Thống kê";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gridBaoCao);
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.panelControl5);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(663, 462);
            this.panelControl3.TabIndex = 8;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.panelControl6);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(2, 2);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(659, 53);
            this.panelControl5.TabIndex = 8;
            // 
            // panelControl6
            // 
            this.panelControl6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl6.Controls.Add(this.labelControl2);
            this.panelControl6.Location = new System.Drawing.Point(125, 6);
            this.panelControl6.Name = "panelControl6";
            this.panelControl6.Size = new System.Drawing.Size(382, 42);
            this.panelControl6.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Location = new System.Drawing.Point(57, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(265, 33);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Báo cáo theo số lượng";
            // 
            // FrmThongKeTheoSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 462);
            this.Controls.Add(this.panelControl3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmThongKeTheoSoLuong";
            this.Text = "Báo Cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gridBaoCao)).EndInit();
            this.gridBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridKetQua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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

        private DevExpress.XtraEditors.GroupControl gridBaoCao;
        private DevExpress.XtraGrid.GridControl gridKetQua;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnIn;
        private DevExpress.XtraEditors.SimpleButton btnBaoCao;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTu;
        private DevExpress.XtraEditors.LabelControl lbNgayDen;
        private System.Windows.Forms.DateTimePicker dateTimePickerDen;
        private DevExpress.XtraEditors.LabelControl lbNgayTu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdduoi;
        private System.Windows.Forms.RadioButton rdtren;
        private System.Windows.Forms.TextBox TxtSoLuong;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DevExpress.XtraEditors.PanelControl panelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}