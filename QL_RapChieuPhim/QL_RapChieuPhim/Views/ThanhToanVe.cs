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
using Excel = Microsoft.Office.Interop.Excel;

namespace QL_RapChieuPhim.Views
{
    public partial class ThanhToanVe : Form
    {
        string maphim;
        string NgayChieu;
        string GioChieu;
        Views.Chon_SanPham csp;
        string masuatchieu;
        Database.Function_SinhMaTuDong auto = new Database.Function_SinhMaTuDong();
        Database.DatabaseAccess dtb = new Database.DatabaseAccess();
        DataTable dt;
        string tongtienve;
        string soghe;
        string tongtiendoan;
        string MaNv;
        int tongsl;
        string[] values;
        public ThanhToanVe(Views.Chon_SanPham csp, string maphim, string NgayChieu, string GioChieu, string masuatchieu, string soghe, string tongtienve, string tongtiendoan, string MaNv, string[] values)
        {
            this.csp = csp;
            this.maphim = maphim;
            this.NgayChieu = NgayChieu;
            this.GioChieu = GioChieu;
            InitializeComponent();
            this.masuatchieu = masuatchieu;
            this.tongtienve = tongtienve;
            this.soghe = soghe;
            this.tongtiendoan = tongtiendoan;
            this.MaNv = MaNv;
            this.values = values;
        }

