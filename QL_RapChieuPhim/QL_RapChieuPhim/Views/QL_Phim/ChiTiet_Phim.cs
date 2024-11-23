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
    public partial class ChiTiet_Phim : Form
    {

        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQuery;
        Views.QL_Phim qlPhim;
        string[] strData;
        public ChiTiet_Phim(Views.QL_Phim qL_Phim, string[] str)
        {
            this.qlPhim = qL_Phim;
            InitializeComponent();
            strData = str;
        }

        private void ChiTiet_Phim_Load(object sender, EventArgs e)
        {
            addtextbox(strData);
            addcombobox();
        }

        private void btn_close_addphim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addtextbox(string[] str)
        {
            txt_MaPhim.Text = str[1];
            txt_TenPhim.Text = str[2];
            comboBox1.Text = dtb.selectColumn("select LoaiPhim from tbTheLoaiPhim where MaTheLoai like '" + str[3] + "'");
            txt_addDaodien.Text = str[4];
            comboBox2.Text = str[5];
            txt_NamPhatHanh.Text = str[6];
            txt_ThoiLuongPhim.Text = str[7];
            txt_MoTaPhim.Text = str[8];
            if (str[9] != "")
            {
                pictureBox_AnhPhim.Image = Image.FromFile(Application.StartupPath + "\\img\\" + str[9]);
            }

        }
        public void addcombobox()
        {
            comboBox1.Items.Add("Kinh Dị");
            comboBox1.Items.Add("Hành Động");
            comboBox1.Items.Add("Hài Hước");
            comboBox1.Items.Add("Tâm Lý Xã Hội");
            comboBox1.Items.Add("Khoa Học Viễn Tưởng");
            comboBox1.Items.Add("Chinh Thám");
            comboBox1.Items.Add("Hoạt Hình");

            comboBox2.Items.Add("Hoa Kỳ");
            comboBox2.Items.Add("Anh");
            comboBox2.Items.Add("Hàn Quốc");
            comboBox2.Items.Add("Trung Quốc");
            comboBox2.Items.Add("Nhật Bản");
            comboBox2.Items.Add("Đài Loan");
            comboBox2.Items.Add("Thái Lan");
            comboBox2.Items.Add("Tây Ban Nha");
            comboBox2.Items.Add("Nga");
            comboBox2.Items.Add("Đức");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
