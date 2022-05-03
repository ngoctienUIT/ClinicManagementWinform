namespace ClinicManagement
{
    partial class Login
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NhoTaiKhoan = new System.Windows.Forms.CheckBox();
            this.QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.button_WOC1 = new ClinicManagement.Button_WOC();
            this.button_DangNhap = new ClinicManagement.Button_WOC();
            this.MatKhau = new ClinicManagement.RJTextBox();
            this.DangNhap = new ClinicManagement.RJTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClinicManagement.Properties.Resources.MainWindow;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 490);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NhoTaiKhoan
            // 
            this.NhoTaiKhoan.AutoSize = true;
            this.NhoTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.NhoTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NhoTaiKhoan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NhoTaiKhoan.Location = new System.Drawing.Point(174, 321);
            this.NhoTaiKhoan.Name = "NhoTaiKhoan";
            this.NhoTaiKhoan.Size = new System.Drawing.Size(121, 22);
            this.NhoTaiKhoan.TabIndex = 3;
            this.NhoTaiKhoan.Text = "Nhớ tài khoản";
            this.NhoTaiKhoan.UseVisualStyleBackColor = false;
            // 
            // QuenMatKhau
            // 
            this.QuenMatKhau.AutoSize = true;
            this.QuenMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.QuenMatKhau.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuenMatKhau.Location = new System.Drawing.Point(466, 321);
            this.QuenMatKhau.Name = "QuenMatKhau";
            this.QuenMatKhau.Size = new System.Drawing.Size(102, 20);
            this.QuenMatKhau.TabIndex = 4;
            this.QuenMatKhau.TabStop = true;
            this.QuenMatKhau.Text = "Quên mật khẩu";
            this.QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.QuenMatKhau_LinkClicked);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(83)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Location = new System.Drawing.Point(390, 361);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(119)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(190, 42);
            this.button_WOC1.TabIndex = 6;
            this.button_WOC1.Text = "Thoát";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.button_DangNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button_DangNhap.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(132)))), ((int)(((byte)(83)))));
            this.button_DangNhap.FlatAppearance.BorderSize = 0;
            this.button_DangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_DangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_DangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DangNhap.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.Location = new System.Drawing.Point(174, 361);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            this.button_DangNhap.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(119)))));
            this.button_DangNhap.OnHoverTextColor = System.Drawing.Color.White;
            this.button_DangNhap.Size = new System.Drawing.Size(190, 42);
            this.button_DangNhap.TabIndex = 5;
            this.button_DangNhap.Text = "Đăng nhập";
            this.button_DangNhap.TextColor = System.Drawing.Color.White;
            this.button_DangNhap.UseVisualStyleBackColor = false;
            this.button_DangNhap.Click += new System.EventHandler(this.button_DangNhap_Click);
            // 
            // MatKhau
            // 
            this.MatKhau.BackColor = System.Drawing.SystemColors.Window;
            this.MatKhau.BorderColor = System.Drawing.Color.Black;
            this.MatKhau.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.MatKhau.BorderRadius = 0;
            this.MatKhau.BorderSize = 2;
            this.MatKhau.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatKhau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MatKhau.Location = new System.Drawing.Point(160, 261);
            this.MatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.MatKhau.Multiline = false;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MatKhau.PasswordChar = true;
            this.MatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MatKhau.PlaceholderText = "Mật Khẩu";
            this.MatKhau.Size = new System.Drawing.Size(434, 39);
            this.MatKhau.TabIndex = 2;
            this.MatKhau.TabStop = false;
            this.MatKhau.Texts = "";
            this.MatKhau.UnderlinedStyle = false;
            // 
            // DangNhap
            // 
            this.DangNhap.BackColor = System.Drawing.SystemColors.Window;
            this.DangNhap.BorderColor = System.Drawing.Color.Black;
            this.DangNhap.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.DangNhap.BorderRadius = 0;
            this.DangNhap.BorderSize = 2;
            this.DangNhap.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DangNhap.Location = new System.Drawing.Point(160, 194);
            this.DangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.DangNhap.Multiline = false;
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DangNhap.PasswordChar = false;
            this.DangNhap.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DangNhap.PlaceholderText = "Tài Khoản";
            this.DangNhap.Size = new System.Drawing.Size(434, 39);
            this.DangNhap.TabIndex = 1;
            this.DangNhap.TabStop = false;
            this.DangNhap.Texts = "";
            this.DangNhap.UnderlinedStyle = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 461);
            this.ControlBox = false;
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.QuenMatKhau);
            this.Controls.Add(this.NhoTaiKhoan);
            this.Controls.Add(this.MatKhau);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý phòng mạch tư";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private ClinicManagement.RJTextBox DangNhap;
        private RJTextBox MatKhau;
        private System.Windows.Forms.CheckBox NhoTaiKhoan;
        private System.Windows.Forms.LinkLabel QuenMatKhau;
        private Button_WOC button_DangNhap;
        private Button_WOC button_WOC1;
    }
}

