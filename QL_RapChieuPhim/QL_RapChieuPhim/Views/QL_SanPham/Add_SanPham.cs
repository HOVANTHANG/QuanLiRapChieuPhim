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
			cbb_LoaiSp.Items.Add("Combo");
		}
		private void btn_openAnhSP_Click(object sender, EventArgs e)
		{
			
			openFile = new OpenFileDialog();
			openFile.Filter = "JPEG images|*.jpg|Bitmap images|*.bmp|PNG images|*.png|All Files|*.*";
			openFile.FilterIndex = 1;
			if (openFile.ShowDialog() == DialogResult.OK)
			{
				pictureBox_AnhSP.Image = Image.FromFile(openFile.FileName);
				imageName = openFile.SafeFileName;
			}
		}
		private void btn_huySP_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_luuSP_Click(object sender, EventArgs e)
		{
			sqlQuery = "insert into tbSanPham(MaSP, TenSP, Loai, NgayNhap, SoLuong, DonGiaBan, Anh) values(";
			sqlQuery += "'" + txt_MaSp.Text + "',N'" + txt_TenSp.Text + "',N'" + cbb_LoaiSp.Text + "','" + dtb_NgayNhap.Value.Date + "','" +
				txt_SoLuong.Text + "','" + txt_DonGia.Text + "','" + imageName + "')";

			dtb.DataChange(sqlQuery);
			//qlSP.dgv_SanPham.DataSource = dtb.DataRead("select * from tbSanPham");
			qlSP.add_sanPham(txt_MaSp.Text);
			MessageSuccess mss = new MessageSuccess("Thêm sản phẩm thành công");
			mss.ShowDialog();
			btn_huySP_Click(sender, e);
		}

		
	}
}
