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
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 14.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panel_menu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
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
            //DisableButton();
            //slidebar_timer.Start();
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
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void btn_phatluong_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.TinhLuong(), sender);
        }
    }
}
