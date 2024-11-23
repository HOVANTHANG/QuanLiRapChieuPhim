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
    public partial class ChiTiet_KhachHang : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQUery;
        Views.QL_KhachHang qlKH;
        string[] strData;

        public ChiTiet_KhachHang(Views.QL_KhachHang qlkh, string[] str)
        {
            InitializeComponent();
            this.qlKH = qlkh;
            strData = str;
        }

        private void btn_close_chiTietKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addDuLieu(string[] str)
        {
            txt_chiTietTKKH.Text = str[1];
            txt_chiTietHoTenKH.Text = str[2];
            txt_chiTietGioiTinhKH.Text = str[3];
            dTP_chiTietNgaySinhKH.Text = str[4];
            txt_chiTietSoDTKH.Text = str[5];
        }

        private void ChiTiet_KhachHang_Load(object sender, EventArgs e)
        {
            addDuLieu(strData);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLichSuGiaoDich_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvLichSuGiaoDich_VisibleChanged(object sender, EventArgs e)
        {
            string sql = "Select tbPhim.TenPhim, tbVe.NgayBanVe, tbXuatChieu.NgayChieu, tbXuatChieu.CaChieu from tbVe " +
               "INNER JOIN tbXuatChieu ON tbXuatChieu.MaXuatChieu = tbVe.MaXuatChieu " +
               "INNER JOIN tbPhim ON tbPhim.MaPhim = tbXuatChieu.MaPhim " +
               "WHERE tbVe.MaKH = N'" + txt_chiTietTKKH.Text.Trim() + "'";
            DataTable dt = dtb.DataRead(sql);
            dgvLichSuGiaoDich.DataSource = dt;
            dgvLichSuGiaoDich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Căn chỉnh các cột
            dgvLichSuGiaoDich.Columns["TenPhim"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvLichSuGiaoDich.Columns["NgayBanVe"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSuGiaoDich.Columns["NgayChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvLichSuGiaoDich.Columns["CaChieu"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Căn chỉnh các cột tự động
            dgvLichSuGiaoDich.AutoResizeColumns();

            // Màu nền tiêu đề cột
            dgvLichSuGiaoDich.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;
            dgvLichSuGiaoDich.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvLichSuGiaoDich.EnableHeadersVisualStyles = false;

            // Màu nền của các ô dữ liệu
            dgvLichSuGiaoDich.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgvLichSuGiaoDich.DefaultCellStyle.SelectionBackColor = Color.FromArgb(42, 87, 141);
            dgvLichSuGiaoDich.DefaultCellStyle.SelectionForeColor = Color.White;

            // Tạo các cột như DataGridView "dGV_thongTinNV"
            dgvLichSuGiaoDich.Columns["TenPhim"].HeaderText = "Tên Phim";
            dgvLichSuGiaoDich.Columns["NgayBanVe"].HeaderText = "Ngày Bán Vé";
            dgvLichSuGiaoDich.Columns["NgayChieu"].HeaderText = "Ngày Chiếu";
            dgvLichSuGiaoDich.Columns["CaChieu"].HeaderText = "Ca Chiếu";

            // Chuyển các cột sang chỉ đọc
            dgvLichSuGiaoDich.Columns["TenPhim"].ReadOnly = true;
            dgvLichSuGiaoDich.Columns["NgayBanVe"].ReadOnly = true;
            dgvLichSuGiaoDich.Columns["NgayChieu"].ReadOnly = true;
            dgvLichSuGiaoDich.Columns["CaChieu"].ReadOnly = true;

            // Thiết lập DataGridView không cho phép thêm dòng mới
            dgvLichSuGiaoDich.AllowUserToAddRows = false;
        }
    }
}
