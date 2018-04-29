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
    public partial class Edit_Apartment : Form
    {
        Controller con = new Controller();
        int id;
        Char Kind;

        public Edit_Apartment()
        {
            InitializeComponent();
        }

        private void Edit_Apartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartment._Apartment' table. You can move, or remove it, as needed.
            // this.apartmentTableAdapter.Fill(this.apartment._Apartment);
            comboBox1.Items.Clear();
            DataTable d = con.get_blocks();
            if (d == null)
                return;

            for (int i = 0; i < d.Rows.Count; i++)

            {
                comboBox1.Items.Add(d.Rows[i][0].ToString());
            }
            comboBox1.SelectedIndex = 0;
            Update_The_Form();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                //  this.apartmentTableAdapter.Fill(this.apartment._Apartment);
                comboBox1.Items.Clear();
                DataTable d = con.get_blocks();
                if (d == null)
                    return;

                for (int i = 0; i < d.Rows.Count; i++)

                {
                    comboBox1.Items.Add(d.Rows[i][0].ToString());
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Update_The_Form()
        {
            string kind;
            if (comboBox1.Text == "")
                return;
            textBox1.Text = con.getstring("name", "apartment", "name = '" + comboBox1.Text + "'");
            textBox2.Text = con.getstring("electricity_account_no", "apartment", "name = '" + comboBox1.Text + "'");
            textBox4.Text = con.getstring("electricity_counter_no", "apartment", "name = '" + comboBox1.Text + "'");
            textBox6.Text = con.getstring("Water_Counter_No", "apartment", "name = '" + comboBox1.Text + "'");
            textBox3.Text = con.getstring("Water_Account_No", "apartment", "name = '" + comboBox1.Text + "'");
            textBox5.Text = con.getstring("Gas_Account_No", "apartment", "name = '" + comboBox1.Text + "'");
            textBox7.Text = con.getstring("Gas_Counter_No", "apartment", "name = '" + comboBox1.Text + "'");
            kind = con.getstring("Kind", "apartment", "name = '" + comboBox1.Text + "'");
            id = con.getvalue("id", "apartment", "name = '" + comboBox1.Text + "'");
            if (id <= 0)
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
            }

            if (kind == "A")
            {
                radioButton1.Checked = true;
            }
            else if (kind == "S")
                radioButton2.Checked = true;
            else
                radioButton3.Checked = true;
            update();
        }
        private void update()
        {
            if (radioButton1.Checked == true)
            {
                Kind = 'A';
                button1.Text = "تعديل شقة";
                button2.Text = "حذف الشقة";
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
                button1.Text = "تعديل محل";
                button2.Text = "حذف المحل";
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
                button1.Text = "تعديل مخزن";
                button2.Text = "حذف المخزن";
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_The_Form();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

            if (con.Edit_apartment(id,name, elec_account, elec_counter, water_account, water_counter, Gas_account, Gas_counter, Kind) != 0)
            {
                MessageBoxs.mes.Show("تم التعديل بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!لم يتم التعديل");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (con.Delete_apartment(id) != 0)
            {
                MessageBoxs.mes.Show("تم الحذف بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!لم يتم الحذف");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Edit_Image form = new Edit_Image(id,'A');
            form.Show();
        }
    }
}
