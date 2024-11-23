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
    public partial class ChamCong : Form
    {
        Database.DatabaseAccess dtbase = new Database.DatabaseAccess();
        DataTable dt;
        string dtNgayChieu;
        string MaNV;
        public ChamCong(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {
            txt_manhanvien.Text = MaNV;

            dt = dtbase.DataRead("SELECT * FROM tbNhanVien where MaNV='"+MaNV+"'");
            if (dt.Rows.Count > 0)
            {
                txt_tennhanvien.Text = dt.Rows[0]["TenNV"].ToString();
            }

            txt_ngaygio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");


            loadData();

        }

        private void FormatDataGridView()
        {
            // Đặt chế độ tự động điều chỉnh cột
            dgv_chamcong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_chamcong.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Đặt tiêu đề cột
            dgv_chamcong.Columns["id"].HeaderText = "Mã CC";
            dgv_chamcong.Columns["idnhanvien"].HeaderText = "Mã NV";
            dgv_chamcong.Columns["TenNV"].HeaderText = "Tên Nhân Viên";
            dgv_chamcong.Columns["gio"].HeaderText = "Giờ";
            dgv_chamcong.Columns["ngay"].HeaderText = "Ngày";
            dgv_chamcong.Columns["thang"].HeaderText = "Tháng";
            dgv_chamcong.Columns["nam"].HeaderText = "Năm";
            dgv_chamcong.Columns["noidung"].HeaderText = "Nội Dung";
            dgv_chamcong.Columns["SDT"].HeaderText = "SĐT";

            // Ẩn cột nếu cần
            dgv_chamcong.Columns["id"].Visible = false; // Ví dụ: Ẩn cột id nếu không cần thiết

            // Căn chỉnh dữ liệu trong các cột
            dgv_chamcong.Columns["gio"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_chamcong.Columns["ngay"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_chamcong.Columns["thang"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv_chamcong.Columns["nam"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Định dạng kiểu dữ liệu nếu cần
            dgv_chamcong.Columns["gio"].DefaultCellStyle.Format = "00";
            dgv_chamcong.Columns["ngay"].DefaultCellStyle.Format = "00";
            dgv_chamcong.Columns["thang"].DefaultCellStyle.Format = "00";
            dgv_chamcong.Columns["nam"].DefaultCellStyle.Format = "0000";

            // Đặt màu nền xen kẽ
            dgv_chamcong.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            //// Chuyển đổi chuỗi ngày giờ thành đối tượng DateTime
            //DateTime ngayGio = DateTime.ParseExact(txt_ngaygio.Text, "dd/MM/yyyy HH:mm:ss", null);

            //// Lấy giờ, ngày, tháng và năm từ đối tượng DateTime
            //int gio = ngayGio.Hour;
            //int ngay = ngayGio.Day;
            //int thang = ngayGio.Month;
            //int nam = ngayGio.Year;

            //dt = dtbase.DataRead("Select * from tbChamCong where idnhanvien='"+MaNV+"' AND ngay='"+ngay+"' AND thang='"+thang+"' AND nam='"+nam+"'");
            //if (dt.Rows.Count > 0)
            //{
            //    btn_chamcong.Enabled = false;
            //    MessageBox.Show("Bạn đã chấm công cho ngày hôm nay rồi!");
            //}
            //else
            //{

            //    var sql = "INSERT INTO tbChamCong (idnhanvien, gio, ngay, thang, nam, noidung) " +
            //              "VALUES('" + txt_manhanvien.Text + "', '" + gio + "', '" + ngay + "', '" + thang + "', '" + nam + "','" + txt_noidung.Text + "')";

            //    dtbase.DataChange(sql);
            //    MessageBox.Show("Chấm công thành công!");
            //    loadData() ;
            //}
        }
        void loadData()
        {
            dt = dtbase.DataRead("SELECT cc.id,cc.idnhanvien,nv.TenNV,cc.gio,cc.ngay,cc.thang,cc.nam,cc.noidung,nv.SDT " +
                           " FROM tbChamCong as cc" +
                           " inner join tbNhanVien as nv on nv.MaNV=idnhanvien");
            dgv_chamcong.DataSource = dt;

            FormatDataGridView();

        }

        private void dgv_chamcong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            // Chuyển đổi chuỗi ngày giờ thành đối tượng DateTime
            DateTime ngayGio = DateTime.ParseExact(txt_ngaygio.Text, "dd/MM/yyyy HH:mm:ss", null);

            // Lấy giờ, ngày, tháng và năm từ đối tượng DateTime
            int gio = ngayGio.Hour;
            int ngay = ngayGio.Day;
            int thang = ngayGio.Month;
            int nam = ngayGio.Year;

            dt = dtbase.DataRead("Select * from tbChamCong where idnhanvien='" + MaNV + "' AND ngay='" + ngay + "' AND thang='" + thang + "' AND nam='" + nam + "'");
            if (dt.Rows.Count > 0)
            {
                btnChamCong.Enabled = false;
                MessageBox.Show("Bạn đã chấm công cho ngày hôm nay rồi!");
            }
            else
            {

                var sql = "INSERT INTO tbChamCong (idnhanvien, gio, ngay, thang, nam, noidung) " +
                          "VALUES('" + txt_manhanvien.Text + "', '" + gio + "', '" + ngay + "', '" + thang + "', '" + nam + "','" + txt_noidung.Text + "')";

                dtbase.DataChange(sql);
                MessageBox.Show("Chấm công thành công!");
                loadData();
            }
        }

        private void txtmaNV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
