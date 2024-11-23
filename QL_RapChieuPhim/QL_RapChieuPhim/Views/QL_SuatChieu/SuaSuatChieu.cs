using CustomControls.RJControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class SuaSuatChieu : Form
    {
		private string endDate;

		public SuaSuatChieu()
        {
            InitializeComponent();
        }
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();
        Views.QL_SuatChieu QL_SuatChieu;
        string[] strData;
        
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public SuaSuatChieu(Views.QL_SuatChieu qL_SuatChieu, string[] str, string endDate)
		{
			this.QL_SuatChieu = qL_SuatChieu;
			this.endDate = endDate; // Lưu ngày kết thúc
			InitializeComponent();
			strData = str;
		}




		public void addtextbox(string[] str)
        {
            //Tên phim
            lblTenPhim.Text = str[1];
            
            //Ngày chiếu
            string ngayChieuStr = str[2];
            DateTime.TryParse( ngayChieuStr, out DateTime ngayChieu);
            lblNgayChieu.Text = ngayChieu.ToString("dd / MM / yyyy");
            
            //Phòng chiếu
            lblPhongChieu.Text = dataBase.selectColumn($"SELECT PC.TenPhong\r\nFROM tbXuatChieu XC\r\nINNER JOIN tbPhongChieu PC ON XC.MaPhong = PC.MaPhong\r\nWHERE XC.MaXuatChieu = '{str[3]}';");
            
            //Giá vé
            lblGiaVe.Text = dataBase.selectColumn($"select REPLACE(FORMAT(TienVe, 'N1'), '.0', '')\r\nfrom tbXuatChieu\r\nwhere MaXuatChieu ='{str[3]}'") + " VNĐ ";
            
            //Giờ chiếu
            DateTime gioChieu = DateTime.ParseExact(str[4], "HH:mm", CultureInfo.InvariantCulture);
            DateTime gioKetThuc;
            txtSuatChieu1.Text = gioChieu.ToString("HH:mm tt");

            string thoiLuongPhimStr = str[5];
            //Lấy số phút từ chuỗi thời lượng phim
            string chiDuLai = new string(thoiLuongPhimStr.Where(char.IsDigit).ToArray());
            //Chuyển chuỗi thành số
            if (int.TryParse(chiDuLai, out int thoiLuongPhim))
            {
                //
                Console.WriteLine(thoiLuongPhim);
                gioKetThuc = gioChieu.AddMinutes(thoiLuongPhim);
                //Tính toán thời gian kết thúc của suất chiếu bằng cách cộng thêm thoiLuongPhim (phút)
                //vào gioChieu (thời gian bắt đầu).
                txtSuatChieu2.Text = gioKetThuc.ToString("HH:mm tt");
            }


        }

        private void SuaSuatChieu_Load(object sender, EventArgs e)
        {
            addtextbox(strData);
            DataTable dt = dataBase.DataRead("select MaPhong from tbXuatChieu where MaXuatChieu = '" + strData[3] + "'");
            string MP = dt.Rows[0]["MaPhong"].ToString(); //Lấy mã phòng chiếu từ bảng tbXuatChieu

            DataTable dt2 = dataBase.DataRead("select * from tbGhe inner join tbPhongChieu on tbGhe.MaPhong = tbPhongChieu.MaPhong inner join tbXuatChieu on tbPhongChieu.MaPhong = tbXuatChieu.MaPhong where tbGhe.MaPhong = '"+MP+"'");
            //Lấy danh sách ghế từ bảng tbGhe, tbPhongChieu, tbXuatChieu
            foreach (DataRow row in dt2.Rows)
            {
                //Duyệt qua từng dòng của bảng dt2
                foreach (Control control in this.Controls)
                {
                    //Duyệt qua từng control trong form
                    if (control is RJButton)
                    {
                        //ktra text của RJButton có bằng với số ghế trong bảng tbGhe không
                        if (control.Text == row["SoGhe"].ToString())
                        {
                            //Nếu Text của RJButton bằng với số ghế trong bảng tbGhe
                            if (row["TrangThai"].ToString() == "False")
                            {
                                control.BackColor = Color.Red;
                            }
                            
                        }
                        
                    }
                }
            }

        }

		//Hàm xử lý sự kiện click vào nút xóa
		private void bunifuButton1_Click(object sender, EventArgs e)
		{
			// Lấy mã phòng chiếu từ bảng tbXuatChieu
			DataTable dt = dataBase.DataRead($"SELECT MaPhong FROM tbXuatChieu WHERE MaXuatChieu = '{strData[3]}'");
			string MP = dt.Rows[0]["MaPhong"].ToString();

			// Cập nhật trạng thái ghế trong bảng tbGhe là 1 tức là trống
			string sql3 = $"UPDATE tbGhe SET TrangThai = 1 WHERE MaPhong = '{MP}'";
			dataBase.DataChange(sql3);

			if (MessageBox.Show("Bạn có chắc chắn xóa suất chiếu này không? Nếu có, ấn Yes. Không thì ấn No.",
				"Xóa suất chiếu", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				// Xóa các liên kết giữa bảng tbVe và bảng tbXuatChieu
				string sql0 = $"UPDATE tbVe SET MaXuatChieu = NULL WHERE MaXuatChieu = '{strData[3]}';";
				dataBase.DataChange(sql0);

				// Xóa suất chiếu
				string sql1 = $"DELETE FROM tbXuatChieu WHERE MaXuatChieu = '{strData[3]}';";
				dataBase.DataChange(sql1);

				// Lấy trạng thái hiện tại
				string startDate = QL_SuatChieu.dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
				string endDate = QL_SuatChieu.dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
				string searchKeyword = QL_SuatChieu.txt_TimKiem.Text.Trim();
				string selectedRoom = QL_SuatChieu.SelectedRoom; // Phòng hiện tại đang chọn

				// Tạo câu truy vấn phù hợp
				string query = $@"
            SELECT
            XC.MaXuatChieu as [Mã suất chiếu],
            P.TenPhim AS [Tên Phim],
            TL.LoaiPhim AS [Loại Phim],
            P.ThoiLuongPhim AS [Thời Lượng],
            XC.CaChieu AS [Giờ Chiếu],
            XC.NgayChieu AS [Ngày Chiếu]
        FROM tbPhim AS P
        INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai
        INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim
        WHERE XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";

				// Lọc theo phòng chiếu nếu có
				if (!string.IsNullOrEmpty(selectedRoom) && selectedRoom != "ALL")
				{
					query += $" AND XC.MaPhong = '{selectedRoom}'";
				}


				// Lọc theo từ khóa tìm kiếm nếu có
				if (!string.IsNullOrEmpty(searchKeyword))
				{
					query += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
				}

				// Cập nhật DataGridView
				QL_SuatChieu.dgv_SuatChieu.DataSource = dataBase.DataRead(query);

				// Đóng form chỉnh sửa
				this.Close();
			}
		}



		private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
