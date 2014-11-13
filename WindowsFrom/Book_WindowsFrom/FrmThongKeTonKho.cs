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
    public partial class FrmThongKeTonKho : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmThongKeTonKho()
        {
            InitializeComponent();
            LoadCB();
        }

        public void LoadCB()
        {
            sv = new Book_Services.Book_ServiceClient();
           Book_Services.BizSach sach = new Book_Services.BizSach
            {
                MaSach = 0,
                Tensach = "Tất Cả"
            };
            List<Book_Services.BizSach> ListSach = sv.LayListSach();
            ListSach.Insert(0,sach);
            cboSach.DataSource = ListSach;
            cboSach.DisplayMember = "Tensach";
            cboSach.ValueMember = "MaSach";
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                gridThongKeKho.DataSource = sv.ThongKeTonKho((Book_Services.BizSach)cboSach.SelectedItem, dateTimePickerTonKho.Value);
                XtraMessageBox.Show("Bạn đã thống kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridThongKeKho.DataSource = null;

            }
        }

       


       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            FrmHienThi hienthi = new FrmHienThi();
            hienthi.MdiParent = FrmMain.ActiveForm;
            hienthi.Show();

            this.Close();
        }
        public static Book_Services.BizNhanVien NhanVien { get; set; }

       
    }
}