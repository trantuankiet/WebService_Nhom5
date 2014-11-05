using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizKhuyenMai
    {
        #region khai báo
        private int maKM;

        public int MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }
        private string tenKM;

        public string TenKM
        {
            get { return tenKM; }
            set { tenKM = value; }
        }
        private int giaTriGiam;

        public int GiaTriGiam
        {
            get { return giaTriGiam; }
            set { giaTriGiam = value; }
        }
        private DateTime ngayApDung;

        public DateTime NgayApDung
        {
            get { return ngayApDung; }
            set { ngayApDung = value; }
        }
        private DateTime ngayHetHan;

        public DateTime NgayHetHan
        {
            get { return ngayHetHan; }
            set { ngayHetHan = value; }
        }
        #endregion

        public static List<BizKhuyenMai> getList()
        {
            return DalKhuyenMai.getList();
        }

        public static void Delete(BizKhuyenMai km)
        {
            DalKhuyenMai.delete(km);
        }

        public static bool Insert(BizKhuyenMai km)
        {
            bool k = false;
            List<BizKhuyenMai> list = DalKhuyenMai.getList();
            foreach (var item in list)
            {
                if ((item.NgayApDung <= km.NgayApDung && item.NgayHetHan >= km.NgayApDung) || (item.NgayHetHan <= km.NgayHetHan && item.NgayHetHan >= km.NgayApDung))
                {
                    k = true;
                    break;
                }
            }
            if (k ==false)
            {
                DalKhuyenMai.insert(km);
                return true;
            }
            return false;
        }

        public static bool Edit(BizKhuyenMai km)
        {
            bool k = false;
            List<BizKhuyenMai> list = DalKhuyenMai.getList();
            foreach (var item in list)
            {
                if (km.MaKM != item.MaKM)
                {
                    if ((item.NgayApDung <= km.NgayApDung && item.NgayHetHan >= km.NgayApDung) || (item.NgayApDung <= km.NgayHetHan && item.NgayHetHan >= km.NgayApDung))
                    {
                        k = true;
                        break;
                    }
                }
            }

            if (k == false)
            {
                DalKhuyenMai.edit(km);
                return true;
            }
            return false;
        }
        public static BizKhuyenMai KtraKhuyenMai()
        {
            DateTime NgayHienTai = DateTime.Now;
            BizKhuyenMai KM = new BizKhuyenMai()
            {
                MaKM = 0
            };
            List<BizKhuyenMai> ListKM = BizKhuyenMai.getList();
            foreach (var item in ListKM)
            {
                if (item.NgayApDung <= NgayHienTai && NgayHienTai <= item.NgayHetHan)
                {
                    KM = item;
                    break;
                }

            }
            return KM;
        }
    }
}
