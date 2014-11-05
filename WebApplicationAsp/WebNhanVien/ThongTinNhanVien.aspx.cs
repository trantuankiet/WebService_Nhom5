using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNhanVien
{
    public partial class ThongTinNhanVien : System.Web.UI.Page
    {
        Book_Services.Book_ServiceClient sv;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    if (Session["MaNV"] != null)
                    {
                        LoadThongTin();
                        panelpass.Visible = false;
                        PNTDoiMatKhau.Visible = false;
                    }
                    else
                    {
                        PanelCapNhat.Visible = false;
                    }
                }
            }
            catch
            {
                ClientMessageBox.Show("Bị Lỗi !!!", this);
    
            }
        }
        public void LoadThongTin()
        {
            try
            {
                sv = new Book_Services.Book_ServiceClient();
                Book_Services.BizNhanVien  nv = sv.LayThongTinNhanVien(Session["MaNV"].ToString());
                TxtHoTen.Text = nv.TenNV;
                TxtSoDienThoai.Text = nv.SDT;
                TxtEmail.Text = nv.Email;
                TxtDiaChi.Text = nv.DiaChi;
                DateTimeNgaySinh.Date = nv.NgaySinh;    
            }
            catch
            {
                ClientMessageBox.Show("Bi Lỗi !!!", this);
            }
        }

        protected void BtnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                int NamHienTai = Convert.ToInt32(DateTime.Now.Year);
                int NamNhanVien = Convert.ToInt32(DateTimeNgaySinh.Date.Year);
                if (NamNhanVien < NamHienTai)
                {
                    if (NamHienTai - NamNhanVien >= 18)
                    {
                        sv = new Book_Services.Book_ServiceClient();
                        Book_Services.BizNhanVien nv = new Book_Services.BizNhanVien();
                        nv.MaNV = Session["MaNV"].ToString();
                        nv.TenNV = TxtHoTen.Text;
                        nv.SDT = TxtSoDienThoai.Text;
                        nv.Email = TxtEmail.Text;
                        nv.DiaChi = TxtDiaChi.Text;
                        nv.NgaySinh = DateTimeNgaySinh.Date;
                        if (panelpass.Visible == true)
                        {
                            LuuMk(nv);
                        }
                        else
                        {
                            sv.EditTTNVKMK(nv);
                            LoadThongTin();
                            ClientMessageBox.Show("Cập nhật thành công!", this);

                        }
                    }
                    else
                    {
                        ClientMessageBox.Show("Tuổi Của Nhân Viên Phải Lớn Hơn 18", this);

                    }
                }
                else
                {
                    ClientMessageBox.Show("Năm Nhập Phải Lớn Hơn Năm Hiện Tại", this);

                }

            }

            catch
            {
                ClientMessageBox.Show("Bi Lỗi !!!", this);
            }
        }

        public void LuuMk(Book_Services.BizNhanVien nv)
        {
            sv = new Book_Services.Book_ServiceClient();
            if (sv.KiemTraMatKhau(Session["MaNV"].ToString(), sv.Mahoa(txtMatKhauCu.Text)) == true)
            {
                nv.MatKhau = sv.Mahoa(TxtMatKhauMoi.Text);
                sv.EditTTNVMK(nv);
                LoadThongTin();
                ClientMessageBox.Show("Cập nhật thành công!", this);
                panelpass.Visible = false;
            }
            else
            {
                ClientMessageBox.Show("Mật Khẩu Củ Không Đúng", this);
            }
        }
        protected void LinkMatKhau_Click(object sender, EventArgs e)
        {
            panelpass.Visible = true;
            PNTDoiMatKhau.Visible = true;
            PNDoiMatKhau.Visible = false;
        }
        protected void LinkTatMatKhau_Click(object sender, EventArgs e)
        {
            panelpass.Visible = false;
            PNTDoiMatKhau.Visible = false;
            PNDoiMatKhau.Visible = true;
        }

    }
}