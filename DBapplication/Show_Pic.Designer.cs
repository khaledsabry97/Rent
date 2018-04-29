namespace DBapplication
{
    partial class Show_Pic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Pic));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioShop = new System.Windows.Forms.RadioButton();
            this.radioPerson = new System.Windows.Forms.RadioButton();
            this.radioApartment = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.radioOther = new System.Windows.Forms.RadioButton();
            this.radioGarage = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::DBapplication.Properties.Resources.no_image_available;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(0, 55);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 470);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sakkal Majalla", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(894, 559);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 90);
            this.button3.TabIndex = 51;
            this.button3.Text = "رجوع";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DisplayMember = "Apartment.Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(560, 189);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(557, 33);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(1245, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(92, 28);
            this.label11.TabIndex = 54;
            this.label11.Text = "اسم الصورة";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.White;
            this.comboBox2.DisplayMember = "Apartment.Name";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Sakkal Majalla", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(560, 107);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.comboBox2.MaxDropDownItems = 1;
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox2.Size = new System.Drawing.Size(558, 33);
            this.comboBox2.TabIndex = 60;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(1254, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(83, 28);
            this.label1.TabIndex = 59;
            this.label1.Text = "اسم المؤجر";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioShop
            // 
            this.radioShop.AutoSize = true;
            this.radioShop.BackColor = System.Drawing.Color.Transparent;
            this.radioShop.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioShop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioShop.FlatAppearance.BorderSize = 2;
            this.radioShop.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioShop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioShop.Location = new System.Drawing.Point(771, 9);
            this.radioShop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioShop.Name = "radioShop";
            this.radioShop.Size = new System.Drawing.Size(67, 36);
            this.radioShop.TabIndex = 64;
            this.radioShop.Text = "محل";
            this.radioShop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioShop.UseVisualStyleBackColor = false;
            this.radioShop.CheckedChanged += new System.EventHandler(this.radioShop_CheckedChanged);
            // 
            // radioPerson
            // 
            this.radioPerson.AutoSize = true;
            this.radioPerson.BackColor = System.Drawing.Color.Transparent;
            this.radioPerson.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioPerson.Checked = true;
            this.radioPerson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioPerson.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioPerson.FlatAppearance.BorderSize = 2;
            this.radioPerson.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioPerson.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioPerson.Location = new System.Drawing.Point(1313, 9);
            this.radioPerson.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioPerson.Name = "radioPerson";
            this.radioPerson.Size = new System.Drawing.Size(85, 36);
            this.radioPerson.TabIndex = 63;
            this.radioPerson.TabStop = true;
            this.radioPerson.Text = "شخص";
            this.radioPerson.UseVisualStyleBackColor = false;
            this.radioPerson.CheckedChanged += new System.EventHandler(this.radioPerson_CheckedChanged);
            // 
            // radioApartment
            // 
            this.radioApartment.AutoSize = true;
            this.radioApartment.BackColor = System.Drawing.Color.Red;
            this.radioApartment.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioApartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioApartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioApartment.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioApartment.FlatAppearance.BorderSize = 2;
            this.radioApartment.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioApartment.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioApartment.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioApartment.Location = new System.Drawing.Point(1052, 9);
            this.radioApartment.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioApartment.Name = "radioApartment";
            this.radioApartment.Size = new System.Drawing.Size(66, 36);
            this.radioApartment.TabIndex = 62;
            this.radioApartment.Text = "شقة";
            this.radioApartment.UseVisualStyleBackColor = false;
            this.radioApartment.CheckedChanged += new System.EventHandler(this.radioApartment_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetPartial;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.radioOther, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioPerson, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioShop, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioApartment, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioGarage, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1405, 54);
            this.tableLayoutPanel2.TabIndex = 66;
            // 
            // radioOther
            // 
            this.radioOther.AutoSize = true;
            this.radioOther.BackColor = System.Drawing.Color.Transparent;
            this.radioOther.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioOther.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioOther.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioOther.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioOther.FlatAppearance.BorderSize = 2;
            this.radioOther.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioOther.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioOther.Location = new System.Drawing.Point(207, 9);
            this.radioOther.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioOther.Name = "radioOther";
            this.radioOther.Size = new System.Drawing.Size(71, 36);
            this.radioOther.TabIndex = 72;
            this.radioOther.Text = "أخرى";
            this.radioOther.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioOther.UseVisualStyleBackColor = false;
            this.radioOther.CheckedChanged += new System.EventHandler(this.radioOther_CheckedChanged);
            // 
            // radioGarage
            // 
            this.radioGarage.AutoSize = true;
            this.radioGarage.BackColor = System.Drawing.Color.Transparent;
            this.radioGarage.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioGarage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioGarage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioGarage.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioGarage.FlatAppearance.BorderSize = 2;
            this.radioGarage.Font = new System.Drawing.Font("Sakkal Majalla", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioGarage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioGarage.Location = new System.Drawing.Point(484, 9);
            this.radioGarage.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioGarage.Name = "radioGarage";
            this.radioGarage.Size = new System.Drawing.Size(74, 36);
            this.radioGarage.TabIndex = 65;
            this.radioGarage.Text = "مخزن";
            this.radioGarage.UseVisualStyleBackColor = false;
            this.radioGarage.CheckedChanged += new System.EventHandler(this.radioGarage_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton1.Checked = true;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButton1.FlatAppearance.BorderSize = 2;
            this.radioButton1.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton1.Location = new System.Drawing.Point(444, 6);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(75, 30);
            this.radioButton1.TabIndex = 68;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "شخص";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Red;
            this.radioButton2.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.radioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.radioButton2.FlatAppearance.BorderSize = 2;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.radioButton2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioButton2.Location = new System.Drawing.Point(199, 6);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 30);
            this.radioButton2.TabIndex = 67;
            this.radioButton2.Text = "شقة";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(718, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 69;
            this.label2.Text = "البحث بـ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(553, 285);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 84);
            this.tableLayoutPanel1.TabIndex = 70;
            this.tableLayoutPanel1.Visible = false;
            // 
            // imageSlider1
            // 
            this.imageSlider1.AllowLooping = true;
            this.imageSlider1.BackgroundImage = global::DBapplication.Properties.Resources.c0105546_milky_way_galactic_centre_composite_spl;
            this.imageSlider1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.imageSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.imageSlider1.Dock = System.Windows.Forms.DockStyle.Left;
            this.imageSlider1.Location = new System.Drawing.Point(0, 54);
            this.imageSlider1.Name = "imageSlider1";
            this.imageSlider1.Size = new System.Drawing.Size(518, 673);
            this.imageSlider1.TabIndex = 71;
            this.imageSlider1.Text = "imageSlider1";
            this.imageSlider1.Click += new System.EventHandler(this.imageSlider1_Click);
            this.imageSlider1.DoubleClick += new System.EventHandler(this.imageSlider1_DoubleClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.button4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.button2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(518, 669);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(887, 58);
            this.tableLayoutPanel3.TabIndex = 72;
            this.tableLayoutPanel3.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(134, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 50);
            this.button4.TabIndex = 53;
            this.button4.Text = "تعديل صورة";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(429, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 50);
            this.button1.TabIndex = 52;
            this.button1.Text = "حذف صورة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sakkal Majalla", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(724, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 50);
            this.button2.TabIndex = 51;
            this.button2.Text = "إضافة صورة";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Show_Pic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::DBapplication.Properties.Resources._5656545_mobile_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1405, 727);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.imageSlider1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Sakkal Majalla", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.Name = "Show_Pic";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عرض الصور";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Show_Pic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioShop;
        private System.Windows.Forms.RadioButton radioPerson;
        private System.Windows.Forms.RadioButton radioApartment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
        private System.Windows.Forms.RadioButton radioOther;
        private System.Windows.Forms.RadioButton radioGarage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}