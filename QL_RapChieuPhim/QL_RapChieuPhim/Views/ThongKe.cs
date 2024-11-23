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
            cbb_thongKeThang.SelectedItem = -1;

            DataTable data = dtb.DataRead("SELECT DISTINCT Nam FROM (   " +
                "SELECT YEAR(NgayBan) AS Nam FROM tbHoaDonSP  " +
                "\nUNION\n" +
                "SELECT YEAR(ThoiGian) AS Nam FROM DoanhThuPhim) " +
                "AS AllYears\n" +
                "ORDER BY Nam ASC;");
            if (data.Rows.Count > 0)
            {
                cbb_thongKeNam.DataSource = data;
                cbb_thongKeNam.DisplayMember = "Nam";
                cbb_thongKeNam.ValueMember = "Nam";
                cbb_thongKeNam.SelectedIndex = -1;
            }

            DataTable dt = dtb.DataRead("select TenPhim , sum (DoanhThu) as DoanhThuPhim from tbPhim " +
                "inner join DoanhThuPhim on " +
                "tbPhim.MaPhim = DoanhThuPhim.MaPhim " +
                "group by TenPhim " +
                "order by DoanhThuPhim desc");
            foreach (DataRow row in dt.Rows)
            {
                string tenPhim = row["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThuPhim"]);

                BieuDo_Phim.Series["Phim"].Points.AddXY(tenPhim, doanhThu);
            }
            DataTable dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as " +
                "DoanhThu from tbChiTietHoaDonSP inner join tbHoaDonSP " +
                "on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD " +
                "inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP " +
                "group by TenSP " +
                "order by DoanhThu desc");
            foreach (DataRow row in dt2.Rows)
            {
                string TenSP = row["TenSP"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThu"]);

                Bieudo_SP.Series["SanPham"].Points.AddXY(TenSP, doanhThu);
            }
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

        public void kiemtra()
        {
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();

            if (cbb_thongKeNam.SelectedIndex != -1 && cbb_thongKeThang.SelectedIndex == -1 || cbb_thongKeThang.SelectedItem == "Null")
            {
                var selectedRowView = (DataRowView)cbb_thongKeNam.SelectedItem;
                int selectedYear = Convert.ToInt32(selectedRowView["Nam"]);
                dt = dtb.DataRead("SELECT TenPhim, SUM(DoanhThu) AS DoanhThuPhim FROM tbPhim " +
                    "INNER JOIN DoanhThuPhim ON tbPhim.MaPhim = DoanhThuPhim.MaPhim " +
                    "WHERE Year(ThoiGian) = " + selectedYear +
                    " GROUP BY TenPhim, year(ThoiGian) " +
                    " ORDER BY DoanhThuPhim DESC;");

                dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as DoanhThu from tbChiTietHoaDonSP " +
                    "inner join tbHoaDonSP on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD " +
                    "inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP  " +
                    "where Year(NgayBan) = " + selectedYear +
                    " group by TenSP, year(NgayBan) " +
                    "order by DoanhThu desc");
            }
            else if (cbb_thongKeNam.SelectedIndex != -1 && cbb_thongKeThang.SelectedIndex != -1)
            {
                var selectedRowViewNam = (DataRowView)cbb_thongKeNam.SelectedItem;
                int selectedYear = Convert.ToInt32(selectedRowViewNam["Nam"]);
                int selectedMonth = Convert.ToInt32(cbb_thongKeThang.SelectedItem);

                dt = dtb.DataRead("SELECT TenPhim, SUM(DoanhThu) AS DoanhThuPhim FROM tbPhim " +
                    "INNER JOIN DoanhThuPhim ON tbPhim.MaPhim = DoanhThuPhim.MaPhim " +
                    "WHERE Year(ThoiGian) = " + selectedYear + " and Month(ThoiGian) = " + selectedMonth +
                    " GROUP BY TenPhim, year(ThoiGian) " +
                    " ORDER BY DoanhThuPhim DESC;");

                dt2 = dtb.DataRead("select TenSP, sum(SLBan*DonGiaBan) as DoanhThu from tbChiTietHoaDonSP " +
                    "inner join tbHoaDonSP on tbChiTietHoaDonSP.SoHD = tbHoaDonSP.SoHD " +
                    "inner join tbSanPham on tbChiTietHoaDonSP.MaSP = tbSanPham.MaSP  " +
                    "where Year(NgayBan) = " + selectedYear + " and Month(NgayBan) = " + selectedMonth +
                    " group by TenSP, year(NgayBan) " +
                    "order by DoanhThu desc");
            }

            dgv_Phim.Columns.Clear();
            BieuDo_Phim.Series["Phim"].Points.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string tenPhim = row["TenPhim"].ToString();
                double doanhThu = Convert.ToDouble(row["DoanhThuPhim"]);

                BieuDo_Phim.Series["Phim"].Points.AddXY(tenPhim, doanhThu);
            }

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

        private void cbb_thongKe_SelectedIndexChanged(object sender, EventArgs e)
        {
            kiemtra();
        }

        private void cbb_thongKe2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_thongKeNam.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập năm", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                kiemtra();
            }
        }
    }
}

