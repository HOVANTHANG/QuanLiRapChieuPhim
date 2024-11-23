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
    public partial class ChiTiet_KhachHang : Form
    {
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        string sqlQUery;
        Views.QL_KhachHang qlKH;
        string[] strData;

        public ChiTiet_KhachHang(Views.QL_KhachHang qlkh, string[] str)
        {
            InitializeComponent();
            this.qlKH = qlkh;
            strData = str;
        }

        private void btn_close_chiTietKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void addDuLieu(string[] str)
        {
            txt_chiTietTKKH.Text = str[1];
            txt_chiTietHoTenKH.Text = str[2];
            txt_chiTietGioiTinhKH.Text = str[3];
            dTP_chiTietNgaySinhKH.Text = str[4];
            txt_chiTietSoDTKH.Text = str[5];
        }

        private void ChiTiet_KhachHang_Load(object sender, EventArgs e)
        {
            addDuLieu(strData);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
