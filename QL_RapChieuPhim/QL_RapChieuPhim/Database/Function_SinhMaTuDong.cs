using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_RapChieuPhim.Database
{
    internal class Function_SinhMaTuDong
    {

        Database.DatabaseAccess dataBase = new Database.DatabaseAccess();

        // Hàm sinh mã tự động theo định dạng KyTuTienTo + số thứ tự, dựa trên dữ liệu có sẵn trong bảng
        public string SinhMaTuDong(string TenBang, char KyTuTienTo, string TruongMa)
        {
            int id = 1;  // Biến để giữ số thứ tự
            bool dung = false;  // Cờ để kiểm soát vòng lặp
            string ma = "";
            DataTable dm = new DataTable();

            // Vòng lặp tiếp tục cho đến khi tìm được mã chưa tồn tại trong cơ sở dữ liệu
            while (!dung)
            {
                // Tạo mã bằng cách nối KyTuTienTo và id, với id được làm tròn 3 chữ số bằng '0'
                ma = KyTuTienTo + id.ToString().PadLeft(3, '0');

                // Thực hiện truy vấn SQL kiểm tra mã trong bảng
                dm = dataBase.DataRead("Select * from " + TenBang + " where " + TruongMa + "='" + ma + "'");

                // Nếu không tìm thấy dòng nào có mã trùng, thoát khỏi vòng lặp
                if (dm.Rows.Count == 0)
                {
                    dung = true;
                }
                else
                {
                    id++;  // Nếu trùng, tăng id và tiếp tục vòng lặp
                }
            }
            return ma;  // Trả về mã mới tạo
        }

        // Hàm tạo mã mới dựa trên mã cuối cùng đã có
        public string SinhMoi(string maCuoi)
        {
            // Lấy phần số từ mã cuối, bỏ qua ký tự đầu tiên
            int soCuoi = int.Parse(maCuoi.Substring(1));

            // Tăng giá trị số lên 1
            soCuoi++;

            // Tạo mã mới bằng cách ghép ký tự đầu tiên với số mới đã làm tròn thành 3 chữ số
            string maMoi = maCuoi[0] + soCuoi.ToString().PadLeft(3, '0');

            return maMoi;  // Trả về mã mới
        }
    }
}
