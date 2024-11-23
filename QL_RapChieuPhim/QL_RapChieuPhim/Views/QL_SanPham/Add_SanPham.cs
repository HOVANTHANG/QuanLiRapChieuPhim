using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
	public partial class Add_SanPham : Form
	{
		Views.sanPham2 qlSP = new Views.sanPham2();	
		Database.DatabaseAccess dtb = new Database.DatabaseAccess();
		string imageName = "";
		OpenFileDialog openFile;
		string sqlQuery;
		Database.Function_SinhMaTuDong auto = new Database.Function_SinhMaTuDong();
		public Add_SanPham(Views.sanPham2 qlSP)
		{
		
			InitializeComponent();
			this.qlSP = qlSP;
		}
		private void Add_SanPham_Load(object sender, EventArgs e)
		{
			txt_MaSp.Text = auto.SinhMaTuDong("tbSanPham", 'S', "MaSP");
			addcombobox();
		}
		public void addcombobox()
		{
			cbb_LoaiSp.Items.Add("Đồ ăn");
			cbb_LoaiSp.Items.Add("Đồ uống");
			cbb_LoaiSp.Items.Add("combo");
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

		private void btn_huySP_Click(object sender, EventArgs e)
		{
			this.Close();
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

			// Kiểm tra ảnh đã được chọn hay chưa
			if (string.IsNullOrWhiteSpace(imageName))
			{
				MessageBox.Show("Vui lòng chọn ảnh sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

			// Tạo câu lệnh SQL
			sqlQuery = "INSERT INTO tbSanPham(MaSP, TenSP, Loai, NgayNhap, SoLuong, DonGiaBan, Anh) VALUES(";
			sqlQuery += "'" + txt_MaSp.Text + "', N'" + txt_TenSp.Text + "', N'" + cbb_LoaiSp.Text + "', '" +
						dtb_NgayNhap.Value.Date.ToString("yyyy-MM-dd") + "', '" + txt_SoLuong.Text + "', '" +
						txt_DonGia.Text + "', '" + imageName + "')";

			// Thực thi câu lệnh
			dtb.DataChange(sqlQuery);

			// Cập nhật danh sách sản phẩm
			qlSP.add_sanPham(txt_MaSp.Text);

			// Thông báo thành công
			MessageSuccess mss = new MessageSuccess("Thêm sản phẩm thành công");
			mss.ShowDialog();

			// Đóng form thêm sản phẩm
			btn_huySP_Click(sender, e);
		}




	}
}
