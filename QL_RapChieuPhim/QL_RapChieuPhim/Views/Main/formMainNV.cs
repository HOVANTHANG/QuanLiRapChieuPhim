using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class formMainNV : Form
    {
        bool expandSlidebar;
        //chuyen mau
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form form_con;
        string tenNV;
        string MaNV;
        public formMainNV()
        {
            random = new Random();
            InitializeComponent();
            this.IsMdiContainer = true;
        }
        public formMainNV(string tenNV,String MaNV)
        {
            random = new Random();
            InitializeComponent();
            this.IsMdiContainer = true;
            this.tenNV = tenNV;
            this.MaNV = MaNV;
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

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.FromArgb(147, 122, 251);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton()
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

       
        

        

        private void slidebar_timer_Tick(object sender, EventArgs e)
        {
            if (expandSlidebar)
            {
                panel_menu.Width -= 10;
                if (panel_menu.Width == panel_menu.MinimumSize.Width)
                {
                    expandSlidebar = false;
                    slidebar_timer.Stop();
                }
            }
            else
            {
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

        private void formMainNV_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_PhimDangChieu_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.Phimdangchieu(MaNV), sender);
           
            
        }

        private void panel_form_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formMainNV_Load_1(object sender, EventArgs e)
        {
            lbl_nhanvien.Text = tenNV;
        }

        private void btn_SanPham_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.Dat_SanPham(MaNV), sender);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ChamCong_Click(object sender, EventArgs e)
        {
            Open_FormCon(new Views.ChamCong(MaNV), sender);
        }
    }
}