        private void ThanhToanVe_Load(object sender, EventArgs e)
        {
            
            dt = dtb.DataRead("select * from tbPhim inner join tbXuatChieu on tbPhim.MaPhim = tbXuatChieu.MaPhim inner join tbPhongChieu on tbXuatChieu.MaPhong = tbPhongChieu.MaPhong where tbXuatChieu.MaXuatChieu = '" +masuatchieu+"'");
            txt_MaVe.Text = auto.SinhMaTuDong("tbVe",'V',"Mave");
            txt_maKhach.Text = auto.SinhMaTuDong("tbKhachHang", 'K', "TenTKKH");
            txt_giochieu.Text = GioChieu;
            txt_ngaychieu.Text = NgayChieu;  
            txt_tenphim.Text = dt.Rows[0]["TenPhim"].ToString();
            //txt_giave.Text = "45000 đ";
            txt_Ghe.Text = soghe;
            txt_phongchieu.Text = dt.Rows[0]["TenPhong"].ToString();
            txt_tongTienVe.Text = tongtienve;


            //đồ ăn

            /*foreach (Control control in csp.flowLayoutPanel2.Controls)
            {
                if (control is Panel panel)
                {
                    // Lấy giá trị của thuộc tính Tag
                    string tagName = panel.Tag as string;

                    DataTable dt2 = dtb.DataRead("select * from tbSanPham where MaSanPham = '" +tagName +"'");


                  
                }
            }*/

            Panel[] panelArray = csp.flowLayoutPanel2.Controls.OfType<Panel>().ToArray();

            // Sử dụng danh sách các Panel
            foreach (Panel panel in panelArray)
            {
                foreach (Control control in panel.Controls)
                {
                    if(control is Button)
                    {
                        panel.Controls.Remove(control);
                    }
                }
                flowLayoutPanel1.Controls.Add(panel);
            }
            txt_tongtienDoAn.Text = tongtiendoan;
            txt_TongTienThanhToan.Text = (Convert.ToInt32(tongtienve) + Convert.ToInt32(tongtiendoan)).ToString();

            tongsl = 0;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhToan_Click(object sender, EventArgs e)
        {
            Function_SinhMaTuDong auto = new Function_SinhMaTuDong();
            string gioitinh = "";
            if(rdo_Nam.Checked == true)
            {
              gioitinh = rdo_Nam.Text;
            }
            else
            {
                gioitinh = rdo_Nu.Text;
            }
            string sql = "insert into tbKhachHang(TenTKKH, TenKH, GioiTinh, NTNS, SDT) values(";
            sql += "'" + txt_maKhach.Text + "',N'" + txt_addHoTenKH.Text + "',N'" + gioitinh + "','" + dtp_NgaySinh.Value.ToString("yyyy-MM-dd") + "','" + txt_sdtKhach.Text + "')";
            dtb.DataChange(sql);

            string maDT = auto.SinhMaTuDong("DoanhThuPhim", 'D', "MaDT");
            string sql0 = "insert into DoanhThuPhim(MaDT, MaPhim, DoanhThu, ThoiGian) values(";
            sql0 += "'" + maDT + "','" + maphim + "','" + txt_tongTienVe.Text + "','" + NgayChieu +"')";
            dtb.DataChange(sql0);

            string sql1 = "insert into tbVe(MaVe, MaKH, MaNV, NgayBanVe, GiaVe, MaXuatChieu) values(";
            sql1 += "'" +txt_MaVe.Text+ "','" +txt_maKhach.Text+ "','" +MaNv + "','" + NgayChieu +"','" +txt_tongTienVe.Text + "','" +masuatchieu + "')";
            dtb.DataChange(sql1);
            string MaHD = auto.SinhMaTuDong("tbHoaDonSP", 'H', "SoHD");
            string sqlSP = "insert into tbHoaDonSP(SoHD, MaNV, NgayBan, TongTien) values(";
            sqlSP += "'" + MaHD + "','" + MaNv + "','" + NgayChieu + "','" + txt_tongTienVe.Text + "')";
            dtb.DataChange(sqlSP);
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                {
                    string maSP = control.Tag as string;
                   
                    foreach (Control control1 in control.Controls)
                    {

                        if(control1 is TextBox)
                        {
                            int soLuong;
                            if (int.TryParse(control1.Text, out soLuong))
                            {
                                dtb.DataChange("update tbSanPham set Soluong = Soluong  - "+soLuong.ToString()+" where MaSP = '"+maSP+"'");
                                string sqlCTSP = "insert into tbChiTietHoaDonSP(SoHD, MaSP, SLBan) values(";
                                sqlCTSP += "'" + MaHD + "','" + maSP + "','" +soLuong+ "')";
                                dtb.DataChange(sqlCTSP);
                            }
                        }
                    }
                }
            }
             foreach (string value in values)
            {
                string sqlStatement = "update tbGhe set TrangThai = 0 where MaPhong = '" + dt.Rows[0]["MaPhong"].ToString() + "' and SoGhe = '" + value.Trim() + "'";
                dtb.DataChange(sqlStatement);
            }

            



             MessageSuccess mss = new MessageSuccess("Thanh Toán Thành Công");
             mss.ShowDialog();


            SaveFileDialog file = new SaveFileDialog();
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range tenTruong = (Excel.Range)exSheet.Cells[1, 1]; //Đưa con trỏ vào ô A1

            //Đưa dữ liệu vào file Excel
            
            tenTruong.Range["A1:D1"].MergeCells = true;

            tenTruong.Range["A1"].Value = "Rạp CHIẾU PHIM DVK Cinema";
            tenTruong.Range["A2"].Value = "Địa chỉ: số 3 Cầu Giấy - Láng Thượng - Đống Đa - Hà Nội";
            tenTruong.Range["A3"].Value = "Điện thoại: 0123456789";
            tenTruong.Range["B5:e5"].MergeCells = true;
            tenTruong.Range["B5:E5"].Font.Size = 18;
            tenTruong.Range["B5:E5"].Font.Color = System.Drawing.Color.Red;
            tenTruong.Range["B5:E5"].Font.Bold = true;
            tenTruong.Range["B5:E5"].Font.Italic = true;
            tenTruong.Range["B5"].Value = "VÉ CHIẾU PHIM";
            tenTruong.Range["A7"].Value = "Mã vé: " + txt_MaVe.Text;
            tenTruong.Range["A8"].Value = "Ngày chiếu: " + txt_ngaychieu.Text;
            tenTruong.Range["A9"].Value = "Ca chiếu: " + txt_giochieu.Text;
            tenTruong.Range["A10"].Value = "Ghế đăng kí: " + txt_Ghe.Text;
            tenTruong.Range["A11"].Value = "Phòng chiếu: " + txt_ngaychieu.Text;
            tenTruong.Range["C12"].Font.Bold = 13;
            tenTruong.Range["C12"].Value = "Tiền vé : " + txt_tongTienVe.Text;

            tenTruong.Range["A14"].Value = "Tên sản phẩm";
            tenTruong.Range["C14"].Value = "Số lượng";
            tenTruong.Range["A14:C14"].Font.Bold = true;

            int countSP = 15;
           
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is Panel)
                { 
                    string maSP = control.Tag as string;
                    string  sqlMonAn = $"Select TenSP from tbSanPham where MaSP = '{maSP}'";
                    string MonAn = dtb.selectColumn(sqlMonAn);
                    tenTruong.Range["a" + countSP.ToString()].Value =  MonAn.ToString();
                    
                    foreach (Control control1 in control.Controls)
                    {
                        if (control1 is TextBox)
                        {
                            int soLuong;
                            if (int.TryParse(control1.Text, out soLuong))
                            {
                                tenTruong.Range["C"+ countSP.ToString()].Value =   soLuong;
                                tenTruong.Range["C" + countSP.ToString()].HorizontalAlignment = HorizontalAlignment.Center;
                            }
                            
                        }
                        
                    }
                    countSP++;
                }
            }

            countSP += 1;
            tenTruong.Range["C" + countSP.ToString()].Font.Bold = 13;
            tenTruong.Range["C" + countSP.ToString()].Value = "Tiền đồ ăn : " + txt_tongtienDoAn.Text;
            countSP += 2;
            tenTruong.Range["C" + countSP.ToString()].Font.Bold = 13;
            tenTruong.Range["C" + countSP.ToString()].Value = "Tổng tiền vé : " + txt_TongTienThanhToan.Text;

            countSP += 3;
            tenTruong.Range["a"+ countSP.ToString()+":" + "e" + countSP.ToString()].MergeCells = true;
            tenTruong.Range["a" + countSP.ToString() + ":" + "e" + countSP.ToString()].Font.Italic = true;
            tenTruong.Range["a" + countSP.ToString()].Value = "Vui lòng đưa mã số này đến quầy vé để thanh toán.";
            
            countSP += 1;
            Excel.Range range = exSheet.Range["A1:E" + countSP.ToString()];
            // Đặt màu nền cho Range
            range.Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.FromArgb(254, 202, 231));

            exSheet.Name = "HoaDonVe";
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
