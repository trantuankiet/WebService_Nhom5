using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.ServiceModel;
namespace Book_WindowsFrom
{
    public partial class ReportTonKho : DevExpress.XtraReports.UI.XtraReport
    {
        public static DateTime NgayThongKe;

        Book_Services.Book_ServiceClient sv;
        public ReportTonKho()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            sv = new Book_Services.Book_ServiceClient();
            LbNgayThongKe.Text = NgayThongKe.ToShortDateString();
            LbNgayTKK.Text = DateTime.Now.ToShortDateString();
            Book_Services.BizSach s = new Book_Services.BizSach()
            {
                MaSach = 0
            };
            bindingTonKho.DataSource = sv.ThongKeTonKho(s,NgayThongKe);
        }


    }
}
