namespace ClinicManagement.View
{
    partial class MedicineManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Headpanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new ClinicManagement.CustomView.CustomPanel();
            this.SearchTextBox = new ClinicManagement.RJTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.medicine_management_label = new System.Windows.Forms.Label();
            this.medicine_icon = new System.Windows.Forms.PictureBox();
            this.import_sold_rate_label = new System.Windows.Forms.Label();
            this.ImportSoldRateTextBox = new ClinicManagement.RJTextBox();
            this.SaveRateButton = new ClinicManagement.Button_WOC();
            this.percentage_label = new System.Windows.Forms.Label();
            this.AddNewMedicineButton = new ClinicManagement.Button_WOC();
            this.MakeMedicineReportButton = new ClinicManagement.Button_WOC();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MedicineManagementTable = new System.Windows.Forms.DataGridView();
            this.STT_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_Thuoc_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten_Thuoc_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_Nhap_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong_Ton_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Nhap_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia_Ban_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicine_Infor_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BackButton = new ClinicManagement.Button_WOC();
            this.Headpanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineManagementTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Headpanel
            // 
            this.Headpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.Headpanel.Controls.Add(this.SearchPanel);
            this.Headpanel.Controls.Add(this.medicine_management_label);
            this.Headpanel.Controls.Add(this.medicine_icon);
            this.Headpanel.Location = new System.Drawing.Point(0, 0);
            this.Headpanel.Name = "Headpanel";
            this.Headpanel.Size = new System.Drawing.Size(1264, 80);
            this.Headpanel.TabIndex = 0;
            // 
            // SearchPanel
            // 
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.SearchPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchPanel.borderColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(135)))), ((int)(((byte)(135)))));
            this.SearchPanel.borderWidth = 2;
            this.SearchPanel.Controls.Add(this.SearchTextBox);
            this.SearchPanel.Controls.Add(this.SearchButton);
            this.SearchPanel.fillColor = System.Drawing.Color.White;
            this.SearchPanel.ForeColor = System.Drawing.Color.Black;
            this.SearchPanel.isBorder = true;
            this.SearchPanel.isFill = true;
            this.SearchPanel.Location = new System.Drawing.Point(341, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.padding = 1;
            this.SearchPanel.radius = 90;
            this.SearchPanel.Size = new System.Drawing.Size(448, 58);
            this.SearchPanel.TabIndex = 2;
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.SearchTextBox.BorderColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BorderFocusColor = System.Drawing.Color.Transparent;
            this.SearchTextBox.BorderRadius = 0;
            this.SearchTextBox.BorderSize = 2;
            this.SearchTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchTextBox.Location = new System.Drawing.Point(51, 12);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.SearchTextBox.PasswordChar = false;
            this.SearchTextBox.PlaceholderColor = System.Drawing.Color.Black;
            this.SearchTextBox.PlaceholderText = "Tìm kiếm";
            this.SearchTextBox.Size = new System.Drawing.Size(378, 37);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.Texts = "";
            this.SearchTextBox.UnderlinedStyle = false;
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.BackgroundImage = global::ClinicManagement.Properties.Resources.search;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.ForeColor = System.Drawing.Color.Transparent;
            this.SearchButton.Location = new System.Drawing.Point(12, 12);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(12, 12, 0, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(35, 35);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // medicine_management_label
            // 
            this.medicine_management_label.AutoSize = true;
            this.medicine_management_label.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.medicine_management_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.medicine_management_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.medicine_management_label.Location = new System.Drawing.Point(76, 9);
            this.medicine_management_label.Name = "medicine_management_label";
            this.medicine_management_label.Size = new System.Drawing.Size(202, 64);
            this.medicine_management_label.TabIndex = 1;
            this.medicine_management_label.Text = "QUẢN LÝ SỬ\r\nDỤNG THUỐC";
            // 
            // medicine_icon
            // 
            this.medicine_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.medicine_icon.Image = global::ClinicManagement.Properties.Resources.Medicine;
            this.medicine_icon.Location = new System.Drawing.Point(12, 12);
            this.medicine_icon.Name = "medicine_icon";
            this.medicine_icon.Size = new System.Drawing.Size(58, 58);
            this.medicine_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicine_icon.TabIndex = 0;
            this.medicine_icon.TabStop = false;
            // 
            // import_sold_rate_label
            // 
            this.import_sold_rate_label.AutoSize = true;
            this.import_sold_rate_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_sold_rate_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.import_sold_rate_label.Location = new System.Drawing.Point(12, 9);
            this.import_sold_rate_label.Name = "import_sold_rate_label";
            this.import_sold_rate_label.Size = new System.Drawing.Size(186, 24);
            this.import_sold_rate_label.TabIndex = 1;
            this.import_sold_rate_label.Text = "Tỉ giá Nhập - bán:";
            // 
            // ImportSoldRateTextBox
            // 
            this.ImportSoldRateTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ImportSoldRateTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.ImportSoldRateTextBox.BorderFocusColor = System.Drawing.Color.DarkGreen;
            this.ImportSoldRateTextBox.BorderRadius = 0;
            this.ImportSoldRateTextBox.BorderSize = 1;
            this.ImportSoldRateTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportSoldRateTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.ImportSoldRateTextBox.Location = new System.Drawing.Point(205, 4);
            this.ImportSoldRateTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportSoldRateTextBox.Multiline = false;
            this.ImportSoldRateTextBox.Name = "ImportSoldRateTextBox";
            this.ImportSoldRateTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ImportSoldRateTextBox.PasswordChar = false;
            this.ImportSoldRateTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ImportSoldRateTextBox.PlaceholderText = "";
            this.ImportSoldRateTextBox.Size = new System.Drawing.Size(51, 33);
            this.ImportSoldRateTextBox.TabIndex = 2;
            this.ImportSoldRateTextBox.Texts = "";
            this.ImportSoldRateTextBox.UnderlinedStyle = true;
            // 
            // SaveRateButton
            // 
            this.SaveRateButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.SaveRateButton.ButtonColor = System.Drawing.Color.White;
            this.SaveRateButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveRateButton.Location = new System.Drawing.Point(296, 1);
            this.SaveRateButton.Name = "SaveRateButton";
            this.SaveRateButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.SaveRateButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.SaveRateButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.SaveRateButton.Size = new System.Drawing.Size(70, 40);
            this.SaveRateButton.TabIndex = 4;
            this.SaveRateButton.Text = "Lưu";
            this.SaveRateButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.SaveRateButton.UseVisualStyleBackColor = true;
            // 
            // percentage_label
            // 
            this.percentage_label.AutoSize = true;
            this.percentage_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.percentage_label.Location = new System.Drawing.Point(263, 9);
            this.percentage_label.Name = "percentage_label";
            this.percentage_label.Size = new System.Drawing.Size(27, 24);
            this.percentage_label.TabIndex = 5;
            this.percentage_label.Text = "%";
            // 
            // AddNewMedicineButton
            // 
            this.AddNewMedicineButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.AddNewMedicineButton.ButtonColor = System.Drawing.Color.White;
            this.AddNewMedicineButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewMedicineButton.Location = new System.Drawing.Point(695, 1);
            this.AddNewMedicineButton.Name = "AddNewMedicineButton";
            this.AddNewMedicineButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.AddNewMedicineButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.AddNewMedicineButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.AddNewMedicineButton.Size = new System.Drawing.Size(240, 40);
            this.AddNewMedicineButton.TabIndex = 6;
            this.AddNewMedicineButton.Text = "Thêm loại thuốc mới";
            this.AddNewMedicineButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.AddNewMedicineButton.UseVisualStyleBackColor = true;
            // 
            // MakeMedicineReportButton
            // 
            this.MakeMedicineReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.MakeMedicineReportButton.ButtonColor = System.Drawing.Color.White;
            this.MakeMedicineReportButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MakeMedicineReportButton.Location = new System.Drawing.Point(962, 1);
            this.MakeMedicineReportButton.Name = "MakeMedicineReportButton";
            this.MakeMedicineReportButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.MakeMedicineReportButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.MakeMedicineReportButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.MakeMedicineReportButton.Size = new System.Drawing.Size(290, 40);
            this.MakeMedicineReportButton.TabIndex = 7;
            this.MakeMedicineReportButton.Text = "Báo cáo sử dụng thuốc";
            this.MakeMedicineReportButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.MakeMedicineReportButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MakeMedicineReportButton);
            this.panel1.Controls.Add(this.ImportSoldRateTextBox);
            this.panel1.Controls.Add(this.AddNewMedicineButton);
            this.panel1.Controls.Add(this.import_sold_rate_label);
            this.panel1.Controls.Add(this.percentage_label);
            this.panel1.Controls.Add(this.SaveRateButton);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 41);
            this.panel1.TabIndex = 8;
            // 
            // MedicineManagementTable
            // 
            this.MedicineManagementTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineManagementTable.BackgroundColor = System.Drawing.Color.White;
            this.MedicineManagementTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineManagementTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.MedicineManagementTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineManagementTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT_Column,
            this.Ma_Thuoc_Column,
            this.Ten_Thuoc_Column,
            this.Ngay_Nhap_Column,
            this.Luong_Ton_Column,
            this.DVT_Column,
            this.Gia_Nhap_Column,
            this.Gia_Ban_Column,
            this.Medicine_Infor_Column});
            this.MedicineManagementTable.Location = new System.Drawing.Point(0, 133);
            this.MedicineManagementTable.Name = "MedicineManagementTable";
            this.MedicineManagementTable.Size = new System.Drawing.Size(1264, 492);
            this.MedicineManagementTable.TabIndex = 9;
            // 
            // STT_Column
            // 
            this.STT_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT_Column.FillWeight = 30F;
            this.STT_Column.HeaderText = "STT";
            this.STT_Column.Name = "STT_Column";
            this.STT_Column.ReadOnly = true;
            // 
            // Ma_Thuoc_Column
            // 
            this.Ma_Thuoc_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ma_Thuoc_Column.FillWeight = 83.94669F;
            this.Ma_Thuoc_Column.HeaderText = "Mã Thuốc";
            this.Ma_Thuoc_Column.Name = "Ma_Thuoc_Column";
            this.Ma_Thuoc_Column.ReadOnly = true;
            // 
            // Ten_Thuoc_Column
            // 
            this.Ten_Thuoc_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten_Thuoc_Column.FillWeight = 83.94669F;
            this.Ten_Thuoc_Column.HeaderText = "Tên Thuốc";
            this.Ten_Thuoc_Column.Name = "Ten_Thuoc_Column";
            this.Ten_Thuoc_Column.ReadOnly = true;
            // 
            // Ngay_Nhap_Column
            // 
            this.Ngay_Nhap_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ngay_Nhap_Column.FillWeight = 83.94669F;
            this.Ngay_Nhap_Column.HeaderText = "Ngày Nhập";
            this.Ngay_Nhap_Column.Name = "Ngay_Nhap_Column";
            this.Ngay_Nhap_Column.ReadOnly = true;
            // 
            // Luong_Ton_Column
            // 
            this.Luong_Ton_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Luong_Ton_Column.FillWeight = 83.94669F;
            this.Luong_Ton_Column.HeaderText = "Lượng Tồn";
            this.Luong_Ton_Column.Name = "Luong_Ton_Column";
            this.Luong_Ton_Column.ReadOnly = true;
            // 
            // DVT_Column
            // 
            this.DVT_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DVT_Column.FillWeight = 83.94669F;
            this.DVT_Column.HeaderText = "ĐVT";
            this.DVT_Column.Name = "DVT_Column";
            this.DVT_Column.ReadOnly = true;
            // 
            // Gia_Nhap_Column
            // 
            this.Gia_Nhap_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_Nhap_Column.FillWeight = 83.94669F;
            this.Gia_Nhap_Column.HeaderText = "Giá Nhập";
            this.Gia_Nhap_Column.Name = "Gia_Nhap_Column";
            this.Gia_Nhap_Column.ReadOnly = true;
            // 
            // Gia_Ban_Column
            // 
            this.Gia_Ban_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gia_Ban_Column.FillWeight = 83.94669F;
            this.Gia_Ban_Column.HeaderText = "Giá Bán";
            this.Gia_Ban_Column.Name = "Gia_Ban_Column";
            this.Gia_Ban_Column.ReadOnly = true;
            // 
            // Medicine_Infor_Column
            // 
            this.Medicine_Infor_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Medicine_Infor_Column.FillWeight = 83.94669F;
            this.Medicine_Infor_Column.HeaderText = "";
            this.Medicine_Infor_Column.Name = "Medicine_Infor_Column";
            this.Medicine_Infor_Column.ReadOnly = true;
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.BackButton.ButtonColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1052, 629);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BackButton.Size = new System.Drawing.Size(200, 40);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Quay lại";
            this.BackButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // MedicineManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MedicineManagementTable);
            this.Controls.Add(this.Headpanel);
            this.Controls.Add(this.panel1);
            this.Name = "MedicineManagement";
            this.Text = "MedicineManagement";
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineManagementTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headpanel;
        private System.Windows.Forms.PictureBox medicine_icon;
        private System.Windows.Forms.Label medicine_management_label;
        private CustomView.CustomPanel SearchPanel;
        private System.Windows.Forms.Button SearchButton;
        private RJTextBox SearchTextBox;
        private System.Windows.Forms.Label import_sold_rate_label;
        private RJTextBox ImportSoldRateTextBox;
        private Button_WOC SaveRateButton;
        private System.Windows.Forms.Label percentage_label;
        private Button_WOC AddNewMedicineButton;
        private Button_WOC MakeMedicineReportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MedicineManagementTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_Thuoc_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten_Thuoc_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_Nhap_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong_Ton_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_Nhap_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia_Ban_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Medicine_Infor_Column;
        private Button_WOC BackButton;
    }
}