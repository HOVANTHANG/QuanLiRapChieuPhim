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
        }

        private void btn_luuSP_Click(object sender, EventArgs e)
        {

            string sql = "Update tbSanPham SET ";
            sql += "TenSP = N'" + txt_TenSp.Text + "',";
            sql += "Loai = N'" + cbb_LoaiSp.Text + "',";
            sql += "NgayNhap = '" + dtb_NgayNhap.Value.Date + "',";
            sql += "SoLuong = '" + txt_SoLuong.Text + "',";
            sql += "DonGiaBan = '" + txt_DonGia.Text + "',";
            sql += "Anh = '" + imageName + "' ";
            sql += "Where MaSP = '" + txt_MaSp.Text + "'";
            dtb.DataChange(sql);

            string tt1 = txt_MaSp.Text;
            string tt2 = txt_TenSp.Text;
            string tt3 = txt_SoLuong.Text;
            string tt4 = txt_DonGia.Text;


            //qlSP.dgv_SanPham.DataSource = dtb.DataRead("select * from tbSanPham");
            qlSP.UpdatePanelByMaSP(tt1, tt2, tt3, tt4, imageName);
            MessageSuccess mss = new MessageSuccess("Sửa sản phẩm thành công");
            mss.ShowDialog();
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
                pictureBox_AnhSP.Image = Image.FromFile(openFile.FileName);
                imageName = openFile.SafeFileName;
            }
        }


    }
}
