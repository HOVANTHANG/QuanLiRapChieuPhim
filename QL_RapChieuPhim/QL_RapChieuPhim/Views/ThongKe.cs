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
    
    public partial class ThongKe : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            cbb_thongKe.Items.Add("Tháng");
            cbb_thongKe.Items.Add("Năm");
            DataTable dt = dtb.DataRead("select TenPhim , sum (DoanhThu) as DoanhThuPhim from tbPhim inner join DoanhThuPhim on tbPhim.MaPhim = DoanhThuPhim.MaPhim group by TenPhim order by DoanhThuPhim desc");
            foreach (DataRow row in dt.Rows)
            {
                string tenPhim = row["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThuPhim"]); //ép kiểu về double

                BieuDo_Phim.Series["Phim"].Points.AddXY(tenPhim, doanhThu); //tên phim trục x, doanh thu trục y
            }

            // Lấy dữ liệu từ bảng tbSanPham
            DataTable dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as DoanhThu from tbChiTietHoaDonSP inner join tbHoaDonSP on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP group by TenSP order by DoanhThu desc");
            foreach (DataRow row in dt2.Rows)
            {
                string TenSP = row["TenSP"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                Bieudo_SP.Series["SanPham"].Points.AddXY(TenSP, doanhThu);
            }

            // Tạo cột STT
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            dgv_Phim.Columns.Add(sttColumn);

            // Tạo cột TenPhim
            DataGridViewTextBoxColumn tenPhimColumn = new DataGridViewTextBoxColumn();
            tenPhimColumn.HeaderText = "Tên Phim";
            dgv_Phim.Columns.Add(tenPhimColumn);

            // Tạo cột Doanh Thu
            DataGridViewTextBoxColumn doanhThuColumn = new DataGridViewTextBoxColumn();
            doanhThuColumn.HeaderText = "Doanh Thu";
            dgv_Phim.Columns.Add(doanhThuColumn);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Tính số thứ tự
                int stt = i + 1;

                // Lấy dữ liệu từ DataTable
                string tenPhim = dt.Rows[i]["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(dt.Rows[i]["DoanhThuPhim"]);

                // Thêm dòng vào DataGridView
                dgv_Phim.Rows.Add(stt, tenPhim, doanhThu);
            }

            // Tạo cột STT2
            DataGridViewTextBoxColumn stt2Column = new DataGridViewTextBoxColumn();
            stt2Column.HeaderText = "STT";
            dgv_SanPham.Columns.Add(stt2Column);

            // Tạo cột TenSP
            DataGridViewTextBoxColumn tenSPColumn = new DataGridViewTextBoxColumn();
            tenSPColumn.HeaderText = "Tên Sản Phẩm";
            dgv_SanPham.Columns.Add(tenSPColumn);

            // Tạo cột Doanh Thu
            DataGridViewTextBoxColumn doanhThu2Column = new DataGridViewTextBoxColumn();
            doanhThu2Column.HeaderText = "Doanh Thu";
            dgv_SanPham.Columns.Add(doanhThu2Column);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                // Tính số thứ tự
                int stt = i + 1;

                // Lấy dữ liệu từ DataTable
                string tenSP = dt2.Rows[i]["TenSP"].ToString();
                double doanhThu = Convert.ToDouble(dt2.Rows[i]["DoanhThu"]);

                // Thêm dòng vào DataGridView
                dgv_SanPham.Rows.Add(stt, tenSP, doanhThu);
            }
        }

        private void cbb_thongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_thongKe.SelectedIndex == 0)
            {
                cbb_thongKe2.Items.Clear();
                cbb_thongKe2.Items.Add("1");
                cbb_thongKe2.Items.Add("2");
                cbb_thongKe2.Items.Add("3");
                cbb_thongKe2.Items.Add("4");
                cbb_thongKe2.Items.Add("5");
                cbb_thongKe2.Items.Add("6");
                cbb_thongKe2.Items.Add("7");
                cbb_thongKe2.Items.Add("8");
                cbb_thongKe2.Items.Add("9");
                cbb_thongKe2.Items.Add("10");
                cbb_thongKe2.Items.Add("11");
                cbb_thongKe2.Items.Add("12");
            }
            if(cbb_thongKe.SelectedIndex == 1) {
                cbb_thongKe2.Items.Clear();
                cbb_thongKe2.Items.Add("2024");
                cbb_thongKe2.Items.Add("2023");
                cbb_thongKe2.Items.Add("2022");
                cbb_thongKe2.Items.Add("2021");
                cbb_thongKe2.Items.Add("2020");
                cbb_thongKe2.Items.Add("2019");
                cbb_thongKe2.Items.Add("2018");
            }
        }

        // Thống kê theo tháng hoặc năm
        private void cbb_thongKe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            if (cbb_thongKe.Text == "Năm")
            {
             dt = dtb.DataRead("SELECT TenPhim, SUM(DoanhThu) AS DoanhThuPhim\r\nFROM tbPhim\r\nINNER JOIN DoanhThuPhim ON tbPhim.MaPhim = DoanhThuPhim.MaPhim\r\nWHERE Year(ThoiGian) = '" + cbb_thongKe2.Text + "'\r\nGROUP BY TenPhim, year(ThoiGian)\r\nORDER BY DoanhThuPhim DESC;");
             dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as DoanhThu from tbChiTietHoaDonSP inner join tbHoaDonSP on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP where Year(NgayBan) ='" + cbb_thongKe2.Text + "' group by TenSP, year(NgayBan) order by DoanhThu desc");

            }
            if (cbb_thongKe.Text == "Tháng")
            {
                dt = dtb.DataRead("SELECT TenPhim, SUM(DoanhThu) AS DoanhThuPhim\r\nFROM tbPhim\r\nINNER JOIN DoanhThuPhim ON tbPhim.MaPhim = DoanhThuPhim.MaPhim\r\nWHERE MONTH(ThoiGian) = '" + cbb_thongKe2.Text + "'\r\nGROUP BY TenPhim, MONTH(ThoiGian)\r\nORDER BY DoanhThuPhim DESC;");
               dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as DoanhThu from tbChiTietHoaDonSP inner join tbHoaDonSP on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP where MONTH(NgayBan) = '" + cbb_thongKe2.Text + "'group by TenSP ,MONTH(NgayBan) order by DoanhThu desc");

            }

            // Xóa dữ liệu cũ
            dgv_Phim.Columns.Clear();
            BieuDo_Phim.Series["Phim"].Points.Clear();
            // Hiển thị dữ liệu mới
            foreach (DataRow row in dt.Rows)
            {
                string tenPhim = row["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThuPhim"]);

                BieuDo_Phim.Series["Phim"].Points.AddXY(tenPhim, doanhThu);
            }
            //
            DataGridViewTextBoxColumn sttColumn = new DataGridViewTextBoxColumn();
            sttColumn.HeaderText = "STT";
            dgv_Phim.Columns.Add(sttColumn);

            // Tạo cột TenPhim
            DataGridViewTextBoxColumn tenPhimColumn = new DataGridViewTextBoxColumn();
            tenPhimColumn.HeaderText = "Tên Phim";
            dgv_Phim.Columns.Add(tenPhimColumn);

            // Tạo cột Doanh Thu
            DataGridViewTextBoxColumn doanhThuColumn = new DataGridViewTextBoxColumn();
            doanhThuColumn.HeaderText = "Doanh Thu";
            dgv_Phim.Columns.Add(doanhThuColumn);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                // Tính số thứ tự
                int stt = i + 1;

                // Lấy dữ liệu từ DataTable
                string tenPhim = dt.Rows[i]["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(dt.Rows[i]["DoanhThuPhim"]);

                // Thêm dòng vào DataGridView
                dgv_Phim.Rows.Add(stt, tenPhim, doanhThu);
            }

           
           
            dgv_SanPham.Columns.Clear();
            Bieudo_SP.Series["SanPham"].Points.Clear();
            foreach (DataRow row in dt2.Rows)
            {
                string TenSP = row["TenSP"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                Bieudo_SP.Series["SanPham"].Points.AddXY(TenSP, doanhThu);
            }
            DataGridViewTextBoxColumn stt2Column = new DataGridViewTextBoxColumn();
            stt2Column.HeaderText = "STT";
            dgv_SanPham.Columns.Add(stt2Column);

            // Tạo cột TenSP
            DataGridViewTextBoxColumn tenSPColumn = new DataGridViewTextBoxColumn();
            tenSPColumn.HeaderText = "Tên Sản Phẩm";
            dgv_SanPham.Columns.Add(tenSPColumn);

            // Tạo cột Doanh Thu
            DataGridViewTextBoxColumn doanhThu2Column = new DataGridViewTextBoxColumn();
            doanhThu2Column.HeaderText = "Doanh Thu";
            dgv_SanPham.Columns.Add(doanhThu2Column);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                // Tính số thứ tự
                int stt = i + 1;

                // Lấy dữ liệu từ DataTable
                string tenSP = dt2.Rows[i]["TenSP"].ToString();
                double doanhThu = Convert.ToDouble(dt2.Rows[i]["DoanhThu"]);

                // Thêm dòng vào DataGridView
                dgv_SanPham.Rows.Add(stt, tenSP, doanhThu);
            }


        }

        private void dgv_Phim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
