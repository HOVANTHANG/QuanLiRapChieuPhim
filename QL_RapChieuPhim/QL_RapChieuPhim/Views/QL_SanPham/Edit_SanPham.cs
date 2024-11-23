using QL_RapChieuPhim;
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
    
    public partial class Edit_SanPham : Form
    {
        string imageName = "";
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        OpenFileDialog openFile;
        Views.sanPham2 qlSP;
        public Edit_SanPham(string maSp , Views.sanPham2 qlSP)
        {
            this.qlSP = qlSP;
            InitializeComponent();
            DataTable dt = dtb.DataRead("select * from tbSanPham where MaSP = '" + maSp + "'");
            txt_MaSp.Text = dt.Rows[0]["MaSP"].ToString();  
            txt_TenSp.Text = dt.Rows[0]["TenSP"].ToString();
            cbb_LoaiSp.Text = dt.Rows[0]["Loai"].ToString();
            dtb_NgayNhap.Value = Convert.ToDateTime(dt.Rows[0]["NgayNhap"]);
            txt_SoLuong.Text = dt.Rows[0]["SoLuong"].ToString();
            txt_DonGia.Text = dt.Rows[0]["DonGiaBan"].ToString();
            if(dt.Rows[0]["Anh"].ToString() != "")
            pictureBox_AnhSP.Image = Image.FromFile(Application.StartupPath + "\\img\\" + dt.Rows[0]["Anh"].ToString() );
            imageName = dt.Rows[0]["Anh"].ToString();

            addcombobox();
        }
        public void addcombobox()
        {
            cbb_LoaiSp.Items.Add("Đồ ăn");
            cbb_LoaiSp.Items.Add("Đồ uống");
			cbb_LoaiSp.Items.Add("combo");
		}

		private void btn_luuSP_Click(object sender, EventArgs e)
		{
			// Kiểm tra tên sản phẩm
			if (string.IsNullOrWhiteSpace(txt_TenSp.Text))
			{
				MessageBox.Show("Vui lòng nhập tên sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra loại sản phẩm
			if (string.IsNullOrWhiteSpace(cbb_LoaiSp.Text))
			{
				MessageBox.Show("Vui lòng chọn loại sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra số lượng
			if (string.IsNullOrWhiteSpace(txt_SoLuong.Text) || !int.TryParse(txt_SoLuong.Text, out _))
			{
				MessageBox.Show("Số lượng phải là số nguyên và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Kiểm tra đơn giá
			if (string.IsNullOrWhiteSpace(txt_DonGia.Text) || !decimal.TryParse(txt_DonGia.Text, out _))
			{
				MessageBox.Show("Đơn giá phải là số và không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Nếu không chọn ảnh mới, giữ nguyên ảnh cũ
			if (string.IsNullOrEmpty(imageName))
			{
				imageName = dtb.DataRead($"SELECT Anh FROM tbSanPham WHERE MaSP = '{txt_MaSp.Text}'").Rows[0]["Anh"].ToString();
			}

			// Cập nhật ảnh nếu có ảnh mới
			if (!string.IsNullOrEmpty(openFile?.FileName))
			{
				string destinationPath = Application.StartupPath + "\\img\\" + imageName;

				// Sao chép ảnh nếu nó chưa tồn tại trong thư mục `img`
				if (!System.IO.File.Exists(destinationPath))
				{
					System.IO.File.Copy(openFile.FileName, destinationPath);
				}
			}

			// Tạo câu lệnh SQL cập nhật
			string sql = "UPDATE tbSanPham SET ";
			sql += "TenSP = N'" + txt_TenSp.Text + "', ";
			sql += "Loai = N'" + cbb_LoaiSp.Text + "', ";
			sql += "NgayNhap = '" + dtb_NgayNhap.Value.Date.ToString("yyyy-MM-dd") + "', ";
			sql += "SoLuong = '" + txt_SoLuong.Text + "', ";
			sql += "DonGiaBan = '" + txt_DonGia.Text + "', ";
			sql += "Anh = '" + imageName + "' ";
			sql += "WHERE MaSP = '" + txt_MaSp.Text + "'";

			// Thực thi câu lệnh
			dtb.DataChange(sql);

			// Update panel vào form chính
			string tt1 = txt_MaSp.Text;
			string tt2 = txt_TenSp.Text;
			string tt3 = txt_SoLuong.Text;
			string tt4 = txt_DonGia.Text;

			qlSP.UpdatePanelByMaSP(tt1, tt2, tt3, tt4, imageName);

			// Thông báo thành công
			MessageSuccess mss = new MessageSuccess("Sửa sản phẩm thành công");
			mss.ShowDialog();

			// Đóng form chỉnh sửa
			btn_huySP_Click(sender, e);
		}



		private void btn_huySP_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

		private void btn_openAnhSP_Click(object sender, EventArgs e)
		{
			openFile = new OpenFileDialog();
			openFile.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|PNG images|*.png|All Files|*.*";
			openFile.FilterIndex = 1;

			if (openFile.ShowDialog() == DialogResult.OK)
			{
				// Hiển thị ảnh trên PictureBox
				pictureBox_AnhSP.Image = Image.FromFile(openFile.FileName);

				// Lấy tên ảnh
				imageName = System.IO.Path.GetFileName(openFile.FileName);

				// Đường dẫn đích trong thư mục `img` của ứng dụng
				string destinationPath = Application.StartupPath + "\\img\\" + imageName;

				// Sao chép ảnh nếu nó chưa tồn tại trong thư mục `img`
				if (!System.IO.File.Exists(destinationPath))
				{
					System.IO.File.Copy(openFile.FileName, destinationPath);
				}
			}
		}

		private void cbb_LoaiSp_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
	}
}
