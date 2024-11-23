using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QL_RapChieuPhim.Views
{
    public partial class QL_SuatChieu : Form
    {
		public string SelectedRoom { get; set; } = ""; // Lưu phòng chiếu đang chọn

		private Button currentBtn;
        private Panel leftBorderbtn; // thanh màu bên trái của button
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();
        string sql = "";
        private DataTable initialData; // tạo biến lưu dư liệu từ database để có thể reset lại dữ liệu khi tìm kiếm
        public QL_SuatChieu()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();  
            leftBorderbtn.Size = new Size(7, 44); // kích thước thanh màu bên trái của button
            panelMenu.Controls.Add(leftBorderbtn);  // thêm thanh màu bên trái của button vào panelMenu
        }

        // hàm tạo hiệu ứng khi click vào button
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton(); //xóa hiệu ứng màu của button trc đó
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;

                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);  // vị trí của thanh màu bên trái của button
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();  // đưa thanh màu bên trái của button lên trên cùng

            }
        }

        // hàm xóa hiệu ứng màu của button trc đó
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = Color.FromArgb(0, 0, 0);
            }
        }


		private void QL_XuatChieu_Load(object sender, EventArgs e)
		{
			dtpNgaySuatChieu.Value = DateTime.Now; // Lấy ngày hiện tại
			dtpNgaySuatChieu2.Value = DateTime.Now; // Giá trị mặc định của ô thứ hai

			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");

			string query = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],   TL.LoaiPhim AS [Loại Phim], P.ThoiLuongPhim AS [Thời Lượng], XC.CaChieu AS [Giờ Chiếu],XC.NgayChieu AS [Ngày Chiếu]  FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";

			dgv_SuatChieu.DataSource = dataBase.DataRead(query);

			DataGridViewImageColumn imageColumn_edit = new DataGridViewImageColumn(); // Tạo icon sửa
			imageColumn_edit.Image = Properties.Resources.edit_icon; // Thêm icon sửa vào imageColumn_edit
			imageColumn_edit.HeaderText = ""; // Header cho cột sửa

			dgv_SuatChieu.Columns.Add(imageColumn_edit); // Thêm cột vào DataGridView
			dgv_SuatChieu.AllowUserToAddRows = false;
		}

		private void btnToanBo_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Đặt giá trị selectedRoom là ALL khi chọn mục Toàn bộ
			SelectedRoom = "ALL";

			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");

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

			dgv_SuatChieu.DataSource = dataBase.DataRead(query);
		}



		private void btnPhong1_Click(object sender, EventArgs e)
		{
			SelectedRoom = "R001"; // Lưu phòng đang chọn
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Truy vấn theo phòng và khoảng thời gian
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string sql = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],  TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng],  XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu] FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai  INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.MaPhong = '{SelectedRoom}' AND XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";
 
			// Lọc theo từ khóa tìm kiếm nếu có
			string searchKeyword = txt_TimKiem.Text.Trim();
			if (!string.IsNullOrEmpty(searchKeyword))
			{
				sql += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
			}

			dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
		}



		private void btnPhong2_Click(object sender, EventArgs e)
        {
			SelectedRoom = "R002"; // Lưu phòng đang chọn
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Truy vấn theo phòng và khoảng thời gian
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string sql = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],  TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng],  XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu] FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai  INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.MaPhong = '{SelectedRoom}' AND XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";


			// Lọc theo từ khóa tìm kiếm nếu có
			string searchKeyword = txt_TimKiem.Text.Trim();
			if (!string.IsNullOrEmpty(searchKeyword))
			{
				sql += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
			}

			dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
		}
        private void btnPhong3_Click(object sender, EventArgs e)
        {
			SelectedRoom = "R003"; // Lưu phòng đang chọn
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Truy vấn theo phòng và khoảng thời gian
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string sql = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],  TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng],  XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu] FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai  INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.MaPhong = '{SelectedRoom}' AND XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";


			// Lọc theo từ khóa tìm kiếm nếu có
			string searchKeyword = txt_TimKiem.Text.Trim();
			if (!string.IsNullOrEmpty(searchKeyword))
			{
				sql += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
			}

			dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
		}
        private void btnPhong4_Click(object sender, EventArgs e)
        {
			SelectedRoom = "R004"; // Lưu phòng đang chọn
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Truy vấn theo phòng và khoảng thời gian
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string sql = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],  TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng],  XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu] FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai  INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.MaPhong = '{SelectedRoom}' AND XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";

			// Lọc theo từ khóa tìm kiếm nếu có
			string searchKeyword = txt_TimKiem.Text.Trim();
			if (!string.IsNullOrEmpty(searchKeyword))
			{
				sql += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
			}

			dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
		}
        private void btnPhong5_Click(object sender, EventArgs e)
        {
			SelectedRoom = "R005"; // Lưu phòng đang chọn
			ActivateButton(sender, Color.FromArgb(13, 183, 253));

			// Truy vấn theo phòng và khoảng thời gian
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string sql = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],  TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng],  XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu] FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai  INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.MaPhong = '{SelectedRoom}' AND XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";

			// Lọc theo từ khóa tìm kiếm nếu có
			string searchKeyword = txt_TimKiem.Text.Trim();
			if (!string.IsNullOrEmpty(searchKeyword))
			{
				sql += $" AND P.TenPhim LIKE N'%{searchKeyword}%'";
			}

			dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
		}
        private void dgv_dataPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemSuatChieu themSuatChieu = new ThemSuatChieu(this);
            themSuatChieu.ShowDialog();

        }

		// hàm xử lý sự kiện click vào button sửa
		private void dgv_SuatChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				DataGridViewColumn selectedColumn = dgv_SuatChieu.Columns[e.ColumnIndex];
				string columnHeaderText = selectedColumn.HeaderText;

				string[] str = new string[10];

				// Nếu là cột chỉnh sửa
				if (columnHeaderText == "")
				{
					// Tên phim
					str[1] = dgv_SuatChieu.CurrentRow.Cells[2].Value.ToString();
					// Ngày chiếu (ngày bắt đầu)
					str[2] = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
					// Mã suất chiếu
					str[3] = dgv_SuatChieu.CurrentRow.Cells[1].Value.ToString();
					// Ca chiếu (giờ chiếu)
					str[4] = dgv_SuatChieu.CurrentRow.Cells[5].Value.ToString();
					// Thời lượng phim
					str[5] = dgv_SuatChieu.CurrentRow.Cells[4].Value.ToString();

					// Chuyển ngày kết thúc sang form SuaSuatChieu
					string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");

					// Khởi tạo form SuaSuatChieu và truyền dữ liệu
					Views.SuaSuatChieu suaSuatChieu = new SuaSuatChieu(this, str, endDate);
					suaSuatChieu.ShowDialog();
				}
			}
		}


		private void dtpNgaySuatChieu_MouseEnter(object sender, EventArgs e)
        {
         
        }

        // hàm xử lý sự kiện khi chọn ngày
        private void dtpNgaySuatChieu_ValueChanged(object sender, EventArgs e)
        {
			if (dtpNgaySuatChieu.Value.Date > dtpNgaySuatChieu2.Value.Date)
			{
				MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtpNgaySuatChieu.Value = dtpNgaySuatChieu2.Value.Date; // Reset về ngày kết thúc
				return;
			}
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");

			string query = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],   TL.LoaiPhim AS [Loại Phim], P.ThoiLuongPhim AS [Thời Lượng], XC.CaChieu AS [Giờ Chiếu],XC.NgayChieu AS [Ngày Chiếu]  FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";


			dgv_SuatChieu.DataSource = dataBase.DataRead(query);
		}

		private void txt_TimKiem_TextChanged(object sender, EventArgs e)
		{
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");
			string searchText = txt_TimKiem.Text.Trim();

			string query = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim], TL.LoaiPhim AS [Loại Phim],  P.ThoiLuongPhim AS [Thời Lượng], XC.CaChieu AS [Giờ Chiếu], XC.NgayChieu AS [Ngày Chiếu]  FROM tbPhim AS P INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'  AND P.TenPhim LIKE N'%{searchText}%'";

			dgv_SuatChieu.DataSource = dataBase.DataRead(query);
		}


		private void dtpNgaySuatChieu2_ValueChanged_1(object sender, EventArgs e)
		{
			if (dtpNgaySuatChieu2.Value.Date < dtpNgaySuatChieu.Value.Date)
			{
				MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dtpNgaySuatChieu2.Value = dtpNgaySuatChieu.Value.Date; // Reset về ngày bắt đầu
				return;
			}
			string startDate = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
			string endDate = dtpNgaySuatChieu2.Value.ToString("yyyy-MM-dd");

			string query = $@" SELECT XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],   TL.LoaiPhim AS [Loại Phim], P.ThoiLuongPhim AS [Thời Lượng], XC.CaChieu AS [Giờ Chiếu],XC.NgayChieu AS [Ngày Chiếu]  FROM tbPhim AS P  INNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai INNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim WHERE XC.NgayChieu BETWEEN '{startDate}' AND '{endDate}'";
 
			dgv_SuatChieu.DataSource = dataBase.DataRead(query);
		}
	}
}
