using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class Edit_KhachHang : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQuery;
        Views.QL_KhachHang ql;
        string[] strData;

        public Edit_KhachHang(Views.QL_KhachHang qL_khachHang, string[] str)
        {
            this.ql = qL_khachHang;
            InitializeComponent();
            strData = str;
        }

        private void btn_close_fixKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huySuaKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luuSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (txt_fixHoTenKH.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên khách hàng!");
                txt_fixHoTenKH.Focus();
            }
            else
            {
                if (txt_fixSoDTKH.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa nhập số điện thoại khách hàng!");
                    txt_fixSoDTKH.Focus();
                }
                else
                {
                    if (MessageBox.Show("Bạn chắc chắn muốn sửa thông tin khách hàng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dtb.DataChange("UPDATE tbKhachHang SET TenKH = N'" + txt_fixHoTenKH.Text + "', GioiTinh = N'" + cB_fixGioiTinhKH.Text + "', NTNS = '" + dTP_fixNgaySinhKH.Value.ToString("yyyy-MM-dd") + "', SDT = '" +
                        txt_fixSoDTKH.Text + "' where TenTKKH = '" + txt_fixTKKH.Text + "'");

                        
                        ql.dGV_thongTinKH.DataSource = dtb.DataRead("select * from tbKhachHang");
                        MessageSuccess mss = new MessageSuccess("sửa thành công");
                        mss.ShowDialog();
                        this.Close();
                    }
                }
            }
        }

        private void Edit_KhachHang_Load(object sender, EventArgs e)
        {
            addDuLieu(strData);
        }

        public void addDuLieu(string[] str)
        {
            txt_fixTKKH.Text = str[1];
            txt_fixHoTenKH.Text = str[2];
            cB_fixGioiTinhKH.Text = str[3];
            dTP_fixNgaySinhKH.Text = str[4];
            txt_fixSoDTKH.Text = str[5];
        }

        private void txt_fixSoDTKH_TextChanged(object sender, EventArgs e)
        {
            if (txt_fixSoDTKH.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                txt_fixSoDTKH.Text = txt_fixSoDTKH.Text.Substring(0, 10);  // cắt chuỗi số thừa
                txt_fixSoDTKH.Select(10, 0);  // đặt con trỏ về cuối text
            }
        }

        private void txt_fixSoDTKH_Validating(object sender, CancelEventArgs e)
        {
            if (txt_fixSoDTKH.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số");
                txt_fixSoDTKH.Focus();
            }
            if (!Regex.IsMatch(txt_fixSoDTKH.Text, @"^0"))   // so sánh với kí tự đầu tiên
            {
                MessageBox.Show("Số điện thoại phải bắt đầu với số 0");
                txt_fixSoDTKH.Select(0, 0);   // đặt con trỏ về trước vị trí kí tự đầu tiên
                txt_fixSoDTKH.Focus();
            }
        }

        private void txt_fixSoDTKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Ô này chỉ được nhập số!");
                e.Handled = true;
            }
        }

        private void dTP_fixNgaySinhKH_ValueChanged(object sender, EventArgs e)
        {
            if (dTP_fixNgaySinhKH.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                dTP_fixNgaySinhKH.Value = DateTime.Now;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
