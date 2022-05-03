namespace ClinicManagement.View
{
    partial class AddMedicineQuantity
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.adding_label = new System.Windows.Forms.Label();
            this.medicine_name_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.remaining_label = new System.Windows.Forms.Label();
            this.import_unit_price_label = new System.Windows.Forms.Label();
            this.ConfirmButton = new ClinicManagement.Button_WOC();
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.UnitLabel = new System.Windows.Forms.Label();
            this.MedicineNameLabel = new System.Windows.Forms.Label();
            this.AddingTextBox = new ClinicManagement.RJTextBox();
            this.ImportUnitPriceTextBox = new ClinicManagement.RJTextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.adding_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.medicine_name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.unit_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.import_unit_price_label, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 19);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(175, 272);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // adding_label
            // 
            this.adding_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.adding_label.AutoSize = true;
            this.adding_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adding_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.adding_label.Location = new System.Drawing.Point(10, 172);
            this.adding_label.Margin = new System.Windows.Forms.Padding(10);
            this.adding_label.Name = "adding_label";
            this.adding_label.Size = new System.Drawing.Size(155, 34);
            this.adding_label.TabIndex = 9;
            this.adding_label.Text = "Số lượng thêm:";
            this.adding_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // medicine_name_label
            // 
            this.medicine_name_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.medicine_name_label.AutoSize = true;
            this.medicine_name_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_name_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.medicine_name_label.Location = new System.Drawing.Point(10, 10);
            this.medicine_name_label.Margin = new System.Windows.Forms.Padding(10);
            this.medicine_name_label.Name = "medicine_name_label";
            this.medicine_name_label.Size = new System.Drawing.Size(111, 34);
            this.medicine_name_label.TabIndex = 6;
            this.medicine_name_label.Text = "Tên thuốc:";
            this.medicine_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // unit_label
            // 
            this.unit_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.unit_label.AutoSize = true;
            this.unit_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.unit_label.Location = new System.Drawing.Point(10, 64);
            this.unit_label.Margin = new System.Windows.Forms.Padding(10);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(118, 34);
            this.unit_label.TabIndex = 7;
            this.unit_label.Text = "Đơn vị tính:";
            this.unit_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remaining_label
            // 
            this.remaining_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.remaining_label.AutoSize = true;
            this.remaining_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.remaining_label.Location = new System.Drawing.Point(10, 118);
            this.remaining_label.Margin = new System.Windows.Forms.Padding(10);
            this.remaining_label.Name = "remaining_label";
            this.remaining_label.Size = new System.Drawing.Size(139, 34);
            this.remaining_label.TabIndex = 8;
            this.remaining_label.Text = "Số lượng tồn:";
            this.remaining_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // import_unit_price_label
            // 
            this.import_unit_price_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.import_unit_price_label.AutoSize = true;
            this.import_unit_price_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_unit_price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.import_unit_price_label.Location = new System.Drawing.Point(10, 226);
            this.import_unit_price_label.Margin = new System.Windows.Forms.Padding(10);
            this.import_unit_price_label.Name = "import_unit_price_label";
            this.import_unit_price_label.Size = new System.Drawing.Size(142, 36);
            this.import_unit_price_label.TabIndex = 10;
            this.import_unit_price_label.Text = "Đơn giá nhập:";
            this.import_unit_price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.ConfirmButton.ButtonColor = System.Drawing.Color.White;
            this.ConfirmButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmButton.Location = new System.Drawing.Point(109, 309);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.ConfirmButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.ConfirmButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.ConfirmButton.Size = new System.Drawing.Size(234, 40);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Xác nhận";
            this.ConfirmButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.Location = new System.Drawing.Point(218, 143);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(120, 22);
            this.RemainingLabel.TabIndex = 20;
            this.RemainingLabel.Text = "Số lượng tồn";
            // 
            // UnitLabel
            // 
            this.UnitLabel.AutoSize = true;
            this.UnitLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitLabel.Location = new System.Drawing.Point(218, 89);
            this.UnitLabel.Name = "UnitLabel";
            this.UnitLabel.Size = new System.Drawing.Size(100, 22);
            this.UnitLabel.TabIndex = 21;
            this.UnitLabel.Text = "Đơn vị tính";
            // 
            // MedicineNameLabel
            // 
            this.MedicineNameLabel.AutoSize = true;
            this.MedicineNameLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameLabel.Location = new System.Drawing.Point(218, 35);
            this.MedicineNameLabel.Name = "MedicineNameLabel";
            this.MedicineNameLabel.Size = new System.Drawing.Size(94, 22);
            this.MedicineNameLabel.TabIndex = 22;
            this.MedicineNameLabel.Text = "Tên thuốc";
            // 
            // AddingTextBox
            // 
            this.AddingTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.AddingTextBox.BorderColor = System.Drawing.Color.Black;
            this.AddingTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.AddingTextBox.BorderRadius = 0;
            this.AddingTextBox.BorderSize = 1;
            this.AddingTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddingTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddingTextBox.Location = new System.Drawing.Point(222, 188);
            this.AddingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddingTextBox.Multiline = false;
            this.AddingTextBox.Name = "AddingTextBox";
            this.AddingTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.AddingTextBox.PasswordChar = false;
            this.AddingTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.AddingTextBox.PlaceholderText = "Số lượng thêm";
            this.AddingTextBox.Size = new System.Drawing.Size(132, 37);
            this.AddingTextBox.TabIndex = 23;
            this.AddingTextBox.Texts = "";
            this.AddingTextBox.UnderlinedStyle = false;
            // 
            // ImportUnitPriceTextBox
            // 
            this.ImportUnitPriceTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ImportUnitPriceTextBox.BorderColor = System.Drawing.Color.Black;
            this.ImportUnitPriceTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.ImportUnitPriceTextBox.BorderRadius = 0;
            this.ImportUnitPriceTextBox.BorderSize = 1;
            this.ImportUnitPriceTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportUnitPriceTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ImportUnitPriceTextBox.Location = new System.Drawing.Point(222, 245);
            this.ImportUnitPriceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ImportUnitPriceTextBox.Multiline = false;
            this.ImportUnitPriceTextBox.Name = "ImportUnitPriceTextBox";
            this.ImportUnitPriceTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.ImportUnitPriceTextBox.PasswordChar = false;
            this.ImportUnitPriceTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.ImportUnitPriceTextBox.PlaceholderText = "Đơn giá nhập";
            this.ImportUnitPriceTextBox.Size = new System.Drawing.Size(132, 37);
            this.ImportUnitPriceTextBox.TabIndex = 24;
            this.ImportUnitPriceTextBox.Texts = "";
            this.ImportUnitPriceTextBox.UnderlinedStyle = false;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.ForeColor = System.Drawing.Color.Transparent;
            this.ExitButton.Image = global::ClinicManagement.Properties.Resources.exitbutton;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitButton.Location = new System.Drawing.Point(379, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(61, 55);
            this.ExitButton.TabIndex = 25;
            this.ExitButton.UseVisualStyleBackColor = false;
            // 
            // AddMedicineQuantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 361);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ImportUnitPriceTextBox);
            this.Controls.Add(this.AddingTextBox);
            this.Controls.Add(this.MedicineNameLabel);
            this.Controls.Add(this.UnitLabel);
            this.Controls.Add(this.RemainingLabel);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddMedicineQuantity";
            this.Text = "AddMedicineQuantity";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label adding_label;
        private System.Windows.Forms.Label medicine_name_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label remaining_label;
        private System.Windows.Forms.Label import_unit_price_label;
        private Button_WOC ConfirmButton;
        private System.Windows.Forms.Label RemainingLabel;
        private System.Windows.Forms.Label UnitLabel;
        private System.Windows.Forms.Label MedicineNameLabel;
        private RJTextBox AddingTextBox;
        private RJTextBox ImportUnitPriceTextBox;
        private System.Windows.Forms.Button ExitButton;
    }
}