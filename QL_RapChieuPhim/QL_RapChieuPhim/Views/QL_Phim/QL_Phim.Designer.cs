namespace QL_RapChieuPhim.Views
{
    partial class QL_Phim
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
            this.txt_timkiem_phim = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ThemPhim = new CustomControls.RJControls.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgv_dataPhim = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataPhim)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txt_timkiem_phim);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.btn_ThemPhim);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 93);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_RapChieuPhim.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(9, 60);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 26);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txt_timkiem_phim
            // 
            this.txt_timkiem_phim.BackColor = System.Drawing.SystemColors.Control;
            this.txt_timkiem_phim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timkiem_phim.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem_phim.ForeColor = System.Drawing.Color.DimGray;
            this.txt_timkiem_phim.Location = new System.Drawing.Point(33, 48);
            this.txt_timkiem_phim.Multiline = true;
            this.txt_timkiem_phim.Name = "txt_timkiem_phim";
            this.txt_timkiem_phim.Size = new System.Drawing.Size(236, 24);
            this.txt_timkiem_phim.TabIndex = 7;
            this.txt_timkiem_phim.UseSystemPasswordChar = true;
            this.txt_timkiem_phim.Click += new System.EventHandler(this.txt_timkiem_phim_Click);
            this.txt_timkiem_phim.TextChanged += new System.EventHandler(this.txt_timkiem_phim_TextChanged);
            this.txt_timkiem_phim.Enter += new System.EventHandler(this.txt_timkiem_phim_Enter);
            this.txt_timkiem_phim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_timkiem_phim_KeyPress);
            this.txt_timkiem_phim.Leave += new System.EventHandler(this.txt_timkiem_phim_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(33, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(236, 1);
            this.panel5.TabIndex = 6;
            // 
            // btn_ThemPhim
            // 
            this.btn_ThemPhim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(183)))), ((int)(((byte)(253)))));
            this.btn_ThemPhim.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(183)))), ((int)(((byte)(253)))));
            this.btn_ThemPhim.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_ThemPhim.BorderRadius = 15;
            this.btn_ThemPhim.BorderSize = 0;
            this.btn_ThemPhim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemPhim.FlatAppearance.BorderSize = 0;
            this.btn_ThemPhim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ThemPhim.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemPhim.ForeColor = System.Drawing.Color.White;
            this.btn_ThemPhim.Image = global::QL_RapChieuPhim.Properties.Resources.add_icon24px;
            this.btn_ThemPhim.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ThemPhim.Location = new System.Drawing.Point(298, 41);
            this.btn_ThemPhim.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ThemPhim.Name = "btn_ThemPhim";
            this.btn_ThemPhim.Size = new System.Drawing.Size(96, 39);
            this.btn_ThemPhim.TabIndex = 5;
            this.btn_ThemPhim.Text = " Thêm";
            this.btn_ThemPhim.TextColor = System.Drawing.Color.White;
            this.btn_ThemPhim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ThemPhim.UseVisualStyleBackColor = false;
            this.btn_ThemPhim.Click += new System.EventHandler(this.btn_ThemPhim_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.dgv_dataPhim);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(820, 372);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(787, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(33, 350);
            this.panel6.TabIndex = 4;
            // 
            // dgv_dataPhim
            // 
            this.dgv_dataPhim.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_dataPhim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_dataPhim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataPhim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_dataPhim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_dataPhim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_dataPhim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_dataPhim.ColumnHeadersHeight = 40;
            this.dgv_dataPhim.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_dataPhim.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_dataPhim.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_dataPhim.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_dataPhim.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_dataPhim.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_dataPhim.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_dataPhim.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_dataPhim.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_dataPhim.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_dataPhim.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_dataPhim.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_dataPhim.CurrentTheme.Name = null;
            this.dgv_dataPhim.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_dataPhim.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_dataPhim.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_dataPhim.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_dataPhim.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_dataPhim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_dataPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_dataPhim.EnableHeadersVisualStyles = false;
            this.dgv_dataPhim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_dataPhim.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_dataPhim.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_dataPhim.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_dataPhim.Location = new System.Drawing.Point(33, 0);
            this.dgv_dataPhim.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_dataPhim.Name = "dgv_dataPhim";
            this.dgv_dataPhim.RowHeadersVisible = false;
            this.dgv_dataPhim.RowHeadersWidth = 51;
            this.dgv_dataPhim.RowTemplate.Height = 40;
            this.dgv_dataPhim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dataPhim.Size = new System.Drawing.Size(787, 350);
            this.dgv_dataPhim.TabIndex = 3;
            this.dgv_dataPhim.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_dataPhim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataPhim_CellClick);
            this.dgv_dataPhim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataPhim_CellContentClick_1);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(33, 350);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(787, 22);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(33, 372);
            this.panel3.TabIndex = 1;
            // 
            // QL_Phim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 465);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "QL_Phim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ PHIM";
            this.Load += new System.EventHandler(this.QL_Phim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataPhim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private CustomControls.RJControls.RJButton btn_ThemPhim;
        private System.Windows.Forms.TextBox txt_timkiem_phim;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        public Bunifu.UI.WinForms.BunifuDataGridView dgv_dataPhim;
        private System.Windows.Forms.Panel panel6;
    }
}