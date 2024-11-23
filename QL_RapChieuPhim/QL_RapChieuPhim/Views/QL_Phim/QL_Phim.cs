using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Views
{
    public partial class QL_Phim : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQuerry;
        //tạo biến lưu dư liệu từ database
        private DataTable initialData;
        
        public QL_Phim()
        {
            InitializeComponent();
        }

       

        private void btn_ThemPhim_Click(object sender, EventArgs e)
        {
            Views.Add_Phim add_Phim = new Views.Add_Phim(this);
            add_Phim.ShowDialog();  
        }

        public void QL_Phim_Load(object sender, EventArgs e)
        {
            sqlQuerry = "select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim";
            initialData = dtb.DataRead(sqlQuerry);
            
            dgv_dataPhim.DataSource = initialData; ;
             //Tạo một DataGridViewButtonColumn
            DataGridViewImageColumn imageColumn_edit = new DataGridViewImageColumn();
            imageColumn_edit.Image = Properties.Resources.edit_icon;
            DataGridViewImageColumn imageColumn_delete = new DataGridViewImageColumn();
            imageColumn_delete.Image = Properties.Resources.delete_icon;

            imageColumn_edit.HeaderText = "";
            imageColumn_delete.HeaderText = " ";


             //Thêm cột vào DataGridView
            dgv_dataPhim.Columns.Add(imageColumn_edit);
            dgv_dataPhim.Columns.Add(imageColumn_delete);
            dgv_dataPhim.AllowUserToAddRows = false;

            

        }

       


        private void dgv_dataPhim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn selectedColumn = dgv_dataPhim.Columns[e.ColumnIndex];
                string columnHeaderText = selectedColumn.HeaderText;

                string[] str = new string[10];

                if (columnHeaderText == "")
                {
                    str[1] = dgv_dataPhim.CurrentRow.Cells[2].Value.ToString();
                    str[2] = dgv_dataPhim.CurrentRow.Cells[3].Value.ToString();
                    str[3] = dgv_dataPhim.CurrentRow.Cells[4].Value.ToString();
                    str[4] = dgv_dataPhim.CurrentRow.Cells[5].Value.ToString();
                    str[5] = dgv_dataPhim.CurrentRow.Cells[6].Value.ToString();
                    str[6] = dgv_dataPhim.CurrentRow.Cells[7].Value.ToString();
                    str[7] = dgv_dataPhim.CurrentRow.Cells[8].Value.ToString();
                    str[8] = dtb.selectColumn("select MoTa from tbPhim where MaPhim like '" + str[1] + "'");
                    str[9] = dtb.selectColumn("select Anh from tbPhim where MaPhim like '" + str[1] + "'");
                    Views.Edit_Phim edit_Phim = new Views.Edit_Phim(this, str);
                    edit_Phim.ShowDialog();
                }
                else if (columnHeaderText == " ")
                {
                    string sql = "";
                    str[1] = dgv_dataPhim.CurrentRow.Cells[2].Value.ToString();
                    if (MessageBox.Show("Bạn  có  chắc  chắn  xóa  mã phim   " + str[1] + " không ? Nếu  có  ấn  nút  Yes, không  thì  ấn  nút  No", "Xóa  sản  phẩm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        DataTable dtable = dtb.DataRead("select * from tbXuatChieu where MaPhim ='" + str[1] +"'");
                        foreach (DataRow row in dtable.Rows)
                        {
                            dtb.DataChange("update tbVe set MaXuatChieu = NULL where MaXuatChieu = '" + row["MaXuatChieu"].ToString() + "'");
                        }
                            dtb.DataChange("Delete From tbXuatChieu Where MaPhim ='" + str[1] + "'");
                        sql = "Delete From tbPhim Where MaPhim ='" + str[1] + "'";
                        dtb.DataChange(sql);
                        sql = "select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim";
                        dgv_dataPhim.DataSource = dtb.DataRead(sql);
                    }
                }
                else
                {
                    str[1] = dgv_dataPhim.CurrentRow.Cells[2].Value.ToString();
                    str[2] = dgv_dataPhim.CurrentRow.Cells[3].Value.ToString();
                    str[3] = dgv_dataPhim.CurrentRow.Cells[4].Value.ToString();
                    str[4] = dgv_dataPhim.CurrentRow.Cells[5].Value.ToString();
                    str[5] = dgv_dataPhim.CurrentRow.Cells[6].Value.ToString();
                    str[6] = dgv_dataPhim.CurrentRow.Cells[7].Value.ToString();
                    str[7] = dgv_dataPhim.CurrentRow.Cells[8].Value.ToString();
                    str[8] = dtb.selectColumn("select MoTa from tbPhim where MaPhim like '" + str[1] + "'");
                    str[9] = dtb.selectColumn("select Anh from tbPhim where MaPhim like '" + str[1] + "'");
                    Views.ChiTiet_Phim ct_phim = new Views.ChiTiet_Phim(this, str);
                    ct_phim.ShowDialog();
                    
                }
            }


        }

        private void txt_timkiem_phim_TextChanged(object sender, EventArgs e)
        {

            if (txt_timkiem_phim.Text != "")
            {
                sqlQuerry = "select MaPhim as N'Mã Phim', TenPhim as N'Tên Phim', MaTheLoai as N'Mã Thể Loại', TenDD as N'Tên Đạo Diễn', QuocGia as N'Quốc Gia', Year(NamSX) as N' Năm sản Xuất', ThoiLuongPhim as N'Thời Lượng Phim' from tbPhim where TenPhim like N'%" + txt_timkiem_phim.Text + "%'";
                dgv_dataPhim.DataSource = dtb.DataRead(sqlQuerry);
            }
            else if (txt_timkiem_phim.Text == "")
            {
                dgv_dataPhim.DataSource = initialData;
                
            }
        }
        private void txt_timkiem_phim_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_dataPhim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_timkiem_phim_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_timkiem_phim_Enter(object sender, EventArgs e)
        {

           
        }

        private void txt_timkiem_phim_Leave(object sender, EventArgs e)
        {
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
