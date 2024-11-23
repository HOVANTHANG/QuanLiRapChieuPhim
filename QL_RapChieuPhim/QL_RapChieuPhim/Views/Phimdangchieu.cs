using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.Adapters;

namespace QL_RapChieuPhim.Views
{
	public partial class Phimdangchieu : Form
	{
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        string dtNgayChieu;
        string MaNV;

        public Phimdangchieu(string MaNV)
        {
            
            InitializeComponent();
            this.MaNV = MaNV;
        }
        private void Phimdangchieu_Load(object sender, EventArgs e)
        {


            HashSet<string> uniqueMaPhims = new HashSet<string>();
        dtNgayChieu = dtp_ngayChieu.Value.ToString("yyyy-MM-dd");
            dt = dtb.DataRead("select tbPhim.MaPhim, TenPhim, Year(NamSX) as NamSX, LoaiPhim, Anh, CaChieu, NgayChieu , TenPhong, TienVe from tbPhim \r\ninner join tbXuatChieu on tbPhim.MaPhim = tbXuatChieu.MaPhim \r\ninner join tbPhongChieu on tbXuatChieu.MaPhong = tbPhongChieu.MaPhong\r\ninner join tbTheLoaiPhim on tbPhim.MaTheLoai = tbTheLoaiPhim.MaTheLoai");
            foreach (DataRow row in dt.Rows)
            {
                
                // Tạo một panel mới
                Bunifu.UI.WinForms.BunifuShadowPanel panel = new Bunifu.UI.WinForms.BunifuShadowPanel();
                panel.Width = 319;
                panel.Height = 379;
                panel.BorderRadius = 8;
                panel.Cursor = Cursors.Hand;
                panel.Margin = new Padding(20);
                panel.Tag = row["MaPhim"].ToString();
                panel.Click += panel_Click; 
                string maPhim = row["MaPhim"].ToString();
                string TenPhim = row["TenPhim"].ToString();
                string NamSX = row["NamSX"].ToString();
                string TheLoai = row["LoaiPhim"].ToString();
                string anh = row["Anh"].ToString();

                if (uniqueMaPhims.Contains(maPhim))
                {
                    // Nếu đã tồn tại, bỏ qua và không tạo panel mới
                    continue;
                }

                uniqueMaPhims.Add(maPhim);

                Bunifu.UI.WinForms.BunifuLabel lblTenPhim = new Bunifu.UI.WinForms.BunifuLabel();
                lblTenPhim.Text = TenPhim;
                lblTenPhim.Location = new Point(20, 281);
                lblTenPhim.Font = new Font("Arial", 12, FontStyle.Bold);

                Bunifu.UI.WinForms.BunifuLabel lblNamSX = new Bunifu.UI.WinForms.BunifuLabel();
                lblNamSX.Text = NamSX;
                lblNamSX.Location = new Point(22, 333);
                lblNamSX.Font = new Font("Arial", 9, FontStyle.Regular);
                lblNamSX.ForeColor = Color.Gray;

                Bunifu.UI.WinForms.BunifuLabel lblTheLoai = new Bunifu.UI.WinForms.BunifuLabel();
                lblTheLoai.Text = TheLoai;
                lblTheLoai.Location = new Point(22, 310);
                lblTheLoai.Font = new Font("Arial", 10, FontStyle.Bold);


                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(243, 243);
                pictureBox.Location = new Point(38, 18);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
          
                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }

                panel.Controls.Add(lblTenPhim);
                panel.Controls.Add(lblNamSX);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblTheLoai);

