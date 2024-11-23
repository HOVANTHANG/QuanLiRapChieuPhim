namespace QL_RapChieuPhim.Views
{
    partial class MessageError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageError));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_Ok = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label1.Location = new System.Drawing.Point(-1, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đã có ca chiếu trong khoảng thời gian này ";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 123;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(78, -58);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(247, 247);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 5;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.AllowAnimations = true;
            this.btn_Ok.AllowMouseEffects = true;
            this.btn_Ok.AllowToggling = false;
            this.btn_Ok.AnimationSpeed = 200;
            this.btn_Ok.AutoGenerateColors = false;
            this.btn_Ok.AutoRoundBorders = false;
            this.btn_Ok.AutoSizeLeftIcon = true;
            this.btn_Ok.AutoSizeRightIcon = true;
            this.btn_Ok.BackColor = System.Drawing.Color.Transparent;
            this.btn_Ok.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Ok.BackgroundImage")));
            this.btn_Ok.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Ok.ButtonText = "OK";
            this.btn_Ok.ButtonTextMarginLeft = 0;
            this.btn_Ok.ColorContrastOnClick = 45;
            this.btn_Ok.ColorContrastOnHover = 45;
            this.btn_Ok.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Ok.CustomizableEdges = borderEdges1;
            this.btn_Ok.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Ok.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Ok.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Ok.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Ok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Ok.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Ok.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Ok.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ok.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Ok.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Ok.IconMarginLeft = 11;
            this.btn_Ok.IconPadding = 10;
            this.btn_Ok.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Ok.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Ok.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Ok.IconSize = 25;
            this.btn_Ok.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.IdleBorderRadius = 1;
            this.btn_Ok.IdleBorderThickness = 1;
            this.btn_Ok.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.IdleIconLeftImage = null;
            this.btn_Ok.IdleIconRightImage = null;
            this.btn_Ok.IndicateFocus = false;
            this.btn_Ok.Location = new System.Drawing.Point(0, 175);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Ok.OnDisabledState.BorderRadius = 1;
            this.btn_Ok.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Ok.OnDisabledState.BorderThickness = 1;
            this.btn_Ok.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Ok.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Ok.OnDisabledState.IconLeftImage = null;
            this.btn_Ok.OnDisabledState.IconRightImage = null;
            this.btn_Ok.onHoverState.BorderColor = System.Drawing.Color.Red;
            this.btn_Ok.onHoverState.BorderRadius = 1;
            this.btn_Ok.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Ok.onHoverState.BorderThickness = 1;
            this.btn_Ok.onHoverState.FillColor = System.Drawing.Color.Red;
            this.btn_Ok.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.onHoverState.IconLeftImage = null;
            this.btn_Ok.onHoverState.IconRightImage = null;
            this.btn_Ok.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.OnIdleState.BorderRadius = 1;
            this.btn_Ok.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Ok.OnIdleState.BorderThickness = 1;
            this.btn_Ok.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.OnIdleState.IconLeftImage = null;
            this.btn_Ok.OnIdleState.IconRightImage = null;
            this.btn_Ok.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.OnPressedState.BorderRadius = 1;
            this.btn_Ok.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Ok.OnPressedState.BorderThickness = 1;
            this.btn_Ok.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.btn_Ok.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Ok.OnPressedState.IconLeftImage = null;
            this.btn_Ok.OnPressedState.IconRightImage = null;
            this.btn_Ok.Size = new System.Drawing.Size(400, 36);
            this.btn_Ok.TabIndex = 4;
            this.btn_Ok.Tag = "";
            this.btn_Ok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Ok.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Ok.TextMarginLeft = 0;
            this.btn_Ok.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Ok.UseDefaultRadiusAndThickness = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.label2.Location = new System.Drawing.Point(26, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Thêm suất chiếu không thành công";
            // 
            // MessageError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(400, 211);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.btn_Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageError";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageError";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Ok;
        private System.Windows.Forms.Label label2;
    }
}