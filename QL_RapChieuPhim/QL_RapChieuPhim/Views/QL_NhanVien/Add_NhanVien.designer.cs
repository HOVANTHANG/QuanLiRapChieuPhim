namespace QL_RapChieuPhim.Views
{
    partial class Add_NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_close_addNhanVien = new System.Windows.Forms.Button();
			this.lbl_themNhanVien = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btn_huyLuuNhanVien = new CustomControls.RJControls.RJButton();
			this.btn_luuNhanVien = new CustomControls.RJControls.RJButton();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel14 = new System.Windows.Forms.Panel();
			this.panel13 = new System.Windows.Forms.Panel();
			this.lbl_addNhapLaiMK = new System.Windows.Forms.Label();
			this.panel10 = new System.Windows.Forms.Panel();
			this.lbl_addMatKhau = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lbl_addCaLam = new System.Windows.Forms.Label();
			this.lbl_addLuong = new System.Windows.Forms.Label();
			this.lbl_addSoDT = new System.Windows.Forms.Label();
			this.cB_addGioiTinh = new System.Windows.Forms.ComboBox();
			this.lbl_addNgaySinh = new System.Windows.Forms.Label();
			this.dTP_addCaLam = new System.Windows.Forms.DateTimePicker();
			this.lbl_addGioiTinh = new System.Windows.Forms.Label();
			this.lbl_addHoTen = new System.Windows.Forms.Label();
			this.txt_addNhapLaiMK = new System.Windows.Forms.TextBox();
			this.panel12 = new System.Windows.Forms.Panel();
			this.txt_addMatKhau = new System.Windows.Forms.TextBox();
			this.panel11 = new System.Windows.Forms.Panel();
			this.txt_addTaiKhoan = new System.Windows.Forms.TextBox();
			this.panel7 = new System.Windows.Forms.Panel();
			this.dTP_addNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txt_addLuong = new System.Windows.Forms.TextBox();
			this.panel9 = new System.Windows.Forms.Panel();
			this.txt_addSoDT = new System.Windows.Forms.TextBox();
			this.panel8 = new System.Windows.Forms.Panel();
			this.lbl_addTaiKhoan = new System.Windows.Forms.Label();
			this.txt_addHoTen = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txt_addMNV = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbl_addMNV = new System.Windows.Forms.Label();
			this.lbl_taoTK = new System.Windows.Forms.Label();
			this.lbl_thongTin = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btn_close_addNhanVien);
			this.panel1.Controls.Add(this.lbl_themNhanVien);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(716, 48);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// btn_close_addNhanVien
			// 
			this.btn_close_addNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close_addNhanVien.Location = new System.Drawing.Point(635, 9);
			this.btn_close_addNhanVien.Name = "btn_close_addNhanVien";
			this.btn_close_addNhanVien.Size = new System.Drawing.Size(30, 30);
			this.btn_close_addNhanVien.TabIndex = 19;
			this.btn_close_addNhanVien.Text = "X";
			this.btn_close_addNhanVien.UseVisualStyleBackColor = true;
			this.btn_close_addNhanVien.Click += new System.EventHandler(this.btn_close_addNhanVien_Click);
			// 
			// lbl_themNhanVien
			// 
			this.lbl_themNhanVien.AutoSize = true;
			this.lbl_themNhanVien.Font = new System.Drawing.Font("Arial", 17F, System.Drawing.FontStyle.Bold);
			this.lbl_themNhanVien.Location = new System.Drawing.Point(12, 9);
			this.lbl_themNhanVien.Name = "lbl_themNhanVien";
			this.lbl_themNhanVien.Size = new System.Drawing.Size(238, 34);
			this.lbl_themNhanVien.TabIndex = 0;
			this.lbl_themNhanVien.Text = "Thêm nhân viên";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.btn_huyLuuNhanVien);
			this.panel2.Controls.Add(this.btn_luuNhanVien);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Location = new System.Drawing.Point(0, 702);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(716, 58);
			this.panel2.TabIndex = 1;
			// 
			// btn_huyLuuNhanVien
			// 
			this.btn_huyLuuNhanVien.BackColor = System.Drawing.Color.Red;
			this.btn_huyLuuNhanVien.BackgroundColor = System.Drawing.Color.Red;
			this.btn_huyLuuNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btn_huyLuuNhanVien.BorderRadius = 16;
			this.btn_huyLuuNhanVien.BorderSize = 0;
			this.btn_huyLuuNhanVien.FlatAppearance.BorderSize = 0;
			this.btn_huyLuuNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_huyLuuNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_huyLuuNhanVien.ForeColor = System.Drawing.Color.White;
			this.btn_huyLuuNhanVien.Location = new System.Drawing.Point(398, 6);
			this.btn_huyLuuNhanVien.Name = "btn_huyLuuNhanVien";
			this.btn_huyLuuNhanVien.Size = new System.Drawing.Size(106, 40);
			this.btn_huyLuuNhanVien.TabIndex = 10;
			this.btn_huyLuuNhanVien.Text = "Hủy";
			this.btn_huyLuuNhanVien.TextColor = System.Drawing.Color.White;
			this.btn_huyLuuNhanVien.UseVisualStyleBackColor = false;
			this.btn_huyLuuNhanVien.Click += new System.EventHandler(this.btn_huy_Click);
			// 
			// btn_luuNhanVien
			// 
			this.btn_luuNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(183)))), ((int)(((byte)(253)))));
			this.btn_luuNhanVien.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(183)))), ((int)(((byte)(253)))));
			this.btn_luuNhanVien.BorderColor = System.Drawing.Color.PaleVioletRed;
			this.btn_luuNhanVien.BorderRadius = 16;
			this.btn_luuNhanVien.BorderSize = 0;
			this.btn_luuNhanVien.FlatAppearance.BorderSize = 0;
			this.btn_luuNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_luuNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_luuNhanVien.ForeColor = System.Drawing.Color.White;
			this.btn_luuNhanVien.Location = new System.Drawing.Point(552, 6);
			this.btn_luuNhanVien.Name = "btn_luuNhanVien";
			this.btn_luuNhanVien.Size = new System.Drawing.Size(106, 40);
			this.btn_luuNhanVien.TabIndex = 9;
			this.btn_luuNhanVien.Text = "Lưu";
			this.btn_luuNhanVien.TextColor = System.Drawing.Color.White;
			this.btn_luuNhanVien.UseVisualStyleBackColor = false;
			this.btn_luuNhanVien.Click += new System.EventHandler(this.btn_luuPhim_Click);
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.Controls.Add(this.panel14);
			this.panel3.Controls.Add(this.panel13);
			this.panel3.Controls.Add(this.lbl_addNhapLaiMK);
			this.panel3.Controls.Add(this.panel10);
			this.panel3.Controls.Add(this.lbl_addMatKhau);
			this.panel3.Controls.Add(this.panel6);
			this.panel3.Controls.Add(this.lbl_addCaLam);
			this.panel3.Controls.Add(this.lbl_addLuong);
			this.panel3.Controls.Add(this.lbl_addSoDT);
			this.panel3.Controls.Add(this.cB_addGioiTinh);
			this.panel3.Controls.Add(this.lbl_addNgaySinh);
			this.panel3.Controls.Add(this.dTP_addCaLam);
			this.panel3.Controls.Add(this.lbl_addGioiTinh);
			this.panel3.Controls.Add(this.lbl_addHoTen);
			this.panel3.Controls.Add(this.txt_addNhapLaiMK);
			this.panel3.Controls.Add(this.panel12);
			this.panel3.Controls.Add(this.txt_addMatKhau);
			this.panel3.Controls.Add(this.panel11);
			this.panel3.Controls.Add(this.txt_addTaiKhoan);
			this.panel3.Controls.Add(this.panel7);
			this.panel3.Controls.Add(this.dTP_addNgaySinh);
			this.panel3.Controls.Add(this.txt_addLuong);
			this.panel3.Controls.Add(this.panel9);
			this.panel3.Controls.Add(this.txt_addSoDT);
			this.panel3.Controls.Add(this.panel8);
			this.panel3.Controls.Add(this.lbl_addTaiKhoan);
			this.panel3.Controls.Add(this.txt_addHoTen);
			this.panel3.Controls.Add(this.panel5);
			this.panel3.Controls.Add(this.txt_addMNV);
			this.panel3.Controls.Add(this.panel4);
			this.panel3.Controls.Add(this.lbl_addMNV);
			this.panel3.Controls.Add(this.lbl_taoTK);
			this.panel3.Controls.Add(this.lbl_thongTin);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(0, 48);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(716, 654);
			this.panel3.TabIndex = 2;
			// 
			// panel14
			// 
			this.panel14.BackColor = System.Drawing.Color.Aqua;
			this.panel14.ForeColor = System.Drawing.Color.Black;
			this.panel14.Location = new System.Drawing.Point(0, 379);
			this.panel14.Margin = new System.Windows.Forms.Padding(4);
			this.panel14.Name = "panel14";
			this.panel14.Size = new System.Drawing.Size(819, 5);
			this.panel14.TabIndex = 44;
			// 
			// panel13
			// 
			this.panel13.BackColor = System.Drawing.Color.Black;
			this.panel13.ForeColor = System.Drawing.Color.Black;
			this.panel13.Location = new System.Drawing.Point(506, 233);
			this.panel13.Margin = new System.Windows.Forms.Padding(4);
			this.panel13.Name = "panel13";
			this.panel13.Size = new System.Drawing.Size(130, 1);
			this.panel13.TabIndex = 43;
			// 
			// lbl_addNhapLaiMK
			// 
			this.lbl_addNhapLaiMK.AutoSize = true;
			this.lbl_addNhapLaiMK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addNhapLaiMK.Location = new System.Drawing.Point(394, 524);
			this.lbl_addNhapLaiMK.Name = "lbl_addNhapLaiMK";
			this.lbl_addNhapLaiMK.Size = new System.Drawing.Size(93, 24);
			this.lbl_addNhapLaiMK.TabIndex = 21;
			this.lbl_addNhapLaiMK.Text = "Nhập lại:";
			// 
			// panel10
			// 
			this.panel10.BackColor = System.Drawing.Color.Black;
			this.panel10.ForeColor = System.Drawing.Color.Black;
			this.panel10.Location = new System.Drawing.Point(287, 233);
			this.panel10.Margin = new System.Windows.Forms.Padding(4);
			this.panel10.Name = "panel10";
			this.panel10.Size = new System.Drawing.Size(135, 1);
			this.panel10.TabIndex = 42;
			// 
			// lbl_addMatKhau
			// 
			this.lbl_addMatKhau.AutoSize = true;
			this.lbl_addMatKhau.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addMatKhau.Location = new System.Drawing.Point(69, 524);
			this.lbl_addMatKhau.Name = "lbl_addMatKhau";
			this.lbl_addMatKhau.Size = new System.Drawing.Size(104, 24);
			this.lbl_addMatKhau.TabIndex = 20;
			this.lbl_addMatKhau.Text = "Mật khẩu:";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.Black;
			this.panel6.ForeColor = System.Drawing.Color.Black;
			this.panel6.Location = new System.Drawing.Point(73, 235);
			this.panel6.Margin = new System.Windows.Forms.Padding(4);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(130, 1);
			this.panel6.TabIndex = 41;
			// 
			// lbl_addCaLam
			// 
			this.lbl_addCaLam.AutoSize = true;
			this.lbl_addCaLam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addCaLam.Location = new System.Drawing.Point(502, 171);
			this.lbl_addCaLam.Name = "lbl_addCaLam";
			this.lbl_addCaLam.Size = new System.Drawing.Size(81, 24);
			this.lbl_addCaLam.TabIndex = 17;
			this.lbl_addCaLam.Text = "Ca làm:";
			// 
			// lbl_addLuong
			// 
			this.lbl_addLuong.AutoSize = true;
			this.lbl_addLuong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addLuong.Location = new System.Drawing.Point(410, 272);
			this.lbl_addLuong.Name = "lbl_addLuong";
			this.lbl_addLuong.Size = new System.Drawing.Size(81, 24);
			this.lbl_addLuong.TabIndex = 16;
			this.lbl_addLuong.Text = "Lương:";
			// 
			// lbl_addSoDT
			// 
			this.lbl_addSoDT.AutoSize = true;
			this.lbl_addSoDT.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addSoDT.Location = new System.Drawing.Point(69, 272);
			this.lbl_addSoDT.Name = "lbl_addSoDT";
			this.lbl_addSoDT.Size = new System.Drawing.Size(141, 24);
			this.lbl_addSoDT.TabIndex = 15;
			this.lbl_addSoDT.Text = "Số điện thoại:";
			// 
			// cB_addGioiTinh
			// 
			this.cB_addGioiTinh.FormattingEnabled = true;
			this.cB_addGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
			this.cB_addGioiTinh.Location = new System.Drawing.Point(73, 209);
			this.cB_addGioiTinh.Name = "cB_addGioiTinh";
			this.cB_addGioiTinh.Size = new System.Drawing.Size(130, 24);
			this.cB_addGioiTinh.TabIndex = 40;
			// 
			// lbl_addNgaySinh
			// 
			this.lbl_addNgaySinh.AutoSize = true;
			this.lbl_addNgaySinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addNgaySinh.Location = new System.Drawing.Point(283, 171);
			this.lbl_addNgaySinh.Name = "lbl_addNgaySinh";
			this.lbl_addNgaySinh.Size = new System.Drawing.Size(111, 24);
			this.lbl_addNgaySinh.TabIndex = 14;
			this.lbl_addNgaySinh.Text = "Ngày sinh:";
			// 
			// dTP_addCaLam
			// 
			this.dTP_addCaLam.CustomFormat = "HH:mm";
			this.dTP_addCaLam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dTP_addCaLam.Location = new System.Drawing.Point(506, 209);
			this.dTP_addCaLam.Name = "dTP_addCaLam";
			this.dTP_addCaLam.ShowUpDown = true;
			this.dTP_addCaLam.Size = new System.Drawing.Size(130, 22);
			this.dTP_addCaLam.TabIndex = 39;
			// 
			// lbl_addGioiTinh
			// 
			this.lbl_addGioiTinh.AutoSize = true;
			this.lbl_addGioiTinh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addGioiTinh.Location = new System.Drawing.Point(69, 171);
			this.lbl_addGioiTinh.Name = "lbl_addGioiTinh";
			this.lbl_addGioiTinh.Size = new System.Drawing.Size(100, 24);
			this.lbl_addGioiTinh.TabIndex = 18;
			this.lbl_addGioiTinh.Text = "Giới tính:";
			// 
			// lbl_addHoTen
			// 
			this.lbl_addHoTen.AutoSize = true;
			this.lbl_addHoTen.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addHoTen.Location = new System.Drawing.Point(328, 69);
			this.lbl_addHoTen.Name = "lbl_addHoTen";
			this.lbl_addHoTen.Size = new System.Drawing.Size(107, 24);
			this.lbl_addHoTen.TabIndex = 11;
			this.lbl_addHoTen.Text = "Họ và tên:";
			// 
			// txt_addNhapLaiMK
			// 
			this.txt_addNhapLaiMK.BackColor = System.Drawing.Color.White;
			this.txt_addNhapLaiMK.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addNhapLaiMK.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addNhapLaiMK.Location = new System.Drawing.Point(398, 568);
			this.txt_addNhapLaiMK.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addNhapLaiMK.Multiline = true;
			this.txt_addNhapLaiMK.Name = "txt_addNhapLaiMK";
			this.txt_addNhapLaiMK.PasswordChar = '•';
			this.txt_addNhapLaiMK.Size = new System.Drawing.Size(237, 30);
			this.txt_addNhapLaiMK.TabIndex = 38;
			// 
			// panel12
			// 
			this.panel12.BackColor = System.Drawing.Color.Black;
			this.panel12.ForeColor = System.Drawing.Color.Black;
			this.panel12.Location = new System.Drawing.Point(398, 601);
			this.panel12.Margin = new System.Windows.Forms.Padding(4);
			this.panel12.Name = "panel12";
			this.panel12.Size = new System.Drawing.Size(237, 1);
			this.panel12.TabIndex = 37;
			// 
			// txt_addMatKhau
			// 
			this.txt_addMatKhau.BackColor = System.Drawing.Color.White;
			this.txt_addMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addMatKhau.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addMatKhau.Location = new System.Drawing.Point(73, 568);
			this.txt_addMatKhau.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addMatKhau.Multiline = true;
			this.txt_addMatKhau.Name = "txt_addMatKhau";
			this.txt_addMatKhau.PasswordChar = '•';
			this.txt_addMatKhau.Size = new System.Drawing.Size(219, 30);
			this.txt_addMatKhau.TabIndex = 36;
			this.txt_addMatKhau.Validating += new System.ComponentModel.CancelEventHandler(this.txt_addMatKhau_Validating);
			// 
			// panel11
			// 
			this.panel11.BackColor = System.Drawing.Color.Black;
			this.panel11.ForeColor = System.Drawing.Color.Black;
			this.panel11.Location = new System.Drawing.Point(73, 601);
			this.panel11.Margin = new System.Windows.Forms.Padding(4);
			this.panel11.Name = "panel11";
			this.panel11.Size = new System.Drawing.Size(219, 1);
			this.panel11.TabIndex = 35;
			// 
			// txt_addTaiKhoan
			// 
			this.txt_addTaiKhoan.BackColor = System.Drawing.Color.White;
			this.txt_addTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addTaiKhoan.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addTaiKhoan.Location = new System.Drawing.Point(286, 461);
			this.txt_addTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addTaiKhoan.Multiline = true;
			this.txt_addTaiKhoan.Name = "txt_addTaiKhoan";
			this.txt_addTaiKhoan.Size = new System.Drawing.Size(257, 30);
			this.txt_addTaiKhoan.TabIndex = 34;
			this.txt_addTaiKhoan.UseSystemPasswordChar = true;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.Black;
			this.panel7.ForeColor = System.Drawing.Color.Black;
			this.panel7.Location = new System.Drawing.Point(286, 494);
			this.panel7.Margin = new System.Windows.Forms.Padding(4);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(257, 1);
			this.panel7.TabIndex = 33;
			// 
			// dTP_addNgaySinh
			// 
			this.dTP_addNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dTP_addNgaySinh.Location = new System.Drawing.Point(287, 209);
			this.dTP_addNgaySinh.Name = "dTP_addNgaySinh";
			this.dTP_addNgaySinh.Size = new System.Drawing.Size(135, 22);
			this.dTP_addNgaySinh.TabIndex = 32;
			this.dTP_addNgaySinh.ValueChanged += new System.EventHandler(this.dTP_addNgaySinh_ValueChanged);
			// 
			// txt_addLuong
			// 
			this.txt_addLuong.BackColor = System.Drawing.Color.White;
			this.txt_addLuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addLuong.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addLuong.Location = new System.Drawing.Point(414, 312);
			this.txt_addLuong.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addLuong.Multiline = true;
			this.txt_addLuong.Name = "txt_addLuong";
			this.txt_addLuong.Size = new System.Drawing.Size(194, 30);
			this.txt_addLuong.TabIndex = 29;
			this.txt_addLuong.UseSystemPasswordChar = true;
			this.txt_addLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soNguyen_KeyPress);
			// 
			// panel9
			// 
			this.panel9.BackColor = System.Drawing.Color.Black;
			this.panel9.ForeColor = System.Drawing.Color.Black;
			this.panel9.Location = new System.Drawing.Point(414, 345);
			this.panel9.Margin = new System.Windows.Forms.Padding(4);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(194, 1);
			this.panel9.TabIndex = 28;
			// 
			// txt_addSoDT
			// 
			this.txt_addSoDT.BackColor = System.Drawing.Color.White;
			this.txt_addSoDT.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addSoDT.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addSoDT.Location = new System.Drawing.Point(73, 312);
			this.txt_addSoDT.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addSoDT.Multiline = true;
			this.txt_addSoDT.Name = "txt_addSoDT";
			this.txt_addSoDT.Size = new System.Drawing.Size(199, 30);
			this.txt_addSoDT.TabIndex = 27;
			this.txt_addSoDT.UseSystemPasswordChar = true;
			this.txt_addSoDT.TextChanged += new System.EventHandler(this.txt_addSoDT_TextChanged);
			this.txt_addSoDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_soNguyen_KeyPress);
			this.txt_addSoDT.Validating += new System.ComponentModel.CancelEventHandler(this.txt_addSoDT_Validating);
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.Black;
			this.panel8.ForeColor = System.Drawing.Color.Black;
			this.panel8.Location = new System.Drawing.Point(73, 345);
			this.panel8.Margin = new System.Windows.Forms.Padding(4);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(199, 1);
			this.panel8.TabIndex = 26;
			// 
			// lbl_addTaiKhoan
			// 
			this.lbl_addTaiKhoan.AutoSize = true;
			this.lbl_addTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addTaiKhoan.Location = new System.Drawing.Point(152, 461);
			this.lbl_addTaiKhoan.Name = "lbl_addTaiKhoan";
			this.lbl_addTaiKhoan.Size = new System.Drawing.Size(110, 24);
			this.lbl_addTaiKhoan.TabIndex = 19;
			this.lbl_addTaiKhoan.Text = "Tài khoản:";
			// 
			// txt_addHoTen
			// 
			this.txt_addHoTen.BackColor = System.Drawing.Color.White;
			this.txt_addHoTen.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addHoTen.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addHoTen.Location = new System.Drawing.Point(332, 106);
			this.txt_addHoTen.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addHoTen.Multiline = true;
			this.txt_addHoTen.Name = "txt_addHoTen";
			this.txt_addHoTen.Size = new System.Drawing.Size(313, 30);
			this.txt_addHoTen.TabIndex = 13;
			this.txt_addHoTen.UseSystemPasswordChar = true;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Black;
			this.panel5.ForeColor = System.Drawing.Color.Black;
			this.panel5.Location = new System.Drawing.Point(332, 139);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(313, 1);
			this.panel5.TabIndex = 12;
			// 
			// txt_addMNV
			// 
			this.txt_addMNV.BackColor = System.Drawing.Color.WhiteSmoke;
			this.txt_addMNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_addMNV.Enabled = false;
			this.txt_addMNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_addMNV.Location = new System.Drawing.Point(73, 106);
			this.txt_addMNV.Margin = new System.Windows.Forms.Padding(4);
			this.txt_addMNV.Multiline = true;
			this.txt_addMNV.Name = "txt_addMNV";
			this.txt_addMNV.Size = new System.Drawing.Size(157, 30);
			this.txt_addMNV.TabIndex = 10;
			this.txt_addMNV.UseSystemPasswordChar = true;
			// 
			// panel4
			// 
			this.panel4.BackColor = System.Drawing.Color.Black;
			this.panel4.ForeColor = System.Drawing.Color.Black;
			this.panel4.Location = new System.Drawing.Point(73, 139);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(157, 1);
			this.panel4.TabIndex = 9;
			// 
			// lbl_addMNV
			// 
			this.lbl_addMNV.AutoSize = true;
			this.lbl_addMNV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_addMNV.Location = new System.Drawing.Point(69, 69);
			this.lbl_addMNV.Name = "lbl_addMNV";
			this.lbl_addMNV.Size = new System.Drawing.Size(143, 24);
			this.lbl_addMNV.TabIndex = 2;
			this.lbl_addMNV.Text = "Mã nhân viên:";
			// 
			// lbl_taoTK
			// 
			this.lbl_taoTK.AutoSize = true;
			this.lbl_taoTK.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_taoTK.Location = new System.Drawing.Point(44, 402);
			this.lbl_taoTK.Name = "lbl_taoTK";
			this.lbl_taoTK.Size = new System.Drawing.Size(248, 27);
			this.lbl_taoTK.TabIndex = 1;
			this.lbl_taoTK.Text = "Tài khoản đăng nhập";
			// 
			// lbl_thongTin
			// 
			this.lbl_thongTin.AutoSize = true;
			this.lbl_thongTin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_thongTin.Location = new System.Drawing.Point(44, 21);
			this.lbl_thongTin.Name = "lbl_thongTin";
			this.lbl_thongTin.Size = new System.Drawing.Size(204, 27);
			this.lbl_thongTin.TabIndex = 0;
			this.lbl_thongTin.Text = "Thông tin cơ bản";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 10;
			this.bunifuElipse1.TargetControl = this;
			// 
			// Add_NhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(716, 760);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Add_NhanVien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add_NhanVien";
			this.Load += new System.EventHandler(this.Add_NhanVien_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_themNhanVien;
        private System.Windows.Forms.Button btn_close_addNhanVien;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btn_luuNhanVien;
        private CustomControls.RJControls.RJButton btn_huyLuuNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_thongTin;
        private System.Windows.Forms.Label lbl_addMNV;
        private System.Windows.Forms.Label lbl_taoTK;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_addMNV;
        private System.Windows.Forms.TextBox txt_addHoTen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_addHoTen;
        private System.Windows.Forms.Label lbl_addGioiTinh;
        private System.Windows.Forms.Label lbl_addCaLam;
        private System.Windows.Forms.Label lbl_addLuong;
        private System.Windows.Forms.Label lbl_addSoDT;
        private System.Windows.Forms.Label lbl_addNgaySinh;
        private System.Windows.Forms.Label lbl_addNhapLaiMK;
        private System.Windows.Forms.Label lbl_addMatKhau;
        private System.Windows.Forms.Label lbl_addTaiKhoan;
        private System.Windows.Forms.TextBox txt_addLuong;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txt_addSoDT;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DateTimePicker dTP_addNgaySinh;
        private System.Windows.Forms.TextBox txt_addTaiKhoan;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txt_addMatKhau;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txt_addNhapLaiMK;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.DateTimePicker dTP_addCaLam;
        private System.Windows.Forms.ComboBox cB_addGioiTinh;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}