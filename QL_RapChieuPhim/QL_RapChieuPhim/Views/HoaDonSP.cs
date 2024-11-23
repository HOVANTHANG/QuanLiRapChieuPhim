using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace QL_RapChieuPhim.Views
{
    public partial class HoaDonSP : Form
    {
        string maNV;
        DateTime ngayhomnay;
        Views.Dat_SanPham dp;
        int tongSL;
        string tongtien;
        string MaHD;
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        Database.Function_SinhMaTuDong auto = new Database.Function_SinhMaTuDong();
        public HoaDonSP(string maNV, DateTime ngayhomnay, Views.Dat_SanPham dp, string tongtien)
        {
            this.maNV = maNV;
            this.ngayhomnay = ngayhomnay;
            this.dp = dp;
            this.tongtien = tongtien;
            InitializeComponent();
        }

        private void HoaDonSP_Load(object sender, EventArgs e)
        {
            tongSL = 0;
            Panel[] panelArray = dp.flowLayoutPanel2.Controls.OfType<Panel>().ToArray();

            // Sử dụng danh sách các Panel
            foreach (Panel panel in panelArray)
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is Button)
                    {
                        panel.Controls.Remove(control);
                    }
                }
                flowLayoutPanel1.Controls.Add(panel);
            }


            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                {
                    string maSP = control.Tag as string;
                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            int soLuong;
                            if (int.TryParse(control1.Text, out soLuong))
                            {
                                tongSL += soLuong;
                            }

                        }

                    }
                }
            }
            MaHD = auto.SinhMaTuDong("tbHoaDonSP", 'H', "SoHD");
            txt_MaHD.Text = MaHD;
            txt_ngayBan.Text = ngayhomnay.ToString("dd/MM/yyyy");
            txt_maNV.Text = maNV;
            txt_SL.Text = tongSL.ToString();
            txt_TongTienThanhToan.Text = tongtien;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            string sqlSP = "insert into tbHoaDonSP(SoHD, MaNV, NgayBan, TongTien) values(";
            sqlSP += "'" + MaHD + "','" + maNV + "','" + ngayhomnay.ToString("yyyy-MM-dd") + "','" + txt_TongTienThanhToan.Text + "')";
            dtb.DataChange(sqlSP);
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                {
                    string maSP = control.Tag as string;

                    foreach (Control control1 in control.Controls)
                    {

                        if (control1 is TextBox)
                        {
                            int soLuong;
                            if (int.TryParse(control1.Text, out soLuong))
                            {
                                dtb.DataChange("update tbSanPham set Soluong = Soluong  - " + soLuong.ToString() + " where MaSP = '" + maSP + "'");
                                string sqlCTSP = "insert into tbChiTietHoaDonSP(SoHD, MaSP, SLBan) values(";
                                sqlCTSP += "'" + MaHD + "','" + maSP + "','" + soLuong + "')";
                                dtb.DataChange(sqlCTSP);
                            }
                        }
                    }
                }
            }
            DataTable dt = dtb.DataRead("select TenNV from tbNhanVien where MaNV = '" + maNV + "'");

            MessageSuccess mss = new MessageSuccess("Thanh Toán Thành Công");
            mss.ShowDialog();

            SaveFileDialog file = new SaveFileDialog();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1

            //Đưa dữ liệu vào file Excel

            tenTruong.Range["A1:D1"].MergeCells = true;

            tenTruong.Range["A1"].Value = "Rạp CHIẾU PHIM DVK CINEMA";
            tenTruong.Range["A2"].Value = "Địa chỉ: số 3 Cầu Giấy - Láng Thượng - Đống Đa - Hà Nội";
            tenTruong.Range["A3"].Value = "Điện thoại: 0123456789";

            tenTruong.Range["B5:G5"].MergeCells = true;
            tenTruong.Range["B5:G5"].Font.Size = 18;
            tenTruong.Range["B5:G5"].Font.Color = System.Drawing.Color.Red;
            tenTruong.Range["B5:G5"].Font.Bold = true;
            tenTruong.Range["B5:G5"].Font.Italic = true;
            tenTruong.Range["B5"].Value = "HÓA ĐƠN SẢN PHẨM DVK CINEMA";

            tenTruong.Range["A7"].Value = "Mã hóa đơn: " + txt_MaHD.Text;
            tenTruong.Range["A8"].Value = "Tên nhân viên: " + dt.Rows[0]["TenNV"].ToString();
            tenTruong.Range["A9"].Value = "Ca chiếu: " + txt_ngayBan.Text;

            tenTruong.Range["A11"].Value = "Tên sản phẩm";
            tenTruong.Range["C11"].Value = "Số lượng";
            tenTruong.Range["E11"].Value = "Giá Tiền";
            tenTruong.Range["A11:E11"].Font.Bold = true;

            int countSP = 12;

            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                {
                    string maSP = control.Tag as string;
                    string sqlMonAn = $"Select TenSP from tbSanPham where MaSP = '{maSP}'";
                    string MonAn = dtb.selectColumn(sqlMonAn);
                    string sqlMonAn1 = $"Select DonGiaBan from tbSanPham where MaSP = '{maSP}'";
                    string MonAn1 = dtb.selectColumn(sqlMonAn1);
                    tenTruong.Range["a" + countSP.ToString()].Value = MonAn.ToString();
                    tenTruong.Range["E" + countSP.ToString()].Value = MonAn1.ToString();


                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            int soLuong;
                            if (int.TryParse(control1.Text, out soLuong))
                            {
                                tenTruong.Range["C" + countSP.ToString()].Value = soLuong;
                                tenTruong.Range["C" + countSP.ToString()].HorizontalAlignment = HorizontalAlignment.Center;
                            }

                        }

                    }
                    countSP++;
                }
            }

            countSP += 1;
            tenTruong.Range["A" + countSP.ToString()].Value = " Tổng số lượng: " + txt_SL.Text;

            tenTruong.Range["C" + countSP.ToString()].Font.Bold = 13;
            tenTruong.Range["C" + countSP.ToString()].Value = "Tổng Tiền : " + txt_TongTienThanhToan.Text;


            countSP += 3;
            tenTruong.Range["a" + countSP.ToString() + ":" + "G" + countSP.ToString()].MergeCells = true;
            tenTruong.Range["a" + countSP.ToString() + ":" + "G" + countSP.ToString()].Font.Italic = true;
            tenTruong.Range["a" + countSP.ToString()].Value = "Cảm ơn quý khách đã sử dụng dịch vụ.";

            countSP += 1;
            Excel.Range range = exSheet.Range["A1:G" + countSP.ToString()];
            // Đặt màu nền cho Range
            range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(254, 202, 231));

            exSheet.Name = "HoaDonSP";
            exBook.Activate();

            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.Filter = "Excel Document(*.xls)|*.xls |Word Document(*.doc)| *.doc | All files(*.*) | *.* ";
            dlgSave.FilterIndex = 1;
            dlgSave.AddExtension = true;
            dlgSave.DefaultExt = ".xls";
            if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
            exApp.Quit();//Thoát khỏi ứng dụng
        }



    
    
    }
}
