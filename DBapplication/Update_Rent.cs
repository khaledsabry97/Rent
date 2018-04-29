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
    public partial class Update_Rent : Form
    {
        Controller con = new Controller();
        int month = DateTime.Today.Month;
        int year = DateTime.Today.Year;
        public Update_Rent()
        {
            InitializeComponent();
            con.Auto_Month_Increament();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Update_Rent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartment._Apartment' table. You can move, or remove it, as needed.
            //  this.apartmentTableAdapter.Fill(this.apartment._Apartment);
            this.apartmentTableAdapter.FillBynotNull(this.apartment._Apartment);
           /*     int id = con.getvalue("person_id", "apartment", "name ='" + comboBox1.Text + "'");
            //      textBox8.Text = id.ToString();

            comboBox2.Items.Clear();

            DataTable d = con.getdatacolumn("p.month", "paying p , apartment a", "p.person_id = " + id +" and p.person_id = a.person_id and p.year = " + year + " and  total_paid is null");
           if(d != null)

                    for(int i = 0;i<d.Rows.Count;i++)
                {
                    comboBox2.Items.Add(d.Rows[i][0]);
                }
                */
        }

        private void fillBynotNullToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.apartmentTableAdapter.FillBynotNull(this.apartment._Apartment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            /*
            int id = con.getvalue("person_id", "apartment", "name ='" + comboBox1.Text + "'");
            comboBox2.Items.Clear();

            DataTable d = con.getdatacolumn("p.month", "paying p natural join apartment a", "p.person_id = " + id + " and p.year = " + year + " and (Electricity_Cost + Water_Cost + Services != 0 OR (Electricity_Cost is null and Water_Cost is null and Services is null))");
            if (d != null)

                for (int i = 0; i < d.Rows.Count; i++)
                {
                    comboBox2.Items.Add(d.Rows[i][0]);
                }
                */
        }

        private void fillBynotNullToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string apartment_name,comment;
            int month,year;
            float electricity, water, services;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Please fill the required fields!");
                return;
            }
            apartment_name = comboBox1.Text;
            //electricity
            if (textBox8.Text != "")
            {
                if (!float.TryParse(textBox8.Text, out electricity))
                {
                    MessageBox.Show("Please put a valid value for electricity!");
                    return;
                }
            }
            else
            {
                electricity = -1;
            }


            //water
            if (textBox1.Text != "")
            {
                if (!float.TryParse(textBox1.Text, out water))
                {
                    MessageBox.Show("Please put a valid value for water!");
                    return;
                }
            }
            else
            {
                water = -1;
            }

            //Services
            if (textBox2.Text != "")
            {
                if (!float.TryParse(textBox2.Text, out services))
                {
                    MessageBox.Show("Please put a valid value for Services!");
                    return;
                }
            }
            else
            {
                services = -1;
            }

            comment = con.unrequired_Fields(textBox3.Text);
            month = dateTimePicker1.Value.Month;
            year = dateTimePicker1.Value.Year;
            
           if (con.Update_Payments(apartment_name,comment,month,year,electricity,water,services) != 0)
            {
                MessageBox.Show("Successfully Updated");
                Close();
            }
            else
            {
                MessageBox.Show("unSuccessfully Operation!");
            }



        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DataSourceChanged(object sender, EventArgs e)
        {

        }
    }
}
