namespace DBapplication
{
    partial class Update_Rent
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.apartmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apartment = new DBapplication.Apartment();
            this.label11 = new System.Windows.Forms.Label();
            this.apartmentTableAdapter = new DBapplication.ApartmentTableAdapters.ApartmentTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.apartmentBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 21);
            this.comboBox1.TabIndex = 35;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.DataSourceChanged += new System.EventHandler(this.comboBox1_DataSourceChanged);
            // 
            // apartmentBindingSource
            // 
            this.apartmentBindingSource.DataMember = "Apartment";
            this.apartmentBindingSource.DataSource = this.apartment;
            // 
            // apartment
            // 
            this.apartment.DataSetName = "Apartment";
            this.apartment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(353, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 35);
            this.label11.TabIndex = 34;
            this.label11.Text = "*الشقة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // apartmentTableAdapter
            // 
            this.apartmentTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(353, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 35);
            this.label5.TabIndex = 44;
            this.label5.Text = "*شهر";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(28, 167);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(151, 27);
            this.textBox8.TabIndex = 50;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 35);
            this.label1.TabIndex = 47;
            this.label1.Text = "قيمة فاتورة الكهرباء";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 228);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 52;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 35);
            this.label2.TabIndex = 51;
            this.label2.Text = "قيمة فاتورة المياه";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(28, 284);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(151, 27);
            this.textBox2.TabIndex = 54;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(338, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 35);
            this.label3.TabIndex = 53;
            this.label3.Text = "خدمات";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 30.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(111, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 56);
            this.button1.TabIndex = 55;
            this.button1.Text = "إضافة ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(28, 349);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(290, 73);
            this.textBox3.TabIndex = 57;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 35);
            this.label4.TabIndex = 56;
            this.label4.Text = "تعليق";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(62, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(247, 20);
            this.dateTimePicker1.TabIndex = 58;
            // 
            // Update_Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 522);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Name = "Update_Rent";
            this.Text = "Update_Rent";
            this.Load += new System.EventHandler(this.Update_Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apartmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apartment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private Apartment apartment;
        private System.Windows.Forms.BindingSource apartmentBindingSource;
        private ApartmentTableAdapters.ApartmentTableAdapter apartmentTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}