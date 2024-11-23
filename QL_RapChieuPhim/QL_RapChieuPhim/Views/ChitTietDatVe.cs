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
    public partial class ChitTietDatVe : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        string maphim;
        Views.Phimdangchieu Phimdangchieu;
        string NgayChieu;
        string MaNv;
        
        public ChitTietDatVe(Phimdangchieu Phimdangchieu, string maPhim, string NgayChieu,string MaNV)
        {
            InitializeComponent();
            this.Phimdangchieu = Phimdangchieu;
            maphim = maPhim;
            this.NgayChieu = NgayChieu;
            this.MaNv = MaNV;
            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void ChitTietDatVe_Load(object sender, EventArgs e)
        {
            dt = dtb.DataRead("select tbPhim.MaPhim, MaXuatChieu, TenPhim, Year(NamSX) as NamSX, LoaiPhim, Anh, CaChieu, NgayChieu , TenPhong, TienVe from tbPhim \r\ninner join tbXuatChieu on tbPhim.MaPhim = tbXuatChieu.MaPhim \r\ninner join tbPhongChieu on tbXuatChieu.MaPhong = tbPhongChieu.MaPhong\r\ninner join tbTheLoaiPhim on tbPhim.MaTheLoai = tbTheLoaiPhim.MaTheLoai where tbPhim.MaPhim = '" + maphim +"'");
            foreach (DataRow row in dt.Rows)
            {
                CustomControls.RJControls.RJButton Button = new CustomControls.RJControls.RJButton();
                string caChieu = row["CaChieu"].ToString();
                string PhongChieu = row["TenPhong"].ToString();
                Button.Text = caChieu + " | " + PhongChieu;
                Button.BorderRadius = 8;
                Button.Tag = row["MaXuatChieu"].ToString();
                Button.Click += button_Click;

                flowLayoutPanel1.Controls.Add(Button);  

            }
            txt_timeChieu.Text = NgayChieu;
            
            lbl_tenphim.Text = dt.Rows[0]["TenPhim"].ToString();
            ptb_anhPhim.Image = Image.FromFile(Application.StartupPath + "\\img\\" + dt.Rows[0]["Anh"].ToString());

        }

        private void button_Click(object sender, EventArgs e) {

            if (sender is Control control && control is CustomControls.RJControls.RJButton Button)
            {
                // Lấy MaPhim từ panel (đã lưu trong Tag của panel)
                string btnSuatChieu = control.Tag as string;
                
                Views.DatPhim datPhim = new Views.DatPhim(maphim, btnSuatChieu ,NgayChieu,MaNv);
                this.Close();
                datPhim.ShowDialog();
                this.Show();
            }
            
             
        }

        private void txt_timeChieu_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
