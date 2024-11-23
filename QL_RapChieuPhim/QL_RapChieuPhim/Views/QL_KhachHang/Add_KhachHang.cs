using QL_RapChieuPhim.Database;
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
    public partial class Add_KhachHang : Form
    {
        DatabaseAccess datab = new DatabaseAccess();
        Views.QL_KhachHang ql = new QL_KhachHang();
        public Add_KhachHang(Views.QL_KhachHang ql)
        {
            InitializeComponent();
            this.ql = ql;
        }

        void ResetValue()
        {
            txt_addTKKH.Text = "";
            txt_addHoTenKH.Text = "";
            txt_addGioiTinhKH.Text = "";
            dTP_addNgaySinhKH.Text = DateTime.Now.ToString();
            txt_addSoDTKH.Text = "";
        }

        private void btn_close_addKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huyLuuKhachHang_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_luuKhachHang_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
