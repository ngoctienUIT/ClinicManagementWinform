using System.Windows.Forms;

namespace ClinicManagement.View
{
    partial class AddNewStaff
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.add = new ClinicManagement.Button_WOC();
            this.back = new ClinicManagement.Button_WOC();
            this.fullName = new ClinicManagement.RJTextBox();
            this.cmnd = new ClinicManagement.RJTextBox();
            this.address = new ClinicManagement.RJTextBox();
            this.email = new ClinicManagement.RJTextBox();
            this.salary = new ClinicManagement.RJTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.salary);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.cmnd);
            this.panel1.Controls.Add(this.fullName);
            this.panel1.Controls.Add(this.back);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.birthday);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 575);
            this.panel1.TabIndex = 0;
            // 
            // birthday
            // 
            this.birthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthday.CalendarFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthday.Location = new System.Drawing.Point(501, 208);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(267, 22);
            this.birthday.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label10.Location = new System.Drawing.Point(355, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 24);
            this.label10.TabIndex = 10;
            this.label10.Text = "Chức vụ:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label9.Location = new System.Drawing.Point(355, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "CMND:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label8.Location = new System.Drawing.Point(355, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label7.Location = new System.Drawing.Point(355, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Địa chỉ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label6.Location = new System.Drawing.Point(355, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lương CB:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label5.Location = new System.Drawing.Point(355, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(355, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Họ và tên:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.id.Location = new System.Drawing.Point(139, 421);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(86, 24);
            this.id.TabIndex = 3;
            this.id.Text = "PMT007";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(38, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã NV:";
            // 
            // avatar
            // 
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Image = global::ClinicManagement.Properties.Resources.Screenshot_2022_05_02_175602;
            this.avatar.Location = new System.Drawing.Point(25, 95);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(238, 303);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 1;
            this.avatar.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(801, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM MỚI NHÂN VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(499, 314);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 32);
            this.comboBox1.TabIndex = 20;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.White;
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.ButtonColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Arial", 10.2F);
            this.add.Location = new System.Drawing.Point(292, 499);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.Size = new System.Drawing.Size(178, 39);
            this.add.TabIndex = 113;
            this.add.Text = "Thêm";
            this.add.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.add.UseVisualStyleBackColor = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.ButtonColor = System.Drawing.Color.White;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Arial", 10.2F);
            this.back.Location = new System.Drawing.Point(703, 2);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(63, 54);
            this.back.TabIndex = 114;
            this.back.Text = "X";
            this.back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // fullName
            // 
            this.fullName.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.fullName.BackColor = System.Drawing.SystemColors.Window;
            this.fullName.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.fullName.BorderFocusColor = System.Drawing.Color.Green;
            this.fullName.BorderRadius = 0;
            this.fullName.BorderSize = 2;
            this.fullName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.fullName.Location = new System.Drawing.Point(499, 81);
            this.fullName.Margin = new System.Windows.Forms.Padding(5);
            this.fullName.Multiline = false;
            this.fullName.Name = "fullName";
            this.fullName.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.fullName.PasswordChar = false;
            this.fullName.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.fullName.PlaceholderText = "Trần Ngọc Tiến";
            this.fullName.Size = new System.Drawing.Size(267, 38);
            this.fullName.TabIndex = 115;
            this.fullName.TabStop = false;
            this.fullName.Texts = "";
            this.fullName.UnderlinedStyle = true;
            // 
            // cmnd
            // 
            this.cmnd.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.cmnd.BackColor = System.Drawing.SystemColors.Window;
            this.cmnd.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.cmnd.BorderFocusColor = System.Drawing.Color.Green;
            this.cmnd.BorderRadius = 0;
            this.cmnd.BorderSize = 2;
            this.cmnd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmnd.Location = new System.Drawing.Point(499, 134);
            this.cmnd.Margin = new System.Windows.Forms.Padding(5);
            this.cmnd.Multiline = false;
            this.cmnd.Name = "cmnd";
            this.cmnd.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.cmnd.PasswordChar = false;
            this.cmnd.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cmnd.PlaceholderText = "123456789";
            this.cmnd.Size = new System.Drawing.Size(267, 38);
            this.cmnd.TabIndex = 116;
            this.cmnd.TabStop = false;
            this.cmnd.Texts = "";
            this.cmnd.UnderlinedStyle = true;
            // 
            // address
            // 
            this.address.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.address.BackColor = System.Drawing.SystemColors.Window;
            this.address.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.address.BorderFocusColor = System.Drawing.Color.Green;
            this.address.BorderRadius = 0;
            this.address.BorderSize = 2;
            this.address.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.address.Location = new System.Drawing.Point(499, 250);
            this.address.Margin = new System.Windows.Forms.Padding(5);
            this.address.Multiline = false;
            this.address.Name = "address";
            this.address.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.address.PasswordChar = false;
            this.address.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.address.PlaceholderText = "Ninh Hòa, Khánh Hòa";
            this.address.Size = new System.Drawing.Size(267, 38);
            this.address.TabIndex = 117;
            this.address.TabStop = false;
            this.address.Texts = "";
            this.address.UnderlinedStyle = true;
            // 
            // email
            // 
            this.email.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.email.BackColor = System.Drawing.SystemColors.Window;
            this.email.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.email.BorderFocusColor = System.Drawing.Color.Green;
            this.email.BorderRadius = 0;
            this.email.BorderSize = 2;
            this.email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.email.Location = new System.Drawing.Point(499, 360);
            this.email.Margin = new System.Windows.Forms.Padding(5);
            this.email.Multiline = false;
            this.email.Name = "email";
            this.email.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.email.PasswordChar = false;
            this.email.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.email.PlaceholderText = "ngoctienTNT.vn@gmail.com";
            this.email.Size = new System.Drawing.Size(267, 38);
            this.email.TabIndex = 118;
            this.email.TabStop = false;
            this.email.Texts = "";
            this.email.UnderlinedStyle = true;
            // 
            // salary
            // 
            this.salary.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.salary.BackColor = System.Drawing.SystemColors.Window;
            this.salary.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.salary.BorderFocusColor = System.Drawing.Color.Green;
            this.salary.BorderRadius = 0;
            this.salary.BorderSize = 2;
            this.salary.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.salary.Location = new System.Drawing.Point(499, 407);
            this.salary.Margin = new System.Windows.Forms.Padding(5);
            this.salary.Multiline = false;
            this.salary.Name = "salary";
            this.salary.Padding = new System.Windows.Forms.Padding(11, 7, 11, 7);
            this.salary.PasswordChar = false;
            this.salary.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.salary.PlaceholderText = "100000000";
            this.salary.Size = new System.Drawing.Size(267, 38);
            this.salary.TabIndex = 119;
            this.salary.TabStop = false;
            this.salary.Texts = "";
            this.salary.UnderlinedStyle = true;
            // 
            // AddNewStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 572);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 590);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(820, 590);
            this.Name = "AddNewStaff";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthday;
        private ComboBox comboBox1;
        private Button_WOC add;
        private Button_WOC back;
        private RJTextBox salary;
        private RJTextBox email;
        private RJTextBox address;
        private RJTextBox cmnd;
        private RJTextBox fullName;
    }
}