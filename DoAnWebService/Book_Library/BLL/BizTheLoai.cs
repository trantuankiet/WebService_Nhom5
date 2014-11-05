using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizTheLoai
    {
        #region khai báo
        private int maTL;

        public int MaTL
        {
            get { return maTL; }
            set { maTL = value; }
        }
        private string tenDM;

        public string TenDM
        {
            get { return tenDM; }
            set { tenDM = value; }
        }
        private Boolean trangThai;

        public Boolean TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        public static List<BizTheLoai> getList()
        {
            return DalTheLoai.getList();
        }
        public static void Insert(BizTheLoai tl)
        {
            DalTheLoai.insert(tl);
        }
        public static void Delete(BizTheLoai tl)
        {
            DalTheLoai.delete(tl);
            List<BizSach> ListSach = BizSach.LayListSach().Where(t => t.TheLoai.MaTL == tl.MaTL).ToList<BizSach>();
            foreach (BizSach sach in ListSach)
            {
                BizSach.XoaSach(sach);
            }
        }
        public static void Edit(BizTheLoai tl)
        {
            DalTheLoai.edit(tl);
        }
        public static void Kichhoat(BizTheLoai tl)
        {
            DalTheLoai.KichHoat(tl);
        }
    }
}
