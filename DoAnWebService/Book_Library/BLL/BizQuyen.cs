using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Library.DAL;
namespace Book_Library.BLL
{
    public class BizQuyen
    {
        #region Khai báo
        private int maQuyen;

        public int MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        private string tenQuyen;

        public string TenQuyen
        {
            get { return tenQuyen; }
            set { tenQuyen = value; }
        }
        private Boolean trangThai;

        public Boolean TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }
        #endregion
        public static List<BizQuyen> getList()
        {
            return DalQuyen.getList().Where(t=>t.TrangThai == true).ToList<BizQuyen>();
        }
        public static void Insert(BizQuyen q)
        {
            DalQuyen.insert(q);
        }
        public static void Delete(BizQuyen q)
        {
            DalQuyen.delete(q);
        }
        public static void Edit(BizQuyen q)
        {
            DalQuyen.edit(q);
        }
    }
}
