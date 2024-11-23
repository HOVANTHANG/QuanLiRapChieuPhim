using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QL_RapChieuPhim.Views
{
    public partial class Login : Form
    {
        //Thư viện bắt sự kiện di chuột khi bật formborderstyle = none
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();

        //bool Matkhau = false;

        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            /*              txt_user.Text = hidetextTK;
                          txt_user.ForeColor = Color.Gray;

                          txt_password.Text = hidetextMK;
                          txt_password.ForeColor = Color.Gray;

                      */
        }


        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            FormMain frm = new FormMain();
            frm.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_DangNhap_Click_2(object sender, EventArgs e)
        {
            string loginname = txt_TaiKhoan.Text;
            string password = txt_MatKhau.Text;

            if (string.IsNullOrWhiteSpace(loginname))
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản");
                txt_TaiKhoan.Focus();
                return; // Thoát khỏi phương thức nếu không hợp lệ
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
                txt_MatKhau.Focus();
                return; // Thoát khỏi phương thức nếu không hợp lệ
            }

            string connectionString = "Data Source=DESKTOP-N7QM0NS\\MSSQLSERVER01;Initial Catalog=QLRapChieuPhim;Integrated Security=True;MultipleActiveResultSets=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Tạo câu truy vấn SQL để kiểm tra đăng nhập và lấy mật khẩu và ChucVu
                string query = "SELECT MatKhau, ChucVu FROM tbTaiKhoan WHERE TenDN = @loginname";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@loginname", loginname);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read()) // Nếu có kết quả
                        {
                            string hashedPassword = reader.GetString(0); // Lấy mật khẩu đã mã hóa từ cơ sở dữ liệu
                            string chucVu = reader.GetString(1); // Lấy chức vụ

                            // Kiểm tra mật khẩu
                            if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                            {
                                // Lấy mã nhân viên
                                string LayMaNV = "SELECT MaNV FROM tbTaiKhoan WHERE TenDN = @loginname";
                                SqlCommand layMaNVCmd = new SqlCommand(LayMaNV, connection);
                                layMaNVCmd.Parameters.AddWithValue("@loginname", loginname);
                                object maNVObject = layMaNVCmd.ExecuteScalar();
                                string MaNV = (maNVObject != DBNull.Value) ? maNVObject.ToString() : string.Empty;

                                // Lấy tên từ bảng nhân viên
                                string LayTenNV = "SELECT TenNV FROM tbNhanVien WHERE MaNV = @MaNV";
                                SqlCommand LayTenNVCmd = new SqlCommand(LayTenNV, connection);
                                LayTenNVCmd.Parameters.AddWithValue("@MaNV", MaNV);
                                object tenNVObject = LayTenNVCmd.ExecuteScalar();
                                string TenNV = (tenNVObject != null) ? tenNVObject.ToString() : string.Empty;

                                // Thực hiện hành động sau khi đăng nhập thành công
                                if (chucVu == "Nhân Viên")
                                {
                                    Views.formMainNV fmNV = new formMainNV(TenNV, MaNV);
                                    this.Hide();
                                    fmNV.ShowDialog();
                                    this.Show();
                                }
                                else if (chucVu == "Admin")
                                {
                                    FormMain fm = new FormMain("Admin");
                                    this.Hide();
                                    fm.ShowDialog();
                                    this.Show();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Đăng nhập không thành công. Mật khẩu không đúng.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập không thành công. Tên tài khoản không tồn tại.");
                        }
                    }
                }
            }
        }


        private void txt_MatKhau_Enter(object sender, EventArgs e)
        {
            txt_MatKhau.UseSystemPasswordChar = true;
            txt_MatKhau.PlaceholderText = "";
        }

        private void txt_MatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_MatKhau.Text))
            {
                txt_MatKhau.UseSystemPasswordChar = false;
                txt_MatKhau.PlaceholderText = "Mật khẩu";
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_DangNhap_Click_2(sender, e);
            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txt_TaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkRegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Views.Register.Register register = new Views.Register.Register();
            register.ShowDialog();
        }
    }
}
