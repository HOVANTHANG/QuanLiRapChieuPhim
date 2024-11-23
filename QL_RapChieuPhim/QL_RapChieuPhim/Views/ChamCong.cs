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

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            // Chuyển đổi chuỗi ngày giờ thành đối tượng DateTime
            DateTime ngayGio = DateTime.ParseExact(txt_ngaygio.Text, "dd/MM/yyyy HH:mm:ss", null);

            // Lấy giờ, ngày, tháng và năm từ đối tượng DateTime
            int gio = ngayGio.Hour;
            int ngay = ngayGio.Day;
            int thang = ngayGio.Month;
            int nam = ngayGio.Year;

            dt = dtbase.DataRead("Select * from tbChamCong where idnhanvien='"+MaNV+"' AND ngay='"+ngay+"' AND thang='"+thang+"' AND nam='"+nam+"'");
            if (dt.Rows.Count > 0)
            {
                btn_chamcong.Enabled = false;
                MessageBox.Show("Bạn đã chấm công cho ngày hôm nay rồi!");
            }
            else
            {

                var sql = "INSERT INTO tbChamCong (idnhanvien, gio, ngay, thang, nam, noidung) " +
                          "VALUES('" + txt_manhanvien.Text + "', '" + gio + "', '" + ngay + "', '" + thang + "', '" + nam + "','" + txt_noidung.Text + "')";

                dtbase.DataChange(sql);
                MessageBox.Show("Chấm công thành công!");
                loadData() ;
            }
        }
        void loadData()
        {
            dt = dtbase.DataRead("SELECT cc.id,cc.idnhanvien,nv.TenNV,cc.gio,cc.ngay,cc.thang,cc.nam,cc.noidung,nv.SDT " +
                           " FROM tbChamCong as cc" +
                           " inner join tbNhanVien as nv on nv.MaNV=idnhanvien");
            dgv_chamcong.DataSource = dt;

        }
    }
}
