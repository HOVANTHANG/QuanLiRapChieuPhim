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
        public void KeyPress_DungKieuSo(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',') // kí tự điều hướng và chữ số 
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }
        }

        public void KeyPress_DungKieuChu(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Ngăn chặn ký tự nhập vào TextBox
            }

        }
    }
}
