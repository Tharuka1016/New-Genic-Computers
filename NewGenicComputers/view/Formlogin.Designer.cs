namespace NEW_GENIC_COMPUTER.PAL
{
    partial class Formlogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            picClose = new PictureBox();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            picHide = new PictureBox();
            picShow = new PictureBox();
            label4 = new Label();
            btnLogin = new Button();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2HtmlToolTip1 = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picShow).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(39, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 58);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8.25F);
            label1.Location = new Point(112, 34);
            label1.Name = "label1";
            label1.Size = new Size(177, 13);
            label1.TabIndex = 0;
            label1.Text = " NEW GENIC COMPUTER | LOG IN";
            // 
            // picClose
            // 
            picClose.Image = (Image)resources.GetObject("picClose.Image");
            picClose.Location = new Point(519, 12);
            picClose.Name = "picClose";
            picClose.Size = new Size(35, 35);
            picClose.SizeMode = PictureBoxSizeMode.Zoom;
            picClose.TabIndex = 2;
            picClose.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(163, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(262, 225);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.25F);
            label2.Location = new Point(134, 271);
            label2.Name = "label2";
            label2.Size = new Size(69, 17);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(133, 291);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(336, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(133, 352);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(336, 23);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.25F);
            label3.Location = new Point(137, 332);
            label3.Name = "label3";
            label3.Size = new Size(66, 17);
            label3.TabIndex = 0;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // picHide
            // 
            picHide.Image = (Image)resources.GetObject("picHide.Image");
            picHide.Location = new Point(440, 352);
            picHide.Name = "picHide";
            picHide.Size = new Size(30, 23);
            picHide.SizeMode = PictureBoxSizeMode.Zoom;
            picHide.TabIndex = 8;
            picHide.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picHide, "Hide Password");
            // 
            // picShow
            // 
            picShow.Image = (Image)resources.GetObject("picShow.Image");
            picShow.Location = new Point(404, 462);
            picShow.Name = "picShow";
            picShow.Size = new Size(30, 23);
            picShow.SizeMode = PictureBoxSizeMode.Zoom;
            picShow.TabIndex = 9;
            picShow.TabStop = false;
            guna2HtmlToolTip1.SetToolTip(picShow, "Show Password");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI Semibold", 9.25F);
            label4.ForeColor = Color.FromArgb(57, 151, 196);
            label4.Location = new Point(239, 387);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 0;
            label4.Text = "Forgot Password?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(22, 67, 108);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(137, 462);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(339, 38);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Log In";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.TargetControl = btnLogin;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.TargetControl = this;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2HtmlToolTip1
            // 
            guna2HtmlToolTip1.AllowLinksHandling = true;
            guna2HtmlToolTip1.MaximumSize = new Size(0, 0);
            // 
            // Formlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(567, 560);
            Controls.Add(picShow);
            Controls.Add(btnLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(picClose);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(picHide);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Formlogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "888888";
            Load += Formlogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)picShow).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox picClose;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private PictureBox picHide;
        private PictureBox picShow;
        private Label label4;
        private Button btnLogin;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2HtmlToolTip guna2HtmlToolTip1;
    }
}