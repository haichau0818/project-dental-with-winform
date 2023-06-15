namespace dental_manager.GUI.Forms
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            pnl_Header = new Panel();
            pic_Minimize = new PictureBox();
            pic_Close = new PictureBox();
            txt_Username = new TextBox();
            pic_Img_Dental = new PictureBox();
            lbl_Login = new Label();
            txt_Password = new TextBox();
            btn_SignIn = new Button();
            ckd_ForgotPassword = new CheckBox();
            pnl_Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_Minimize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_Img_Dental).BeginInit();
            SuspendLayout();
            // 
            // pnl_Header
            // 
            pnl_Header.BackColor = Color.White;
            pnl_Header.Controls.Add(pic_Minimize);
            pnl_Header.Controls.Add(pic_Close);
            pnl_Header.Dock = DockStyle.Top;
            pnl_Header.Location = new Point(0, 0);
            pnl_Header.Name = "pnl_Header";
            pnl_Header.Size = new Size(800, 30);
            pnl_Header.TabIndex = 0;
            // 
            // pic_Minimize
            // 
            pic_Minimize.Dock = DockStyle.Right;
            pic_Minimize.Image = (Image)resources.GetObject("pic_Minimize.Image");
            pic_Minimize.Location = new Point(740, 0);
            pic_Minimize.Name = "pic_Minimize";
            pic_Minimize.Size = new Size(30, 30);
            pic_Minimize.TabIndex = 1;
            pic_Minimize.TabStop = false;
            pic_Minimize.Click += pic_Minimize_Click;
            // 
            // pic_Close
            // 
            pic_Close.Dock = DockStyle.Right;
            pic_Close.Image = (Image)resources.GetObject("pic_Close.Image");
            pic_Close.Location = new Point(770, 0);
            pic_Close.Name = "pic_Close";
            pic_Close.Size = new Size(30, 30);
            pic_Close.TabIndex = 1;
            pic_Close.TabStop = false;
            pic_Close.Click += pic_Close_Click;
            // 
            // txt_Username
            // 
            txt_Username.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Username.ForeColor = Color.FromArgb(172, 209, 254);
            txt_Username.Location = new Point(427, 155);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(343, 28);
            txt_Username.TabIndex = 1;
            txt_Username.Text = "Username...";
            txt_Username.Click += txt_Username_Click;
            txt_Username.TextChanged += txt_Username_TextChanged;
            txt_Username.Leave += txt_Username_Leave;
            // 
            // pic_Img_Dental
            // 
            pic_Img_Dental.Dock = DockStyle.Left;
            pic_Img_Dental.Image = (Image)resources.GetObject("pic_Img_Dental.Image");
            pic_Img_Dental.Location = new Point(0, 30);
            pic_Img_Dental.Name = "pic_Img_Dental";
            pic_Img_Dental.Size = new Size(400, 370);
            pic_Img_Dental.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_Img_Dental.TabIndex = 2;
            pic_Img_Dental.TabStop = false;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.Font = new Font("Verdana", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Login.ForeColor = Color.FromArgb(36, 134, 206);
            lbl_Login.Location = new Point(542, 72);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new Size(123, 41);
            lbl_Login.TabIndex = 3;
            lbl_Login.Text = "Login";
            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Verdana", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.ForeColor = Color.FromArgb(172, 209, 254);
            txt_Password.Location = new Point(427, 202);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(343, 28);
            txt_Password.TabIndex = 1;
            txt_Password.Text = "Password...";
            txt_Password.Click += txt_Password_Click;
            txt_Password.TextChanged += txt_Password_TextChanged;
            txt_Password.Leave += txt_Password_Leave;
            // 
            // btn_SignIn
            // 
            btn_SignIn.BackColor = Color.FromArgb(172, 209, 254);
            btn_SignIn.FlatAppearance.BorderColor = Color.Gainsboro;
            btn_SignIn.FlatStyle = FlatStyle.Flat;
            btn_SignIn.Font = new Font("Verdana", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_SignIn.ForeColor = Color.FromArgb(36, 134, 206);
            btn_SignIn.Location = new Point(427, 279);
            btn_SignIn.Name = "btn_SignIn";
            btn_SignIn.Size = new Size(343, 43);
            btn_SignIn.TabIndex = 4;
            btn_SignIn.Text = "SIGN IN";
            btn_SignIn.UseVisualStyleBackColor = false;
            btn_SignIn.Click += btn_SignIn_Click;
            btn_SignIn.Leave += btn_SignIn_Leave;
            btn_SignIn.MouseLeave += btn_SignIn_MouseLeave;
            btn_SignIn.MouseHover += btn_SignIn_MouseHover;
            // 
            // ckd_ForgotPassword
            // 
            ckd_ForgotPassword.AutoSize = true;
            ckd_ForgotPassword.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ckd_ForgotPassword.ForeColor = Color.FromArgb(36, 134, 206);
            ckd_ForgotPassword.Location = new Point(427, 236);
            ckd_ForgotPassword.Name = "ckd_ForgotPassword";
            ckd_ForgotPassword.Size = new Size(112, 22);
            ckd_ForgotPassword.TabIndex = 6;
            ckd_ForgotPassword.Text = "Remember";
            ckd_ForgotPassword.UseVisualStyleBackColor = true;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 400);
            Controls.Add(ckd_ForgotPassword);
            Controls.Add(btn_SignIn);
            Controls.Add(lbl_Login);
            Controls.Add(pic_Img_Dental);
            Controls.Add(txt_Password);
            Controls.Add(txt_Username);
            Controls.Add(pnl_Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frm_Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_Login";
            Load += frm_Login_Load;
            pnl_Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_Minimize).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_Img_Dental).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnl_Header;
        private PictureBox pic_Minimize;
        private PictureBox pic_Close;
        private TextBox txt_Username;
        private PictureBox pic_Img_Dental;
        private Label lbl_Login;
        private TextBox txt_Password;
        private Button btn_SignIn;
        private CheckBox ckd_ForgotPassword;
    }
}