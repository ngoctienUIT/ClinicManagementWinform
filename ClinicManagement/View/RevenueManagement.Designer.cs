namespace ClinicManagement.View
{
    partial class RevenueManagement
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
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.customPanel1 = new ClinicManagement.CustomView.CustomPanel();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.since = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new ClinicManagement.Button_WOC();
            this.back = new ClinicManagement.Button_WOC();
            this.button_WOC2 = new ClinicManagement.Button_WOC();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.title.Location = new System.Drawing.Point(66, 20);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(311, 32);
            this.title.TabIndex = 1;
            this.title.Text = "QUẢN LÝ DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.down);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1909, 100);
            this.panel1.TabIndex = 1;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(1685, 29);
            this.name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(116, 20);
            this.name.TabIndex = 5;
            this.name.Text = "Trần Ngọc Tiến";
            // 
            // customPanel1
            // 
            this.customPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customPanel1.BackColor = System.Drawing.Color.Transparent;
            this.customPanel1.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customPanel1.borderWidth = 2;
            this.customPanel1.Controls.Add(this.search);
            this.customPanel1.Controls.Add(this.pictureBox1);
            this.customPanel1.fillColor = System.Drawing.Color.White;
            this.customPanel1.isBorder = true;
            this.customPanel1.isFill = true;
            this.customPanel1.Location = new System.Drawing.Point(743, 20);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.padding = 2;
            this.customPanel1.radius = 90;
            this.customPanel1.Size = new System.Drawing.Size(476, 41);
            this.customPanel1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(49, 9);
            this.search.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(412, 25);
            this.search.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClinicManagement.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(22, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 24);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Image = global::ClinicManagement.Properties.Resources.revenue;
            this.avatar.Location = new System.Drawing.Point(1628, 15);
            this.avatar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(38, 41);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 4;
            this.avatar.TabStop = false;
            // 
            // down
            // 
            this.down.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.down.BackColor = System.Drawing.Color.Transparent;
            this.down.BackgroundImage = global::ClinicManagement.Properties.Resources.down_arrow;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down.Location = new System.Drawing.Point(1825, 6);
            this.down.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(57, 55);
            this.down.TabIndex = 2;
            this.down.UseVisualStyleBackColor = false;
            // 
            // icon
            // 
            this.icon.Image = global::ClinicManagement.Properties.Resources.revenue;
            this.icon.InitialImage = global::ClinicManagement.Properties.Resources.PatientLookup;
            this.icon.Location = new System.Drawing.Point(10, 9);
            this.icon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(52, 57);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.button_WOC2);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.toDate);
            this.panel2.Controls.Add(this.since);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1909, 994);
            this.panel2.TabIndex = 2;
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(1509, 82);
            this.toDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(270, 26);
            this.toDate.TabIndex = 5;
            // 
            // since
            // 
            this.since.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.since.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.since.Location = new System.Drawing.Point(273, 82);
            this.since.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.since.Name = "since";
            this.since.Size = new System.Drawing.Size(270, 26);
            this.since.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.maHoaDon,
            this.tenKhachHang,
            this.ngayKham,
            this.tienKham,
            this.tienThuoc,
            this.tong});
            this.dataGridView1.Location = new System.Drawing.Point(26, 125);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1856, 751);
            this.dataGridView1.TabIndex = 3;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            // 
            // maHoaDon
            // 
            this.maHoaDon.HeaderText = "Mã hóa đơn";
            this.maHoaDon.MinimumWidth = 6;
            this.maHoaDon.Name = "maHoaDon";
            // 
            // tenKhachHang
            // 
            this.tenKhachHang.HeaderText = "Tên khách hàng";
            this.tenKhachHang.MinimumWidth = 6;
            this.tenKhachHang.Name = "tenKhachHang";
            // 
            // ngayKham
            // 
            this.ngayKham.HeaderText = "Ngày khám";
            this.ngayKham.MinimumWidth = 6;
            this.ngayKham.Name = "ngayKham";
            // 
            // tienKham
            // 
            this.tienKham.HeaderText = "Tiền khám";
            this.tienKham.MinimumWidth = 6;
            this.tienKham.Name = "tienKham";
            // 
            // tienThuoc
            // 
            this.tienThuoc.HeaderText = "Tiền thuốc";
            this.tienThuoc.MinimumWidth = 6;
            this.tienThuoc.Name = "tienThuoc";
            // 
            // tong
            // 
            this.tong.HeaderText = "Tổng";
            this.tong.MinimumWidth = 6;
            this.tong.Name = "tong";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(1412, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(184, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1909, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.add.Location = new System.Drawing.Point(108, 912);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.add.OnHoverTextColor = System.Drawing.Color.White;
            this.add.Size = new System.Drawing.Size(311, 46);
            this.add.TabIndex = 114;
            this.add.Text = "In danh sách hóa đơn";
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
            this.back.Location = new System.Drawing.Point(1657, 912);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(134, 45);
            this.back.TabIndex = 115;
            this.back.Text = "Quay lại";
            this.back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.back.UseVisualStyleBackColor = false;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.White;
            this.button_WOC2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_WOC2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC2.ButtonColor = System.Drawing.Color.White;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Arial", 10.2F);
            this.button_WOC2.Location = new System.Drawing.Point(614, 912);
            this.button_WOC2.Margin = new System.Windows.Forms.Padding(2);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(264, 46);
            this.button_WOC2.TabIndex = 116;
            this.button_WOC2.Text = "Lập báo cáo tháng";
            this.button_WOC2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.button_WOC2.UseVisualStyleBackColor = false;
            // 
            // RevenueManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1072);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "RevenueManagement";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.RevenueManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label name;
        private CustomView.CustomPanel customPanel1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker toDate;
        private System.Windows.Forms.DateTimePicker since;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
        private Button_WOC button_WOC2;
        private Button_WOC back;
        private Button_WOC add;
    }
}