using QL_RapChieuPhim.Database;
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
    public partial class Add_NhanVien : Form
    {
        DatabaseAccess datab = new DatabaseAccess();
        Views.QL_NhanVien ql = new QL_NhanVien();
        Database.Function_SinhMaTuDong auto = new Function_SinhMaTuDong();
        public Add_NhanVien(Views.QL_NhanVien ql)
        {
            InitializeComponent();
            this.ql = ql;
        }

        void ResetValue()
        {
            txt_addMNV.Text = "";
            txt_addHoTen.Text = "";
            cB_addGioiTinh.Text = "";
            dTP_addNgaySinh.Text = DateTime.Now.ToString();
            txt_addSoDT.Text = "";
            txt_addLuong.Text = "";
            dTP_addCaLam.Text = DateTime.Now.ToString();
            txt_addTaiKhoan.Text = "";
            txt_addMatKhau.Text = "";
            txt_addNhapLaiMK.Text = "";
        }

        private void btn_luuPhim_Click(object sender, EventArgs e)
        {
            string sql = "";
            string sql2 = "";
            if(txt_addMNV.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên!");
                txt_addMNV.Focus();
            }
            else
            {
                sql = "Select * from tbNhanVien Where MaNV = '" + txt_addMNV.Text + "'";
                DataTable dttb = datab.DataRead(sql);
                if(dttb.Rows.Count > 0)
                {
                    MessageBox.Show("Mã nhân viên đã có trong cơ sở dữ liệu!");
                    txt_addMNV.Text = "";
                    txt_addMNV.Focus();
                }
                else
                {
                    if (txt_addHoTen.Text.Trim() == "")
                    {
                        MessageBox.Show("Bạn chưa nhập họ tên nhân viên!");
                        txt_addHoTen.Focus();
                    }
                    else
                    {
                        if (cB_addGioiTinh.Text.Trim() == "")
                        {
                            MessageBox.Show("Bạn chưa chọn giới tính cho nhân viên!");
                            cB_addGioiTinh.Focus();
                        }

                        else
                        {
                            if (dTP_addNgaySinh.Text.Trim() == "")
                            {
                                MessageBox.Show("Bạn chưa nhập ngày sinh cho nhân viên!");
                                dTP_addNgaySinh.Focus();
                            }

                            else
                            {
                                if (txt_addSoDT.Text.Trim() == "")
                                {
                                    MessageBox.Show("Bạn chưa nhập số điện thoại cho nhân viên!");
                                    txt_addSoDT.Focus();
                                }
                                else
                                {
                                    if (txt_addLuong.Text.Trim() == "")
                                    {
                                        MessageBox.Show("Bạn chưa nhập lương cho nhân viên!");
                                        txt_addLuong.Focus();
                                    }

                                    else
                                    {
                                        if (dTP_addCaLam.Text.Trim() == "")
                                        {
                                            MessageBox.Show("Bạn chưa nhập ca làm cho nhân viên");
                                            dTP_addCaLam.Focus();
                                        }
                                        else
                                        {
                                            if (txt_addTaiKhoan.Text.Trim() == "")
                                            {
                                                MessageBox.Show("Bạn chưa nhập tài khoản cho nhân viên");
                                                txt_addTaiKhoan.Focus();
                                            }
                                            else
                                            {
                                                sql2 = "Select * from tbTaiKhoan Where TenDN = '" + txt_addTaiKhoan.Text + "'";
                                                DataTable dtb = datab.DataRead(sql2);
                                                if (dtb.Rows.Count > 0)
                                                {
                                                    MessageBox.Show("Tên đăng nhập đã có trong cơ sở dữ liệu!");
                                                    txt_addTaiKhoan.Text = "";
                                                    txt_addTaiKhoan.Focus();
                                                }
                                                else 
                                                {
                                                    if (txt_addMatKhau.Text.Trim() == "")
                                                    {
                                                        MessageBox.Show("Bạn chưa nhập mật khẩu cho nhân viên");
                                                        txt_addMatKhau.Focus();
                                                    }
                                                    else
                                                    {
                                                        if (txt_addNhapLaiMK.Text.Trim() == "" || txt_addNhapLaiMK.Text.Trim() != txt_addMatKhau.Text.Trim())
                                                        {
                                                            MessageBox.Show("Mật khẩu nhập lại của bạn chưa chính xác!");
                                                            txt_addNhapLaiMK.Focus();
                                                        }
                                                        else
                                                        {
                                                            if (MessageBox.Show("Bạn chắc chắn muốn thêm nhân viên mới?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                                            {
                                                                datab.DataChange("INSERT INTO tbNhanVien(MaNV, TenNV, GioiTinh, NgaySinh, SDT, Luong, CaLam) VALUES ('" + txt_addMNV.Text +
                                                                "',N'" + txt_addHoTen.Text + "',N'" + cB_addGioiTinh.Text + "','" + dTP_addNgaySinh.Value.ToString("yyyy-MM-dd") + "','" +
                                                                txt_addSoDT.Text + "','" + txt_addLuong.Text + "','" + dTP_addCaLam.Value.ToString("HH:mm") + "')");
                                                                datab.DataChange("INSERT INTO tbTaiKhoan(TenDN, MatKhau, MaNV, ChucVu) VALUES ('" + txt_addTaiKhoan.Text + "','" +
                                                                    txt_addMatKhau.Text + "','" + txt_addMNV.Text + "','" + "Nhân Viên" + "')");

                                                                MessageBox.Show("Bạn đã thêm nhân viên mới thành công!");
                                                                
                                                                ql.dGV_thongTinNV.DataSource = datab.DataRead("select * from tbNhanVien");
                                                                ql.SoLuongDong();
                                                                Views.MessageSuccess mss = new Views.MessageSuccess("Thêm nhân viên thành công");
                                                                mss.ShowDialog();
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
                        }
                    }
                }               
            }
        }

        private void btn_close_addNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_soNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt16(e.KeyChar) < 48 || Convert.ToInt16(e.KeyChar) > 57) && Convert.ToInt16(e.KeyChar) != 8)
            {
                MessageBox.Show("Ô này chỉ được nhập số!");
                e.Handled = true;
            }
        }

        private void txt_addSoDT_TextChanged(object sender, EventArgs e)
        {
            if(txt_addSoDT.Text.Length > 10)
            {
                MessageBox.Show("Số điện thoại chỉ được nhập 10 số");
                txt_addSoDT.Text = txt_addSoDT.Text.Substring(0, 10);  // cắt chuỗi số thừa
                txt_addSoDT.Select(10, 0);  // đặt con trỏ về cuối text
            }
        }

        private void dTP_addNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if(dTP_addNgaySinh.Value > DateTime.Now)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hiện tại!");
                dTP_addNgaySinh.Value = DateTime.Now;
            }
        }

        private void txt_addSoDT_Validating(object sender, CancelEventArgs e)
        {
            if (txt_addSoDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 số");
                
            }
            if (!Regex.IsMatch(txt_addSoDT.Text, @"^0"))   // so sánh với kí tự đầu tiên
            {
                MessageBox.Show("Số điện thoại phải bắt đầu với số 0");
                txt_addSoDT.Select(0, 0);   // đặt con trỏ về trước vị trí kí tự đầu tiên
                
            }
        }

        private void txt_addMatKhau_Validating(object sender, CancelEventArgs e)
        {
            if (txt_addMatKhau.Text.Length < 4)
            {
                MessageBox.Show("Mật khẩu bạn tạo phải ít nhất có 4 kí tự!");
                
            }
            if (!Regex.IsMatch(txt_addMatKhau.Text, "[A-Z]"))  // kiểm tra xem có kí tự in hoa không
            {
                MessageBox.Show("Mật khẩu bạn tạo phải có ít nhất 1 chữ cái in hoa!");
                
            }
            if (!Regex.IsMatch(txt_addMatKhau.Text, @"[\W_]"))  // kiểm tra xem có kí tự đặc biệt không
            {
                MessageBox.Show("Mật khẩu bạn tạo phải có ít nhất 1 kí tự đặc biệt!");
                
            }
            if (txt_addMatKhau.Text.Contains(" "))   // kiểm tra xem có dấu cách không
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng!");
                
            }
        }

        private void Add_NhanVien_Load(object sender, EventArgs e)
        {
            cB_addGioiTinh.SelectedIndex = 0;
            txt_addMNV.Text = auto.SinhMaTuDong("tbNhanVien", 'N', "MaNV");

        }

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
