using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.ServiceModel;
using System.Collections.Generic;
namespace Book_WindowsFrom
{
    public partial class ReportTongSoLuongBanRa : DevExpress.XtraReports.UI.XtraReport
    {
        public static DateTime NgayBatDau;
        public static DateTime NgayKetThuc;
        public static List<Book_Services.BizSach> ListSach;
        public ReportTongSoLuongBanRa()
        {
            InitializeComponent();
            LoadBaoCaoDoanhThu();
        }
        public void LoadBaoCaoDoanhThu()
        {
            bindingSourceSoLuong.DataSource = ListSach;
            LBNgayLapBaoCao.Text = DateTime.Now.ToShortDateString();
            LbNgayBD.Text = NgayBatDau.ToShortDateString();
            LbNgayDen.Text = NgayKetThuc.ToShortDateString();
            this.ShowPreview();

        }
    }
}
