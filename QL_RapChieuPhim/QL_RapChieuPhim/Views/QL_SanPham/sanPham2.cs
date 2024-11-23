using Bunifu.UI.WinForm.BunifuShadowPanel;
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
    public partial class sanPham2 : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        public sanPham2()
        {
            InitializeComponent();

        }
        private void sanPham2_Load(object sender, EventArgs e)
        {
            cbb_LoaiSP.Items.Add("Tất cả");
            cbb_LoaiSP.Items.Add("Đồ ăn");
            cbb_LoaiSP.Items.Add("Đồ uống");
            cbb_LoaiSP.Items.Add("Combo");
            
            dt = dtb.DataRead("select * from tbSanPham");

            // Tạo panel cho mỗi dòng trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Tạo một panel mới
                Bunifu.UI.WinForms.BunifuPanel panel = new Bunifu.UI.WinForms.BunifuPanel();

                // Đặt thuộc tính của panel
                panel.Width = 180;
                panel.Height = 195;
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.BorderRadius = 10;
                panel.Margin = new Padding(20);
                panel.Tag = row["MaSP"].ToString();


                // Lấy dữ liệu từ DataTable và thêm vào panel
                string tenSanPham = row["TenSP"].ToString();
                string soluong = row["SoLuong"].ToString();
                string donGia = row["DonGiaBan"].ToString();   
                string anh = row["Anh"].ToString();
                // Tạo các control để hiển thị dữ liệu

                Label lblTenSanPham = new Label();
                lblTenSanPham.Text = tenSanPham;
                lblTenSanPham.Location = new Point(9, 134);


                Label lblSoLuong = new Label();
                lblSoLuong.Text = "SL: " + soluong;
                lblSoLuong.Location = new Point(9, 160);
                lblSoLuong.ForeColor = Color.Gray;

                Label lblDonGia = new Label();
                lblDonGia.Text = donGia + " đ";
                lblDonGia.Location = new Point(104, 160);
                lblDonGia.ForeColor = Color.Gray;

                //tạo pictubox

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(109, 117);
                pictureBox.Location = new Point(12, 14);
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                // Load hình ảnh từ tệp ảnh
                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                //tạo 2 nút edit, delete
                Button button1 = new Button();
                button1.Size = new System.Drawing.Size(30, 30);
                button1.Location = new Point(123, 19);
                button1.Image = Properties.Resources.edit_icon_24px;
                button1.Click += Button3_Click;

                Button button2 = new Button();
                button2.Size = new System.Drawing.Size(30, 30);
                button2.Location = new Point(123, 55);
                button2.Image = Properties.Resources.bin_icon_24px;
                button2.Click += Button4_Click;

                // Thêm các control vào panel

                panel.Controls.Add(lblTenSanPham);
                panel.Controls.Add(lblSoLuong);
                panel.Controls.Add(lblDonGia);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(button1);    
                panel.Controls.Add(button2);

                // Thêm panel vào control cha (ví dụ: một FlowLayoutPanel có tên là flowLayoutPanel1)
                flowLayoutPanel1.Controls.Add(panel);

            }
            

        }
        public void add_sanPham(string maSP)
        {
            DataTable dt2 = dtb.DataRead("select * from tbSanPham where MaSP = '" +maSP + "'");    
            // Tạo một panel mới
            Bunifu.UI.WinForms.BunifuPanel panel = new Bunifu.UI.WinForms.BunifuPanel();

            // Đặt thuộc tính của panel
            string masanpham = dt2.Rows[0]["MaSP"].ToString();
            panel.Width = 180;
            panel.Height = 195;
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.BorderRadius = 100;
            panel.Margin = new Padding(20);
            panel.Tag = masanpham;


            // Lấy dữ liệu từ DataTable và thêm vào panel
            string tenSanPham = dt2.Rows[0]["TenSP"].ToString();
            string soluong = dt2.Rows[0]["SoLuong"].ToString();
            string donGia = dt2.Rows[0]["DonGiaBan"].ToString();
            string anh = dt2.Rows[0]["Anh"].ToString();
            // Tạo các control để hiển thị dữ liệu

            Label lblTenSanPham = new Label();
            lblTenSanPham.Text = tenSanPham;
            lblTenSanPham.Location = new Point(9, 134);

            Label lblSoLuong = new Label();
            lblSoLuong.Text = "SL: " + soluong;
            lblSoLuong.Location = new Point(9, 160);
            lblSoLuong.ForeColor = Color.Gray;

            Label lblDonGia = new Label();
            lblDonGia.Text = donGia + " đ";
            lblDonGia.Location = new Point(104, 160);
            lblDonGia.ForeColor = Color.Gray;

            //tạo pictubox

            PictureBox pictureBox = new PictureBox();
            pictureBox.Size = new System.Drawing.Size(109, 117);
            pictureBox.Location = new Point(12, 14);
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


            // Load hình ảnh từ tệp ảnh
            string imagePath = Application.StartupPath + "\\img\\" + anh;
            if (System.IO.File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            //tạo 2 nút edit, delete
            Button button1 = new Button();
            button1.Size = new System.Drawing.Size(30, 30);
            button1.Location = new Point(123, 19);
            button1.Image = Properties.Resources.edit_icon_24px;
            button1.Click += Button3_Click;

            Button button2 = new Button();
            button2.Size = new System.Drawing.Size(30, 30);
            button2.Location = new Point(123, 55);
            button2.Image = Properties.Resources.bin_icon_24px;
            button2.Click += Button4_Click;

            // Thêm các control vào panel

            panel.Controls.Add(lblTenSanPham);
            panel.Controls.Add(lblSoLuong);
            panel.Controls.Add(lblDonGia);
            panel.Controls.Add(pictureBox);
            panel.Controls.Add(button1);
            panel.Controls.Add(button2);

            // Thêm panel vào control cha (ví dụ: một FlowLayoutPanel có tên là flowLayoutPanel1)
            flowLayoutPanel1.Controls.Add(panel);
        }

        public void RemovePanelByMaSP(string maSP)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuPanel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;

                    // So sánh MaSP của panel với MaSP mà bạn muốn xóa
                    if (panelMaSP == maSP)
                    {
                        // Xóa panel khỏi FlowLayoutPanel
                        flowLayoutPanel1.Controls.Remove(panel);
                        break; // Dừng vòng lặp sau khi xóa panel thành công
                    }
                }
            }
        }
        public void UpdatePanelByMaSP(string maSP, string tenSanPham, string soLuong, string donGia, string anh)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuPanel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;

                    // So sánh MaSP của panel với MaSP mà bạn muốn cập nhật
                    if (panelMaSP == maSP)
                    {
                        // Tìm và cập nhật các thành phần trên panel
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is Label lbl)
                            {
                                if (lbl.Location == new Point(9, 134))
                                {
                                    lbl.Text = tenSanPham;
                                }
                                else if (lbl.Location == new Point(9, 160))
                                {
                                    lbl.Text = "SL: " + soLuong;
                                }
                                else if (lbl.Location == new Point(104, 160))
                                {
                                    lbl.Text = donGia + " đ";
                                }
                            }
                            else if (panelControl is PictureBox pictureBox)
                            {
                                // Cập nhật hình ảnh
                                string imagePath = Application.StartupPath + "\\img\\" + anh;
                                if (System.IO.File.Exists(imagePath))
                                {
                                    pictureBox.Image = Image.FromFile(imagePath);
                                }
                            }
                        }
                        break; // Dừng vòng lặp sau khi cập nhật panel
                    }
                }
            }
        }


        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            Views.Add_SanPham add_sp = new Views.Add_SanPham(this);
            add_sp.Show();
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            // Lấy nút Button1 mà bạn đã bấm
            Button button1 = sender as Button;

            // Tìm panel chứa nút Button1
            Bunifu.UI.WinForms.BunifuPanel panel = button1.Parent as Bunifu.UI.WinForms.BunifuPanel;

            // Kiểm tra xem panel có tồn tại không
            if (panel != null)
            {
                // Lấy vị trí của panel trong FlowLayoutPanel
                int panelIndex = flowLayoutPanel1.Controls.IndexOf(panel);

                // Kiểm tra xem vị trí nằm trong giới hạn của DataTable
                if (panelIndex >= 0 && panelIndex < dt.Rows.Count)
                {
                    // Lấy MaSP tương ứng từ DataTable dt
                    string maSP = dt.Rows[panelIndex]["MaSP"].ToString();

                    Views.Edit_SanPham editSP = new Views.Edit_SanPham(maSP, this);
                    editSP.ShowDialog();
                    
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            // Lấy nút Button1 mà bạn đã bấm
            Button button1 = sender as Button;

            // Tìm panel chứa nút Button1
            Bunifu.UI.WinForms.BunifuPanel panel = button1.Parent as Bunifu.UI.WinForms.BunifuPanel;

            // Kiểm tra xem panel có tồn tại không
            if (panel != null)
            {
                // Lấy vị trí của panel trong FlowLayoutPanel
                int panelIndex = flowLayoutPanel1.Controls.IndexOf(panel);

                // Kiểm tra xem vị trí nằm trong giới hạn của DataTable
                if (panelIndex >= 0 && panelIndex < dt.Rows.Count)
                {
                    // Lấy MaSP tương ứng từ DataTable dt
                    string maSP = dt.Rows[panelIndex]["MaSP"].ToString();

                    if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã  sản phẩm này không ? Nếu  có  ấn  nút  Yes, không  thì  ấn  nút  No", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        RemovePanelByMaSP(maSP);
                        dtb.DataChange("delete from tbSanPham Where MaSP ='" + maSP + "'");
                    }
                   
                    
                }
            }
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.Parent is Bunifu.UI.WinForms.BunifuPanel panel)
            {
                // Lấy MaSP từ Tag của panel
                string maSP = panel.Tag as string;

                Views.Edit_SanPham editSP = new Views.Edit_SanPham(maSP, this);
                editSP.ShowDialog();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (sender is Control control && control.Parent is Bunifu.UI.WinForms.BunifuPanel panel)
            {
                // Lấy MaSP từ Tag của panel
                string maSP = panel.Tag as string;

                if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã  sản phẩm này không ? Nếu  có  ấn  nút  Yes, không  thì  ấn  nút  No", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    RemovePanelByMaSP(maSP);
                    dtb.DataChange("delete from tbChiTietHoaDonSP Where MaSP ='" + maSP + "'");
                    dtb.DataChange("delete from tbSanPham Where MaSP ='" + maSP + "'");
                }
            }
        }

        private void txt_timkiemSP_TextChange(object sender, EventArgs e)
        {
            string keyword = txt_timkiemSP.Text.Trim().ToLower();

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Bunifu.UI.WinForms.BunifuPanel panel)
                {
                    // Lấy dữ liệu từ các control bên trong panel
                    string tenSanPham = "";
                    string soLuong = "";
                    string donGia = "";

                    foreach (Control panelControl in panel.Controls)
                    {
                        if (panelControl is Label lbl)
                        {
                            if (lbl.Location == new Point(9, 134))
                            {
                                tenSanPham = lbl.Text.ToLower();
                            }
                            else if (lbl.Location == new Point(9, 160))
                            {
                                soLuong = lbl.Text.ToLower();
                            }
                            else if (lbl.Location == new Point(104, 134))
                            {
                                donGia = lbl.Text.ToLower();
                            }
                        }
                    }

                    // Kiểm tra nếu có bất kỳ phần nào chứa keyword
                    if (tenSanPham.Contains(keyword) || soLuong.Contains(keyword) || donGia.Contains(keyword))
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

        private void cbb_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiSP.Text == "Tất cả")
            {
                // Hiển thị lại tất cả các panel
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        control.Visible = true;
                    }
                }
            }
            else
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Panel)
                    {
                        string maSP = control.Tag as string;
                        string sqlMonAn = $"Select Loai from tbSanPham where MaSP = '{maSP}'";
                        string MonAn = dtb.selectColumn(sqlMonAn);
                        if (cbb_LoaiSP.Text == MonAn)
                        {
                            control.Visible = true;
                        }
                        else
                        {
                            control.Visible = false;
                        }
                    }
                }
            }
        }

    }
}
