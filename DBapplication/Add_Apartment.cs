using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class Add_Apartment : Form
    {
        private Rectangle b;
        private Point c;
        private float buttonoffset;
        private float labeloffset;
        Controller con = new Controller();
        char Kind;
        static Dictionary<string, byte[]> Imgs = new Dictionary<string, byte[]>();

        public Add_Apartment()
        {
            InitializeComponent();
            
            update();
            Imgs.Clear();
            Add_Apartment_Image.Images.Clear();
            //buttonoffset = this.Width - textBox1.Width;
            labeloffset = this.Width - label1.Width;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, elec_account, elec_counter, water_account, water_counter, Gas_account, Gas_counter;

            if (textBox1.Text == "")
            {
                MessageBoxs.mes.Show("من فضلك إملأ الأماكن المطلوبة");
                return;
            }
            name = textBox1.Text;
            elec_account = con.unrequired_Fields(textBox2.Text);
            elec_counter = con.unrequired_Fields(textBox4.Text);
            water_account = con.unrequired_Fields(textBox3.Text);
            water_counter = con.unrequired_Fields(textBox6.Text);
            Gas_account = con.unrequired_Fields(textBox5.Text);
            Gas_counter = con.unrequired_Fields(textBox7.Text);

            if (con.Add_apartment(name, elec_account, elec_counter, water_account, water_counter, Gas_account, Gas_counter, Kind) != 0)
            {
                int id = con.getvalueunspecified("max(id)", "apartment");
                for (int i = 0; i < Imgs.Count; i++)
                {
                    byte[] Img = Imgs.Values.ElementAt(i);
                    string Name_Img = Imgs.Keys.ElementAt(i);
                    if (con.saveimage(Img, Name_Img, "NULL", id.ToString()) == 0)
                    {
                        MessageBoxs.mes.Show("!لم يتم حفظ الصور بنجاح");
                    }

                }
                    MessageBoxs.mes.Show("تم الإضافة بنجاح");

                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!فشلت إضافة العقار");                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            update();
          
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            update();
           
        }

        private void Add_Apartment_Load(object sender, EventArgs e)
        {
        }


        private void update()
        {
            if (radioButton1.Checked == true)
            {
                Kind = 'A';
                button1.Text = "إضافة شقة";
                textBox7.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox3.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                label6.Visible = true;
                label3.Visible = true;
            }

            else if (radioButton2.Checked == true)
            {
                Kind = 'S';
                button1.Text = "إضافة محل";
                textBox7.Visible = false;
                textBox5.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                textBox3.Visible = true;
                textBox6.Visible = true;
                label6.Visible = true;
                label3.Visible = true;
                textBox7.Text = "";
                textBox5.Text = "";
            }




            else if (radioButton3.Checked == true)
            {
                Kind = 'G';
                button1.Text = "إضافة مخزن";
                textBox7.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox3.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label3.Visible = false;
                textBox7.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox3.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public static void LoadImage(Dictionary<string, byte[]> k)
        {
            Imgs = k;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Apartment_Image form = new Add_Apartment_Image();
            form.Show();
        }

        private void Add_Apartment_SizeChanged(object sender, EventArgs e)
        {
          //  textBox1.Width = this.Width - (int)buttonoffset;
          //  label1.Width = this.Width - (int)labeloffset;
        }
    }
}
