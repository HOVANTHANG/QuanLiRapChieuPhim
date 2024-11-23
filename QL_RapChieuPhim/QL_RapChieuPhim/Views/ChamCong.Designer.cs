namespace QL_RapChieuPhim.Views
{
    partial class ChamCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_chamcong = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgv_chamcong = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_manhanvien = new System.Windows.Forms.TextBox();
            this.txt_tennhanvien = new System.Windows.Forms.TextBox();
            this.txt_ngaygio = new System.Windows.Forms.TextBox();
            this.txt_noidung = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nội Dung";
            // 
            // btn_chamcong
            // 
            this.btn_chamcong.Location = new System.Drawing.Point(423, 90);
            this.btn_chamcong.Name = "btn_chamcong";
            this.btn_chamcong.Size = new System.Drawing.Size(75, 23);
            this.btn_chamcong.TabIndex = 3;
            this.btn_chamcong.Text = "Chấm Công";
            this.btn_chamcong.UseVisualStyleBackColor = true;
            this.btn_chamcong.Click += new System.EventHandler(this.btn_chamcong_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_chamcong);
            this.groupBox1.Location = new System.Drawing.Point(15, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Chấm Công";
            // 
            // dgv_chamcong
            // 
            this.dgv_chamcong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chamcong.Location = new System.Drawing.Point(6, 19);
            this.dgv_chamcong.Name = "dgv_chamcong";
            this.dgv_chamcong.Size = new System.Drawing.Size(807, 219);
            this.dgv_chamcong.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên Nhân Viên";
            // 
            // txt_manhanvien
            // 
            this.txt_manhanvien.Enabled = false;
            this.txt_manhanvien.Location = new System.Drawing.Point(128, 31);
            this.txt_manhanvien.Name = "txt_manhanvien";
            this.txt_manhanvien.Size = new System.Drawing.Size(187, 20);
            this.txt_manhanvien.TabIndex = 6;
            // 
            // txt_tennhanvien
            // 
            this.txt_tennhanvien.Enabled = false;
            this.txt_tennhanvien.Location = new System.Drawing.Point(128, 69);
            this.txt_tennhanvien.Name = "txt_tennhanvien";
            this.txt_tennhanvien.Size = new System.Drawing.Size(187, 20);
            this.txt_tennhanvien.TabIndex = 7;
            // 
            // txt_ngaygio
            // 
            this.txt_ngaygio.Location = new System.Drawing.Point(128, 113);
            this.txt_ngaygio.Name = "txt_ngaygio";
            this.txt_ngaygio.Size = new System.Drawing.Size(187, 20);
            this.txt_ngaygio.TabIndex = 8;
            // 
            // txt_noidung
            // 
            this.txt_noidung.Location = new System.Drawing.Point(128, 161);
            this.txt_noidung.Multiline = true;
            this.txt_noidung.Name = "txt_noidung";
            this.txt_noidung.Size = new System.Drawing.Size(187, 66);
            this.txt_noidung.TabIndex = 9;
            // 
            // ChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 507);
            this.Controls.Add(this.txt_noidung);
            this.Controls.Add(this.txt_ngaygio);
            this.Controls.Add(this.txt_tennhanvien);
            this.Controls.Add(this.txt_manhanvien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_chamcong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChamCong";
            this.Text = "ChamCong";
            this.Load += new System.EventHandler(this.ChamCong_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chamcong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_chamcong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_chamcong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_manhanvien;
        private System.Windows.Forms.TextBox txt_tennhanvien;
        private System.Windows.Forms.TextBox txt_ngaygio;
        private System.Windows.Forms.TextBox txt_noidung;
    }
}