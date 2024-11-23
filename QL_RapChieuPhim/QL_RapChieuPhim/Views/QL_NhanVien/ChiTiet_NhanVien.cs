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
    public partial class ChiTiet_NhanVien : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        Views.QL_NhanVien ql;
        string[] strData;
        public ChiTiet_NhanVien(QL_NhanVien qlNV, string[] str)
        {
            InitializeComponent();
            this.ql = qlNV;
            strData = str;
        }

        public void addDuLieu(string[] str)
        {
            txt_chiTietMNV.Text = str[1];
            txt_chiTietHoTen.Text = str[2];
            txt_chiTietGioiTinh.Text = str[3];
            dTP_chiTietNgaySinh.Text = str[4];
            txt_chiTietSoDT.Text = str[5];
            txt_chiTietLuong.Text = str[6];
            dTP_chiTietCaLam.Text = str[7];
            txt_chiTietTaiKhoan.Text = dtb.selectColumn("select TenDN from tbTaiKhoan where MaNV = '" + str[1] + "'");
        }

        private void ChiTiet_NhanVien_Load(object sender, EventArgs e)
        {
            addDuLieu(strData);
        }

        private void btn_close_chiTietNhanVien_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
