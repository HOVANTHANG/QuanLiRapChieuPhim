using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_RapChieuPhim.Database
{
    internal class ChoPhepKyTu
    {
        // Hàm này được gọi khi một ký tự được nhập vào TextBox để đảm bảo
        // chỉ cho phép nhập số, dấu '.' và dấu ','

        public void KeyPress_DungKieuSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') // kí tự điều hướng và chữ số 
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox neus ko hợp lệ
            }
        }

        // Hàm này được gọi khi một ký tự được nhập vào TextBox để đảm bảo
        //chỉ cho phép nhập chữ cái, dấu cách và phím xóa (Backspace)

        public void KeyPress_DungKieuChu(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }

        }
    }
}
