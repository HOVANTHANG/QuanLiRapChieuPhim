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
    public partial class Chon_SanPham : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        int tongtien;
        string NgayChieu;
        string GioChieu;
        string maphim;
        string masuatchieu;
        private TextBox txt;
        private HashSet<string> uniqueSP = new HashSet<string>();
        string MaNv;
        string[] values;

        string soghe;
        string tongtienVe;
        public Chon_SanPham(string ngayChieu, string gioChieu, string maphim, string masuatchieu, string soghe, string tongtienVe, string MaNv, string[] values)
        {
            InitializeComponent();
            NgayChieu = ngayChieu;
            GioChieu = gioChieu;
            this.maphim = maphim;
            this.masuatchieu = masuatchieu;
            this.soghe = soghe;
            this.tongtienVe = tongtienVe;
            this.MaNv = MaNv;
            this.values = values;
        }
        private void Chon_SanPham_Load(object sender, EventArgs e)
        {
            dt = dtb.DataRead("select * from tbSanPham");

            // Tạo panel cho mỗi dòng trong DataTable
            foreach (DataRow row in dt.Rows)
            {
                // Tạo một panel mới
                Panel panel = new Panel();

                // Đặt thuộc tính của panel
                panel.Width = 180;
                panel.Height = 195;
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                
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
                lblTenSanPham.Location = new Point(9, 154);


                Label lblSoLuong = new Label();
                lblSoLuong.Text = "SL: " + soluong;
                lblSoLuong.Location = new Point(9, 175);
                lblSoLuong.ForeColor = Color.Gray;

                Label lblDonGia = new Label();
                lblDonGia.Text = donGia + " đ";
                lblDonGia.Location = new Point(110, 175);
                lblDonGia.ForeColor = Color.Gray;

                //tạo pictubox

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(150, 125);
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
                Button button = new Button();
                button.Size = new System.Drawing.Size(28, 28);
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;  
                button.Location = new Point(130, 143);
                button.Image = Properties.Resources.add_icon_24px;
                button.Click += Button_Click;

                

                // Thêm các control vào panel

                panel.Controls.Add(lblTenSanPham);
                panel.Controls.Add(lblSoLuong);
                panel.Controls.Add(lblDonGia);
                panel.Controls.Add(pictureBox);
                panel.Controls.Add(button);
               

                // Thêm panel vào control cha (ví dụ: một FlowLayoutPanel có tên là flowLayoutPanel1)
                flowLayoutPanel1.Controls.Add(panel);

                tongtien = 0;
                txt_tongtien.Text = "0";
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            if (sender is Control control && control.Parent is Panel panel)
            {
                string panelMaSP = panel.Tag as string;
                dt2 = dtb.DataRead("select * from tbSanPham Where MaSP = '" + panelMaSP +"'");
            }
            string soLuong = dt2.Rows[0]["SoLuong"].ToString();



            if(soLuong == "0" )
            {
                MessageBox.Show("Số lượng sản phẩm đã hết");
            }
            else
            {
                string maSP = dt2.Rows[0]["MaSP"].ToString();


                if (uniqueSP.Contains(maSP))
                {
                    if (int.TryParse(txt.Text, out int giaTriHienTai1))
                    {
                        giaTriHienTai1++;
                        //txt.Text = giaTriHienTai1.ToString();

                        if (sender is Control control1 && control1.Parent is Panel panel2)
                        {
                            string panelMaSP = panel2.Tag as string;
                            UpdatePanelByMaSP1(panelMaSP, giaTriHienTai1.ToString());
                            UpdateTxt(panelMaSP, giaTriHienTai1.ToString());
                        }

                        // Cập nhật lại tổng tiền
                        tongtien += Convert.ToInt32(dt2.Rows[0]["DonGiaBan"]);
                        txt_tongtien.Text = tongtien.ToString();
                        
                    }

                    return;
                }
                uniqueSP.Add(maSP);

                Panel panel1 = new Panel();
                panel1.Width = 313;
                panel1.Height = 86;
                panel1.BackColor = Color.White;
                panel1.BorderStyle = BorderStyle.FixedSingle;
                panel1.Tag = dt2.Rows[0]["MaSP"].ToString();



                string tenSanPham = dt2.Rows[0]["TenSP"].ToString();
                string anh = dt2.Rows[0]["Anh"].ToString();
                string DonGia = dt2.Rows[0]["DonGiaBan"].ToString();
                

                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new System.Drawing.Size(102, 86);
                pictureBox.Dock = DockStyle.Left;
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                string imagePath = Application.StartupPath + "\\img\\" + anh;
                if (System.IO.File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }


                Label lblTenSanPham = new Label();
                lblTenSanPham.Text = tenSanPham;
                lblTenSanPham.Location = new Point(105, 15);
                lblTenSanPham.Font = new Font("Arial", 14, FontStyle.Bold);

                Label lblDonGia = new Label();
                lblDonGia.Text = DonGia + " đ";
                lblDonGia.Location = new Point(221, 63);
                lblDonGia.ForeColor = Color.Gray;
                lblDonGia.Font = new Font("Arial", 12, FontStyle.Bold);
                /*
                Button button2 = new Button();
                button2.Location = new Point(168, 49);
                button2.Size = new System.Drawing.Size(30, 30);
                button2.Font = new Font("Arial", 12, FontStyle.Bold);
                button2.Text = " + ";
                button2.Click += button2_Click;

                Button button3 = new Button();
                button3.Location = new Point(108, 49);
                button3.Size = new System.Drawing.Size(30, 30);
                button3.Font = new Font("Arial", 12, FontStyle.Bold);
                button3.Text = " - ";
                button3.Click += button3_Click;*/


                txt = new TextBox();
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.Size = new System.Drawing.Size(30, 30);
                txt.Location = new Point(138, 49);
                txt.Multiline = true;
                //txt.Enabled = false;
                txt.Text = "0";
                txt.TextAlign = HorizontalAlignment.Center;
                txt.Font = new Font("Arial", 12, FontStyle.Bold);
                txt.Enabled = false;

                CustomControls.RJControls.RJButton rjButton = new CustomControls.RJControls.RJButton();
                rjButton.Size = new System.Drawing.Size(30, 30);
                rjButton.BorderRadius = 8;
                rjButton.Image = Properties.Resources.bin_icon_24px;
                rjButton.Location = new Point(271, 3);
                rjButton.BackColor = Color.WhiteSmoke;
                rjButton.Click += xoa_click;


                panel1.Controls.Add(pictureBox);
                //panel1.Controls.Add(button3);
                //panel1.Controls.Add(button2);
                panel1.Controls.Add(lblDonGia);
                panel1.Controls.Add(txt);
                panel1.Controls.Add(lblTenSanPham);
                panel1.Controls.Add(rjButton);

                flowLayoutPanel2.Controls.Add(panel1);

                tongtien += Convert.ToInt32(DonGia);
                txt_tongtien.Text = tongtien.ToString();
                
               
                if (txt != null && int.TryParse(txt.Text, out int giaTriHienTai))
                {
                    giaTriHienTai++;
                    txt.Text = giaTriHienTai.ToString();
                    if (sender is Control control1 && control1.Parent is Panel panel2)
                    {
                        string panelMaSP = panel2.Tag as string;

                        UpdatePanelByMaSP1(panelMaSP, giaTriHienTai.ToString());
                        UpdateTxt(panelMaSP, giaTriHienTai.ToString());
                       

                    }
                }
            }
          
        }

        public void UpdateTxt(string maSP, string soLuong)
        {
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if (control is Panel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;
                    
                    if (panelMaSP == maSP)
                    {
                        
                        // Tìm và cập nhật các thành phần trên panel
                        foreach (Control panelControl in panel.Controls)
                        {
                            
                            if (panelControl is TextBox txt1)
                            {
                               
                                if (txt1.Location == new Point(138, 49))
                                {
                                    txt1.Text = soLuong;
                                    
                                }
                            }
                        }
                        

                        break; // Dừng vòng lặp sau khi cập nhật panel
                    }
                }
            }
        }
        public void UpdatePanelByMaSP1(string maSP, string soLuong)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;
                    DataTable dt2 = dtb.DataRead("select SoLuong from tbSanPham Where MaSP = '" + panelMaSP + "'");
                    // So sánh MaSP của panel với MaSP mà bạn muốn cập nhật
                    if (panelMaSP == maSP)
                    {
                        // Tìm và cập nhật các thành phần trên panel
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is Label lbl)
                            {
                                if (lbl.Location == new Point(9, 175))
                                {
                                    
                                    string SoLuongbandau = dt2.Rows[0]["SoLuong"].ToString();
                                    int tong = Convert.ToInt32(SoLuongbandau) - Convert.ToInt32(soLuong);
                                    lbl.Text = "SL: " + tong.ToString();
                                    txt_tongtien.Text = tongtien.ToString();
                                }
                            }
                        }
                        break; // Dừng vòng lặp sau khi cập nhật panel
                    }
                }
            }
        }
        public void UpdatePanelByMaSP2(string maSP)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;
                    DataTable dt2 = dtb.DataRead("select SoLuong from tbSanPham Where MaSP = '" + panelMaSP + "'");
                    // So sánh MaSP của panel với MaSP mà bạn muốn cập nhật
                    if (panelMaSP == maSP)
                    {
                        // Tìm và cập nhật các thành phần trên panel
                        foreach (Control panelControl in panel.Controls)
                        {
                            if (panelControl is Label lbl)
                            {
                                if (lbl.Location == new Point(9, 175))
                                {
                                    string soluongText = lbl.Text;
                                    string SoLuongbandau = soluongText.Replace("SL: ", "");
                                    int tong = Convert.ToInt32(SoLuongbandau) + 1;
                                    lbl.Text = "SL: " + tong.ToString();
                                }
                            }
                        }
                        break; // Dừng vòng lặp sau khi cập nhật panel
                    }
                }
            }
        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {
            if (txt != null && int.TryParse(txt.Text, out int giaTriHienTai))
            {
                giaTriHienTai++;
                txt.Text = giaTriHienTai.ToString();
                if (sender is Control control && control.Parent is Panel panel)
                {
                    string panelMaSP = panel.Tag as string;
                    UpdatePanelByMaSP1(panelMaSP,txt.Text);
                }
            }
            

        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            if (txt != null && int.TryParse(txt.Text, out int giaTriHienTai) && giaTriHienTai > 1)
            {
                giaTriHienTai--;
                txt.Text = giaTriHienTai.ToString();
                if (sender is Control control && control.Parent is Panel panel)
                {
                    string panelMaSP = panel.Tag as string;
                    UpdatePanelByMaSP2(panelMaSP);
                }
            }
        } */
        public void RemovePanelByMaSP(string maSP)
        {
            int SL = 0;
            foreach (Control control in flowLayoutPanel2.Controls)
            {
                
                if (control is Panel panel)
                {
                    // Lấy MaSP từ panel (đã lưu trong Tag của panel)
                    string panelMaSP = control.Tag as string;

                    // So sánh MaSP của panel với MaSP mà bạn muốn xóa
                    if (panelMaSP == maSP)
                    {
                        foreach (Control panelControl in panel.Controls)
                        {

                            if (panelControl is TextBox txt1)
                            {

                                if (txt1.Location == new Point(138, 49))
                                {
                                     SL = Convert.ToInt32(txt1.Text);
                                     SL--;
                                    txt1.Text = SL.ToString();
                                    
                                }
                            }
                        }


                        // Xóa panel khỏi FlowLayoutPanel
                        if( SL < 1)
                        {
                            flowLayoutPanel2.Controls.Remove(panel);
                        }
                       

                        break; // Dừng vòng lặp sau khi xóa panel thành công
                    }
                }
            }
        }
        private void xoa_click(object sender, EventArgs e)
        {
            DataTable dt3 = new DataTable();

            if (txt != null && int.TryParse(txt.Text, out int giaTriHienTai))
            {
                //giaTriHienTai--;
                //txt.Text = giaTriHienTai.ToString();
                if (sender is Control control && control.Parent is Panel panel)
                {
                    string panelMaSP = panel.Tag as string;
                   
                    dt3 = dtb.DataRead("select DonGiaBan from tbSanPham Where MaSP = '" + panelMaSP + "'");
                    RemovePanelByMaSP(panelMaSP);
                    UpdatePanelByMaSP2(panelMaSP);
                    uniqueSP.Remove(panelMaSP);
                    
                }
                
            }

            tongtien -= Convert.ToInt32(dt3.Rows[0]["DonGiaBan"]);
            txt_tongtien.Text = tongtien.ToString();
        }
  
        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

       

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            uniqueSP.Clear();
            
            Views.ThanhToanVe ttv = new Views.ThanhToanVe(this, maphim, NgayChieu, GioChieu, masuatchieu, soghe, tongtienVe, txt_tongtien.Text,MaNv,values);
            
            ttv.ShowDialog();
            txt_tongtien.Text = "0";
            tongtien = 0;
           
        }
    }
}
