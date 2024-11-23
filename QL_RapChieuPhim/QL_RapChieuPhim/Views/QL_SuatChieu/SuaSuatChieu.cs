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
        public SuaSuatChieu()
        {
            InitializeComponent();
        }
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();
        Views.QL_SuatChieu QL_SuatChieu;
        string[] strData;
        //Views.QL_SuatChieu qlsc = new QL_SuatChieu();
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public SuaSuatChieu(Views.QL_SuatChieu qL_SuatChieu, string[] str)
        {
            this.QL_SuatChieu = qL_SuatChieu;
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
            string chiDuLai = new string(thoiLuongPhimStr.Where(char.IsDigit).ToArray());
            if (int.TryParse(chiDuLai, out int thoiLuongPhim))
            {
                Console.WriteLine(thoiLuongPhim);
                gioKetThuc = gioChieu.AddMinutes(thoiLuongPhim);
                txtSuatChieu2.Text = gioKetThuc.ToString("HH:mm tt");
            }


        }

        private void SuaSuatChieu_Load(object sender, EventArgs e)
        {
            addtextbox(strData);
            DataTable dt = dataBase.DataRead("select MaPhong from tbXuatChieu where MaXuatChieu = '" + strData[3] + "'");
            string MP = dt.Rows[0]["MaPhong"].ToString();
            DataTable dt2 = dataBase.DataRead("select * from tbGhe inner join tbPhongChieu on tbGhe.MaPhong = tbPhongChieu.MaPhong inner join tbXuatChieu on tbPhongChieu.MaPhong = tbXuatChieu.MaPhong where tbGhe.MaPhong = '"+MP+"'");
            foreach (DataRow row in dt2.Rows)
            {
                foreach (Control control in this.Controls)
                {
                    if (control is RJButton)
                    {
                        if (control.Text == row["SoGhe"].ToString())
                        {
                            if (row["TrangThai"].ToString() == "False")
                            {
                                control.BackColor = Color.Red;
                            }
                            
                        }
                        
                    }
                }
            }

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            DataTable dt = dataBase.DataRead("select MaPhong from tbXuatChieu where MaXuatChieu = '" + strData[3] + "'");
            string MP = dt.Rows[0]["MaPhong"].ToString();
            
            string sql3 = "Update tbGhe set TrangThai = 1 WHERE MaPhong = '" + MP + "'";
            dataBase.DataChange(sql3);
            
            if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã phòng này không ? Nếu  có  ấn  nút  Yes, không  thì  ấn  nút  No", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql0 = $"Update tbVe set MaXuatChieu = Null \r\nWHERE MaXuatChieu = '{strData[3]}';";
                dataBase.DataChange(sql0);

                string sql1 = $"DELETE FROM tbXuatChieu\r\nWHERE MaXuatChieu = '{strData[3]}';";
                dataBase.DataChange(sql1);

                string sql2 = "SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + strData[2] + "' ";
                QL_SuatChieu.dgv_SuatChieu.DataSource = dataBase.DataRead(sql2);
                this.Close();
            }

                
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
