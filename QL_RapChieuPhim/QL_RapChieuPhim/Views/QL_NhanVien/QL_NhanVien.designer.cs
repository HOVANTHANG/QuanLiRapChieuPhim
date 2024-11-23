namespace QL_RapChieuPhim.Views
{
    partial class QL_NhanVien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_themNV = new CustomControls.RJControls.RJButton();
            this.chanTimKiem = new System.Windows.Forms.Panel();
            this.txt_timKiemNV = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ketQuaTKNV = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dGV_thongTinNV = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_thongTinNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_themNV);
            this.panel1.Controls.Add(this.chanTimKiem);
            this.panel1.Controls.Add(this.txt_timKiemNV);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 123);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_themNV
            // 
            this.btn_themNV.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_themNV.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btn_themNV.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_themNV.BorderRadius = 15;
            this.btn_themNV.BorderSize = 0;
            this.btn_themNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_themNV.FlatAppearance.BorderSize = 0;
            this.btn_themNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_themNV.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_themNV.ForeColor = System.Drawing.Color.White;
            this.btn_themNV.Image = global::QL_RapChieuPhim.Properties.Resources.add_icon24px;
            this.btn_themNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_themNV.Location = new System.Drawing.Point(388, 46);
            this.btn_themNV.Name = "btn_themNV";
            this.btn_themNV.Size = new System.Drawing.Size(122, 47);
            this.btn_themNV.TabIndex = 10;
            this.btn_themNV.Text = "   Thêm";
            this.btn_themNV.TextColor = System.Drawing.Color.White;
            this.btn_themNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_themNV.UseVisualStyleBackColor = false;
            this.btn_themNV.Click += new System.EventHandler(this.btn_themNV_Click);
            // 
            // chanTimKiem
            // 
            this.chanTimKiem.BackColor = System.Drawing.Color.Black;
            this.chanTimKiem.ForeColor = System.Drawing.Color.Black;
            this.chanTimKiem.Location = new System.Drawing.Point(44, 75);
            this.chanTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.chanTimKiem.Name = "chanTimKiem";
            this.chanTimKiem.Size = new System.Drawing.Size(315, 1);
            this.chanTimKiem.TabIndex = 9;
            // 
            // txt_timKiemNV
            // 
            this.txt_timKiemNV.BackColor = System.Drawing.SystemColors.Control;
            this.txt_timKiemNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timKiemNV.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timKiemNV.Location = new System.Drawing.Point(40, 46);
            this.txt_timKiemNV.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timKiemNV.Multiline = true;
            this.txt_timKiemNV.Name = "txt_timKiemNV";
            this.txt_timKiemNV.Size = new System.Drawing.Size(315, 30);
            this.txt_timKiemNV.TabIndex = 8;
            this.txt_timKiemNV.UseSystemPasswordChar = true;
            this.txt_timKiemNV.TextChanged += new System.EventHandler(this.txt_timKiemNV_TextChanged);
            this.txt_timKiemNV.Enter += new System.EventHandler(this.txt_timKiemNV_Enter);
            this.txt_timKiemNV.Leave += new System.EventHandler(this.txt_timKiemNV_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbl_ketQuaTKNV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 559);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 42);
            this.panel2.TabIndex = 1;
            // 
            // lbl_ketQuaTKNV
            // 
            this.lbl_ketQuaTKNV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ketQuaTKNV.AutoSize = true;
            this.lbl_ketQuaTKNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ketQuaTKNV.Location = new System.Drawing.Point(926, 11);
            this.lbl_ketQuaTKNV.Name = "lbl_ketQuaTKNV";
            this.lbl_ketQuaTKNV.Size = new System.Drawing.Size(77, 22);
            this.lbl_ketQuaTKNV.TabIndex = 0;
            this.lbl_ketQuaTKNV.Text = "Kết quả:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.Frozen = true;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::QL_RapChieuPhim.Properties.Resources.edit_icon;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 116;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::QL_RapChieuPhim.Properties.Resources.bin_icon_24px;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 115;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dGV_thongTinNV);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 123);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1093, 436);
            this.panel3.TabIndex = 2;
            // 
            // dGV_thongTinNV
            // 
            this.dGV_thongTinNV.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dGV_thongTinNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_thongTinNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGV_thongTinNV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dGV_thongTinNV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGV_thongTinNV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_thongTinNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dGV_thongTinNV.ColumnHeadersHeight = 40;
            this.dGV_thongTinNV.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dGV_thongTinNV.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinNV.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinNV.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dGV_thongTinNV.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinNV.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dGV_thongTinNV.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dGV_thongTinNV.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dGV_thongTinNV.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinNV.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGV_thongTinNV.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dGV_thongTinNV.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dGV_thongTinNV.CurrentTheme.Name = null;
            this.dGV_thongTinNV.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGV_thongTinNV.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dGV_thongTinNV.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dGV_thongTinNV.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dGV_thongTinNV.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGV_thongTinNV.DefaultCellStyle = dataGridViewCellStyle9;
            this.dGV_thongTinNV.EnableHeadersVisualStyles = false;
            this.dGV_thongTinNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dGV_thongTinNV.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dGV_thongTinNV.HeaderBgColor = System.Drawing.Color.Empty;
            this.dGV_thongTinNV.HeaderForeColor = System.Drawing.Color.White;
            this.dGV_thongTinNV.Location = new System.Drawing.Point(72, 6);
            this.dGV_thongTinNV.Name = "dGV_thongTinNV";
            this.dGV_thongTinNV.RowHeadersVisible = false;
            this.dGV_thongTinNV.RowHeadersWidth = 51;
            this.dGV_thongTinNV.RowTemplate.Height = 40;
            this.dGV_thongTinNV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_thongTinNV.Size = new System.Drawing.Size(940, 424);
            this.dGV_thongTinNV.TabIndex = 11;
            this.dGV_thongTinNV.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dGV_thongTinNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_thongTinNV_CellClick);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(66, 436);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1018, 123);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 436);
            this.panel4.TabIndex = 12;
            // 
            // tbNhanVienBindingSource
            // 
            this.tbNhanVienBindingSource.DataMember = "tbNhanVien";
            // 
            // QL_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 601);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QL_NhanVien";
            this.Text = "QUẢN LÝ NHÂN VIÊN";
            this.Load += new System.EventHandler(this.QL_NhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_thongTinNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNhanVienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_timKiemNV;
        private System.Windows.Forms.Panel chanTimKiem;
        private CustomControls.RJControls.RJButton btn_themNV;
        private System.Windows.Forms.Label lbl_ketQuaTKNV;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Panel panel3;
       // private QLRapChieuPhim2023DataSet qLRapChieuPhim2023DataSet;
        private System.Windows.Forms.BindingSource tbNhanVienBindingSource;
        public Bunifu.UI.WinForms.BunifuDataGridView dGV_thongTinNV;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        // private QLRapChieuPhim2023DataSetTableAdapters.tbNhanVienTableAdapter tbNhanVienTableAdapter;
    }
}