namespace DBapplication
{
    partial class ALL
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.apartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rentDataSet = new DBapplication.RentDataSet();
            this.apartmentTableAdapter = new DBapplication.RentDataSetTableAdapters.ApartmentTableAdapter();
            this.apartment_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rental_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.End_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Increasing_Percentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Increasing_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Services = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricityaccountnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.electricitycounternoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterAccountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waterCounterNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasAccountNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasCounterNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Khaki;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.apartment_Name,
            this.name1,
            this.Rental_Price,
            this.Start_Date,
            this.End_Date,
            this.Increasing_Percentage,
            this.Increasing_Date,
            this.phone,
            this.Insurance,
            this.Services,
            this.electricityaccountnoDataGridViewTextBoxColumn,
            this.electricitycounternoDataGridViewTextBoxColumn,
            this.waterAccountNoDataGridViewTextBoxColumn,
            this.waterCounterNoDataGridViewTextBoxColumn,
            this.gasAccountNoDataGridViewTextBoxColumn,
            this.gasCounterNoDataGridViewTextBoxColumn,
            this.Address,
            this.Email,
            this.Description});
            this.dataGridView1.DataSource = this.apartmentBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "-";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(542, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // apartmentBindingSource
            // 
            this.apartmentBindingSource.DataMember = "Apartment";
            this.apartmentBindingSource.DataSource = this.rentDataSet;
            // 
            // rentDataSet
            // 
            this.rentDataSet.DataSetName = "RentDataSet";
            this.rentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apartmentTableAdapter
            // 
            this.apartmentTableAdapter.ClearBeforeFill = true;
            // 
            // apartment_Name
            // 
            this.apartment_Name.DataPropertyName = "Name";
            this.apartment_Name.HeaderText = "اسم الشقة";
            this.apartment_Name.Name = "apartment_Name";
            this.apartment_Name.ReadOnly = true;
            // 
            // name1
            // 
            this.name1.DataPropertyName = "name1";
            this.name1.HeaderText = "اسم المؤجر";
            this.name1.Name = "name1";
            this.name1.ReadOnly = true;
            // 
            // Rental_Price
            // 
            this.Rental_Price.DataPropertyName = "Rental_Price";
            this.Rental_Price.HeaderText = "قيمة الإيجار";
            this.Rental_Price.Name = "Rental_Price";
            this.Rental_Price.ReadOnly = true;
            // 
            // Start_Date
            // 
            this.Start_Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Start_Date.DataPropertyName = "Start_Date";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Start_Date.DefaultCellStyle = dataGridViewCellStyle2;
            this.Start_Date.HeaderText = "تاريخ البداية";
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.ReadOnly = true;
            this.Start_Date.Width = 115;
            // 
            // End_Date
            // 
            this.End_Date.DataPropertyName = "End_Date";
            this.End_Date.HeaderText = "تاريخ الإنتهاء";
            this.End_Date.Name = "End_Date";
            this.End_Date.ReadOnly = true;
            // 
            // Increasing_Percentage
            // 
            this.Increasing_Percentage.DataPropertyName = "Increasing_Percentage";
            this.Increasing_Percentage.HeaderText = "نسبة الزيادة";
            this.Increasing_Percentage.Name = "Increasing_Percentage";
            this.Increasing_Percentage.ReadOnly = true;
            // 
            // Increasing_Date
            // 
            this.Increasing_Date.DataPropertyName = "Increasing_Date";
            this.Increasing_Date.HeaderText = "تاريخ الزيادة";
            this.Increasing_Date.Name = "Increasing_Date";
            this.Increasing_Date.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "هاتف";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // Insurance
            // 
            this.Insurance.DataPropertyName = "Insurance";
            this.Insurance.HeaderText = "التأمين";
            this.Insurance.Name = "Insurance";
            this.Insurance.ReadOnly = true;
            // 
            // Services
            // 
            this.Services.DataPropertyName = "Services";
            this.Services.HeaderText = "خدمات";
            this.Services.Name = "Services";
            this.Services.ReadOnly = true;
            // 
            // electricityaccountnoDataGridViewTextBoxColumn
            // 
            this.electricityaccountnoDataGridViewTextBoxColumn.DataPropertyName = "electricity_account_no";
            this.electricityaccountnoDataGridViewTextBoxColumn.HeaderText = "رقم حساب الكهرباء";
            this.electricityaccountnoDataGridViewTextBoxColumn.Name = "electricityaccountnoDataGridViewTextBoxColumn";
            this.electricityaccountnoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // electricitycounternoDataGridViewTextBoxColumn
            // 
            this.electricitycounternoDataGridViewTextBoxColumn.DataPropertyName = "electricity_counter_no";
            this.electricitycounternoDataGridViewTextBoxColumn.HeaderText = "رقم عداد الكهرباء";
            this.electricitycounternoDataGridViewTextBoxColumn.Name = "electricitycounternoDataGridViewTextBoxColumn";
            this.electricitycounternoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waterAccountNoDataGridViewTextBoxColumn
            // 
            this.waterAccountNoDataGridViewTextBoxColumn.DataPropertyName = "Water_Account_No";
            this.waterAccountNoDataGridViewTextBoxColumn.HeaderText = "رقم حساب الكهرباء";
            this.waterAccountNoDataGridViewTextBoxColumn.Name = "waterAccountNoDataGridViewTextBoxColumn";
            this.waterAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // waterCounterNoDataGridViewTextBoxColumn
            // 
            this.waterCounterNoDataGridViewTextBoxColumn.DataPropertyName = "Water_Counter_No";
            this.waterCounterNoDataGridViewTextBoxColumn.HeaderText = "رقم عداد المياه";
            this.waterCounterNoDataGridViewTextBoxColumn.Name = "waterCounterNoDataGridViewTextBoxColumn";
            this.waterCounterNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gasAccountNoDataGridViewTextBoxColumn
            // 
            this.gasAccountNoDataGridViewTextBoxColumn.DataPropertyName = "Gas_Account_No";
            this.gasAccountNoDataGridViewTextBoxColumn.HeaderText = "رقم حساب الغاز";
            this.gasAccountNoDataGridViewTextBoxColumn.Name = "gasAccountNoDataGridViewTextBoxColumn";
            this.gasAccountNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gasCounterNoDataGridViewTextBoxColumn
            // 
            this.gasCounterNoDataGridViewTextBoxColumn.DataPropertyName = "Gas_Counter_No";
            this.gasCounterNoDataGridViewTextBoxColumn.HeaderText = "رقم عداد الغاز";
            this.gasCounterNoDataGridViewTextBoxColumn.Name = "gasCounterNoDataGridViewTextBoxColumn";
            this.gasCounterNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "عنوان المؤجر";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "إيميل";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "وصف";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // ALL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 280);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ALL";
            this.Text = "AllInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private RentDataSet rentDataSet;
        private System.Windows.Forms.BindingSource apartmentBindingSource;
        private RentDataSetTableAdapters.ApartmentTableAdapter apartmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apartment_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rental_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn End_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Increasing_Percentage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Increasing_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Services;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricityaccountnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn electricitycounternoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterAccountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn waterCounterNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasAccountNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gasCounterNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}