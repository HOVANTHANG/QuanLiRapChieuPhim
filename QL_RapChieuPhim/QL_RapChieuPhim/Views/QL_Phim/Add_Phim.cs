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
    public partial class Add_Phim : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string imageName = "";
        OpenFileDialog openFile;
        string sqlQuery;
        Views.QL_Phim qlPhim;
        Database.Function_SinhMaTuDong sinhMP = new Database.Function_SinhMaTuDong();
        public Add_Phim(Views.QL_Phim qlPhim)
        {
            this.qlPhim = qlPhim;   
            InitializeComponent();
        }

        private void btn_close_addphim_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void Add_Phim_Load(object sender, EventArgs e)
        {
            txt_MaPhim.Text = sinhMP.SinhMaTuDong("tbPhim", 'P', "MaPhim");
            addcombobox();
        }
        public void addcombobox()
        {
            DataTable dt = dtb.DataRead("select * from tbTheLoaiPhim");
            foreach (DataRow row in dt.Rows) {
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

        private void btn_luuPhim_Click(object sender, EventArgs e)
        {
             sqlQuery = dtb.selectColumn("select MaTheLoai from tbTheLoaiPhim where LoaiPhim like N'" + cbb_TheLoaiPhim.Text +"'");

            if (txt_TenPhim.Text.Trim() == "") { 
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

             DataTable dtable = dtb.DataRead("select * from tbPhim where MaPhim = '" + txt_MaPhim.Text + "'");
            if (dtable.Rows.Count > 0)
            {
                error_Phim.SetError(txt_MaPhim, " Mã sản phẩm đã tồn tại");
                return;
            }


            string sql = "insert into tbPhim(MaPhim, TenPhim, MaTheLoai, TenDD, ThoiLuongPhim, NamSX, QuocGia, MoTa, Anh) values(";
             sql += "N'" + txt_MaPhim.Text + "',N'" + txt_TenPhim.Text + "','" + sqlQuery + "',N'" + txt_addDaodien.Text + "',N'" +
                 txt_ThoiLuongPhim.Text + "','" + txt_NamPhatHanh.Text + "',N'" + cbb_QuocGia.Text + "',N'" + txt_MoTaPhim.Text+ "','" + imageName + "')";
             dtb.DataChange(sql);
            qlPhim.dgv_dataPhim.DataSource = dtb.DataRead("select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim");

            MessageSuccess mss = new MessageSuccess("Thêm phim thành công");
            mss.ShowDialog();
            btn_close_addphim_Click(sender, e);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
