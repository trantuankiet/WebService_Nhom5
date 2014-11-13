using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Book_WindowsFrom
{
    public partial class FrmThongKeTheoSoLuong : DevExpress.XtraEditors.XtraForm
    {
        Book_Services.Book_ServiceClient sv;
        public FrmThongKeTheoSoLuong()
        {
            InitializeComponent();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePickerTu.Value < dateTimePickerDen.Value)
                {
                    sv = new Book_Services.Book_ServiceClient();
                    List<Book_Services.BizSach> ListSach;
                    if (rdtren.Checked == true)
                    {
                        ListSach = sv.ThongKeTheoSoLuong(Convert.ToInt32(TxtSoLuong.Text), true, dateTimePickerTu.Value, dateTimePickerDen.Value);
                    }
                    else
                    {
                        ListSach = sv.ThongKeTheoSoLuong(Convert.ToInt32(TxtSoLuong.Text), false, dateTimePickerTu.Value, dateTimePickerDen.Value);

                    }
                    if (ListSach.Count > 0)
                    {
                        gridKetQua.DataSource = ListSach;
                        XtraMessageBox.Show("Bạn đã thống kê thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                    }
                    else
                    {
                        XtraMessageBox.Show("Không Có Danh Sách Cần Thống Kê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                        gridKetQua.DataSource = null;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Ngày Bắt Đầu Phải Nhỏ Hơn Ngày Kết Thúc", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                    gridKetQua.DataSource = null;
                   
                }
            }
            catch
            {
                XtraMessageBox.Show("Lỗi chương trình !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
          
                gridKetQua.DataSource = null;
                   
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