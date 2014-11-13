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
    public partial class FrmThongKeSoLuongBanRa : DevExpress.XtraEditors.XtraForm
    {

        Book_Services.Book_ServiceClient sv;
        public FrmThongKeSoLuongBanRa()
        {
            try
            {
                InitializeComponent();
                LoadCboDanhMuc();
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Có Lỗi !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            }
        }
        public void LoadCboDanhMuc()
        {
            sv = new Book_Services.Book_ServiceClient();
            Book_Services.BizTheLoai TL = new Book_Services.BizTheLoai
            {
                 TenDM = "Tất cả",
                 MaTL = 0
            };
            List<Book_Services.BizTheLoai> List = sv.ListTheLoai();
            List.Insert(0, TL);
            CboDanhMuc.DataSource = List;
            CboDanhMuc.DisplayMember = "TenDM";
            CboDanhMuc.ValueMember = "MaTL";
        }
         

        private void FrmBaoCaoSoLuong_Load(object sender, EventArgs e)
        {

        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {

                if (DateTimeNBD.Value <= DateTimeNKT.Value)
                {
                    sv = new Book_Services.Book_ServiceClient();
                    List<Book_Services.BizSach> ListTK = sv.ThongKeSoLuongBanRa((Book_Services.BizTheLoai)CboDanhMuc.SelectedItem, DateTimeNBD.Value, DateTimeNKT.Value);

                    if (ListTK.Count > 0)
                    {
                        gridDanhSachSoLuong.DataSource = ListTK;

                        XtraMessageBox.Show("Thống kê Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Không Có Danh Sách Cần Thống Kê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridDanhSachSoLuong.DataSource = null;
            
                    }
                }
                else
                {
                    XtraMessageBox.Show("Ngày Bắt Đầu Phải Nhỏ Hơn Ngày Kết Thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridDanhSachSoLuong.DataSource = null;
                }
            }
            catch
            {
                XtraMessageBox.Show("Chương Trình Bị Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gridDanhSachSoLuong.DataSource = null;
             
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