namespace QL_RapChieuPhim.Views
{
    partial class formMainNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMainNV));
            this.slidebar_timer = new System.Windows.Forms.Timer(this.components);
            this.panel_menu = new System.Windows.Forms.Panel();
            this.lbl_nhanvien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_ChamCong = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox_menu = new System.Windows.Forms.PictureBox();
            this.btn_nhanvien = new System.Windows.Forms.Button();
            this.btn_SanPham = new System.Windows.Forms.Button();
            this.btn_PhimDangChieu = new System.Windows.Forms.Button();
            this.panel_menu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // slidebar_timer
            // 
            this.slidebar_timer.Interval = 10;
            this.slidebar_timer.Tick += new System.EventHandler(this.slidebar_timer_Tick);
            // 
            // panel_menu
            // 
            this.panel_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(219)))));
            this.panel_menu.Controls.Add(this.btn_ChamCong);
            this.panel_menu.Controls.Add(this.lbl_nhanvien);
            this.panel_menu.Controls.Add(this.button1);
            this.panel_menu.Controls.Add(this.label1);
            this.panel_menu.Controls.Add(this.panel1);
            this.panel_menu.Controls.Add(this.pictureBox_menu);
            this.panel_menu.Controls.Add(this.btn_nhanvien);
            this.panel_menu.Controls.Add(this.btn_SanPham);
            this.panel_menu.Controls.Add(this.btn_PhimDangChieu);
            this.panel_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_menu.Location = new System.Drawing.Point(0, 0);
            this.panel_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_menu.MaximumSize = new System.Drawing.Size(299, 0);
            this.panel_menu.MinimumSize = new System.Drawing.Size(80, 629);
            this.panel_menu.Name = "panel_menu";
            this.panel_menu.Size = new System.Drawing.Size(299, 629);
            this.panel_menu.TabIndex = 0;
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_nhanvien.AutoSize = true;
            this.lbl_nhanvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.ForeColor = System.Drawing.Color.White;
            this.lbl_nhanvien.Location = new System.Drawing.Point(75, 513);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(0, 24);
            this.lbl_nhanvien.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(77, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 578);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel_form
            // 
            this.panel_form.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_form.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_form.Location = new System.Drawing.Point(299, 57);
            this.panel_form.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1064, 572);
            this.panel_form.TabIndex = 2;
            this.panel_form.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_form_Paint);
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_tieude.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.lbl_tieude.Location = new System.Drawing.Point(469, 13);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(183, 29);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "Rạp Phim CGV";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(219)))));
            this.panel2.Controls.Add(this.lbl_tieude);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(299, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 57);
            this.panel2.TabIndex = 1;
            // 
            // btn_ChamCong
            // 
            this.btn_ChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChamCong.FlatAppearance.BorderSize = 0;
            this.btn_ChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChamCong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChamCong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.btn_ChamCong.Image = global::QL_RapChieuPhim.Properties.Resources.icons8_bounced_check_40;
            this.btn_ChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChamCong.Location = new System.Drawing.Point(0, 189);
            this.btn_ChamCong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_ChamCong.Name = "btn_ChamCong";
            this.btn_ChamCong.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_ChamCong.Size = new System.Drawing.Size(299, 50);
            this.btn_ChamCong.TabIndex = 9;
            this.btn_ChamCong.Text = "   Chấm Công";
            this.btn_ChamCong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChamCong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChamCong.UseVisualStyleBackColor = true;
            this.btn_ChamCong.Click += new System.EventHandler(this.btn_ChamCong_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.button1.Image = global::QL_RapChieuPhim.Properties.Resources.icons8_log_out_50;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 554);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(299, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "   Đăng xuất";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox_menu
            // 
            this.pictureBox_menu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_menu.Image = global::QL_RapChieuPhim.Properties.Resources.icons8_drag_list_down_50;
            this.pictureBox_menu.Location = new System.Drawing.Point(21, 22);
            this.pictureBox_menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_menu.Name = "pictureBox_menu";
            this.pictureBox_menu.Size = new System.Drawing.Size(33, 34);
            this.pictureBox_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_menu.TabIndex = 1;
            this.pictureBox_menu.TabStop = false;
            this.pictureBox_menu.Click += new System.EventHandler(this.pictureBox_menu_Click);
            // 
            // btn_nhanvien
            // 
            this.btn_nhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_nhanvien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nhanvien.FlatAppearance.BorderSize = 0;
            this.btn_nhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhanvien.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.btn_nhanvien.Image = global::QL_RapChieuPhim.Properties.Resources.icons8_supplier_40;
            this.btn_nhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.Location = new System.Drawing.Point(0, 500);
            this.btn_nhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_nhanvien.Name = "btn_nhanvien";
            this.btn_nhanvien.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_nhanvien.Size = new System.Drawing.Size(299, 50);
            this.btn_nhanvien.TabIndex = 3;
            this.btn_nhanvien.Text = "   ";
            this.btn_nhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_nhanvien.UseVisualStyleBackColor = true;
            // 
            // btn_SanPham
            // 
            this.btn_SanPham.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SanPham.FlatAppearance.BorderSize = 0;
            this.btn_SanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SanPham.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.btn_SanPham.Image = global::QL_RapChieuPhim.Properties.Resources.QL_product;
            this.btn_SanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.Location = new System.Drawing.Point(0, 135);
            this.btn_SanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SanPham.Name = "btn_SanPham";
            this.btn_SanPham.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_SanPham.Size = new System.Drawing.Size(299, 50);
            this.btn_SanPham.TabIndex = 3;
            this.btn_SanPham.Text = "    Sản Phẩm";
            this.btn_SanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_SanPham.UseVisualStyleBackColor = true;
            this.btn_SanPham.Click += new System.EventHandler(this.btn_SanPham_Click);
            // 
            // btn_PhimDangChieu
            // 
            this.btn_PhimDangChieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PhimDangChieu.FlatAppearance.BorderSize = 0;
            this.btn_PhimDangChieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PhimDangChieu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PhimDangChieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(48)))), ((int)(((byte)(93)))));
            this.btn_PhimDangChieu.Image = global::QL_RapChieuPhim.Properties.Resources.icons8_film_401;
            this.btn_PhimDangChieu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhimDangChieu.Location = new System.Drawing.Point(0, 82);
            this.btn_PhimDangChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_PhimDangChieu.Name = "btn_PhimDangChieu";
            this.btn_PhimDangChieu.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btn_PhimDangChieu.Size = new System.Drawing.Size(299, 50);
            this.btn_PhimDangChieu.TabIndex = 2;
            this.btn_PhimDangChieu.Text = "   Phim Đang Chiếu";
            this.btn_PhimDangChieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PhimDangChieu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PhimDangChieu.UseVisualStyleBackColor = true;
            this.btn_PhimDangChieu.Click += new System.EventHandler(this.btn_PhimDangChieu_Click);
            // 
            // formMainNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 629);
            this.Controls.Add(this.panel_form);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMainNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formMainNV_Load_1);
            this.panel_menu.ResumeLayout(false);
            this.panel_menu.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer slidebar_timer;
        private System.Windows.Forms.Panel panel_menu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox_menu;
        private System.Windows.Forms.Button btn_nhanvien;
        private System.Windows.Forms.Button btn_SanPham;
        private System.Windows.Forms.Button btn_PhimDangChieu;
        private System.Windows.Forms.Panel panel_form;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_nhanvien;
        private System.Windows.Forms.Button btn_ChamCong;
    }
}