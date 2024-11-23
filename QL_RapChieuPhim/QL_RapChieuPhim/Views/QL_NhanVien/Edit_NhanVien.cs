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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QL_RapChieuPhim.Views
{
    public partial class Edit_NhanVien : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQuery;
        Views.QL_NhanVien qL;
        string[] strData;

        public Edit_NhanVien(Views.QL_NhanVien qL_NhanVien, string[] str)
        {
            this.qL = qL_NhanVien;
            InitializeComponent();
            strData = str;
        }

        private void Edit_NhanVien_Load(object sender, EventArgs e)
        {
            addDuLieu(strData);
        }

        public void addDuLieu(string[] str)
        {
            txt_fixMNV.Text = str[1];
            txt_fixHoTen.Text = str[2];
            cB_fixgioiTinh.Text = str[3];
            dTP_fixNgaySinh.Text = str[4];
            txt_fixSoDT.Text = str[5];
            txt_fixLuong.Text = str[6];
            dTP_fixCaLam.Text = str[7];
            txt_fixTaiKhoan.Text = dtb.selectColumn("select TenDN from tbTaiKhoan where MaNV = '" + str[1] + "'");
            txt_fixMatKhau.Text = dtb.selectColumn("select MatKhau from tbTaiKhoan where MaNV = '" + str[1] + "'");
        }

        private void btn_close_fixNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huySuaNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luuSuaNhanVien_Click(object sender, EventArgs e)
        {
            if (txt_fixHoTen.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên nhân viên!");
                txt_fixHoTen.Focus();
            }
            else
            {
                if (cB_fixgioiTinh.Text.Trim() == "")
                {
                    MessageBox.Show("Bạn chưa chọn giới tính cho nhân viên!");
                    cB_fixgioiTinh.Focus();
                }

                else
                {
                    if (dTP_fixNgaySinh.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập ngày sinh cho nhân viên!");
                        dTP_fixNgaySinh.Focus();
                    }
                    else
                    {
                        if (txt_fixSoDT.Text.Trim() == "")
                        {
                            MessageBox.Show("Bạn chưa nhập số điện thoại cho nhân viên!");
                            txt_fixSoDT.Focus();
                        }
                        else
                        {
                            if (txt_fixLuong.Text.Trim() == "")
                            {
                                MessageBox.Show("Bạn chưa nhập lương cho nhân viên!");
                                txt_fixLuong.Focus();
                            }

                            else
                            {
                                if (dTP_fixCaLam.Text.Trim() == "")
                                {
                                    MessageBox.Show("Bạn chưa nhập ca làm cho nhân viên");
                                    dTP_fixCaLam.Focus();
                                }
                                else
                                {
                                    if (txt_fixMatKhau.Text.Trim() == "")
                                    {
                                        MessageBox.Show("Bạn chưa nhập mật khẩu cho nhân viên");
                                        txt_fixMatKhau.Focus();
                                    }
                                    else
                                    {
                                        if (MessageBox.Show("Bạn chắc chắn muốn sửa thông tin nhân viên không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                        {
                                            dtb.DataChange("UPDATE tbNhanVien SET TenNV = N'" + txt_fixHoTen.Text + "', GioiTinh = N'" + cB_fixgioiTinh.Text + "', NgaySinh = '" + dTP_fixNgaySinh.Value.ToString("yyyy-MM-dd") + "', SDT = '" +
                                            txt_fixSoDT.Text + "', Luong = '" + txt_fixLuong.Text + "', CaLam = '" + dTP_fixCaLam.Value.ToString("HH:mm") + "' where MaNV = '" + txt_fixMNV.Text + "'");
                                            dtb.DataChange("UPDATE tbTaiKhoan SET MatKhau = '" + txt_fixMatKhau.Text + "', ChucVu = '" + "Nhân Viên" + "' where MaNV = '" + txt_fixMNV.Text + "'");

                                            Views.MessageSuccess mss = new Views.MessageSuccess("sửa nhân viên thành công");
                                            mss.Show();
                                            qL.dGV_thongTinNV.DataSource = dtb.DataRead("select * from tbNhanVien");
                                            
                                            this.Close();
                                           
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void txt_fixSoDT_TextChanged(object sender, EventArgs e)
        {
            if (txt_fixSoDT.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                txt_fixSoDT.Text = txt_fixSoDT.Text.Substring(0, 10);  // cắt chuỗi số thừa
                txt_fixSoDT.Select(10, 0);  // đặt con trỏ về cuối text
            }
        }

        private void txt_fixSoDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Ô này chỉ được nhập số!");
                e.Handled = true;
            }
        }
        private void dTP_fixNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (dTP_fixNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                dTP_fixNgaySinh.Value = DateTime.Now;
            }
        }

        private void txt_fixSoDT_Validating(object sender, CancelEventArgs e)
        {
            if (txt_fixSoDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số");
                txt_fixSoDT.Focus();
            }
            if (!Regex.IsMatch(txt_fixSoDT.Text, @"^0"))   // so sánh với kí tự đầu tiên
            {
                MessageBox.Show("Số điện thoại phải bắt đầu với số 0");
                txt_fixSoDT.Select(0, 0);   // đặt con trỏ về trước vị trí kí tự đầu tiên
                txt_fixSoDT.Focus();
            }
        }

        private void txt_fixMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txt_fixMatKhau.Text.Length < 4)
            {
                MessageBox.Show("Mật khẩu bạn tạo phải ít nhất có 4 kí tự!");
                txt_fixMatKhau.Focus();
            }
            if (!Regex.IsMatch(txt_fixMatKhau.Text, "[A-Z]"))  // kiểm tra xem có kí tự in hoa không
            {
                MessageBox.Show("Mật khẩu bạn tạo phải có ít nhất 1 chữ cái in hoa!");
                txt_fixMatKhau.Focus();
            }
            if (!Regex.IsMatch(txt_fixMatKhau.Text, @"[\W_]"))  // kiểm tra xem có kí tự đặc biệt không
            {
                MessageBox.Show("Mật khẩu bạn tạo phải có ít nhất 1 kí tự đặc biệt!");
                txt_fixMatKhau.Focus();
            }
            if (txt_fixMatKhau.Text.Contains(" "))   // kiểm tra xem có dấu cách không
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!");
                txt_fixMatKhau.Focus();
            }
        }
    }
}

