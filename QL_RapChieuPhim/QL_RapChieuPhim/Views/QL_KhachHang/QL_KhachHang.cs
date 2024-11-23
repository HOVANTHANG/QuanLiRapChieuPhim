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
    public partial class QL_KhachHang : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQuerry;
        private DataTable initialData;
        public QL_KhachHang()
        {
            InitializeComponent();
           // txt_timKiemKH.Text = "Tìm kiếm";
            //txt_timKiemKH.ForeColor = Color.Gray;
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            Views.Add_KhachHang add_khachHang = new Views.Add_KhachHang(this);
            add_khachHang.Show();
        }

        private void txt_timKiemKH_Enter(object sender, EventArgs e)
        {/*
            if (txt_timKiemKH.Text == "Tìm kiếm")
            {
                txt_timKiemKH.Text = "";
                txt_timKiemKH.ForeColor = Color.Black;
            }*/
        }

        private void txt_timKiemKH_Leave(object sender, EventArgs e)
        {/*
            if (txt_timKiemKH.Text == "")
            {
                txt_timKiemKH.Text = "Tìm kiếm";
                txt_timKiemKH.ForeColor = Color.Gray;
            }*/
        }

        private void dGV_thongTinKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn selectedColumn = dGV_thongTinKH.Columns[e.ColumnIndex];
                string columnHeaderText = selectedColumn.HeaderText;

                string[] str = new string[10];
                if(columnHeaderText == "")
                {
                    str[1] = dGV_thongTinKH.CurrentRow.Cells[2].Value.ToString();
                    str[2] = dGV_thongTinKH.CurrentRow.Cells[3].Value.ToString();
                    str[3] = dGV_thongTinKH.CurrentRow.Cells[4].Value.ToString();
                    str[4] = dGV_thongTinKH.CurrentRow.Cells[5].Value.ToString();
                    str[5] = dGV_thongTinKH.CurrentRow.Cells[6].Value.ToString();
                    Views.Edit_KhachHang edit_khachHang = new Views.Edit_KhachHang(this, str);
                    edit_khachHang.Show();
                }
                else if(columnHeaderText == " ")
                {
                    string sql = "";
                    str[1] = dGV_thongTinKH.CurrentRow.Cells[2].Value.ToString();
                    if(MessageBox.Show("Bạn có chắc muốn xóa khách hàng " + str[1] + " không?", "Xóa khách hàng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        sql = "Delete From tbVe where MaKH ='" + str[1] + "'";
                        dtb.DataChange(sql);
                        sql = "Delete From tbKhachHang where TenTKKH ='" + str[1] + "'";
                        dtb.DataChange(sql);
                        sql = "select TenTKKH, TenKH, GioiTinh, NTNS, SDT from tbKhachHang";
                        dGV_thongTinKH.DataSource = dtb.DataRead(sql);
                        SoLuongDongKH();
                    }
                }
                else
                {
                    str[1] = dGV_thongTinKH.CurrentRow.Cells[2].Value.ToString();
                    str[2] = dGV_thongTinKH.CurrentRow.Cells[3].Value.ToString();
                    str[3] = dGV_thongTinKH.CurrentRow.Cells[4].Value.ToString();
                    str[4] = dGV_thongTinKH.CurrentRow.Cells[5].Value.ToString();
                    str[5] = dGV_thongTinKH.CurrentRow.Cells[6].Value.ToString();
                    Views.ChiTiet_KhachHang chitiet_khachHang = new Views.ChiTiet_KhachHang(this, str);
                    chitiet_khachHang.Show();
                }
            }
        }

        private void QL_KhachHang_Load(object sender, EventArgs e)
        {
            
            initialData = dtb.DataRead("select * from tbKhachHang");
            dGV_thongTinKH.DataSource = initialData;
            // Tạo 1 DataGridViewButtonColumn
            DataGridViewImageColumn cotSua = new DataGridViewImageColumn();
            cotSua.Image = Properties.Resources.edit_icon_24px;
            DataGridViewImageColumn cotXoa = new DataGridViewImageColumn();
            cotXoa.Image = Properties.Resources.bin_icon_24px;

            cotSua.HeaderText = "";
            cotXoa.HeaderText = " ";

            // Thêm cột vào DataGridView
            dGV_thongTinKH.Columns.Add(cotSua);
            dGV_thongTinKH.Columns.Add(cotXoa);
            dGV_thongTinKH.AllowUserToAddRows = false;

            dGV_thongTinKH.Columns[0].HeaderText = "Mã khách hàng";
            dGV_thongTinKH.Columns[1].HeaderText = "Tên khách hàng";
            dGV_thongTinKH.Columns[2].HeaderText = "Giới tính";
            dGV_thongTinKH.Columns[3].HeaderText = "Ngày sinh";
            dGV_thongTinKH.Columns[4].HeaderText = "Số điện thoại";

            dGV_thongTinKH.Columns[0].ReadOnly = true;
            dGV_thongTinKH.Columns[1].ReadOnly = true;
            dGV_thongTinKH.Columns[2].ReadOnly = true;
            dGV_thongTinKH.Columns[3].ReadOnly = true;
            dGV_thongTinKH.Columns[4].ReadOnly = true;

            SoLuongDongKH();
        }

        public int SoLuongDongKH()
        {
            int sldong = dGV_thongTinKH.Rows.Count;
            lbl_ketQuaTKKH.Text = "Kết quả: " + sldong.ToString();
            return sldong;
        }

        private void dGV_thongTinKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_timKiemKH_TextChanged(object sender, EventArgs e)
        {
            if (txt_timKiemKH.Text != "")
            {
                sqlQuerry = "select * from tbKhachHang where TenKH like N'%" + txt_timKiemKH.Text + "%'";
                dGV_thongTinKH.DataSource = dtb.DataRead(sqlQuerry);
            }
            else if (txt_timKiemKH.Text == "")
            {
                dGV_thongTinKH.DataSource = initialData;

            }
        }
    }
}
