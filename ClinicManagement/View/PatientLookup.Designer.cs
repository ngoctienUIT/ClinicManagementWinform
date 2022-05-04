namespace ClinicManagement.View
{
    partial class PatientLookup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.customPanel1 = new ClinicManagement.CustomView.CustomPanel();
            this.search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.avatar = new System.Windows.Forms.PictureBox();
            this.down = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.printList = new ClinicManagement.Button_WOC();
            this.back = new ClinicManagement.Button_WOC();
            this.panel1.SuspendLayout();
            this.customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1914, 78);
            this.panel1.TabIndex = 0;
            // 
            // name
            // 
            this.name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(1666, 27);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(142, 23);
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
            this.customPanel1.Location = new System.Drawing.Point(674, 12);
            this.customPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customPanel1.Name = "customPanel1";
            this.customPanel1.padding = 2;
            this.customPanel1.radius = 90;
            this.customPanel1.Size = new System.Drawing.Size(752, 50);
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
            this.search.Size = new System.Drawing.Size(670, 31);
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
            this.avatar.Image = global::ClinicManagement.Properties.Resources.PatientLookup;
            this.avatar.Location = new System.Drawing.Point(1600, 12);
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
            this.down.Location = new System.Drawing.Point(1833, 20);
            this.down.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(40, 39);
            this.down.TabIndex = 2;
            this.down.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.title.Location = new System.Drawing.Point(91, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(484, 50);
            this.title.TabIndex = 1;
            this.title.Text = "TRA CỨU BỆNH NHÂN";
            // 
            // icon
            // 
            this.icon.Image = global::ClinicManagement.Properties.Resources.PatientLookup;
            this.icon.InitialImage = global::ClinicManagement.Properties.Resources.PatientLookup;
            this.icon.Location = new System.Drawing.Point(13, 7);
            this.icon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(69, 70);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial,
            this.patientCode,
            this.fullName,
            this.day,
            this.type,
            this.symptom});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(13, 145);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1877, 740);
            this.dataGridView1.TabIndex = 1;
            // 
            // serial
            // 
            this.serial.HeaderText = "STT";
            this.serial.MinimumWidth = 6;
            this.serial.Name = "serial";
            // 
            // patientCode
            // 
            this.patientCode.HeaderText = "Mã bệnh nhân";
            this.patientCode.MinimumWidth = 6;
            this.patientCode.Name = "patientCode";
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Họ tên";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            // 
            // day
            // 
            this.day.HeaderText = "Ngày khám";
            this.day.MinimumWidth = 6;
            this.day.Name = "day";
            // 
            // type
            // 
            this.type.HeaderText = "Loại bệnh";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            // 
            // symptom
            // 
            this.symptom.HeaderText = "Triệu chứng";
            this.symptom.MinimumWidth = 6;
            this.symptom.Name = "symptom";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1914, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "DANH SÁCH BỆNH NHÂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.printList);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1914, 990);
            this.panel2.TabIndex = 3;
            // 
            // printList
            // 
            this.printList.BackColor = System.Drawing.Color.White;
            this.printList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.printList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printList.ButtonColor = System.Drawing.Color.White;
            this.printList.FlatAppearance.BorderSize = 0;
            this.printList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.printList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.printList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printList.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printList.Location = new System.Drawing.Point(977, 906);
            this.printList.Margin = new System.Windows.Forms.Padding(2);
            this.printList.Name = "printList";
            this.printList.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printList.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.printList.OnHoverTextColor = System.Drawing.Color.White;
            this.printList.Size = new System.Drawing.Size(334, 59);
            this.printList.TabIndex = 114;
            this.printList.Text = "In danh sách";
            this.printList.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.printList.UseVisualStyleBackColor = false;
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
            this.back.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(1589, 906);
            this.back.Margin = new System.Windows.Forms.Padding(2);
            this.back.Name = "back";
            this.back.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.back.OnHoverTextColor = System.Drawing.Color.White;
            this.back.Size = new System.Drawing.Size(230, 59);
            this.back.TabIndex = 115;
            this.back.Text = "Quay về";
            this.back.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.back.UseVisualStyleBackColor = false;
            // 
            // PatientLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 1072);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1078);
            this.Name = "PatientLookup";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.PatientLookup_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.customPanel1.ResumeLayout(false);
            this.customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private global::ClinicManagement.CustomView.CustomPanel customPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn day;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Button_WOC back;
        private Button_WOC printList;
    }
}