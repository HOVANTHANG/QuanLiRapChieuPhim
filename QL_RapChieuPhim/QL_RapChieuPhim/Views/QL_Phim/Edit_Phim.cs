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
    public partial class Edit_Phim : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string imageName = "";
        OpenFileDialog openFile;
        string sqlQuery;
        Views.QL_Phim qlPhim;
        string[] strData;
        public Edit_Phim(Views.QL_Phim qL_Phim, string[] str)
        {
            this.qlPhim = qL_Phim;
            InitializeComponent();
            strData = str;  
        }
        private void Edit_Phim_Load(object sender, EventArgs e)
        {
            addcombobox();
            addtextbox(strData);
        }
        public void addtextbox(string[] str) {
            txt_MaPhim.Text = str[1];
            txt_TenPhim.Text = str[2];
            cbb_TheLoaiPhim.Text = dtb.selectColumn("select LoaiPhim from tbTheLoaiPhim where MaTheLoai like '" + str[3] + "'");
            txt_addDaodien.Text = str[4];
            cbb_QuocGia.Text = str[5];
            txt_NamPhatHanh.Text = str[6];
            txt_ThoiLuongPhim.Text = str[7];
            txt_MoTaPhim.Text = str[8];
            if (str[9] != "") {
                pictureBox_AnhPhim.Image = Image.FromFile(Application.StartupPath + "\\img\\" + str[9]);
                imageName = str[9];
            }
            
        }
        public void addcombobox()
        {
            DataTable dt = dtb.DataRead("select * from tbTheLoaiPhim");
            foreach (DataRow row in dt.Rows)
            {
                cbb_TheLoaiPhim.Items.Add(row["LoaiPhim"].ToString());
            }

            cbb_QuocGia.Items.Add("Hoa Kỳ");
            cbb_QuocGia.Items.Add("Anh");
            cbb_QuocGia.Items.Add("Hàn Quốc");
            cbb_QuocGia.Items.Add("Trung Quốc");
            cbb_QuocGia.Items.Add("Nhật Bản");
            cbb_QuocGia.Items.Add("Đài Loan");
            cbb_QuocGia.Items.Add("Thái Lan");
            cbb_QuocGia.Items.Add("Tây Ban Nha");
            cbb_QuocGia.Items.Add("Nga");
            cbb_QuocGia.Items.Add("Đức");
        }

        private void btn_openAnhPhim_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|PNG images|*.png|All Files|*.*";
            openFile.FilterIndex = 1;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_AnhPhim.Image = Image.FromFile(openFile.FileName);
                imageName = openFile.SafeFileName;
            }
        }

        private void btn_close_addphim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luuPhim_Click(object sender, EventArgs e)
        {
            sqlQuery = dtb.selectColumn("select MaTheLoai from tbTheLoaiPhim where LoaiPhim like N'" + cbb_TheLoaiPhim.Text + "'");

            if (txt_TenPhim.Text.Trim() == "")
            {
                error_Phim.SetError(txt_TenPhim, "Tên Phim không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }
            if (cbb_TheLoaiPhim.Text.Trim() == "")
            {
                error_Phim.SetError(cbb_TheLoaiPhim, "Thể loại phim không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }
            if (txt_addDaodien.Text.Trim() == "")
            {
                error_Phim.SetError(txt_addDaodien, "Đạo diễn không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }
            if (cbb_QuocGia.Text.Trim() == "")
            {
                error_Phim.SetError(cbb_QuocGia, "Quốc gia không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }
            if (txt_ThoiLuongPhim.Text.Trim() == "")
            {
                error_Phim.SetError(txt_ThoiLuongPhim, "Thời lượng không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }
            if (txt_NamPhatHanh.Text.Trim() == "")
            {
                error_Phim.SetError(txt_NamPhatHanh, "Năm phát hành không được bỏ trống");
                return;
            }
            else
            {
                error_Phim.Clear();
            }

           

            string sql = "Update tbPhim SET ";
            sql += "TenPhim = N'" + txt_TenPhim.Text + "',";
            sql += "MaTheLoai = '" + sqlQuery + "',";
            sql += "TenDD = '" + txt_addDaodien.Text + "',";
            sql += "ThoiLuongPhim = N'" + txt_ThoiLuongPhim.Text + "',";
            sql += "NamSX = '" + txt_NamPhatHanh.Text + "',";
            sql += "QuocGia = N'" + cbb_QuocGia.Text + "' , ";
            sql += "MoTa = N'" + txt_MoTaPhim.Text + "' , ";
            sql += "Anh = '" + imageName + "' ";
            sql += "Where MaPhim = '" + txt_MaPhim.Text + "'";

             dtb.DataChange(sql);

            qlPhim.dgv_dataPhim.DataSource = dtb.DataRead("select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim");
            MessageSuccess mss = new MessageSuccess("sửa phim thành công");
            mss.ShowDialog();
            btn_close_addphim_Click(sender, e);


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
