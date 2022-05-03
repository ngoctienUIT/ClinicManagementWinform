namespace ClinicManagement.View
{
    partial class EmployeesList
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
            this.employees_list_label = new System.Windows.Forms.Label();
            this.EmployeesListDataGridView = new System.Windows.Forms.DataGridView();
            this.BackButton = new ClinicManagement.Button_WOC();
            this.AddNewEmployee = new ClinicManagement.Button_WOC();
            this.CreateSalaryTableButton = new ClinicManagement.Button_WOC();
            this.Headpanel.SuspendLayout();
            this.SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesListDataGridView)).BeginInit();
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
            this.Headpanel.TabIndex = 2;
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
            this.SearchPanel.Location = new System.Drawing.Point(407, 13);
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
            this.SearchTextBox.Location = new System.Drawing.Point(51, 13);
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
            this.medicine_management_label.Location = new System.Drawing.Point(80, 26);
            this.medicine_management_label.Name = "medicine_management_label";
            this.medicine_management_label.Size = new System.Drawing.Size(296, 32);
            this.medicine_management_label.TabIndex = 1;
            this.medicine_management_label.Text = "QUẢN LÝ NHÂN VIÊN";
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
            // employees_list_label
            // 
            this.employees_list_label.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employees_list_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.employees_list_label.Location = new System.Drawing.Point(0, 90);
            this.employees_list_label.Name = "employees_list_label";
            this.employees_list_label.Size = new System.Drawing.Size(1261, 70);
            this.employees_list_label.TabIndex = 3;
            this.employees_list_label.Text = "DANH SÁCH NHÂN VIÊN";
            this.employees_list_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmployeesListDataGridView
            // 
            this.EmployeesListDataGridView.AllowUserToAddRows = false;
            this.EmployeesListDataGridView.AllowUserToDeleteRows = false;
            this.EmployeesListDataGridView.AllowUserToOrderColumns = true;
            this.EmployeesListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeesListDataGridView.Location = new System.Drawing.Point(0, 163);
            this.EmployeesListDataGridView.Name = "EmployeesListDataGridView";
            this.EmployeesListDataGridView.Size = new System.Drawing.Size(1264, 423);
            this.EmployeesListDataGridView.TabIndex = 4;
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
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Quay lại";
            this.BackButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.AddNewEmployee.ButtonColor = System.Drawing.Color.White;
            this.AddNewEmployee.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewEmployee.Location = new System.Drawing.Point(12, 629);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.AddNewEmployee.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.AddNewEmployee.OnHoverTextColor = System.Drawing.Color.Gray;
            this.AddNewEmployee.Size = new System.Drawing.Size(254, 40);
            this.AddNewEmployee.TabIndex = 11;
            this.AddNewEmployee.Text = "Thêm nhân viên mới";
            this.AddNewEmployee.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.AddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // CreateSalaryTableButton
            // 
            this.CreateSalaryTableButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.CreateSalaryTableButton.ButtonColor = System.Drawing.Color.White;
            this.CreateSalaryTableButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateSalaryTableButton.Location = new System.Drawing.Point(329, 629);
            this.CreateSalaryTableButton.Name = "CreateSalaryTableButton";
            this.CreateSalaryTableButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.CreateSalaryTableButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.CreateSalaryTableButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.CreateSalaryTableButton.Size = new System.Drawing.Size(352, 40);
            this.CreateSalaryTableButton.TabIndex = 12;
            this.CreateSalaryTableButton.Text = "Lập bảng tính lương nhân viên";
            this.CreateSalaryTableButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.CreateSalaryTableButton.UseVisualStyleBackColor = true;
            // 
            // EmployeesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.CreateSalaryTableButton);
            this.Controls.Add(this.AddNewEmployee);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EmployeesListDataGridView);
            this.Controls.Add(this.employees_list_label);
            this.Controls.Add(this.Headpanel);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EmployeesList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeesList";
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            this.SearchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeesListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headpanel;
        private CustomView.CustomPanel SearchPanel;
        private RJTextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label medicine_management_label;
        private System.Windows.Forms.PictureBox medicine_icon;
        private System.Windows.Forms.Label employees_list_label;
        private System.Windows.Forms.DataGridView EmployeesListDataGridView;
        private Button_WOC BackButton;
        private Button_WOC AddNewEmployee;
        private Button_WOC CreateSalaryTableButton;
    }
}