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
    public partial class Edit_Information_Contract : Form
    {
        Controller con = new Controller();
        int id;
        public Edit_Information_Contract()
        {
            InitializeComponent();
            

        }

        private void Edit_Information_Contract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartment._Apartment' table. You can move, or remove it, as needed.
            //  this.apartmentTableAdapter.Fill(this.apartment._Apartment);
            //   this.apartmentTableAdapter.FillBynotNull(this.apartment._Apartment);
            comboBox1.Items.Clear();
            DataTable d = con.get_blocks_busy();
            if (d == null)
                return;

            for (int i = 0; i < d.Rows.Count; i++)

            {
                comboBox1.Items.Add(d.Rows[i][0].ToString());
            }
            comboBox1.SelectedIndex = 0;
            Update_The_Form();

        }

        private void fillBynotNullToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBynotNull(this.apartment._Apartment);
                comboBox1.Items.Clear();
                DataTable d = con.get_blocks_busy();
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

        private void fillBynotNullToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void Update_The_Form()
        {
            if (comboBox1.Text == "")
                return;
            textBox1.Text = con.getstring("p.name", "person p,apartment a", "p.id = a.person_id and a.name = '"+comboBox1.Text+"'");
            textBox2.Text = con.getstring("p.phone", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox8.Text = con.getstring("p.Rental_Price", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox7.Text = con.getstring("p.Increasing_Percentage", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox3.Text = con.getstring("p.Services", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox5.Text = con.getstring("p.Insurance", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox6.Text = con.getstring("p.Address", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox9.Text = con.getstring("p.Description", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            textBox10.Text = con.getstring("p.Email", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            dateTimePicker1.Text = con.getstring("p.Start_Date", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            dateTimePicker2.Text = con.getstring("p.End_Date", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            dateTimePicker3.Text = con.getstring("p.Increasing_Date", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            id = con.getvalue("p.id", "person p,apartment a", "p.id = a.person_id and a.name = '" + comboBox1.Text + "'");
            if (id < 0)
                button1.Visible = false;
            else
                button1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Update_The_Form();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string person_name, apartmentname, startdate, enddate, increasingdate, address, email, comment, phones,Service;
            int phone, increasingpercentage;
            float rentcost, insurance, services;
            if (textBox1.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBoxs.mes.Show("من فضلك إملأ الأماكن المطلوبة");
                return;
            }

            person_name = textBox1.Text;
            startdate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            enddate = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            increasingdate = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            apartmentname = comboBox1.Text;
            if (!float.TryParse(textBox8.Text, out rentcost))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة إيجار حقيقية");
                return;
            }
            /*
            if (!int.TryParse(textBox2.Text, out phone))
            {
                MessageBoxs.mes.Show("من فضلك أدخل رقم هاتف صحيح");
                return;
            }
            else
            {
                phones = textBox2.Text;
            }*/

            if (!int.TryParse(textBox7.Text, out increasingpercentage))
            {
                MessageBoxs.mes.Show("من فضلك أدخل نسبة زيادة فعلية");
                return;
            }

            if (!float.TryParse(textBox5.Text, out insurance))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة تأمين صحيحة");
                return;
            }

            if (textBox3.Text == "")
                Service = "NULL";
            else
             if (!float.TryParse(textBox3.Text, out services))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة خدمات صحيحة");
                return;
            }
            else
                Service = services.ToString();


            if (textBox2.Text == "")
                phones = "NULL";
            else if (!int.TryParse(textBox2.Text, out phone))
            {
                MessageBoxs.mes.Show("من فضلك أدخل رقم هاتف صحيح");
                return;
            }
            else
                phones = textBox2.Text;


            address = con.unrequired_Fields(textBox6.Text);
            email = con.unrequired_Fields(textBox10.Text);
            comment = con.unrequired_Fields(textBox9.Text);
            if (address != "NULL")
                address = "'" + address + "'";
            if (email != "NULL")
                email = "'" + email + "'";
            if (comment != "NULL")
                comment = "'" + comment + "'";


            if (con.Edit_Contract(id,person_name, apartmentname, startdate, enddate, address, comment, rentcost, increasingpercentage, increasingdate, insurance, Service, phones, email) != 0)
            {
                MessageBoxs.mes.Show("!تم التعديل بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!لم يتم التعديل");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Image form = new Edit_Image(id,'P');
            form.Show();
        }
    }
}
