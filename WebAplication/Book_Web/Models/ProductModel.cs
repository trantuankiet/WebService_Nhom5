using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.ServiceModel;

namespace Book_Web.Models
{
    public class SearchAdvancedModel
    {
        #region Khai Báo
        
        private string tensach;

        [Display ( Name ="Tên Sách")]
        public string Tensach
        {
            get { return tensach; }
            set { tensach = value; }
        }

        private int MatheLoai;
        
        [Display(Name = "Thể Loại")]
        public int MaTheLoai
        {
            get { return MatheLoai; }
            set { MatheLoai = value; }
        }

        private decimal giaTu;
        [Display(Name = "Giá đến")]
        [DisplayFormat(DataFormatString="{0:0,0 VNĐ}")]
        public decimal GiaTu
        {
            get { return giaTu; }
            set { giaTu = value; }
        }
        private decimal giaDen;
        [Display(Name = "Giá từ")]
        [DisplayFormat(DataFormatString = "{0:0,0 VNĐ}")]    
        public decimal GiaDen
        {
            get { return giaDen; }
            set { giaDen = value; }
        }

        private SelectList listTheLoai;

        public SelectList ListTheLoai
        {
            get { return listTheLoai; }
            set { listTheLoai = value; }
        }
        
        #endregion
       
    }
}