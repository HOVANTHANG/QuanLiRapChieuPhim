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
   

        //sửa 
        public void addtextbox(string[] str)
        {
            txt_MaPhim.Text = str[1];
            txt_TenPhim.Text = str[2];
            cbb_TheLoaiPhim.Text = dtb.selectColumn("SELECT LoaiPhim FROM tbTheLoaiPhim WHERE MaTheLoai LIKE '" + str[3] + "'");
            txt_addDaodien.Text = str[4];
            cbb_QuocGia.Text = str[5];
            txt_NamPhatHanh.Text = str[6];
            txt_ThoiLuongPhim.Text = str[7];
            txt_MoTaPhim.Text = str[8];

            if (!string.IsNullOrEmpty(str[9]))
            {
                string imagePath = Application.StartupPath + "\\img\\" + str[9];
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox_AnhPhim.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("Ảnh không tồn tại: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBox_AnhPhim.Image = Properties.Resources.close_icon; // Hiển thị ảnh mặc định
                }
            }
            else
            {
                pictureBox_AnhPhim.Image = Properties.Resources.close_icon; // Hiển thị ảnh mặc định nếu không có ảnh
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


        //sửa 
        private void SaveImage(string sourcePath, string newImageName)
        {
            string destinationPath = Application.StartupPath + "\\img\\" + newImageName;

            // Kiểm tra nếu file chưa tồn tại, tiến hành sao chép
            if (!System.IO.File.Exists(destinationPath))
            {
                try
                {
                    System.IO.File.Copy(sourcePath, destinationPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sao chép file ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //sửa 
        private void btn_openAnhPhim_Click(object sender, EventArgs e)
        {
            openFile = new OpenFileDialog();
            openFile.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|PNG images|*.png|All Files|*.*";
            openFile.FilterIndex = 1;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureBox_AnhPhim.Image = Image.FromFile(openFile.FileName); // Hiển thị ảnh trong PictureBox
                imageName = openFile.SafeFileName; // Lấy tên file ảnh
            }
        }

        

        private void btn_close_addphim_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		//sửa
		private void btn_luuPhim_Click(object sender, EventArgs e)
		{
			sqlQuery = dtb.selectColumn("SELECT MaTheLoai FROM tbTheLoaiPhim WHERE LoaiPhim LIKE N'" + cbb_TheLoaiPhim.Text + "'");

			// Kiểm tra thông tin đầu vào
			if (string.IsNullOrWhiteSpace(txt_TenPhim.Text))
			{
				error_Phim.SetError(txt_TenPhim, "Tên Phim không được bỏ trống");
				return;
			}
			else
			{
				error_Phim.Clear();
			}

			if (string.IsNullOrWhiteSpace(txt_addDaodien.Text))
			{
				error_Phim.SetError(txt_addDaodien, "Đạo diễn không được bỏ trống");
				return;
			}
			else
			{
				error_Phim.Clear();
			}

			if (string.IsNullOrWhiteSpace(txt_ThoiLuongPhim.Text))
			{
				error_Phim.SetError(txt_ThoiLuongPhim, "Thời lượng phim không được bỏ trống");
				return;
			}
			else if (!int.TryParse(txt_ThoiLuongPhim.Text, out _))
			{
				error_Phim.SetError(txt_ThoiLuongPhim, "Thời lượng chỉ được nhập số");
				return;
			}
			else
			{
				error_Phim.Clear();
			}

			if (string.IsNullOrWhiteSpace(txt_NamPhatHanh.Text))
			{
				error_Phim.SetError(txt_NamPhatHanh, "Năm phát hành không được bỏ trống");
				return;
			}
			else if (!int.TryParse(txt_NamPhatHanh.Text, out int namPhatHanh) || txt_NamPhatHanh.Text.Length != 4)
			{
				error_Phim.SetError(txt_NamPhatHanh, "Năm phát hành phải là số và gồm đúng 4 chữ số");
				return;
			}
			else
			{
				error_Phim.Clear();
			}

			if (string.IsNullOrEmpty(cbb_QuocGia.Text))
			{
				error_Phim.SetError(cbb_QuocGia, "Quốc gia không được bỏ trống");
				return;
			}
			else
			{
				error_Phim.Clear();
			}

			// Nếu không chọn ảnh mới, giữ nguyên ảnh cũ
			if (string.IsNullOrEmpty(imageName))
			{
				imageName = strData[9]; // Giá trị ảnh cũ từ dữ liệu truyền vào
			}

			// Nếu chọn ảnh mới, sao chép ảnh vào thư mục img
			if (!string.IsNullOrEmpty(openFile?.FileName))
			{
				SaveImage(openFile.FileName, imageName);
			}

			// Câu lệnh SQL cập nhật phim
			string sql = "UPDATE tbPhim SET ";
			sql += "TenPhim = N'" + txt_TenPhim.Text + "', ";
			sql += "MaTheLoai = '" + sqlQuery + "', ";
			sql += "TenDD = N'" + txt_addDaodien.Text + "', ";
			sql += "ThoiLuongPhim = N'" + txt_ThoiLuongPhim.Text + "', ";
			sql += "NamSX = '" + txt_NamPhatHanh.Text + "', ";
			sql += "QuocGia = N'" + cbb_QuocGia.Text + "', ";
			sql += "MoTa = N'" + txt_MoTaPhim.Text + "', ";
			sql += "Anh = '" + imageName + "' "; // Lưu tên ảnh (ảnh mới hoặc cũ)
			sql += "WHERE MaPhim = '" + txt_MaPhim.Text + "'";

			// Thực hiện câu lệnh SQL
			dtb.DataChange(sql);

			// Cập nhật lại DataGridView
			qlPhim.dgv_dataPhim.DataSource = dtb.DataRead("select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim");

			MessageSuccess mss = new MessageSuccess("Sửa phim thành công");
			mss.ShowDialog();
			btn_close_addphim_Click(sender, e);
		}


	}
}
