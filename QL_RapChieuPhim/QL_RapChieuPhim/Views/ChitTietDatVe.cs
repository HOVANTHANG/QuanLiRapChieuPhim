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
        Views.Phimdangchieu Phimdangchieu; //công dụng để truyền dữ liệu giữa các form
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
			// Chỉ truy vấn các suất chiếu của ngày chiếu được chọn
			string query = $@"
        SELECT 
            tbPhim.MaPhim, 
            MaXuatChieu, 
            TenPhim, 
            Year(NamSX) AS NamSX, 
            LoaiPhim, 
            Anh, 
            CaChieu, 
            NgayChieu, 
            TenPhong, 
            TienVe 
        FROM tbPhim
        INNER JOIN tbXuatChieu ON tbPhim.MaPhim = tbXuatChieu.MaPhim
        INNER JOIN tbPhongChieu ON tbXuatChieu.MaPhong = tbPhongChieu.MaPhong
        INNER JOIN tbTheLoaiPhim ON tbPhim.MaTheLoai = tbTheLoaiPhim.MaTheLoai
        WHERE tbPhim.MaPhim = '{maphim}' 
          AND tbXuatChieu.NgayChieu = '{NgayChieu}'"; // Lọc theo ngày chiếu được chọn

			dt = dtb.DataRead(query);

			// Tạo nút cho mỗi suất chiếu
			foreach (DataRow row in dt.Rows)
			{
				CustomControls.RJControls.RJButton Button = new CustomControls.RJControls.RJButton();
				string caChieu = row["CaChieu"].ToString();
				string PhongChieu = row["TenPhong"].ToString();

				Button.Text = caChieu + " | " + PhongChieu; // Hiển thị giờ chiếu và phòng chiếu
				Button.BorderRadius = 8;
				Button.Tag = row["MaXuatChieu"].ToString(); // Lưu mã xuất chiếu vào tag của button
				Button.Click += button_Click;  // Thêm sự kiện click cho button

				flowLayoutPanel1.Controls.Add(Button);
			}

			// Hiển thị thông tin phim
			if (dt.Rows.Count > 0)
			{
				txt_timeChieu.Text = NgayChieu;
				lbl_tenphim.Text = dt.Rows[0]["TenPhim"].ToString(); // Lấy tên phim từ kết quả truy vấn
				string imagePath = Application.StartupPath + "\\img\\" + dt.Rows[0]["Anh"].ToString();
				if (System.IO.File.Exists(imagePath))
				{
					ptb_anhPhim.Image = Image.FromFile(imagePath);
				}
			}
			else
			{
				MessageBox.Show("Không có suất chiếu nào cho ngày này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}


		private void button_Click(object sender, EventArgs e) 
        {
            if (sender is Control control && control is CustomControls.RJControls.RJButton Button) // kiểm tra xem sender có phải là button không
            {
                // Lấy MaPhim từ panel (đã lưu trong Tag của panel)
                string btnSuatChieu = control.Tag as string; // lấy mã xuất chiếu từ tag của button

                Views.DatPhim datPhim = new Views.DatPhim(maphim, btnSuatChieu ,NgayChieu,MaNv);
                this.Close();
                datPhim.ShowDialog();
                this.Show();
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
