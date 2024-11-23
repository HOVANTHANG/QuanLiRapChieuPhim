namespace QL_RapChieuPhim.Views
{
	partial class QL_SanPham
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
            this.txt_timkiem_SP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_ThemSP = new CustomControls.RJControls.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ptb_anhSP = new System.Windows.Forms.PictureBox();
            this.lbl_giaSP = new System.Windows.Forms.Label();
            this.lbl_solluongSP = new System.Windows.Forms.Label();
            this.lbl_tenSP = new System.Windows.Forms.Label();
            this.btn_SuaSP = new System.Windows.Forms.Button();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.cbb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_timkiemSP = new CustomControls.RJControls.RJButton();
            this.dgv_SanPham = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhSP)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_timkiem_SP
            // 
            this.txt_timkiem_SP.BackColor = System.Drawing.SystemColors.Control;
            this.txt_timkiem_SP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timkiem_SP.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem_SP.Location = new System.Drawing.Point(21, 36);
            this.txt_timkiem_SP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem_SP.Multiline = true;
            this.txt_timkiem_SP.Name = "txt_timkiem_SP";
            this.txt_timkiem_SP.Size = new System.Drawing.Size(187, 30);
            this.txt_timkiem_SP.TabIndex = 10;
            this.txt_timkiem_SP.UseSystemPasswordChar = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(21, 74);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 1);
            this.panel5.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(386, 666);
            this.panel2.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_ThemSP);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 666);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết sản phẩm";
            // 
            // btn_ThemSP
            // 
            this.btn_ThemSP.BackColor = System.Drawing.Color.White;
            this.btn_ThemSP.BackgroundColor = System.Drawing.Color.White;
            this.btn_ThemSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemSP.BorderRadius = 15;
            this.btn_ThemSP.BorderSize = 3;
            this.btn_ThemSP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemSP.FlatAppearance.BorderSize = 0;
            this.btn_ThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemSP.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSP.ForeColor = System.Drawing.Color.DimGray;
            this.btn_ThemSP.Image = global::QL_RapChieuPhim.Properties.Resources.popcorn_icon;
            this.btn_ThemSP.Location = new System.Drawing.Point(40, 429);
            this.btn_ThemSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ThemSP.Name = "btn_ThemSP";
            this.btn_ThemSP.Size = new System.Drawing.Size(180, 89);
            this.btn_ThemSP.TabIndex = 8;
            this.btn_ThemSP.Text = " Thêm sản phẩm";
            this.btn_ThemSP.TextColor = System.Drawing.Color.DimGray;
            this.btn_ThemSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemSP.UseVisualStyleBackColor = false;
            this.btn_ThemSP.Click += new System.EventHandler(this.btn_ThemSP_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.lbl_giaSP);
            this.panel3.Controls.Add(this.lbl_solluongSP);
            this.panel3.Controls.Add(this.lbl_tenSP);
            this.panel3.Controls.Add(this.btn_SuaSP);
            this.panel3.Controls.Add(this.btn_XoaSP);
            this.panel3.Location = new System.Drawing.Point(40, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 361);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.ptb_anhSP);
            this.panel4.Location = new System.Drawing.Point(17, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(261, 257);
            this.panel4.TabIndex = 15;
            // 
            // ptb_anhSP
            // 
            this.ptb_anhSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptb_anhSP.Location = new System.Drawing.Point(0, 0);
            this.ptb_anhSP.Name = "ptb_anhSP";
            this.ptb_anhSP.Size = new System.Drawing.Size(259, 255);
            this.ptb_anhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_anhSP.TabIndex = 14;
            this.ptb_anhSP.TabStop = false;
            // 
            // lbl_giaSP
            // 
            this.lbl_giaSP.AutoSize = true;
            this.lbl_giaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_giaSP.Location = new System.Drawing.Point(253, 315);
            this.lbl_giaSP.Name = "lbl_giaSP";
            this.lbl_giaSP.Size = new System.Drawing.Size(24, 16);
            this.lbl_giaSP.TabIndex = 13;
            this.lbl_giaSP.Text = "0đ";
            // 
            // lbl_solluongSP
            // 
            this.lbl_solluongSP.AutoSize = true;
            this.lbl_solluongSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_solluongSP.Location = new System.Drawing.Point(15, 315);
            this.lbl_solluongSP.Name = "lbl_solluongSP";
            this.lbl_solluongSP.Size = new System.Drawing.Size(33, 16);
            this.lbl_solluongSP.TabIndex = 13;
            this.lbl_solluongSP.Text = "SL: ";
            // 
            // lbl_tenSP
            // 
            this.lbl_tenSP.AutoSize = true;
            this.lbl_tenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenSP.Location = new System.Drawing.Point(14, 283);
            this.lbl_tenSP.Name = "lbl_tenSP";
            this.lbl_tenSP.Size = new System.Drawing.Size(67, 16);
            this.lbl_tenSP.TabIndex = 13;
            this.lbl_tenSP.Text = "Tên món";
            // 
            // btn_SuaSP
            // 
            this.btn_SuaSP.Image = global::QL_RapChieuPhim.Properties.Resources.edit_icon;
            this.btn_SuaSP.Location = new System.Drawing.Point(284, 14);
            this.btn_SuaSP.Name = "btn_SuaSP";
            this.btn_SuaSP.Size = new System.Drawing.Size(40, 40);
            this.btn_SuaSP.TabIndex = 12;
            this.btn_SuaSP.UseVisualStyleBackColor = true;
            this.btn_SuaSP.Click += new System.EventHandler(this.btn_SuaSP_Click);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Image = global::QL_RapChieuPhim.Properties.Resources.delete_icon;
            this.btn_XoaSP.Location = new System.Drawing.Point(284, 60);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(40, 40);
            this.btn_XoaSP.TabIndex = 12;
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // cbb_LoaiSP
            // 
            this.cbb_LoaiSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_LoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_LoaiSP.ForeColor = System.Drawing.Color.DarkGray;
            this.cbb_LoaiSP.FormattingEnabled = true;
            this.cbb_LoaiSP.Location = new System.Drawing.Point(615, 36);
            this.cbb_LoaiSP.Name = "cbb_LoaiSP";
            this.cbb_LoaiSP.Size = new System.Drawing.Size(120, 24);
            this.cbb_LoaiSP.TabIndex = 13;
            this.cbb_LoaiSP.Text = "Tất cả";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.ForeColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(614, 70);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 1);
            this.panel6.TabIndex = 9;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_timkiemSP);
            this.panel7.Controls.Add(this.cbb_LoaiSP);
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.txt_timkiem_SP);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(386, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(773, 100);
            this.panel7.TabIndex = 14;
            // 
            // btn_timkiemSP
            // 
            this.btn_timkiemSP.BackColor = System.Drawing.Color.White;
            this.btn_timkiemSP.BackgroundColor = System.Drawing.Color.White;
            this.btn_timkiemSP.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_timkiemSP.BorderRadius = 23;
            this.btn_timkiemSP.BorderSize = 0;
            this.btn_timkiemSP.FlatAppearance.BorderSize = 0;
            this.btn_timkiemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiemSP.ForeColor = System.Drawing.Color.DimGray;
            this.btn_timkiemSP.Image = global::QL_RapChieuPhim.Properties.Resources.search;
            this.btn_timkiemSP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timkiemSP.Location = new System.Drawing.Point(239, 36);
            this.btn_timkiemSP.Name = "btn_timkiemSP";
            this.btn_timkiemSP.Size = new System.Drawing.Size(109, 49);
            this.btn_timkiemSP.TabIndex = 12;
            this.btn_timkiemSP.Text = "   Tìm kiếm";
            this.btn_timkiemSP.TextColor = System.Drawing.Color.DimGray;
            this.btn_timkiemSP.UseVisualStyleBackColor = false;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_SanPham.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_SanPham.Location = new System.Drawing.Point(3, 23);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.Size = new System.Drawing.Size(767, 540);
            this.dgv_SanPham.TabIndex = 2;
            this.dgv_SanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgv_SanPham);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(386, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(773, 566);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sản phẩm";
            // 
            // QL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 666);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QL_SanPham";
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.QL_SanPham_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_anhSP)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txt_timkiem_SP;
		private System.Windows.Forms.Panel panel5;
		private CustomControls.RJControls.RJButton btn_ThemSP;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lbl_giaSP;
		private System.Windows.Forms.Button btn_XoaSP;
		private System.Windows.Forms.Button btn_SuaSP;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbl_solluongSP;
		private System.Windows.Forms.Label lbl_tenSP;
		private CustomControls.RJControls.RJButton btn_timkiemSP;
		private System.Windows.Forms.PictureBox ptb_anhSP;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.ComboBox cbb_LoaiSP;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		public System.Windows.Forms.DataGridView dgv_SanPham;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.GroupBox groupBox1;
    }
}