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
    public partial class QL_NhanVien : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
       // string sqlQuerry;
        public QL_NhanVien()
        {
            InitializeComponent();
            txt_timKiemNV.Text = "Tìm kiếm";
            txt_timKiemNV.ForeColor = Color.Gray;
        }

        private void btn_themNV_Click(object sender, EventArgs e)
        {
            Views.Add_NhanVien add_nhanVien = new Views.Add_NhanVien(this);
            add_nhanVien.ShowDialog();
        }
        private void QL_NhanVien_Load(object sender, EventArgs e)
        {
            dGV_thongTinNV.DataSource = dtb.DataRead("select * from tbNhanVien");


            // Thêm cột vào DataGridView


            dGV_thongTinNV.Columns[0].HeaderText = "Mã nhân viên";
            dGV_thongTinNV.Columns[1].HeaderText = "Tên nhân viên";
            dGV_thongTinNV.Columns[2].HeaderText = "Giới tính";
            dGV_thongTinNV.Columns[3].HeaderText = "Ngày sinh";
            dGV_thongTinNV.Columns[4].HeaderText = "Số điện thoại";
            dGV_thongTinNV.Columns[5].HeaderText = "Lương";
            dGV_thongTinNV.Columns[6].HeaderText = "Ca làm";

            dGV_thongTinNV.Columns[0].ReadOnly = true;
            dGV_thongTinNV.Columns[1].ReadOnly = true;
            dGV_thongTinNV.Columns[2].ReadOnly = true;
            dGV_thongTinNV.Columns[3].ReadOnly = true;
            dGV_thongTinNV.Columns[4].ReadOnly = true;
            dGV_thongTinNV.Columns[5].ReadOnly = true;
            dGV_thongTinNV.Columns[6].ReadOnly = true;

           

            // Tạo 1 DataGridViewButtonColumn
            DataGridViewImageColumn cotSua = new DataGridViewImageColumn();
            cotSua.Image = Properties.Resources.edit_icon_24px;
            DataGridViewImageColumn cotXoa = new DataGridViewImageColumn();
            cotXoa.Image = Properties.Resources.bin_icon_24px;


            cotSua.HeaderText = "";
            cotXoa.HeaderText = " ";

            dGV_thongTinNV.Columns.Add(cotSua);
            dGV_thongTinNV.Columns.Add(cotXoa);

            dGV_thongTinNV.AllowUserToAddRows = false;
            SoLuongDong();
        }

        private void txt_timKiemNV_Enter(object sender, EventArgs e)
        {
            if (txt_timKiemNV.Text == "Tìm kiếm")
            {
                txt_timKiemNV.Text = "";
                txt_timKiemNV.ForeColor = Color.Black;
            }
        }

        private void txt_timKiemNV_Leave(object sender, EventArgs e)
        {
            if(txt_timKiemNV.Text == "")
            {
                txt_timKiemNV.Text = "Tìm kiếm";
                txt_timKiemNV.ForeColor = Color.Gray;
            }
        }

       

        private void dGV_thongTinNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //sửa nhân viên
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn selectedColumn = dGV_thongTinNV.Columns[e.ColumnIndex]; // Lấy cột được chọn
                string columnHeaderText = selectedColumn.HeaderText; // Lấy tiêu đề của cột được chọn

                string[] str = new string[20];

                if (columnHeaderText == "")// Nếu cột được chọn là cột sửa
                {
                    str[1] = dGV_thongTinNV.CurrentRow.Cells[0].Value.ToString();
                    str[2] = dGV_thongTinNV.CurrentRow.Cells[1].Value.ToString();
                    str[3] = dGV_thongTinNV.CurrentRow.Cells[2].Value.ToString();
                    str[4] = dGV_thongTinNV.CurrentRow.Cells[3].Value.ToString();
                    str[5] = dGV_thongTinNV.CurrentRow.Cells[4].Value.ToString();
                    str[6] = dGV_thongTinNV.CurrentRow.Cells[5].Value.ToString();
                    str[7] = dGV_thongTinNV.CurrentRow.Cells[6].Value.ToString();
                    str[8] = dGV_thongTinNV.CurrentRow.Cells[7].Value.ToString();
                    str[9] = dGV_thongTinNV.CurrentRow.Cells[8].Value.ToString();
                    if (str[1] == "System.Drawing.Bitmap") //nếu cột là ảnh thì gán lại giá trị cho các biến
                    {
                        str[1] = str[3];
                        str[2] = str[4];
                        str[3] = str[5];
                        str[4] = str[6];
                        str[5] = str[7];
                        str[6] = str[8];
                        str[7] = str[9];
                        Views.Edit_NhanVien edit_NhanVien = new Views.Edit_NhanVien(this, str);
                        edit_NhanVien.Show();
                        
                    }
                    else
                    {
                        Views.Edit_NhanVien edit_NhanVien = new Views.Edit_NhanVien(this, str);
                        edit_NhanVien.Show();
                    }
                
                }

                //xóa nhân viên
                else if (columnHeaderText == " ")
                {

                    string sql = "";
                    str[1] = dGV_thongTinNV.CurrentRow.Cells[0].Value.ToString(); // 
                    str[3] = dGV_thongTinNV.CurrentRow.Cells[2].Value.ToString(); // 

                    if (str[1] == "System.Drawing.Bitmap") //nếu cột 1 là ảnh thì xóa cột 3 là mã 
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + str[3] + " không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = "Update tbVe set MaNV = null Where MaNV ='" + str[3] + "'";
                            dtb.DataChange(sql);
                            sql = "Delete From tbTaiKhoan where tbTaiKhoan.MaNV ='" + str[3] + "'";
                            dtb.DataChange(sql);
                            sql = "Delete From tbNhanVien where tbNhanVien.MaNV ='" + str[3] + "'";
                            dtb.DataChange(sql);
                            sql = "select * from tbNhanVien";
                            dGV_thongTinNV.DataSource = dtb.DataRead(sql);
                            SoLuongDong();

                        }
                    }
                    else //nếu cột 1 không phải là ảnh thì xóa cột 1 là mã
                    {
                        if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên " + str[1] + " không?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sql = "Update tbHoaDonSP set MaNV = null Where MaNV ='" + str[1] + "'";
                            dtb.DataChange(sql);
                            sql = "Update tbVe set MaNV = null Where MaNV ='" + str[1] + "'";
                            dtb.DataChange(sql);
                            sql = "Delete From tbTaiKhoan where tbTaiKhoan.MaNV ='" + str[1] + "'";
                            dtb.DataChange(sql);
                            sql = "Delete From tbNhanVien where tbNhanVien.MaNV ='" + str[1] + "'";
                            dtb.DataChange(sql);
                            sql = "select * from tbNhanVien";
                            dGV_thongTinNV.DataSource = dtb.DataRead(sql);
                            SoLuongDong();
                        }
                    }
                }
                //chi tiết nhân viên
                else
                {
                    str[1] = dGV_thongTinNV.CurrentRow.Cells[0].Value.ToString();
                    str[2] = dGV_thongTinNV.CurrentRow.Cells[1].Value.ToString();
                    str[3] = dGV_thongTinNV.CurrentRow.Cells[2].Value.ToString();
                    str[4] = dGV_thongTinNV.CurrentRow.Cells[3].Value.ToString();
                    str[5] = dGV_thongTinNV.CurrentRow.Cells[4].Value.ToString();
                    str[6] = dGV_thongTinNV.CurrentRow.Cells[5].Value.ToString();
                    str[7] = dGV_thongTinNV.CurrentRow.Cells[6].Value.ToString();
                    str[8] = dGV_thongTinNV.CurrentRow.Cells[7].Value.ToString();
                    str[9] = dGV_thongTinNV.CurrentRow.Cells[8].Value.ToString();

                    if (str[1] == "System.Drawing.Bitmap")
                    {
                        str[1] = str[3];
                        str[2] = str[4];
                        str[3] = str[5];
                        str[4] = str[6];
                        str[5] = str[7];
                        str[6] = str[8];
                        str[7] = str[9];
                        Views.ChiTiet_NhanVien chitiet_NhanVien = new Views.ChiTiet_NhanVien(this, str);
                        chitiet_NhanVien.Show();

                    }
                    else
                    {
                        Views.ChiTiet_NhanVien chitiet_NhanVien = new Views.ChiTiet_NhanVien(this, str);
                        chitiet_NhanVien.Show();
                    }
                    
                }
            }
        }

        

        public int SoLuongDong()
        {
            int sldong = dGV_thongTinNV.Rows.Count;
            lbl_ketQuaTKNV.Text = "Kết quả: " + sldong.ToString();
            return sldong;
        }

        private void txt_timKiemNV_TextChanged(object sender, EventArgs e)
        {
            string sql = "Select * from tbNhanVien Where MaNV is not null";
            if (txt_timKiemNV.Text.Trim() == "" || txt_timKiemNV.Text.Trim() == "Tìm kiếm")//nếu ô tìm kiếm trống hoặc chứa chữ "Tìm kiếm" thì hiển thị tất cả
            {
                dGV_thongTinNV.DataSource = dtb.DataRead("Select * from tbNhanVien");
                SoLuongDong();
            }
            else //
            {
                sql += " AND TenNV LIKE N'%" + txt_timKiemNV.Text + "%'"; //tìm kiếm theo tên nhân viên
                dGV_thongTinNV.DataSource = dtb.DataRead(sql);
                SoLuongDong();
            }
            
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
