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
            this.customPanel1 = new global::ClinicManagement.CustomView.CustomPanel();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back = new global::ClinicManagement.CustomView.CustomButton();
            this.report = new global::ClinicManagement.CustomView.CustomButton();
            this.printInvoiceList = new global::ClinicManagement.CustomView.CustomButton();
            this.toDate = new System.Windows.Forms.DateTimePicker();
            this.since = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tong = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.title.Location = new System.Drawing.Point(91, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(385, 38);
            this.title.TabIndex = 1;
            this.title.Text = "QUẢN LÝ DOANH THU";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.customPanel1);
            this.panel1.Controls.Add(this.avatar);
            this.panel1.Controls.Add(this.down);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.icon);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1389, 78);
            this.panel1.TabIndex = 1;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(1141, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(148, 25);
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
            this.customPanel1.Location = new System.Drawing.Point(567, 12);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.padding = 2;
            this.customPanel1.radius = 90;
            this.customPanel1.Size = new System.Drawing.Size(469, 50);
            this.customPanel1.TabIndex = 1;
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(65, 11);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(387, 31);
            this.search.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ClinicManagement.Properties.Resources.search;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(30, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 30);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // avatar
            // 
            this.avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.avatar.Image = global::ClinicManagement.Properties.Resources.revenue;
            this.avatar.Location = new System.Drawing.Point(1075, 12);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(51, 50);
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
            this.down.Location = new System.Drawing.Point(1325, 18);
            this.down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(40, 39);
            this.down.TabIndex = 2;
            this.down.UseVisualStyleBackColor = false;
            // 
            // icon
            // 
            this.icon.Image = global::ClinicManagement.Properties.Resources.revenue;
            this.icon.InitialImage = global::ClinicManagement.Properties.Resources.PatientLookup;
            this.icon.Location = new System.Drawing.Point(13, 7);
            this.icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(69, 70);
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
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.report);
            this.panel2.Controls.Add(this.printInvoiceList);
            this.panel2.Controls.Add(this.toDate);
            this.panel2.Controls.Add(this.since);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1389, 646);
            this.panel2.TabIndex = 2;
            // 
            // back
            // 
            this.back.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.back.BackColor = System.Drawing.Color.White;
            this.back.BackgroundColor = System.Drawing.Color.White;
            this.back.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.back.BorderRadius = 15;
            this.back.BorderSize = 2;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.back.Location = new System.Drawing.Point(1215, 592);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(150, 40);
            this.back.TabIndex = 8;
            this.back.Text = "Quay lại";
            this.back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.back.UseVisualStyleBackColor = false;
            // 
            // report
            // 
            this.report.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.report.BackColor = System.Drawing.Color.White;
            this.report.BackgroundColor = System.Drawing.Color.White;
            this.report.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.report.BorderRadius = 15;
            this.report.BorderSize = 2;
            this.report.FlatAppearance.BorderSize = 0;
            this.report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.report.Location = new System.Drawing.Point(383, 583);
            this.report.Name = "report";
            this.report.Size = new System.Drawing.Size(231, 40);
            this.report.TabIndex = 7;
            this.report.Text = "Lập báo cáo tháng";
            this.report.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.report.UseVisualStyleBackColor = false;
            // 
            // printInvoiceList
            // 
            this.printInvoiceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.printInvoiceList.BackColor = System.Drawing.Color.White;
            this.printInvoiceList.BackgroundColor = System.Drawing.Color.White;
            this.printInvoiceList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.printInvoiceList.BorderRadius = 15;
            this.printInvoiceList.BorderSize = 2;
            this.printInvoiceList.FlatAppearance.BorderSize = 0;
            this.printInvoiceList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printInvoiceList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printInvoiceList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.printInvoiceList.Location = new System.Drawing.Point(34, 583);
            this.printInvoiceList.Name = "printInvoiceList";
            this.printInvoiceList.Size = new System.Drawing.Size(252, 40);
            this.printInvoiceList.TabIndex = 6;
            this.printInvoiceList.Text = "In danh sách hóa đơn";
            this.printInvoiceList.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.printInvoiceList.UseVisualStyleBackColor = false;
            // 
            // toDate
            // 
            this.toDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.toDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDate.Location = new System.Drawing.Point(956, 79);
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(252, 22);
            this.toDate.TabIndex = 5;
            // 
            // since
            // 
            this.since.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.since.Location = new System.Drawing.Point(362, 79);
            this.since.Name = "since";
            this.since.Size = new System.Drawing.Size(252, 22);
            this.since.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(34, 124);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1331, 418);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(824, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(246, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1389, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // RevenueManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 726);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RevenueManagement";
            this.Text = "RevenueManagement";
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
        private CustomView.CustomButton back;
        private CustomView.CustomButton report;
        private CustomView.CustomButton printInvoiceList;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienKham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tong;
    }
}