                flowLayoutPanel1.Controls.Add(panel);


            }

        }
        private void bunifuShadowPanel1_Click(object sender, EventArgs e)
        {

        }

        private void dtp_ngayChieu_ValueChanged(object sender, EventArgs e)
        {
            HashSet<string> uniqueMaPhims = new HashSet<string>();
            // Xóa các panel hiện tại trong flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Lấy ngày được chọn từ DateTimePicker
            dtNgayChieu = dtp_ngayChieu.Value.ToString("yyyy-MM-dd");

            // Lọc DataTable dựa trên ngày được chọn
            DataRow[] filteredRows = dt.Select($"NgayChieu = '{dtNgayChieu}'");

            foreach (DataRow row in filteredRows)
            {


                // Tạo một panel mới
                Bunifu.UI.WinForms.BunifuShadowPanel panel = new Bunifu.UI.WinForms.BunifuShadowPanel();
                panel.Width = 319;
                panel.Height = 379;
                panel.BorderRadius = 8;
                panel.Cursor = Cursors.Hand;
                panel.Margin = new Padding(20);
                panel.Tag = row["MaPhim"].ToString();
                panel.Click += panel_Click;

                string maPhim = row["MaPhim"].ToString();
                string TenPhim = row["TenPhim"].ToString();
                string NamSX = row["NamSX"].ToString();
                string TheLoai = row["LoaiPhim"].ToString();
                string anh = row["Anh"].ToString();
                
                if (uniqueMaPhims.Contains(maPhim))
                {
                    // Nếu đã tồn tại, bỏ qua và không tạo panel mới
                    continue;
                }

                uniqueMaPhims.Add(maPhim);

                
                Bunifu.UI.WinForms.BunifuLabel lblTenPhim = new Bunifu.UI.WinForms.BunifuLabel();
                lblTenPhim.Text = TenPhim;
                lblTenPhim.Location = new Point(20, 281);
                lblTenPhim.Font = new Font("Arial", 10, FontStyle.Bold);

                Bunifu.UI.WinForms.BunifuLabel lblNamSX = new Bunifu.UI.WinForms.BunifuLabel();
                lblNamSX.Text = NamSX;
                lblNamSX.Location = new Point(22, 333);
                lblNamSX.Font = new Font("Arial", 9, FontStyle.Regular);
                lblNamSX.ForeColor = Color.Gray;

                Bunifu.UI.WinForms.BunifuLabel lblTheLoai = new Bunifu.UI.WinForms.BunifuLabel();
                lblTheLoai.Text = TheLoai;
                lblTheLoai.Location = new Point(22, 310);
                lblTheLoai.Font = new Font("Arial", 10, FontStyle.Bold);


                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(243, 243);
                pictureBox.Location = new Point(38, 18);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }

                panel.Controls.Add(lblTenPhim);
                panel.Controls.Add(lblNamSX);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblTheLoai);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }


        private void cboTheLoai_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

       /* private void cboTheLoai_Click(object sender, EventArgs e)
        {
            DataTable datab = dtb.DataRead("select * from tbTheLoaiPhim");
            cboTheLoai.DataSource = datab;
            cboTheLoai.DisplayMember = "LoaiPhim";
            cboTheLoai.ValueMember = "MaTheLoai";
            // Lấy thể loại được chọn từ ComboBox
            string tenTL = cboTheLoai.Text;

            // Xóa các panel hiện tại trong flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Lấy ngày được chọn từ DateTimePicker
            dtNgayChieu = dtp_ngayChieu.Value.ToString("yyyy-MM-dd");

            // Lọc DataTable dựa trên ngày được chọn
            DataRow[] filteredRows = dt.Select($"LoaiPhim = '{tenTL}'");

            foreach (DataRow row in filteredRows)
            {


                // Tạo một panel mới
                Bunifu.UI.WinForms.BunifuShadowPanel panel = new Bunifu.UI.WinForms.BunifuShadowPanel();
                panel.Width = 319;
                panel.Height = 379;
                panel.BorderRadius = 8;
                panel.Cursor = Cursors.Hand;
                panel.Margin = new Padding(20);
                panel.Tag = row["tbPhim.MaPhim"].ToString();

                string TenPhim = row["TenPhim"].ToString();
                string NamSX = row["NamSX"].ToString();
                string TheLoai = row["LoaiPhim"].ToString();
                string anh = row["Anh"].ToString();

                Bunifu.UI.WinForms.BunifuLabel lblTenPhim = new Bunifu.UI.WinForms.BunifuLabel();
                lblTenPhim.Text = TenPhim;
                lblTenPhim.Location = new Point(20, 281);
                lblTenPhim.Font = new Font("Arial", 10, FontStyle.Bold);

                Bunifu.UI.WinForms.BunifuLabel lblNamSX = new Bunifu.UI.WinForms.BunifuLabel();
                lblNamSX.Text = NamSX;
                lblNamSX.Location = new Point(22, 333);
                lblNamSX.Font = new Font("Arial", 9, FontStyle.Regular);
                lblNamSX.ForeColor = Color.Gray;

                Bunifu.UI.WinForms.BunifuLabel lblTheLoai = new Bunifu.UI.WinForms.BunifuLabel();
                lblTheLoai.Text = TheLoai;
                lblTheLoai.Location = new Point(22, 310);
                lblTheLoai.Font = new Font("Arial", 10, FontStyle.Bold);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(243, 243);
                pictureBox.Location = new Point(38, 18);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }

                panel.Controls.Add(lblTenPhim);
                panel.Controls.Add(lblNamSX);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblTheLoai);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }

        private void cboTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboTheLoai_TextChanged(object sender, EventArgs e)
        {
            
        }
       */
        private void panel_Click(object sender, EventArgs e)
        {
            string NgayChieu = dtp_ngayChieu.Text;
                if (sender is Control control && control is Bunifu.UI.WinForms.BunifuShadowPanel panel)
                {
                    // Lấy MaPhim từ panel (đã lưu trong Tag của panel)
                    string panelMaPhim = control.Tag as string;

                    Views.ChitTietDatVe ctdv = new Views.ChitTietDatVe(this,panelMaPhim ,NgayChieu,MaNV);
                    ctdv.ShowDialog();
                }
            
        }

        private void txt_timkiem_phim_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_timkiem_phim.Text.Trim().ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuShadowPanel panel)
                {
                    // Lấy dữ liệu từ các control bên trong panel
                    string tenPhim = "";
                    string TheLoai = "";
                    string Namsx = "";

                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is Bunifu.UI.WinForms.BunifuLabel lbl)
                        {
                            if (lbl.Location == new Point(20, 281))
                            {
                                tenPhim = lbl.Text.ToLower();
                            }
                            else if (lbl.Location == new Point(22, 333))
                            {
                                TheLoai = lbl.Text.ToLower();
                            }
                            else if (lbl.Location == new Point(22, 310))
                            {
                                Namsx = lbl.Text.ToLower();
                            }
                        }
                    }

                    // Kiểm tra nếu có bất kỳ phần nào chứa keyword
                    if (tenPhim.Contains(keyword) || TheLoai.Contains(keyword) || Namsx.Contains(keyword))
                    {
                        panel.Visible = true;
                    }
                    else
                    {
                        panel.Visible = false;
                    }
                }
            }
        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnXoaLoc_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các panel hiện tại trong flowLayoutPanel1
            flowLayoutPanel1.Controls.Clear();

            // Thêm lại tất cả các phim vào flowLayoutPanel1
            HashSet<string> uniqueMaPhims = new HashSet<string>();

            foreach (DataRow row in dt.Rows)
            {
                // Kiểm tra nếu phim đã được thêm
                string maPhim = row["MaPhim"].ToString();
                if (uniqueMaPhims.Contains(maPhim))
                {
                    continue;
                }
                uniqueMaPhims.Add(maPhim);

                // Tạo panel
                Bunifu.UI.WinForms.BunifuShadowPanel panel = new Bunifu.UI.WinForms.BunifuShadowPanel();
                panel.Width = 319;
                panel.Height = 379;
                panel.BorderRadius = 8;
                panel.Cursor = Cursors.Hand;
                panel.Margin = new Padding(20);
                panel.Tag = maPhim;
                panel.Click += panel_Click;

                string TenPhim = row["TenPhim"].ToString();
                string NamSX = row["NamSX"].ToString();
                string TheLoai = row["LoaiPhim"].ToString();
                string anh = row["Anh"].ToString();

                Bunifu.UI.WinForms.BunifuLabel lblTenPhim = new Bunifu.UI.WinForms.BunifuLabel();
                lblTenPhim.Text = TenPhim;
                lblTenPhim.Location = new Point(20, 281);
                lblTenPhim.Font = new Font("Arial", 12, FontStyle.Bold);

                Bunifu.UI.WinForms.BunifuLabel lblNamSX = new Bunifu.UI.WinForms.BunifuLabel();
                lblNamSX.Text = NamSX;
                lblNamSX.Location = new Point(22, 333);
                lblNamSX.Font = new Font("Arial", 9, FontStyle.Regular);
                lblNamSX.ForeColor = Color.Gray;

                Bunifu.UI.WinForms.BunifuLabel lblTheLoai = new Bunifu.UI.WinForms.BunifuLabel();
                lblTheLoai.Text = TheLoai;
                lblTheLoai.Location = new Point(22, 310);
                lblTheLoai.Font = new Font("Arial", 10, FontStyle.Bold);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(243, 243);
                pictureBox.Location = new Point(38, 18);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }

                panel.Controls.Add(lblTenPhim);
                panel.Controls.Add(lblNamSX);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(lblTheLoai);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }
    }
}
