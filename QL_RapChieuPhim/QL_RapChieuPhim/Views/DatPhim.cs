using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
	public partial class DatPhim : Form
	{
		bool isGreen = false;
        int giave = 0;

        string maphim;
        string btnSuatChieu;
        string TienSuatChieu;
        string NgayChieu;
        string GioChieu;
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        string MaNv;

        string TimeChieu;
       
        public DatPhim(string maphim, string btnSuatChieu, string NgayChieu, string MaNv)
		{
            this.maphim = maphim;
            this.btnSuatChieu = btnSuatChieu;
            this.NgayChieu = NgayChieu;
           this.MaNv = MaNv;
			InitializeComponent();
		}

		private void DatPhim_Load(object sender, EventArgs e)
		{
            dt = dtb.DataRead("select tbPhim.MaPhim ,TenPhim, tbXuatChieu.MaXuatChieu, TenPhong, CaChieu, Anh, TienVe, ThoiLuongPhim, tbPhongChieu.MaPhong from tbPhim inner join  tbXuatChieu on tbPhim.MaPhim = tbXuatChieu.MaPhim inner join tbPhongChieu on tbXuatChieu.MaPhong = tbPhongChieu.MaPhong where tbXuatChieu.MaXuatChieu = '"+btnSuatChieu +"'");
            string thoiLuongPhimStr = dt.Rows[0]["ThoiLuongPhim"].ToString();
            string timeChieu = dt.Rows[0]["CaChieu"].ToString();
            DateTime gioChieu =  Convert.ToDateTime(timeChieu);
            string chiDuLai = new string(thoiLuongPhimStr.Where(char.IsDigit).ToArray());

            if (int.TryParse(chiDuLai, out int thoiLuongPhim))
            {
                Console.WriteLine(thoiLuongPhim);
                gioChieu = gioChieu.AddMinutes(thoiLuongPhim);
                lbl_SuatChieu.Text = "Giờ chiếu: " + timeChieu + "  -  " + gioChieu.ToString("HH:mm");
                GioChieu =timeChieu + " - " + gioChieu.ToString("HH:mm");
            }

            lbl_tenPhim.Text = "Tên phim: " + dt.Rows[0]["TenPhim"];
            lbl_PhongChieu.Text = "Phòng chiếu: " + dt.Rows[0]["TenPhong"];
            ptb_anhPhim.Image = Image.FromFile(Application.StartupPath + "\\img\\" + dt.Rows[0]["Anh"].ToString());
            TienSuatChieu = dt.Rows[0]["TienVe"].ToString();
            giave = Convert.ToInt32(TienSuatChieu);


            DataTable dt2 = dtb.DataRead("select * from tbGhe inner join tbPhongChieu on tbGhe.MaPhong = tbPhongChieu.MaPhong inner join tbXuatChieu on tbPhongChieu.MaPhong = tbXuatChieu.MaPhong where tbGhe.MaPhong = '" + dt.Rows[0]["MaPhong"].ToString() +"'");
            foreach (DataRow row in dt2.Rows)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton)
                    {
                        if (control.Text == row["SoGhe"].ToString())
                        {
                            // MessageBox.Show(control.Text + "|" + row["SoGhe"].ToString());
                            if (row["TrangThai"].ToString() == "False")
                            {
                                control.BackColor = Color.Red;
                            }
                        }
                    }
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is RJButton clickedButton)
            {
                if (clickedButton.BackColor == Color.Red)
                {
                    MessageBox.Show("Ghế này đã được đặt");
                    return;
                }
                // Reset giá vé về 0 và tính toán lại tổng
                giave = 0;
                if (clickedButton.BackColor == Color.White)
                {
                    clickedButton.BackColor = Color.Green;
                    lbl_ghe.Text += clickedButton.Text + ", ";
                }
                else if (clickedButton.BackColor == Color.Green)
                {
                    clickedButton.BackColor = Color.White;
                    lbl_ghe.Text = lbl_ghe.Text.Replace(clickedButton.Text + ", ", "");
                }
                // Tính lại tổng tiền dựa trên tất cả các ghế được chọn
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton btn && btn.BackColor == Color.Green)
                    {
                        if (btn.Text == "D1" || btn.Text == "D2" || btn.Text == "D3" || btn.Text == "D4"
                              || btn.Text == "D5" || btn.Text == "D6" || btn.Text == "E1" || btn.Text == "E2"
                              || btn.Text == "E3" || btn.Text == "E4" || btn.Text == "E5" || btn.Text == "E6"
                              || btn.Text == "F1" || btn.Text == "F2" || btn.Text == "F3" || btn.Text == "F4"
                              || btn.Text == "F5" || btn.Text == "F6")
                        {
                            giave += 50000;
                        }
                        else
                        {
                            giave += 30000;
                        }
                    }
                }
                // Cập nhật hiển thị
                if (giave == 0)
                {
                    txt_giave.Text = "0";
                    txt_tongtien.Text = "0";
                    lbl_ghe.Text = "";
                }
                else
                {
                    if (clickedButton.Text == "D1" || clickedButton.Text == "D2" || clickedButton.Text == "D3" || clickedButton.Text == "D4"
                 || clickedButton.Text == "D5" || clickedButton.Text == "D6" || clickedButton.Text == "E1" || clickedButton.Text == "E2"
                 || clickedButton.Text == "E3" || clickedButton.Text == "E4" || clickedButton.Text == "E5" || clickedButton.Text == "E6"
                 || clickedButton.Text == "F1" || clickedButton.Text == "F2" || clickedButton.Text == "F3" || clickedButton.Text == "F4"
                 || clickedButton.Text == "F5" || clickedButton.Text == "F6")
                    {
                        txt_giave.Text = "50000"; //Cộng thêm giá vé từ csdl bảng suất chiếu
                    }
                    else
                    {
                        txt_giave.Text = "30000"; 
                    }
                    txt_tongtien.Text = giave.ToString();
                }
            }
        }


        //private void Button_Click(object sender, EventArgs e)
        //{

        //          if (sender is RJButton clickedButton)
        //          {
        //              if (clickedButton.BackColor == Color.Red)
        //              {
        //                  MessageBox.Show("Ghế này đã được đặt");
        //                  return;
        //              }
        //              if (clickedButton.BackColor == Color.White)
        //              {
        //                  if(clickedButton.Text == "D1" || clickedButton.Text == "D2" || clickedButton.Text == "D3"|| clickedButton.Text == "D4"
        //                      || clickedButton.Text == "D5" || clickedButton.Text == "D6" || clickedButton.Text == "E1" || clickedButton.Text == "E2"
        //                      || clickedButton.Text == "E3" || clickedButton.Text == "E4" || clickedButton.Text == "E5" || clickedButton.Text == "E6"
        //                      || clickedButton.Text == "F1" || clickedButton.Text == "F2" || clickedButton.Text == "F3" || clickedButton.Text == "F4"
        //                      || clickedButton.Text == "F5" || clickedButton.Text == "F6")
        //                  {
        //                      clickedButton.BackColor = Color.Green;
        //                      txt_giave.Text = "50000";
        //                      giave += 50000;
        //                  }
        //                  else
        //                  {
        //                      clickedButton.BackColor = Color.Green;
        //                      txt_giave.Text = "30000";
        //                      giave += 30000;
        //                  }

        //                  lbl_ghe.Text += clickedButton.Text + ", ";

        //              }
        //              else if(clickedButton.BackColor == Color.Green)
        //              {
        //                  if (clickedButton.Text == "D1" || clickedButton.Text == "D2" || clickedButton.Text == "D3" || clickedButton.Text == "D4"
        //                      || clickedButton.Text == "D5" || clickedButton.Text == "D6" || clickedButton.Text == "E1" || clickedButton.Text == "E2"
        //                      || clickedButton.Text == "E3" || clickedButton.Text == "E4" || clickedButton.Text == "E5" || clickedButton.Text == "E6"
        //                      || clickedButton.Text == "F1" || clickedButton.Text == "F2" || clickedButton.Text == "F3" || clickedButton.Text == "F4"
        //                      || clickedButton.Text == "F5" || clickedButton.Text == "F6")
        //                  {
        //                      clickedButton.BackColor = Color.White;
        //                      txt_giave.Text = "50000";
        //                      giave -= 50000;
        //                  }
        //                  else
        //                  {
        //                      clickedButton.BackColor = Color.White;
        //                      txt_giave.Text = "30000";
        //                      giave -= 30000;
        //                  }


        //                  lbl_ghe.Text = lbl_ghe.Text.Replace(clickedButton.Text + ", ", "");
        //              }
        //              txt_tongtien.Text = (giave).ToString();

        //          }

        //      }


        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {


            
            if (txt_tongtien.Text == "")
            {
                MessageBox.Show("vui lòng chọn ghế ngồi");
            }
            else
            {
                string text = lbl_ghe.Text;
                string[] values = text.Split(',');

                Views.Chon_SanPham cSP = new Views.Chon_SanPham(NgayChieu, GioChieu, maphim, btnSuatChieu, lbl_ghe.Text, txt_tongtien.Text,MaNv,values);
                cSP.ShowDialog();
            } 



  
        }

        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton81_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
