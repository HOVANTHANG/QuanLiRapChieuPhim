using QL_RapChieuPhim.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QL_RapChieuPhim.Views
{
    public partial class ThemSuatChieu : Form
    {
        Function_SinhMaTuDong ft = new Function_SinhMaTuDong();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        ChoPhepKyTu cpkt = new ChoPhepKyTu();
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();

        Views.QL_SuatChieu qlsc = new QL_SuatChieu();
        public ThemSuatChieu(QL_SuatChieu qlsc)
        {
            InitializeComponent();
            this.qlsc = qlsc;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void UpdateGiaVe()
        {
            DateTime gioSuatChieu = dtpGioSuatChieu.Value;
            int gio = gioSuatChieu.Hour;

            int giaVe = 0;

            if (gio >= 7 && gio < 17)
            {
                giaVe = 10000;
            }
            else if (gio >= 17 && gio < 24)
            {
                giaVe = 20000;
            }
            else if (gio >= 0 && gio < 3)
            {
                giaVe = 30000;
            }
            txtGiaVe.Text = giaVe.ToString();

        }

        private void dtpGioSuatChieu_Validating(object sender, CancelEventArgs e)
        {
            DateTime gioSuatChieu = dtpGioSuatChieu.Value;
            int gio = gioSuatChieu.Hour;
            int phut = gioSuatChieu.Minute;

            if (gio >= 3 && gio < 7) // 3 < gio < 7
            {
                e.Cancel = true;
                MessageBox.Show("Cửa hàng đã đóng cửa vào thời điểm từ 3:00 AM đến 7:00 AM .", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dtpGioSuatChieu_ValueChanged(object sender, EventArgs e)
        {

            UpdateGiaVe();
        }
        private void cboPhongChieu_MouseDown(object sender, MouseEventArgs e)
        {
            string sql = "select * from tbPhongChieu";
            cboPhongChieu.DataSource = dataBase.DataRead(sql);
            cboPhongChieu.DisplayMember = "TenPhong";
            cboPhongChieu.ValueMember = "MaPhong";
        }
        private void cboTenPhim_MouseDown(object sender, MouseEventArgs e)
        {
            string sql = "select * from tbPhim";
            cboTenPhim.DataSource = dataBase.DataRead(sql);
            cboTenPhim.DisplayMember = "TenPhim";
            cboTenPhim.ValueMember = "MaPhim";
        }

        private bool KiemTraTrungLap(string ngayChieu, string gioBatDau, string maPhong, int thoiLuongPhim)
        {
            string storedProcedure = "CheckTrungLap";

            SqlParameter[] parameters =
            {
                 new SqlParameter("@TrungLap", SqlDbType.Bit) { Direction = ParameterDirection.Output },
                 new SqlParameter("@NgayChieu", SqlDbType.DateTime) { Value = ngayChieu },
                 new SqlParameter("@GioBatDau", SqlDbType.Time) { Value = gioBatDau },
                 new SqlParameter("@PhongChieu", SqlDbType.VarChar, 10) { Value = maPhong },
                 new SqlParameter("@ThoiLuongPhim", SqlDbType.Int) { Value = thoiLuongPhim }
             };

            try
            {
                dataBase.ExecuteStoredProcedure(storedProcedure, parameters);

                bool trungLap = (bool)parameters[0].Value;

                return trungLap;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi kiểm tra trùng lặp: " + ex.Message);
                return false;
            }
        }



        private void btn_luuPhim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cboTenPhim.Text))
            {
                ErrorMes.SetError(cboTenPhim, "Hãy nhập mã mặt hàng!");
            }
            else if (string.IsNullOrWhiteSpace(cboPhongChieu.Text))
            {
                ErrorMes.Clear();
                ErrorMes.SetError(cboPhongChieu, "Hãy nhập mã mặt hàng!");

            }
            else if (string.IsNullOrWhiteSpace(txtGiaVe.Text))
            {
                ErrorMes.Clear();
                ErrorMes.SetError(txtGiaVe, "Hãy nhập mã mặt hàng!");
            }
            else
            {
                ErrorMes.Clear();



                DateTime gioChieu = dtpGioSuatChieu.Value;
                DateTime gioBatDau = dtpGioSuatChieu.Value;
                string gioBatDauString = gioBatDau.ToString("HH:mm");

                //Lấy thời lượng phim
                string sql = "select ThoiLuongPhim\r\nfrom tbPhim\r\nwhere MaPhim = '" + cboTenPhim.SelectedValue.ToString() + "'";
                DataTable result = dataBase.DataRead(sql);
                string thoiLuongPhimStr = result.Rows[0]["ThoiLuongPhim"].ToString();


                string chiDuLai = new string(thoiLuongPhimStr.Where(char.IsDigit).ToArray());


                int thoiLuongChieuPhim = int.Parse(chiDuLai);
                //MessageBox.Show(KiemTraTrungLap(dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd"), gioBatDauString, cboPhongChieu.SelectedValue.ToString(),  thoiLuongChieuPhim).ToString());
                //MessageBox.Show(thoiLuongChieuPhim.ToString());

                if (KiemTraTrungLap(dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd"), gioBatDauString, cboPhongChieu.SelectedValue.ToString(), thoiLuongChieuPhim))
                {
                    //MessageBox.Show("Lịch chiếu trùng lặp trong khoảng giờ này ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageError error = new MessageError();
                    error.ShowDialog();
                    return;
                }
                else
                {
                    MessageSuccess messageSuccess = new MessageSuccess("Thêm suất chiếu thành công");
                    messageSuccess.ShowDialog();
                    if (result.Rows.Count > 0)
                    {
                        if (int.TryParse(chiDuLai, out int thoiLuongPhim))
                        {
                            Console.WriteLine(thoiLuongPhim);
                            gioChieu = gioChieu.AddMinutes(thoiLuongPhim);
                            lblGioChieu.Text = "  Giờ chiếu: " + dtpGioSuatChieu.Text + "  ->  " + gioChieu.ToString("HH:mm");

                        }
                    }
                    lblTenPhim.Text = cboTenPhim.Text;
                    lblNgayChieu.Text = "  Ngày chiếu: " + dtpNgaySuatChieu.Text;
                    lblPhongChieu.Text = "  Phòng chiếu: " + cboPhongChieu.Text;
                    lblGiaVe.Text = "  Giá vé: " + txtGiaVe.Text + " VND";
                    string maSuatChieu = ft.SinhMaTuDong("tbXuatChieu", 'X', "MaXuatChieu");
                   // string maVe = ft.SinhMaTuDong("tbChiTietVe", 'V', "MaVe");
                    string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
                    string gioSuatChieu = dtpGioSuatChieu.Value.ToString("HH:mm");

                    string them = "INSERT INTO [dbo].[tbXuatChieu] ([MaXuatChieu], [NgayChieu], [CaChieu], [TienVe], [MaPhim], [MaPhong])\r\nVALUES\r\n('" + maSuatChieu + "', '" + dtNgayChieu + "', '" + gioSuatChieu + "','" + txtGiaVe.Text + "' , '" + cboTenPhim.SelectedValue.ToString() + "', '" + cboPhongChieu.SelectedValue.ToString() + "')";
                    dataBase.DataChange(them);
                    qlsc.dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' ");
                    qlsc.dtpNgaySuatChieu.Text = dtNgayChieu;
                    if(lblTenPhim.Text !=  "") btn_luuPhim.Enabled = false;
                }

            }


        }


        private void ThemSuatChieu_Load(object sender, EventArgs e)
        {
            UpdateGiaVe();
            dtpNgaySuatChieu.Value = DateTime.Now;
        }

        private void txtGiaVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            cpkt.KeyPress_DungKieuSo(sender, e);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
