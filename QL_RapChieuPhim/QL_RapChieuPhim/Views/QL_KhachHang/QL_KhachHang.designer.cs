namespace QL_RapChieuPhim.Views
{
    partial class QL_KhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chanTimKiem = new System.Windows.Forms.Panel();
            this.txt_timKiemKH = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ketQuaTKKH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_thongTinKH = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_thongTinKH)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.chanTimKiem);
            this.panel1.Controls.Add(this.txt_timKiemKH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 123);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_RapChieuPhim.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(39, 58);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // chanTimKiem
            // 
            this.chanTimKiem.BackColor = System.Drawing.Color.Black;
            this.chanTimKiem.ForeColor = System.Drawing.Color.Black;
            this.chanTimKiem.Location = new System.Drawing.Point(81, 74);
            this.chanTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chanTimKiem.Name = "chanTimKiem";
            this.chanTimKiem.Size = new System.Drawing.Size(315, 1);
            this.chanTimKiem.TabIndex = 12;
            // 
            // txt_timKiemKH
            // 
            this.txt_timKiemKH.BackColor = System.Drawing.SystemColors.Control;
            this.txt_timKiemKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timKiemKH.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiemKH.Location = new System.Drawing.Point(77, 46);
            this.txt_timKiemKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_timKiemKH.Multiline = true;
            this.txt_timKiemKH.Name = "txt_timKiemKH";
            this.txt_timKiemKH.Size = new System.Drawing.Size(315, 30);
            this.txt_timKiemKH.TabIndex = 11;
            this.txt_timKiemKH.UseSystemPasswordChar = true;
            this.txt_timKiemKH.TextChanged += new System.EventHandler(this.txt_timKiemKH_TextChanged);
            this.txt_timKiemKH.Enter += new System.EventHandler(this.txt_timKiemKH_Enter);
            this.txt_timKiemKH.Leave += new System.EventHandler(this.txt_timKiemKH_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ketQuaTKKH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 42);
            this.panel2.TabIndex = 1;
            // 
            // lbl_ketQuaTKKH
            // 
            this.lbl_ketQuaTKKH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ketQuaTKKH.AutoSize = true;
            this.lbl_ketQuaTKKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ketQuaTKKH.Location = new System.Drawing.Point(927, 11);
            this.lbl_ketQuaTKKH.Name = "lbl_ketQuaTKKH";
            this.lbl_ketQuaTKKH.Size = new System.Drawing.Size(77, 22);
            this.lbl_ketQuaTKKH.TabIndex = 2;
            this.lbl_ketQuaTKKH.Text = "Kết quả:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dGV_thongTinKH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 436);
            this.panel3.TabIndex = 2;
            // 
            // dGV_thongTinKH
            // 
            this.dGV_thongTinKH.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinKH.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_thongTinKH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_thongTinKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_thongTinKH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_thongTinKH.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_thongTinKH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_thongTinKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_thongTinKH.ColumnHeadersHeight = 40;
            this.dGV_thongTinKH.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dGV_thongTinKH.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinKH.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinKH.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dGV_thongTinKH.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinKH.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dGV_thongTinKH.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dGV_thongTinKH.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dGV_thongTinKH.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinKH.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGV_thongTinKH.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dGV_thongTinKH.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dGV_thongTinKH.CurrentTheme.Name = null;
            this.dGV_thongTinKH.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_thongTinKH.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinKH.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinKH.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dGV_thongTinKH.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_thongTinKH.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGV_thongTinKH.EnableHeadersVisualStyles = false;
            this.dGV_thongTinKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dGV_thongTinKH.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dGV_thongTinKH.HeaderBgColor = System.Drawing.Color.Empty;
            this.dGV_thongTinKH.HeaderForeColor = System.Drawing.Color.White;
            this.dGV_thongTinKH.Location = new System.Drawing.Point(59, 0);
            this.dGV_thongTinKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dGV_thongTinKH.Name = "dGV_thongTinKH";
            this.dGV_thongTinKH.RowHeadersVisible = false;
            this.dGV_thongTinKH.RowHeadersWidth = 51;
            this.dGV_thongTinKH.RowTemplate.Height = 40;
            this.dGV_thongTinKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_thongTinKH.Size = new System.Drawing.Size(981, 436);
            this.dGV_thongTinKH.TabIndex = 0;
            this.dGV_thongTinKH.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dGV_thongTinKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_thongTinKH_CellClick);
            this.dGV_thongTinKH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_thongTinKH_CellContentClick);
            // 
            // QL_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 601);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QL_KhachHang";
            this.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.QL_KhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_thongTinKH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ketQuaTKKH;
        private System.Windows.Forms.Panel chanTimKiem;
        private System.Windows.Forms.TextBox txt_timKiemKH;
        private System.Windows.Forms.Panel panel3;
        public Bunifu.UI.WinForms.BunifuDataGridView dGV_thongTinKH;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}