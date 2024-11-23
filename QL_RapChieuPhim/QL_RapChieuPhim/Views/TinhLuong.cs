using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QL_RapChieuPhim.Views
{
    public partial class TinhLuong : Form
    {
        Database.DatabaseAccess dtbase = new Database.DatabaseAccess();
        DataTable dt;
        public TinhLuong()
        {
            InitializeComponent();
        }

       

        void loadData()
        {
            dt = dtbase.DataRead("SELECT * FROM tbNhanVien");
            dgv_dsnhanvien.DataSource = dt;

            CustomizeDataGridView(dgv_dsnhanvien);
        }

        private void TinhLuong_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgv_dsnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_manv.Text = dgv_dsnhanvien.CurrentRow.Cells[0].Value.ToString();
            txt_tennhanvien.Text= dgv_dsnhanvien.CurrentRow.Cells[1].Value.ToString();
            txt_gioitinh.Text = dgv_dsnhanvien.CurrentRow.Cells[2].Value.ToString();
            txt_ngaysinh.Text = dgv_dsnhanvien.CurrentRow.Cells[3].Value.ToString();
            txt_sdt.Text = dgv_dsnhanvien.CurrentRow.Cells[4].Value.ToString();
            txt_luong.Text = dgv_dsnhanvien.CurrentRow.Cells[5].Value.ToString();
           
        }



        void loadData1()
        {
            dt = dtbase.DataRead("SELECT * FROM tbTinhLuong");
            dgv_tinhluong.DataSource = dt;

            CustomizeDataGridView(dgv_tinhluong);

        }

        

        private void btn_TinhLuong_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu hôm nay là ngày mùng 1 đầu tháng
            DateTime today = DateTime.Today;
            if (today.Day != 1)
            {
                MessageBox.Show("Lương chỉ được tính vào ngày mùng 1 của tháng.");
                return;
            }

            // Lấy tháng và năm hiện tại
            string month = today.Month.ToString();
            string year = today.Year.ToString();

            // Lấy danh sách tất cả nhân viên
            dt = dtbase.DataRead("SELECT * FROM tbNhanVien");

            foreach (DataRow nhanvien in dt.Rows)
            {
                string manv = nhanvien["MaNV"].ToString();
                int luongNgay = int.Parse(nhanvien["Luong"].ToString()); // Lương theo ngày

                // Lấy dữ liệu chấm công của nhân viên trong tháng và năm hiện tại
                DataTable chamCongDt = dtbase.DataRead($"SELECT DISTINCT ngay FROM tbChamCong WHERE idnhanvien='{manv}' AND thang='{month}' AND nam='{year}'");

                if (chamCongDt.Rows.Count == 0)
                {
                    continue; // Nếu không có dữ liệu chấm công, bỏ qua nhân viên này
                }

                // Tính số ngày làm việc
                int totalDays = chamCongDt.Rows.Count;

                // Tính tổng lương theo ngày
                int tongLuong = totalDays * luongNgay;

                // Kiểm tra xem đã tồn tại bản ghi lương cho nhân viên trong tháng này chưa
                DataTable tinhLuongDt = dtbase.DataRead($"SELECT * FROM tbTinhLuong WHERE idnhanvien='{manv}' AND thang='{month}' AND nam='{year}'");
                if (tinhLuongDt.Rows.Count > 0)
                {
                    // Cập nhật lương nếu đã tồn tại bản ghi
                    string updateSql = $"UPDATE tbTinhLuong SET tong='{tongLuong}', ngaycong='{totalDays}' WHERE idnhanvien='{manv}' AND thang='{month}' AND nam='{year}'";
                    dtbase.DataChange(updateSql);
                }
                else
                {
                    // Thêm mới bản ghi lương nếu chưa tồn tại
                    string insertSql = $"INSERT INTO tbTinhLuong (idnhanvien, ngaycong, thang, nam, tong) VALUES ('{manv}', '{totalDays}', '{month}', '{year}', '{tongLuong}')";
                    dtbase.DataChange(insertSql);
                }
            }

            MessageBox.Show("Tính lương cho tất cả nhân viên thành công!");
            loadData1();
        }

        private void btn_Excel_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu DataGridView không có dữ liệu
            if (dgv_tinhluong.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất ra Excel.");
                return;
            }

            // Tạo một ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();

            // Kiểm tra nếu Excel không được cài đặt
            if (excelApp == null)
            {
                MessageBox.Show("Excel không được cài đặt trên máy tính của bạn.");
                return;
            }

            // Tạo một workbook và worksheet mới
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            // Đặt tên cho các cột trong Excel từ DataGridView
            for (int i = 0; i < dgv_tinhluong.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgv_tinhluong.Columns[i].HeaderText;
            }

            // Dán dữ liệu vào các ô của Excel
            for (int i = 0; i < dgv_tinhluong.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_tinhluong.Columns.Count; j++)
                {
                    // Kiểm tra dữ liệu không null
                    if (dgv_tinhluong.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv_tinhluong.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = string.Empty;  // Tránh lỗi khi ô trống
                    }
                }
            }

            // Lưu file Excel và chọn đường dẫn lưu
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            saveFileDialog.Title = "Save an Excel File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook.SaveAs(saveFileDialog.FileName);
                    workbook.Close();
                    excelApp.Quit();
                    MessageBox.Show("Dữ liệu đã được xuất ra file Excel thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi khi lưu file Excel: " + ex.Message);
                }
            }
            else
            {
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Không lưu file Excel.");
            }
        }

        private void CustomizeDataGridView(DataGridView dgv)
        {
            // Đặt màu nền xen kẽ cho các hàng
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Đặt màu nền cho tiêu đề
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Căn giữa tiêu đề
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Font chữ cho tiêu đề
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Font chữ cho dữ liệu
            dgv.DefaultCellStyle.Font = new Font("Arial", 11);

            // Căn chỉnh dữ liệu theo từng cột (ví dụ căn giữa)
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Bật chế độ đọc và không cho chỉnh sửa trực tiếp
            dgv.ReadOnly = true;

            // Tự động điều chỉnh độ rộng cột theo nội dung
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        
    }
}
