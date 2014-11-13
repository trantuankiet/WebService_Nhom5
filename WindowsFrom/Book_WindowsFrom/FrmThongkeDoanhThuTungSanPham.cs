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
    public partial class FrmThongkeDoanhThuTungSanPham : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmThongkeDoanhThuTungSanPham()
        {
            InitializeComponent();
        }

        private void FrmThongkeDoanhThu_Load(object sender, EventArgs e)
        {
        }

        private void BtnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTimeNBD.Value < DateTimeNKT.Value)
                {
                    sv = new Book_Services.Book_ServiceClient();
                    decimal TongTienVC = sv.ThongKeTienVanChuyen(DateTimeNBD.Value,DateTimeNKT.Value);
                    decimal TongTienSanPham = sv.ThongKeTongDoanhThuSanPham(DateTimeNBD.Value,DateTimeNKT.Value);
                    decimal TongTienDoanhThu = TongTienVC + TongTienSanPham;
                    GridDanhSachDoanhThu.DataSource = sv.ThongKeDoanhThuTungSanPham(DateTimeNBD.Value, DateTimeNKT.Value);
                    LbTongdoanhthusp.Text = "Tổng doanh thu của sản phẩm : " + String.Format("{0:0,0 VNĐ}", TongTienSanPham);
                    LbTongVC.Text = "Tổng tiền vận chuyển : " + String.Format("{0:0,0 VNĐ}", TongTienVC);
                    LbTongTienDoanhThu.Text ="Tổng doanh thu : " + String.Format("{0:0,0 VNĐ}",TongTienDoanhThu);
                    XtraMessageBox.Show("Bạn đã thống kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                }
                else
                {
                    XtraMessageBox.Show("Ngày Bắt Đầu Phải Nhỏ Hơn Ngày Kết Thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    GridDanhSachDoanhThu.DataSource = null;
                    LbTongdoanhthusp.Text = null;
                    LbTongVC.Text = null;
                    LbTongTienDoanhThu.Text = null;
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
                    GridDanhSachDoanhThu.DataSource = null;
                    LbTongdoanhthusp.Text = null;    
                    LbTongVC.Text = null;
                    LbTongTienDoanhThu.Text = null;
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