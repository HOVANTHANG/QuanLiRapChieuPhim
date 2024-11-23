namespace QL_RapChieuPhim.Views
{
    partial class TinhLuong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_dsnhanvien = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_gioitinh = new System.Windows.Forms.TextBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.txt_manv = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tinhcong = new System.Windows.Forms.Button();
            this.btn_ExportToExcel_Click = new System.Windows.Forms.Button();
            this.dgv_tinhluong = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnhanvien)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tinhluong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_dsnhanvien);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Nhân Viên";
            // 
            // dgv_dsnhanvien
            // 
            this.dgv_dsnhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dsnhanvien.Location = new System.Drawing.Point(16, 22);
            this.dgv_dsnhanvien.Name = "dgv_dsnhanvien";
            this.dgv_dsnhanvien.Size = new System.Drawing.Size(509, 150);
            this.dgv_dsnhanvien.TabIndex = 0;
            this.dgv_dsnhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dsnhanvien_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_luong);
            this.groupBox2.Controls.Add(this.txt_sdt);
            this.groupBox2.Controls.Add(this.txt_ngaysinh);
            this.groupBox2.Controls.Add(this.txt_gioitinh);
            this.groupBox2.Controls.Add(this.txt_tennhanvien);
            this.groupBox2.Controls.Add(this.txt_manv);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(527, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(425, 155);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin nhân viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(383, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "VNĐ";
            // 
            // txt_luong
            // 
            this.txt_luong.Enabled = false;
            this.txt_luong.Location = new System.Drawing.Point(296, 96);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(81, 20);
            this.txt_luong.TabIndex = 11;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Enabled = false;
            this.txt_sdt.Location = new System.Drawing.Point(296, 52);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(100, 20);
            this.txt_sdt.TabIndex = 10;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Enabled = false;
            this.txt_ngaysinh.Location = new System.Drawing.Point(296, 18);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(100, 20);
            this.txt_ngaysinh.TabIndex = 9;
            // 
            // txt_gioitinh
            // 
            this.txt_gioitinh.Enabled = false;
            this.txt_gioitinh.Location = new System.Drawing.Point(91, 96);
            this.txt_gioitinh.Name = "txt_gioitinh";
            this.txt_gioitinh.Size = new System.Drawing.Size(100, 20);
            this.txt_gioitinh.TabIndex = 8;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Enabled = false;
            this.txt_tennhanvien.Location = new System.Drawing.Point(91, 52);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(100, 20);
            this.txt_tennhanvien.TabIndex = 7;
            // 
            // txt_manv
            // 
            this.txt_manv.Enabled = false;
            this.txt_manv.Location = new System.Drawing.Point(91, 19);
            this.txt_manv.Name = "txt_manv";
            this.txt_manv.Size = new System.Drawing.Size(100, 20);
            this.txt_manv.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Lương Cơ Bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số ĐT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày Sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tổng Lương = Số Ngày Công * Lương Cơ Bản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tính ngày công từ ngày 01 hàng tháng";
            // 
            // btn_tinhcong
            // 
            this.btn_tinhcong.Location = new System.Drawing.Point(635, 213);
            this.btn_tinhcong.Name = "btn_tinhcong";
            this.btn_tinhcong.Size = new System.Drawing.Size(103, 38);
            this.btn_tinhcong.TabIndex = 4;
            this.btn_tinhcong.Text = "Tính Lương";
            this.btn_tinhcong.UseVisualStyleBackColor = true;
            this.btn_tinhcong.Click += new System.EventHandler(this.btn_tinhcong_Click);
            // 
            // btn_ExportToExcel_Click
            // 
            this.btn_ExportToExcel_Click.Location = new System.Drawing.Point(799, 213);
            this.btn_ExportToExcel_Click.Name = "btn_ExportToExcel_Click";
            this.btn_ExportToExcel_Click.Size = new System.Drawing.Size(90, 38);
            this.btn_ExportToExcel_Click.TabIndex = 5;
            this.btn_ExportToExcel_Click.Text = "Xuất Excel";
            this.btn_ExportToExcel_Click.UseVisualStyleBackColor = true;
            this.btn_ExportToExcel_Click.Click += new System.EventHandler(this.btn_ExportToExcel_Click_Click);
            // 
            // dgv_tinhluong
            // 
            this.dgv_tinhluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tinhluong.Location = new System.Drawing.Point(20, 271);
            this.dgv_tinhluong.Name = "dgv_tinhluong";
            this.dgv_tinhluong.Size = new System.Drawing.Size(932, 239);
            this.dgv_tinhluong.TabIndex = 6;
            // 
            // TinhLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 522);
            this.Controls.Add(this.dgv_tinhluong);
            this.Controls.Add(this.btn_ExportToExcel_Click);
            this.Controls.Add(this.btn_tinhcong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TinhLuong";
            this.Text = "TinhLuong";
            this.Load += new System.EventHandler(this.TinhLuong_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dsnhanvien)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tinhluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_dsnhanvien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tinhcong;
        private System.Windows.Forms.Button btn_ExportToExcel_Click;
        private System.Windows.Forms.DataGridView dgv_tinhluong;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_gioitinh;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.TextBox txt_manv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}