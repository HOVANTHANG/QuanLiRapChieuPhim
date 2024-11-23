namespace QL_RapChieuPhim.Views
{
	partial class Phimdangchieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Phimdangchieu));
            this.dtp_ngayChieu = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_timkiem_phim = new System.Windows.Forms.TextBox();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuShadowPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_ngayChieu
            // 
            this.dtp_ngayChieu.BackColor = System.Drawing.SystemColors.Control;
            this.dtp_ngayChieu.BorderRadius = 0;
            this.dtp_ngayChieu.Color = System.Drawing.Color.Silver;
            this.dtp_ngayChieu.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.dtp_ngayChieu.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dtp_ngayChieu.DisabledColor = System.Drawing.Color.Gray;
            this.dtp_ngayChieu.DisplayWeekNumbers = false;
            this.dtp_ngayChieu.DPHeight = 0;
            this.dtp_ngayChieu.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtp_ngayChieu.FillDatePicker = false;
            this.dtp_ngayChieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_ngayChieu.ForeColor = System.Drawing.Color.Black;
            this.dtp_ngayChieu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngayChieu.Icon = ((System.Drawing.Image)(resources.GetObject("dtp_ngayChieu.Icon")));
            this.dtp_ngayChieu.IconColor = System.Drawing.Color.Gray;
            this.dtp_ngayChieu.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dtp_ngayChieu.LeftTextMargin = 5;
            this.dtp_ngayChieu.Location = new System.Drawing.Point(401, 57);
            this.dtp_ngayChieu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_ngayChieu.MinimumSize = new System.Drawing.Size(4, 32);
            this.dtp_ngayChieu.Name = "dtp_ngayChieu";
            this.dtp_ngayChieu.Size = new System.Drawing.Size(213, 32);
            this.dtp_ngayChieu.TabIndex = 1;
            this.dtp_ngayChieu.ValueChanged += new System.EventHandler(this.dtp_ngayChieu_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.ForeColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(84, 95);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 1);
            this.panel5.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_RapChieuPhim.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(36, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(401, 95);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(213, 1);
            this.panel3.TabIndex = 8;
            // 
            // txt_timkiem_phim
            // 
            this.txt_timkiem_phim.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_timkiem_phim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_timkiem_phim.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem_phim.Location = new System.Drawing.Point(84, 57);
            this.txt_timkiem_phim.Margin = new System.Windows.Forms.Padding(4);
            this.txt_timkiem_phim.Multiline = true;
            this.txt_timkiem_phim.Name = "txt_timkiem_phim";
            this.txt_timkiem_phim.Size = new System.Drawing.Size(259, 30);
            this.txt_timkiem_phim.TabIndex = 9;
            this.txt_timkiem_phim.UseSystemPasswordChar = true;
            this.txt_timkiem_phim.TextChanged += new System.EventHandler(this.txt_timkiem_phim_TextChanged);
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.BorderRadius = 1;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Controls.Add(this.panel5);
            this.bunifuShadowPanel2.Controls.Add(this.dtp_ngayChieu);
            this.bunifuShadowPanel2.Controls.Add(this.txt_timkiem_phim);
            this.bunifuShadowPanel2.Controls.Add(this.pictureBox1);
            this.bunifuShadowPanel2.Controls.Add(this.panel3);
            this.bunifuShadowPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 5;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(1205, 119);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 13;
            this.bunifuShadowPanel2.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.bunifuShadowPanel2_ControlAdded);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 142);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1181, 496);
            this.flowLayoutPanel1.TabIndex = 14;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // Phimdangchieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 640);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Phimdangchieu";
            this.Text = "Phimdangchieu";
            this.Load += new System.EventHandler(this.Phimdangchieu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuShadowPanel2.ResumeLayout(false);
            this.bunifuShadowPanel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.TextBox txt_timkiem_phim;
        private Bunifu.UI.WinForms.BunifuDatePicker dtp_ngayChieu;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}