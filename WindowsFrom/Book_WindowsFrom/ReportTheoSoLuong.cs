using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.ServiceModel;
namespace Book_WindowsFrom
{
    public partial class ReportTheoSoLuong : DevExpress.XtraReports.UI.XtraReport
    {
        
        public static List<Book_Services.BizSach> List = new List<Book_Services.BizSach>();
        public static DateTime ngaybatdau;
        public static DateTime ngayketthuc;
        public ReportTheoSoLuong()
        {
            InitializeComponent();
            LoadBaoCao();
        }
        public void LoadBaoCao()
        {
            bingdingBaoCao.DataSource = List;
            xrLabelNgayBaoCao.Text = DateTime.Now.ToShortDateString();
            xrLabelNgayTu.Text = ngaybatdau.ToShortDateString();
            xrLabelNgayDen.Text = ngayketthuc.ToShortDateString();
        }

    }
}
