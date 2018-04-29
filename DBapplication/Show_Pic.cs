using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DBapplication
{
    public partial class Show_Pic : Form
    {
        Controller con = new Controller();
        int id =-1;
        char Kind;
        char SchKind;
        byte[] img = null;
       // bool New_Image = false;
        public Show_Pic()
        {
            InitializeComponent();
            Update_Radio();
        }
        private void Upload_Data()
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            imageSlider1.Images.Clear();
            DataTable d;
            if (Kind == 'P')
            {
                if (SchKind == 'A')
                    d = con.getdatacolumn("a.name", "person p,apartment a", "p.id = a.person_id");
                else
                    d = con.getdatacolumn("p.name", "person p,apartment a", "p.id = a.person_id");

            }
            else if(Kind == 'O')
            {
                d = con.getdatacolumn("File_Name", "other");

            }
            else
            {
                d = con.getdatacolumn("a.name", "apartment a", " kind = '"+Kind+"'");
            }


            if (d == null)
                return;

            for (int i = 0; i < d.Rows.Count; i++)

            {
                comboBox2.Items.Add(d.Rows[i][0].ToString());
            }
            comboBox2.MaxDropDownItems = 1;
            comboBox2.SelectedIndex = 0;

        }

        private void Upload_Kind()
        {
            comboBox1.Items.Clear();
            comboBox1.Text = "";
            DataTable d;
            if (Kind == 'P')
            {
                d = con.getdatacolumn("File_Name", "Images", "Person_Id = " + id);
            }
            else if(Kind == 'O')
                d = con.getdatacolumn("File_Name", "other", "id = " + id);
            else
            {
                    d = con.getdatacolumn("File_Name", "Images", "Apartment_id = " + id);
            }

            if (d == null)
                return;
            
            for (int i = 0; i < d.Rows.Count; i++)

            {
                comboBox1.Items.Add(d.Rows[i][0].ToString());
            }

            comboBox1.SelectedIndex = 0;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            imageSlider1.CurrentImageIndex= comboBox1.SelectedIndex;

        }

        public void Change_Image()
        {
            imageSlider1.Images.Clear();
            if (Kind == 'O')
            {
                int i = 0;
                while (imageSlider1.Images.Count != comboBox2.Items.Count)
                {
                    if (comboBox2.Items.Count < 0)
                        return;

                    Byte[] IMG;
                    if (con.getvalue("count(*)", "OTHER", "File_Name = '" + comboBox2.Items[i].ToString() + "'") == 0)
                    {
                        pictureBox1.Image = null;
                        return;
                    }
                    IMG = con.getOtherimage("File_Name = '" + comboBox2.Items[i].ToString() + "'");


                    MemoryStream ms = new MemoryStream(IMG);
                    imageSlider1.Images.Add(Image.FromStream(ms));
                    if (i == comboBox2.Items.Count - 1)
                        break;
                    else
                        i++;
                }
            }
            else
            {
                while (imageSlider1.Images.Count != comboBox1.Items.Count)
                {
                    if (comboBox1.Items.Count < 0)
                        return;

                    Byte[] IMG;
                    if (Kind == 'P')
                    {
                        if (con.getvalue("count(*)", "Images", "File_Name = '" + comboBox1.Text + "' and Person_Id =" + id) == 0)
                        {
                            pictureBox1.Image = null;
                            return;
                        }
                        IMG = con.getimage("File_Name = '" + comboBox1.Text + "' and Person_Id =" + id);

                    }
                    else if (Kind == 'O')
                    {
                        if (con.getvalue("count(*)", "OTHER", "File_Name = '" + comboBox2.Text + "'") == 0)
                        {
                            pictureBox1.Image = null;
                            return;
                        }
                        IMG = con.getOtherimage("File_Name = '" + comboBox2.Text + "'");
                    }
                    else
                    {
                        if (con.getvalue("count(*)", "Images", "File_Name = '" + comboBox1.Text + "' and Apartment_id =" + id) == 0)
                        {
                            pictureBox1.Image = null;
                            return;
                        }
                        IMG = con.getimage("File_Name = '" + comboBox1.Text + "' and Apartment_id =" + id);

                    }

                    MemoryStream ms = new MemoryStream(IMG);
                    imageSlider1.Images.Add(Image.FromStream(ms));
                    if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
                        comboBox1.SelectedIndex = 0;
                    else
                        comboBox1.SelectedIndex++;
                }
            }
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Show_Pic_Load(object sender, EventArgs e)
        {
            pictureBox1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioPerson_CheckedChanged(object sender, EventArgs e)
        {
            if(radioPerson.Checked)
            Update_Radio();
        }

        private void Update_Radio()
        {
            if(radioApartment.Checked)
            {
                label1.Text = "اسم الشقة";
                Kind = 'A';
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel3.Visible = false;
            }
            else if (radioPerson.Checked)
            {
                label1.Text = "اسم المؤجر";
                Kind = 'P';
                tableLayoutPanel1.Visible = true;
                tableLayoutPanel3.Visible = false;
                label11.Visible = true;
                comboBox1.Visible = true;
            }
            else if(radioShop.Checked)
            {
                label1.Text = "اسم المحل";
                Kind = 'S';
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel3.Visible = false;
                label11.Visible = true;
                comboBox1.Visible = true;

            }
            else if(radioGarage.Checked)
            {
                label1.Text = "اسم المخزن";
                Kind = 'G';
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel3.Visible = false;
                label11.Visible = true;
                comboBox1.Visible = true;
            }
            else if(radioOther.Checked)
            {
                label1.Text = "اسم الصورة";
                Kind = 'O';
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel3.Visible = true;
                label11.Visible = false;
                comboBox1.Visible = false;
            }
            pictureBox1.Image = null;
            
            Upload_Data();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Images.K.Clear();
                if (Kind == 'P')
            {
                if(SchKind == 'A')
                    id = con.getvalue("A.person_id", "apartment a", "a.name = '" + comboBox2.Text + "'");
                else
                id = con.getvalue("p.id", "person p,apartment a", "p.id = a.person_id and p.name = '" + comboBox2.Text + "'");
            }

            else if(Kind == 'O')
            {
                Change_Image();
                imageSlider1.CurrentImageIndex = comboBox2.SelectedIndex;
                return;
            }
            else
            {
                id = con.getvalue("id", "apartment", "name = '" + comboBox2.Text + "'");

            }
            pictureBox1.Image = null;

            Upload_Kind();
            Change_Image();
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            /*
            Images form = new Images(pictureBox1.Image);
            form.Show();
            */

        }

        private void radioApartment_CheckedChanged(object sender, EventArgs e)
        {
            if (radioApartment.Checked)
                Update_Radio();
        }

        private void radioShop_CheckedChanged(object sender, EventArgs e)
        {
            if (radioShop.Checked)
                Update_Radio();
        }

        private void radioGarage_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGarage.Checked)
                Update_Radio();
        }


        void Update_Search()
        {
            if(radioButton1.Checked)
            {
                label1.Text = "اسم المؤجر";
                SchKind = 'P';
            }
            else if(radioButton2.Checked)
            {
                label1.Text = "اسم الشقة";
                SchKind = 'A';
            }

            pictureBox1.Image = null;

            Upload_Data();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Update_Search();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Update_Search();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {
            if(Kind == 'O')
                comboBox2.SelectedIndex = imageSlider1.CurrentImageIndex;
            else
            comboBox1.SelectedIndex = imageSlider1.CurrentImageIndex;

        }
        public void ChangeIndex()
        {

        }

        private void imageSlider1_DoubleClick(object sender, EventArgs e)
        {
            if (imageSlider1.Images.Count == 0)
                return;
            for(int i  = 0; i < imageSlider1.Images.Count;i++)
            Images.Draw_Picture(imageSlider1.Images[i]);
            Images G = new Images(imageSlider1.Images[0]);
            G.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioGarage.Checked = true;
            Edit_Image form = new Edit_Image(-2,'O');
            form.Show();
        }

        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            if (radioOther.Checked)
                Update_Radio();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            radioGarage.Checked = true;
            Edit_Image form = new Edit_Image(-4, 'O');
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            radioGarage.Checked = true;
            Edit_Image form = new Edit_Image(-3, 'O');
            form.Show();
        }
    }
}
