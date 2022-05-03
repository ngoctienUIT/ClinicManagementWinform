namespace ClinicManagement.View
{
    partial class MedicineReport
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
            this.Headpanel = new System.Windows.Forms.Panel();
            this.SearchPanel = new ClinicManagement.CustomView.CustomPanel();
            this.SearchTextBox = new ClinicManagement.RJTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.medicine_management_label = new System.Windows.Forms.Label();
            this.medicine_icon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.year_label = new System.Windows.Forms.Label();
            this.YearComboBox = new System.Windows.Forms.ComboBox();
            this.month_label = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MedicineReportDataGridView = new System.Windows.Forms.DataGridView();
            this.PrintReportButton = new ClinicManagement.Button_WOC();
            this.BackButton = new ClinicManagement.Button_WOC();
            this.Headpanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineReportDataGridView)).BeginInit();
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
            this.Headpanel.Size = new System.Drawing.Size(1264, 86);
            this.Headpanel.TabIndex = 1;
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
            this.SearchPanel.Location = new System.Drawing.Point(397, 13);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.padding = 1;
            this.SearchPanel.radius = 90;
            this.SearchPanel.Size = new System.Drawing.Size(448, 62);
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
            this.SearchTextBox.Location = new System.Drawing.Point(54, 13);
            this.SearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.SearchTextBox.Multiline = false;
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.SearchTextBox.PasswordChar = false;
            this.SearchTextBox.PlaceholderColor = System.Drawing.Color.Black;
            this.SearchTextBox.PlaceholderText = "Tìm kiếm";
            this.SearchTextBox.Size = new System.Drawing.Size(378, 39);
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
            this.SearchButton.Location = new System.Drawing.Point(12, 13);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(12, 13, 0, 0);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(38, 38);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SearchButton.UseVisualStyleBackColor = false;
            // 
            // medicine_management_label
            // 
            this.medicine_management_label.AutoSize = true;
            this.medicine_management_label.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.medicine_management_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.medicine_management_label.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.medicine_management_label.Location = new System.Drawing.Point(80, 11);
            this.medicine_management_label.Name = "medicine_management_label";
            this.medicine_management_label.Size = new System.Drawing.Size(202, 64);
            this.medicine_management_label.TabIndex = 1;
            this.medicine_management_label.Text = "BÁO CÁO SỬ\r\nDỤNG THUỐC";
            // 
            // medicine_icon
            // 
            this.medicine_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.medicine_icon.Image = global::ClinicManagement.Properties.Resources.report;
            this.medicine_icon.Location = new System.Drawing.Point(12, 13);
            this.medicine_icon.Name = "medicine_icon";
            this.medicine_icon.Size = new System.Drawing.Size(62, 62);
            this.medicine_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.medicine_icon.TabIndex = 0;
            this.medicine_icon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.year_label);
            this.panel1.Controls.Add(this.YearComboBox);
            this.panel1.Controls.Add(this.month_label);
            this.panel1.Controls.Add(this.MonthComboBox);
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 47);
            this.panel1.TabIndex = 2;
            // 
            // year_label
            // 
            this.year_label.AutoSize = true;
            this.year_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.year_label.Location = new System.Drawing.Point(728, 11);
            this.year_label.Name = "year_label";
            this.year_label.Size = new System.Drawing.Size(62, 24);
            this.year_label.TabIndex = 4;
            this.year_label.Text = "Năm:";
            // 
            // YearComboBox
            // 
            this.YearComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearComboBox.FormattingEnabled = true;
            this.YearComboBox.Location = new System.Drawing.Point(796, 9);
            this.YearComboBox.Name = "YearComboBox";
            this.YearComboBox.Size = new System.Drawing.Size(189, 30);
            this.YearComboBox.TabIndex = 3;
            // 
            // month_label
            // 
            this.month_label.AutoSize = true;
            this.month_label.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.month_label.Location = new System.Drawing.Point(393, 11);
            this.month_label.Name = "month_label";
            this.month_label.Size = new System.Drawing.Size(81, 24);
            this.month_label.TabIndex = 2;
            this.month_label.Text = "Tháng:";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Location = new System.Drawing.Point(480, 9);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(189, 30);
            this.MonthComboBox.TabIndex = 0;
            // 
            // MedicineReportDataGridView
            // 
            this.MedicineReportDataGridView.AllowUserToAddRows = false;
            this.MedicineReportDataGridView.AllowUserToDeleteRows = false;
            this.MedicineReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicineReportDataGridView.Location = new System.Drawing.Point(0, 146);
            this.MedicineReportDataGridView.Name = "MedicineReportDataGridView";
            this.MedicineReportDataGridView.Size = new System.Drawing.Size(1264, 525);
            this.MedicineReportDataGridView.TabIndex = 3;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.PrintReportButton.ButtonColor = System.Drawing.Color.White;
            this.PrintReportButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReportButton.Location = new System.Drawing.Point(824, 681);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.PrintReportButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.PrintReportButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.PrintReportButton.Size = new System.Drawing.Size(189, 40);
            this.PrintReportButton.TabIndex = 7;
            this.PrintReportButton.Text = "In báo cáo";
            this.PrintReportButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.PrintReportButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.BackButton.ButtonColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1052, 681);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BackButton.Size = new System.Drawing.Size(200, 40);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Quay lại";
            this.BackButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // MedicineReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 733);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.PrintReportButton);
            this.Controls.Add(this.MedicineReportDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Headpanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MedicineReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicineReport";
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicineReportDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headpanel;
        private CustomView.CustomPanel SearchPanel;
        private RJTextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label medicine_management_label;
        private System.Windows.Forms.PictureBox medicine_icon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label year_label;
        private System.Windows.Forms.ComboBox YearComboBox;
        private System.Windows.Forms.Label month_label;
        private System.Windows.Forms.DataGridView MedicineReportDataGridView;
        private Button_WOC PrintReportButton;
        private Button_WOC BackButton;
    }
}