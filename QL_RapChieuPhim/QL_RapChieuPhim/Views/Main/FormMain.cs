using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class FormMain : Form
    {
        bool expandSlidebar;
        //chuyen mau
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form form_con;
        private string tenNV;
        public FormMain()
        {
            random = new Random();  
            InitializeComponent();
        }
        public FormMain(string tenNV)
        {
            this.tenNV = tenNV; 
            random = new Random();
            InitializeComponent();
        }
        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempIndex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempIndex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}

        private void ActivateButton(object btnSender) //Sử dụng để thay đổi màu và chữ của button khi ấn vào
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                    Color color = Color.FromArgb(147, 122, 251); //Đặt màu nền button
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton() //Sử dụng để thay đổi màu và chữ của button khi không ấn vào
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(191, 191, 219);
                    previousBtn.ForeColor = Color.FromArgb(43, 48, 93);
                    previousBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void Open_FormCon(Form FormCon, object btnSender)
        {
            if (form_con != null)
                form_con.Close();
            ActivateButton(btnSender);
            form_con = FormCon;
            FormCon.TopLevel = false;
            FormCon.FormBorderStyle = FormBorderStyle.None;
            FormCon.Dock = DockStyle.Fill;
            this.panel_form.Controls.Add(FormCon);
            this.panel_form.Tag = FormCon;
            FormCon.BringToFront();
            FormCon.Show();
            lbl_tieude.Text = FormCon.Text;
        }

        private void btn_QLPhim_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.QL_Phim(), sender);
        }

        private void btn_QLSuatChieu_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.QL_SuatChieu(), sender);
        }

        private void QL_NhanVien_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.QL_NhanVien(), sender);
        }

        private void QL_khachHang_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.QL_KhachHang(), sender);
        }

        private void btn_QLSanPham_Click(object sender, EventArgs e)
        {
           Open_FormCon(new sanPham2(),sender);
        }
        private void ThongKe_DoanhSo_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.ThongKe(), sender);
        }

        private void slidebar_timer_Tick(object sender, EventArgs e)
        {
            if(expandSlidebar)
            {
                panel_menu.Width -= 10;
                if(panel_menu.Width == panel_menu.MinimumSize.Width)
                {
                    expandSlidebar = false;
                    slidebar_timer.Stop();
                }
            }
            else { 
                panel_menu.Width += 10;
                if (panel_menu.Width == panel_menu.MaximumSize.Width)
                {
                    expandSlidebar = true;
                    slidebar_timer.Stop();
                }
            }

       
        }
        private void pictureBox_menu_Click(object sender, EventArgs e)
        {
            DisableButton();
            slidebar_timer.Start();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lbl_admin.Text = tenNV;
        }

        private void panel_menu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Login login = new Login();
            //login.Show();
            //this.Close();

            if (slidebar_timer.Enabled)
            {
                slidebar_timer.Stop();
            }

            // Mở form Login
            Login login = new Login();
            login.Show();

            // Đóng form hiện tại
            this.Close();
        }

        private void lbl_tieude_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tieude_Click_1(object sender, EventArgs e)
        {

        }

        private void panel_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_phatluong_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.TinhLuong(), sender);
        }
    }
}
