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
		bool isGreen = false; //biến kiểm tra màu của button
        int giave = 0;

        string maphim;
        string btnSuatChieu;
        string TienSuatChieu;
        string NgayChieu;
        string GioChieu;
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt; //datatable để lưu dữ liệu
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
            DateTime gioChieu =  Convert.ToDateTime(timeChieu); // chuyển string sang datetime
            //Ví dụ: Nếu hôm nay là ngày 20/11/2024, kết quả là 20/11/2024 09:00:00
            string chiDuLai = new string(thoiLuongPhimStr.Where(char.IsDigit).ToArray());

            if (int.TryParse(chiDuLai, out int thoiLuongPhim)) // kiểm tra xem thoiLuongPhim có phải là số không
            {
                Console.WriteLine(thoiLuongPhim);
                gioChieu = gioChieu.AddMinutes(thoiLuongPhim); //Cộng thêm số phút (từ thoiLuongPhim) vào giờ bắt đầu.
                lbl_SuatChieu.Text = "Giờ chiếu: " + timeChieu + "  -  " + gioChieu.ToString("HH:mm");
                GioChieu =timeChieu + " - " + gioChieu.ToString("HH:mm");
            }

            lbl_tenPhim.Text = "Tên phim: " + dt.Rows[0]["TenPhim"];
            lbl_PhongChieu.Text = "Phòng chiếu: " + dt.Rows[0]["TenPhong"];
            ptb_anhPhim.Image = Image.FromFile(Application.StartupPath + "\\img\\" + dt.Rows[0]["Anh"].ToString());
            TienSuatChieu = dt.Rows[0]["TienVe"].ToString();
            giave = 0;


            DataTable dt2 = dtb.DataRead("select * from tbGhe inner join tbPhongChieu on tbGhe.MaPhong = tbPhongChieu.MaPhong inner join tbXuatChieu on tbPhongChieu.MaPhong = tbXuatChieu.MaPhong where tbGhe.MaPhong = '" + dt.Rows[0]["MaPhong"].ToString() +"'");
            foreach (DataRow row in dt2.Rows)
            {
                foreach (Control control in this.Controls)  //duyệt các 
                {
                    if (control is RJButton) //ktra control có phải là ghế hay ko
                    {
                        if (control.Text == row["SoGhe"].ToString()) //nếu số ghế trùng với số ghế trong csdl 
                        {
                            if (row["TrangThai"].ToString() == "False")   
                            { 
                                control.BackColor = Color.Red; //nếu trạng thái là false thì màu đỏ
                            }
                        }
                    }
                }
            }
        }


		private void Button_Click(object sender, EventArgs e)
		{
			if (sender is RJButton clickedButton) // Kiểm tra sender có phải là RJButton không
			{
				if (clickedButton.BackColor == Color.Red)
				{
					MessageBox.Show("Ghế này đã được đặt");
					return;
				}

				int giaGhe = 0; // Biến lưu giá vé ghế hiện tại

				if (clickedButton.BackColor == Color.White)
				{
					// Xác định giá ghế
					if (clickedButton.Text == "D1" || clickedButton.Text == "D2" || clickedButton.Text == "D3" || clickedButton.Text == "D4"
						|| clickedButton.Text == "D5" || clickedButton.Text == "D6" || clickedButton.Text == "E1" || clickedButton.Text == "E2"
						|| clickedButton.Text == "E3" || clickedButton.Text == "E4" || clickedButton.Text == "E5" || clickedButton.Text == "E6"
						|| clickedButton.Text == "F1" || clickedButton.Text == "F2" || clickedButton.Text == "F3" || clickedButton.Text == "F4"
						|| clickedButton.Text == "F5" || clickedButton.Text == "F6")
					{
						giaGhe = 50000;
					}
					else
					{
						giaGhe = 30000;
					}

					clickedButton.BackColor = Color.Green;
					giave += giaGhe;

					// Cộng giá vé phim (TienSuatChieu)
					txt_giave.Text = (giaGhe + Convert.ToInt32(TienSuatChieu)).ToString() + " Đ";
					giave += Convert.ToInt32(TienSuatChieu); // Cộng giá vé phim mỗi lần chọn ghế
					lbl_ghe.Text += clickedButton.Text + ", "; // Thêm ghế vào danh sách hiển thị
				}
				else if (clickedButton.BackColor == Color.Green)
				{
					// Xác định giá ghế
					if (clickedButton.Text == "D1" || clickedButton.Text == "D2" || clickedButton.Text == "D3" || clickedButton.Text == "D4"
						|| clickedButton.Text == "D5" || clickedButton.Text == "D6" || clickedButton.Text == "E1" || clickedButton.Text == "E2"
						|| clickedButton.Text == "E3" || clickedButton.Text == "E4" || clickedButton.Text == "E5" || clickedButton.Text == "E6"
						|| clickedButton.Text == "F1" || clickedButton.Text == "F2" || clickedButton.Text == "F3" || clickedButton.Text == "F4"
						|| clickedButton.Text == "F5" || clickedButton.Text == "F6")
					{
						giaGhe = 50000;
					}
					else
					{
						giaGhe = 30000;
					}

					clickedButton.BackColor = Color.White;
					giave -= giaGhe;

					// Trừ giá vé phim (TienSuatChieu)
					txt_giave.Text = (giaGhe + Convert.ToInt32(TienSuatChieu)).ToString();
					giave -= Convert.ToInt32(TienSuatChieu); // Cộng giá vé phim mỗi lần chọn ghế
					lbl_ghe.Text = lbl_ghe.Text.Replace(clickedButton.Text + ", ", ""); // Xóa ghế khỏi danh sách
				}

				// Cập nhật tổng tiền
				txt_tongtien.Text = giave.ToString() ;
			}
		}




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
                string text = lbl_ghe.Text;  //lấy danh sách ghế đã chọn
                string[] values = text.Split(','); //tách chuỗi thành mảng các ghế 

                Views.Chon_SanPham cSP = new Views.Chon_SanPham(NgayChieu, GioChieu, maphim, btnSuatChieu, lbl_ghe.Text, txt_tongtien.Text,MaNv,values);
                cSP.ShowDialog();
            } 
        }

        private void ptb_anhPhim_Click(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
            this.Close();
		}
	}
}
