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
	public partial class QL_SanPham : Form
	{
		Database.DatabaseAccess dtb = new Database.DatabaseAccess();
		string[] strSP = new string[10];
		string selectedMaSP;
		public QL_SanPham()
		{
			
			InitializeComponent();
		}

		private void QL_SanPham_Load(object sender, EventArgs e)
		{
			dgv_SanPham.DataSource = dtb.DataRead("select * from tbSanPham");
		}

		private void btn_ThemSP_Click(object sender, EventArgs e)
		{
			//Views.Add_SanPham add_sp = new Views.Add_SanPham(this);
			//add_sp.Show();	
		}

		private void dgv_SanPham_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			string[] strSP = new string[10];

			strSP[1] = dgv_SanPham.CurrentRow.Cells[0].Value.ToString();
			strSP[2] = dgv_SanPham.CurrentRow.Cells[1].Value.ToString();
			strSP[3] = dgv_SanPham.CurrentRow.Cells[2].Value.ToString();
			strSP[4] = dgv_SanPham.CurrentRow.Cells[3].Value.ToString();
			strSP[5] = dgv_SanPham.CurrentRow.Cells[4].Value.ToString();
			strSP[6] = dgv_SanPham.CurrentRow.Cells[5].Value.ToString();
			strSP[7] = dtb.selectColumn("select Anh from tbSanPham where MaSP like '" + strSP[1] + "'");

			lbl_tenSP.Text = "tên sp: " + strSP[2];
			lbl_giaSP.Text = strSP[6] + "đ";
			lbl_solluongSP.Text = "số lượng: " + strSP[5];
			if(strSP[7] != "")
			ptb_anhSP.Image = Image.FromFile(Application.StartupPath + "\\img\\" + strSP[7]);

			selectedMaSP = strSP[1];



		}

		private void btn_XoaSP_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã  sản phẩm  " + selectedMaSP + " không ? Nếu  có  ấn  nút  Yes, không  thì  ấn  nút  No", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				dtb.DataChange("delete from tbSanPham where MaSP = '" + selectedMaSP + "'");
				dgv_SanPham.DataSource = dtb.DataRead("select * from tbSanPham");
			}
		}

        private void btn_SuaSP_Click(object sender, EventArgs e)
        {
			//Views.Edit_SanPham editSP = new Views.Edit_SanPham(selectedMaSP,this);
			//editSP.ShowDialog();
        }
    }
}
