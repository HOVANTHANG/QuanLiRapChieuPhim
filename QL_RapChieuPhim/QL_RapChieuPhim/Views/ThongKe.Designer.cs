namespace QL_RapChieuPhim.Views
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.BieuDo_Phim = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuShadowPanel2 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgv_Phim = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuShadowPanel3 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.Bieudo_SP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuShadowPanel4 = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.dgv_SanPham = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cbb_thongKe = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cbb_thongKe2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo_Phim)).BeginInit();
            this.bunifuShadowPanel1.SuspendLayout();
            this.bunifuShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).BeginInit();
            this.bunifuShadowPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Bieudo_SP)).BeginInit();
            this.bunifuShadowPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // BieuDo_Phim
            // 
            this.BieuDo_Phim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.BieuDo_Phim.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BieuDo_Phim.Legends.Add(legend1);
            this.BieuDo_Phim.Location = new System.Drawing.Point(20, 18);
            this.BieuDo_Phim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BieuDo_Phim.Name = "BieuDo_Phim";
            this.BieuDo_Phim.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Phim";
            series1.YValuesPerPoint = 2;
            this.BieuDo_Phim.Series.Add(series1);
            this.BieuDo_Phim.Size = new System.Drawing.Size(755, 295);
            this.BieuDo_Phim.TabIndex = 0;
            this.BieuDo_Phim.Text = "Thống Kê Doanh Số";
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel1.BorderRadius = 10;
            this.bunifuShadowPanel1.BorderThickness = 1;
            this.bunifuShadowPanel1.Controls.Add(this.BieuDo_Phim);
            this.bunifuShadowPanel1.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel1.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(37, 52);
            this.bunifuShadowPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel1.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(1)))));
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowDepth = 5;
            this.bunifuShadowPanel1.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(796, 332);
            this.bunifuShadowPanel1.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel1.TabIndex = 1;
            // 
            // bunifuShadowPanel2
            // 
            this.bunifuShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel2.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.BorderRadius = 8;
            this.bunifuShadowPanel2.BorderThickness = 1;
            this.bunifuShadowPanel2.Controls.Add(this.dgv_Phim);
            this.bunifuShadowPanel2.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel2.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel2.Location = new System.Drawing.Point(37, 373);
            this.bunifuShadowPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuShadowPanel2.Name = "bunifuShadowPanel2";
            this.bunifuShadowPanel2.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel2.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel2.ShadowDept = 2;
            this.bunifuShadowPanel2.ShadowDepth = 5;
            this.bunifuShadowPanel2.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel2.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel2.Size = new System.Drawing.Size(796, 369);
            this.bunifuShadowPanel2.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel2.TabIndex = 2;
            // 
            // dgv_Phim
            // 
            this.dgv_Phim.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Phim.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Phim.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Phim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Phim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Phim.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Phim.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Phim.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Phim.ColumnHeadersHeight = 40;
            this.dgv_Phim.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_Phim.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Phim.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Phim.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Phim.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Phim.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Phim.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Phim.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Phim.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Phim.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_Phim.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Phim.CurrentTheme.Name = null;
            this.dgv_Phim.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Phim.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Phim.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Phim.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Phim.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Phim.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Phim.EnableHeadersVisualStyles = false;
            this.dgv_Phim.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Phim.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Phim.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Phim.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Phim.Location = new System.Drawing.Point(20, 19);
            this.dgv_Phim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_Phim.Name = "dgv_Phim";
            this.dgv_Phim.RowHeadersVisible = false;
            this.dgv_Phim.RowHeadersWidth = 51;
            this.dgv_Phim.RowTemplate.Height = 40;
            this.dgv_Phim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phim.Size = new System.Drawing.Size(755, 327);
            this.dgv_Phim.TabIndex = 0;
            this.dgv_Phim.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgv_Phim.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Phim_CellContentClick);
            // 
            // bunifuShadowPanel3
            // 
            this.bunifuShadowPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel3.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel3.BorderRadius = 10;
            this.bunifuShadowPanel3.BorderThickness = 1;
            this.bunifuShadowPanel3.Controls.Add(this.Bieudo_SP);
            this.bunifuShadowPanel3.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel3.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel3.Location = new System.Drawing.Point(856, 52);
            this.bunifuShadowPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuShadowPanel3.Name = "bunifuShadowPanel3";
            this.bunifuShadowPanel3.PanelColor = System.Drawing.Color.White;
            this.bunifuShadowPanel3.PanelColor2 = System.Drawing.Color.White;
            this.bunifuShadowPanel3.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel3.ShadowDept = 2;
            this.bunifuShadowPanel3.ShadowDepth = 5;
            this.bunifuShadowPanel3.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel3.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel3.Size = new System.Drawing.Size(617, 332);
            this.bunifuShadowPanel3.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel3.TabIndex = 1;
            // 
            // Bieudo_SP
            // 
            chartArea2.Name = "ChartArea1";
            this.Bieudo_SP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Bieudo_SP.Legends.Add(legend2);
            this.Bieudo_SP.Location = new System.Drawing.Point(20, 18);
            this.Bieudo_SP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Bieudo_SP.Name = "Bieudo_SP";
            this.Bieudo_SP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "SanPham";
            this.Bieudo_SP.Series.Add(series2);
            this.Bieudo_SP.Size = new System.Drawing.Size(575, 295);
            this.Bieudo_SP.TabIndex = 0;
            this.Bieudo_SP.Text = "chart1";
            // 
            // bunifuShadowPanel4
            // 
            this.bunifuShadowPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel4.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel4.BorderRadius = 8;
            this.bunifuShadowPanel4.BorderThickness = 1;
            this.bunifuShadowPanel4.Controls.Add(this.dgv_SanPham);
            this.bunifuShadowPanel4.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.bunifuShadowPanel4.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.bunifuShadowPanel4.Location = new System.Drawing.Point(856, 373);
            this.bunifuShadowPanel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuShadowPanel4.Name = "bunifuShadowPanel4";
            this.bunifuShadowPanel4.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel4.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.bunifuShadowPanel4.ShadowColor = System.Drawing.Color.DarkGray;
            this.bunifuShadowPanel4.ShadowDept = 2;
            this.bunifuShadowPanel4.ShadowDepth = 5;
            this.bunifuShadowPanel4.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.bunifuShadowPanel4.ShadowTopLeftVisible = false;
            this.bunifuShadowPanel4.Size = new System.Drawing.Size(617, 369);
            this.bunifuShadowPanel4.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.bunifuShadowPanel4.TabIndex = 2;
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgv_SanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_SanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_SanPham.ColumnHeadersHeight = 40;
            this.dgv_SanPham.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_SanPham.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_SanPham.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_SanPham.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_SanPham.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_SanPham.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SanPham.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_SanPham.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_SanPham.CurrentTheme.Name = null;
            this.dgv_SanPham.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_SanPham.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_SanPham.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SanPham.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_SanPham.EnableHeadersVisualStyles = false;
            this.dgv_SanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_SanPham.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_SanPham.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_SanPham.Location = new System.Drawing.Point(20, 25);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.RowHeadersVisible = false;
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.RowTemplate.Height = 40;
            this.dgv_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SanPham.Size = new System.Drawing.Size(575, 327);
            this.dgv_SanPham.TabIndex = 0;
            this.dgv_SanPham.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // cbb_thongKe
            // 
            this.cbb_thongKe.BackColor = System.Drawing.Color.Transparent;
            this.cbb_thongKe.BackgroundColor = System.Drawing.Color.White;
            this.cbb_thongKe.BorderColor = System.Drawing.Color.Aqua;
            this.cbb_thongKe.BorderRadius = 8;
            this.cbb_thongKe.Color = System.Drawing.Color.Aqua;
            this.cbb_thongKe.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbb_thongKe.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbb_thongKe.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_thongKe.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbb_thongKe.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbb_thongKe.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbb_thongKe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_thongKe.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbb_thongKe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_thongKe.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbb_thongKe.FillDropDown = true;
            this.cbb_thongKe.FillIndicator = false;
            this.cbb_thongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_thongKe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_thongKe.ForeColor = System.Drawing.Color.Black;
            this.cbb_thongKe.FormattingEnabled = true;
            this.cbb_thongKe.Icon = null;
            this.cbb_thongKe.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbb_thongKe.IndicatorColor = System.Drawing.Color.Gray;
            this.cbb_thongKe.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbb_thongKe.ItemBackColor = System.Drawing.Color.White;
            this.cbb_thongKe.ItemBorderColor = System.Drawing.Color.White;
            this.cbb_thongKe.ItemForeColor = System.Drawing.Color.Black;
            this.cbb_thongKe.ItemHeight = 26;
            this.cbb_thongKe.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbb_thongKe.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbb_thongKe.ItemTopMargin = 3;
            this.cbb_thongKe.Location = new System.Drawing.Point(107, 5);
            this.cbb_thongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_thongKe.Name = "cbb_thongKe";
            this.cbb_thongKe.Size = new System.Drawing.Size(189, 32);
            this.cbb_thongKe.TabIndex = 4;
            this.cbb_thongKe.Text = null;
            this.cbb_thongKe.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbb_thongKe.TextLeftMargin = 5;
            this.cbb_thongKe.SelectedIndexChanged += new System.EventHandler(this.cbb_thongKe_SelectedIndexChanged);
            // 
            // cbb_thongKe2
            // 
            this.cbb_thongKe2.BackColor = System.Drawing.Color.Transparent;
            this.cbb_thongKe2.BackgroundColor = System.Drawing.Color.White;
            this.cbb_thongKe2.BorderColor = System.Drawing.Color.Aqua;
            this.cbb_thongKe2.BorderRadius = 8;
            this.cbb_thongKe2.Color = System.Drawing.Color.Aqua;
            this.cbb_thongKe2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbb_thongKe2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbb_thongKe2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbb_thongKe2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cbb_thongKe2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbb_thongKe2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbb_thongKe2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbb_thongKe2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbb_thongKe2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_thongKe2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbb_thongKe2.FillDropDown = true;
            this.cbb_thongKe2.FillIndicator = false;
            this.cbb_thongKe2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_thongKe2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cbb_thongKe2.ForeColor = System.Drawing.Color.Black;
            this.cbb_thongKe2.FormattingEnabled = true;
            this.cbb_thongKe2.Icon = null;
            this.cbb_thongKe2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbb_thongKe2.IndicatorColor = System.Drawing.Color.Gray;
            this.cbb_thongKe2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbb_thongKe2.ItemBackColor = System.Drawing.Color.White;
            this.cbb_thongKe2.ItemBorderColor = System.Drawing.Color.White;
            this.cbb_thongKe2.ItemForeColor = System.Drawing.Color.Black;
            this.cbb_thongKe2.ItemHeight = 26;
            this.cbb_thongKe2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cbb_thongKe2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cbb_thongKe2.ItemTopMargin = 3;
            this.cbb_thongKe2.Location = new System.Drawing.Point(325, 5);
            this.cbb_thongKe2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_thongKe2.Name = "cbb_thongKe2";
            this.cbb_thongKe2.Size = new System.Drawing.Size(133, 32);
            this.cbb_thongKe2.TabIndex = 4;
            this.cbb_thongKe2.Text = null;
            this.cbb_thongKe2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbb_thongKe2.TextLeftMargin = 5;
            this.cbb_thongKe2.SelectedIndexChanged += new System.EventHandler(this.cbb_thongKe2_SelectedIndexChanged);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bunifuLabel1.Location = new System.Drawing.Point(37, 12);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(37, 23);
            this.bunifuLabel1.TabIndex = 5;
            this.bunifuLabel1.Text = "Lọc  : ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 746);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.cbb_thongKe2);
            this.Controls.Add(this.cbb_thongKe);
            this.Controls.Add(this.bunifuShadowPanel4);
            this.Controls.Add(this.bunifuShadowPanel3);
            this.Controls.Add(this.bunifuShadowPanel2);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BieuDo_Phim)).EndInit();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.bunifuShadowPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phim)).EndInit();
            this.bunifuShadowPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Bieudo_SP)).EndInit();
            this.bunifuShadowPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BieuDo_Phim;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel1;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel2;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Phim;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart Bieudo_SP;
        private Bunifu.UI.WinForms.BunifuShadowPanel bunifuShadowPanel4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_SanPham;
        private Bunifu.UI.WinForms.BunifuDropdown cbb_thongKe;
        private Bunifu.UI.WinForms.BunifuDropdown cbb_thongKe2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}