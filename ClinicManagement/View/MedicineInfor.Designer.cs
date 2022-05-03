namespace ClinicManagement.View
{
    partial class MedicineInfor
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
            this.medicine_management_label = new System.Windows.Forms.Label();
            this.medicine_icon = new System.Windows.Forms.PictureBox();
            this.medicine_infor_label = new System.Windows.Forms.Label();
            this.MedicinePicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddMedicineQuantityButton = new System.Windows.Forms.Button();
            this.RemainingLabel = new System.Windows.Forms.Label();
            this.SoldUnitPriceLabel = new System.Windows.Forms.Label();
            this.ImportUnitPriceLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new ClinicManagement.RJTextBox();
            this.TypeTextBox = new ClinicManagement.RJTextBox();
            this.UnitTextBox = new ClinicManagement.RJTextBox();
            this.MedicineNameTextBox = new ClinicManagement.RJTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.import_unit_price_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.type_label = new System.Windows.Forms.Label();
            this.sold_unit_price_label = new System.Windows.Forms.Label();
            this.medicine_name_label = new System.Windows.Forms.Label();
            this.unit_label = new System.Windows.Forms.Label();
            this.remaining_label = new System.Windows.Forms.Label();
            this.BackButton = new ClinicManagement.Button_WOC();
            this.UpdateMedicineButton = new ClinicManagement.Button_WOC();
            this.DeleteMedicineButton = new ClinicManagement.Button_WOC();
            this.Headpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinePicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Headpanel
            // 
            this.Headpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.Headpanel.Controls.Add(this.medicine_management_label);
            this.Headpanel.Controls.Add(this.medicine_icon);
            this.Headpanel.Location = new System.Drawing.Point(0, 0);
            this.Headpanel.Name = "Headpanel";
            this.Headpanel.Size = new System.Drawing.Size(1264, 80);
            this.Headpanel.TabIndex = 1;
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
            // medicine_infor_label
            // 
            this.medicine_infor_label.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicine_infor_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.medicine_infor_label.Location = new System.Drawing.Point(0, 83);
            this.medicine_infor_label.Name = "medicine_infor_label";
            this.medicine_infor_label.Size = new System.Drawing.Size(1261, 70);
            this.medicine_infor_label.TabIndex = 4;
            this.medicine_infor_label.Text = "THÔNG TIN THUỐC";
            this.medicine_infor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MedicinePicture
            // 
            this.MedicinePicture.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedicinePicture.Location = new System.Drawing.Point(82, 50);
            this.MedicinePicture.Name = "MedicinePicture";
            this.MedicinePicture.Size = new System.Drawing.Size(420, 420);
            this.MedicinePicture.TabIndex = 5;
            this.MedicinePicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddMedicineQuantityButton);
            this.panel1.Controls.Add(this.RemainingLabel);
            this.panel1.Controls.Add(this.SoldUnitPriceLabel);
            this.panel1.Controls.Add(this.ImportUnitPriceLabel);
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Controls.Add(this.TypeTextBox);
            this.panel1.Controls.Add(this.UnitTextBox);
            this.panel1.Controls.Add(this.MedicineNameTextBox);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.MedicinePicture);
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(100, 40, 40, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 507);
            this.panel1.TabIndex = 6;
            // 
            // AddMedicineQuantityButton
            // 
            this.AddMedicineQuantityButton.AutoSize = true;
            this.AddMedicineQuantityButton.BackColor = System.Drawing.Color.Transparent;
            this.AddMedicineQuantityButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMedicineQuantityButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.AddMedicineQuantityButton.Location = new System.Drawing.Point(810, 170);
            this.AddMedicineQuantityButton.Name = "AddMedicineQuantityButton";
            this.AddMedicineQuantityButton.Size = new System.Drawing.Size(44, 44);
            this.AddMedicineQuantityButton.TabIndex = 21;
            this.AddMedicineQuantityButton.Text = "+";
            this.AddMedicineQuantityButton.UseVisualStyleBackColor = false;
            // 
            // RemainingLabel
            // 
            this.RemainingLabel.AutoSize = true;
            this.RemainingLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingLabel.Location = new System.Drawing.Point(761, 184);
            this.RemainingLabel.Name = "RemainingLabel";
            this.RemainingLabel.Size = new System.Drawing.Size(43, 22);
            this.RemainingLabel.TabIndex = 20;
            this.RemainingLabel.Text = "160";
            // 
            // SoldUnitPriceLabel
            // 
            this.SoldUnitPriceLabel.AutoSize = true;
            this.SoldUnitPriceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldUnitPriceLabel.Location = new System.Drawing.Point(758, 427);
            this.SoldUnitPriceLabel.Name = "SoldUnitPriceLabel";
            this.SoldUnitPriceLabel.Size = new System.Drawing.Size(70, 22);
            this.SoldUnitPriceLabel.TabIndex = 19;
            this.SoldUnitPriceLabel.Text = "4,400đ";
            // 
            // ImportUnitPriceLabel
            // 
            this.ImportUnitPriceLabel.AutoSize = true;
            this.ImportUnitPriceLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImportUnitPriceLabel.Location = new System.Drawing.Point(758, 367);
            this.ImportUnitPriceLabel.Name = "ImportUnitPriceLabel";
            this.ImportUnitPriceLabel.Size = new System.Drawing.Size(65, 22);
            this.ImportUnitPriceLabel.TabIndex = 18;
            this.ImportUnitPriceLabel.Text = "4000đ";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.DescriptionTextBox.BorderColor = System.Drawing.Color.Black;
            this.DescriptionTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.DescriptionTextBox.BorderRadius = 0;
            this.DescriptionTextBox.BorderSize = 1;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DescriptionTextBox.Location = new System.Drawing.Point(762, 292);
            this.DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.DescriptionTextBox.PasswordChar = false;
            this.DescriptionTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.DescriptionTextBox.PlaceholderText = "Cách dùng";
            this.DescriptionTextBox.Size = new System.Drawing.Size(407, 47);
            this.DescriptionTextBox.TabIndex = 17;
            this.DescriptionTextBox.Texts = "";
            this.DescriptionTextBox.UnderlinedStyle = false;
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.TypeTextBox.BorderColor = System.Drawing.Color.Black;
            this.TypeTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.TypeTextBox.BorderRadius = 0;
            this.TypeTextBox.BorderSize = 1;
            this.TypeTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TypeTextBox.Location = new System.Drawing.Point(762, 234);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TypeTextBox.Multiline = false;
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.TypeTextBox.PasswordChar = false;
            this.TypeTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.TypeTextBox.PlaceholderText = "Loại thuốc";
            this.TypeTextBox.Size = new System.Drawing.Size(407, 37);
            this.TypeTextBox.TabIndex = 16;
            this.TypeTextBox.Texts = "";
            this.TypeTextBox.UnderlinedStyle = false;
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.UnitTextBox.BorderColor = System.Drawing.Color.Black;
            this.UnitTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.UnitTextBox.BorderRadius = 0;
            this.UnitTextBox.BorderSize = 1;
            this.UnitTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UnitTextBox.Location = new System.Drawing.Point(762, 118);
            this.UnitTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UnitTextBox.Multiline = false;
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.UnitTextBox.PasswordChar = false;
            this.UnitTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.UnitTextBox.PlaceholderText = "ĐVT";
            this.UnitTextBox.Size = new System.Drawing.Size(407, 37);
            this.UnitTextBox.TabIndex = 15;
            this.UnitTextBox.Texts = "";
            this.UnitTextBox.UnderlinedStyle = false;
            // 
            // MedicineNameTextBox
            // 
            this.MedicineNameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.MedicineNameTextBox.BorderColor = System.Drawing.Color.Black;
            this.MedicineNameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.MedicineNameTextBox.BorderRadius = 0;
            this.MedicineNameTextBox.BorderSize = 1;
            this.MedicineNameTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MedicineNameTextBox.Location = new System.Drawing.Point(762, 60);
            this.MedicineNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.MedicineNameTextBox.Multiline = false;
            this.MedicineNameTextBox.Name = "MedicineNameTextBox";
            this.MedicineNameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.MedicineNameTextBox.PasswordChar = false;
            this.MedicineNameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.MedicineNameTextBox.PlaceholderText = "Tên thuốc";
            this.MedicineNameTextBox.Size = new System.Drawing.Size(407, 37);
            this.MedicineNameTextBox.TabIndex = 14;
            this.MedicineNameTextBox.Texts = "";
            this.MedicineNameTextBox.UnderlinedStyle = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.import_unit_price_label, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.description_label, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.type_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.sold_unit_price_label, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.medicine_name_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.unit_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.remaining_label, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(548, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(164, 420);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // import_unit_price_label
            // 
            this.import_unit_price_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.import_unit_price_label.AutoSize = true;
            this.import_unit_price_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.import_unit_price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.import_unit_price_label.Location = new System.Drawing.Point(10, 309);
            this.import_unit_price_label.Margin = new System.Windows.Forms.Padding(10);
            this.import_unit_price_label.Name = "import_unit_price_label";
            this.import_unit_price_label.Size = new System.Drawing.Size(142, 38);
            this.import_unit_price_label.TabIndex = 11;
            this.import_unit_price_label.Text = "Đơn giá nhập:";
            this.import_unit_price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // description_label
            // 
            this.description_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.description_label.Location = new System.Drawing.Point(10, 242);
            this.description_label.Margin = new System.Windows.Forms.Padding(10);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(118, 47);
            this.description_label.TabIndex = 10;
            this.description_label.Text = "Cách dùng:";
            this.description_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // type_label
            // 
            this.type_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.type_label.AutoSize = true;
            this.type_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.type_label.Location = new System.Drawing.Point(10, 184);
            this.type_label.Margin = new System.Windows.Forms.Padding(10);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(115, 38);
            this.type_label.TabIndex = 9;
            this.type_label.Text = "Loại thuốc:";
            this.type_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sold_unit_price_label
            // 
            this.sold_unit_price_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sold_unit_price_label.AutoSize = true;
            this.sold_unit_price_label.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold_unit_price_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(84)))), ((int)(((byte)(43)))));
            this.sold_unit_price_label.Location = new System.Drawing.Point(10, 367);
            this.sold_unit_price_label.Margin = new System.Windows.Forms.Padding(10);
            this.sold_unit_price_label.Name = "sold_unit_price_label";
            this.sold_unit_price_label.Size = new System.Drawing.Size(130, 43);
            this.sold_unit_price_label.TabIndex = 12;
            this.sold_unit_price_label.Text = "Đơn giá bán:";
            this.sold_unit_price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.medicine_name_label.Size = new System.Drawing.Size(111, 38);
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
            this.unit_label.Location = new System.Drawing.Point(10, 68);
            this.unit_label.Margin = new System.Windows.Forms.Padding(10);
            this.unit_label.Name = "unit_label";
            this.unit_label.Size = new System.Drawing.Size(118, 38);
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
            this.remaining_label.Location = new System.Drawing.Point(10, 126);
            this.remaining_label.Margin = new System.Windows.Forms.Padding(10);
            this.remaining_label.Name = "remaining_label";
            this.remaining_label.Size = new System.Drawing.Size(139, 38);
            this.remaining_label.TabIndex = 8;
            this.remaining_label.Text = "Số lượng tồn:";
            this.remaining_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackButton
            // 
            this.BackButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.BackButton.ButtonColor = System.Drawing.Color.White;
            this.BackButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1052, 681);
            this.BackButton.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.BackButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.BackButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.BackButton.Size = new System.Drawing.Size(200, 40);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Quay lại";
            this.BackButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // UpdateMedicineButton
            // 
            this.UpdateMedicineButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.UpdateMedicineButton.ButtonColor = System.Drawing.Color.White;
            this.UpdateMedicineButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateMedicineButton.Location = new System.Drawing.Point(768, 681);
            this.UpdateMedicineButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.UpdateMedicineButton.Name = "UpdateMedicineButton";
            this.UpdateMedicineButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.UpdateMedicineButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.UpdateMedicineButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.UpdateMedicineButton.Size = new System.Drawing.Size(244, 40);
            this.UpdateMedicineButton.TabIndex = 12;
            this.UpdateMedicineButton.Text = "Cập nhật thông tin";
            this.UpdateMedicineButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.UpdateMedicineButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMedicineButton
            // 
            this.DeleteMedicineButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(146)))), ((int)(((byte)(59)))));
            this.DeleteMedicineButton.ButtonColor = System.Drawing.Color.White;
            this.DeleteMedicineButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteMedicineButton.Location = new System.Drawing.Point(528, 681);
            this.DeleteMedicineButton.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.DeleteMedicineButton.Name = "DeleteMedicineButton";
            this.DeleteMedicineButton.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.DeleteMedicineButton.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.DeleteMedicineButton.OnHoverTextColor = System.Drawing.Color.Gray;
            this.DeleteMedicineButton.Size = new System.Drawing.Size(200, 40);
            this.DeleteMedicineButton.TabIndex = 13;
            this.DeleteMedicineButton.Text = "Xóa thuốc";
            this.DeleteMedicineButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(28)))));
            this.DeleteMedicineButton.UseVisualStyleBackColor = true;
            // 
            // MedicineInfor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 733);
            this.Controls.Add(this.DeleteMedicineButton);
            this.Controls.Add(this.UpdateMedicineButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.medicine_infor_label);
            this.Controls.Add(this.Headpanel);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MedicineInfor";
            this.Text = "MedicineInfor";
            this.Headpanel.ResumeLayout(false);
            this.Headpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medicine_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MedicinePicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Headpanel;
        private System.Windows.Forms.Label medicine_management_label;
        private System.Windows.Forms.PictureBox medicine_icon;
        private System.Windows.Forms.Label medicine_infor_label;
        private System.Windows.Forms.PictureBox MedicinePicture;
        private System.Windows.Forms.Panel panel1;
        private RJTextBox DescriptionTextBox;
        private RJTextBox TypeTextBox;
        private RJTextBox UnitTextBox;
        private RJTextBox MedicineNameTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label import_unit_price_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label sold_unit_price_label;
        private System.Windows.Forms.Label medicine_name_label;
        private System.Windows.Forms.Label unit_label;
        private System.Windows.Forms.Label remaining_label;
        private System.Windows.Forms.Label RemainingLabel;
        private System.Windows.Forms.Label SoldUnitPriceLabel;
        private System.Windows.Forms.Label ImportUnitPriceLabel;
        private System.Windows.Forms.Button AddMedicineQuantityButton;
        private Button_WOC BackButton;
        private Button_WOC UpdateMedicineButton;
        private Button_WOC DeleteMedicineButton;
    }
}