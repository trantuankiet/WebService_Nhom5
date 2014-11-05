using System;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.ServiceModel;
namespace Book_WindowsFrom
{
    public partial class ReportDoanhThu : DevExpress.XtraReports.UI.XtraReport
    {
        public static List<Book_Services.BizSach> ListDoanhThu = null;
        public static decimal TongDoanhThu;
        public static DateTime NgayBatDau;
        public static DateTime NgayKetThuc;
        public static decimal TongVC;
        public ReportDoanhThu()
        {
            InitializeComponent();
            LoadBaoCaoDoanhThu();
        }
        public void LoadBaoCaoDoanhThu()
        {
            
            bindingDoanhThu.DataSource = ListDoanhThu;
            LBNgayLapBaoCao.Text = DateTime.Now.ToShortDateString();
            LbNgayBD.Text = NgayBatDau.ToShortDateString();
            LbNgayDen.Text = NgayKetThuc.ToShortDateString();
            XTBTongTien.Text = String.Format("{0:0,0 VNĐ}", TongDoanhThu);
            XTBTongVanC.Text = String.Format("{0:0,0 VNĐ}", TongVC);
            this.ShowPreview();
            
        }

    }
}
