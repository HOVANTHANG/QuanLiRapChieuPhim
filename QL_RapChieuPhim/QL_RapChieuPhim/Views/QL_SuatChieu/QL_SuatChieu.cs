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
        private Button currentBtn;
        private Panel leftBorderbtn;
        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();
        string sql = "";
        private DataTable initialData;
        public QL_SuatChieu()
        {
            InitializeComponent();
            leftBorderbtn = new Panel();
            leftBorderbtn.Size = new Size(7, 44);
            panelMenu.Controls.Add(leftBorderbtn);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (Button)senderBtn;
                currentBtn.BackColor = Color.FromArgb(255, 255, 255);
                currentBtn.ForeColor = color;

                leftBorderbtn.BackColor = color;
                leftBorderbtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderbtn.Visible = true;
                leftBorderbtn.BringToFront();

            }
        }

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
            dtpNgaySuatChieu.Value = DateTime.Now;

            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' ");
            DataGridViewImageColumn imageColumn_edit = new DataGridViewImageColumn();
            imageColumn_edit.Image = Properties.Resources.edit_icon;
            imageColumn_edit.HeaderText = "";

            dgv_SuatChieu.Columns.Add(imageColumn_edit);
            dgv_SuatChieu.AllowUserToAddRows = false;
        }

        private void btnToanBo_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n   XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' ");

        }

        private void btnPhong1_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n     XC.CaChieu AS [Giờ Chiếu]\r\n FROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim INNER JOIN tbPhongChieu AS PC on XC.MaPhong = PC.MaPhong \r\nWHERE PC.MaPhong = 'R001'\r\n\tand NgayChieu =  '" + dtNgayChieu + "'");
        }

        private void btnPhong2_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n     XC.CaChieu AS [Giờ Chiếu]\r\n FROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim INNER JOIN tbPhongChieu AS PC on XC.MaPhong = PC.MaPhong \r\nWHERE PC.MaPhong = 'R002'\r\n\tand NgayChieu =  '" + dtNgayChieu + "'");

        }
        private void btnPhong3_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n     XC.CaChieu AS [Giờ Chiếu]\r\n FROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim INNER JOIN tbPhongChieu AS PC on XC.MaPhong = PC.MaPhong \r\nWHERE PC.MaPhong = 'R003'\r\n\tand NgayChieu =  '" + dtNgayChieu + "'");

        }
        private void btnPhong4_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n     XC.CaChieu AS [Giờ Chiếu]\r\n FROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim INNER JOIN tbPhongChieu AS PC on XC.MaPhong = PC.MaPhong \r\nWHERE PC.MaPhong = 'R004'\r\n\tand NgayChieu =  '" + dtNgayChieu + "'");

        }
        private void btnPhong5_Click(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            ActivateButton(sender, Color.FromArgb(13, 183, 253));
            dgv_SuatChieu.DataSource = dataBase.DataRead("SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n     XC.CaChieu AS [Giờ Chiếu]\r\n FROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim INNER JOIN tbPhongChieu AS PC on XC.MaPhong = PC.MaPhong \r\nWHERE PC.MaPhong = 'R005'\r\n\tand NgayChieu =  '" + dtNgayChieu + "'");


        }
        private void dgv_dataPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void btn_Them_Click(object sender, EventArgs e)
        {
            ThemSuatChieu themSuatChieu = new ThemSuatChieu(this);
            themSuatChieu.ShowDialog();

        }


        private void dgv_SuatChieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn selectedColumn = dgv_SuatChieu.Columns[e.ColumnIndex];
                string columnHeaderText = selectedColumn.HeaderText;

                string[] str = new string[10];

                if (columnHeaderText == "")
                {
                    //tenphim
                    str[1] = dgv_SuatChieu.CurrentRow.Cells[2].Value.ToString();
                    //ngaychieu
                    str[2] = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
                    //maSuatChieu
                    str[3] = dgv_SuatChieu.CurrentRow.Cells[1].Value.ToString();
                    //cachieu
                    str[4] = dgv_SuatChieu.CurrentRow.Cells[5].Value.ToString();
                    //ThoiLuongPhim
                    str[5] = dgv_SuatChieu.CurrentRow.Cells[4].Value.ToString();

                    Views.SuaSuatChieu suaSuatChieu = new SuaSuatChieu(this, str);
                    suaSuatChieu.ShowDialog();
                }


            }
        }

        private void dtpNgaySuatChieu_MouseEnter(object sender, EventArgs e)
        {
            /*DateTime dtNgayChieu = Convert.ToDateTime(dtpNgaySuatChieu.Text.Trim())
            string sql = "SELECT\r\n    P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbChiTietVe AS CTV ON P.MaPhim = CTV.MaPhim\r\nINNER JOIN tbXuatChieu AS XC ON CTV.MaXuatChieu = XC.MaXuatChieu\r\nwhere NgayChieu = '" + string.Format("{0:yyyy/MM/dd}", dtNgayChieu) + "'";
            dgv_SuatChieu.DataSource = dataBase.DataReader(sql);*/
        }

        private void dtpNgaySuatChieu_ValueChanged(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' ";
            dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string dtNgayChieu = dtpNgaySuatChieu.Value.ToString("yyyy-MM-dd");
            string sql = "SELECT\r\n    XC.MaXuatChieu as [Mã suất chiếu], P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' and P.TenPhim like N'%" + txt_TimKiem.Text + "%' ";

            string sql1 = "SELECT\r\n   XC.MaXuatChieu as [Mã suất chiếu],  P.TenPhim AS [Tên Phim],\r\n    TL.LoaiPhim AS [Loại Phim],\r\n    P.ThoiLuongPhim AS [Thời Lượng],\r\n    XC.CaChieu AS [Giờ Chiếu]\r\nFROM tbPhim AS P\r\nINNER JOIN tbTheLoaiPhim AS TL ON P.MaTheLoai = TL.MaTheLoai\r\nINNER JOIN tbXuatChieu AS XC ON P.MaPhim = XC.MaPhim\r\nwhere NgayChieu = '" + dtNgayChieu + "' ";
            initialData = dataBase.DataRead(sql1);

            if (txt_TimKiem.Text != "")
            {
                dgv_SuatChieu.DataSource = dataBase.DataRead(sql);
            }
            else
            {
                dgv_SuatChieu.DataSource = initialData;
            }

        }
    }
}
