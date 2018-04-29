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
    public partial class Sign_Contract : Form
    {
        Controller con = new Controller();
        static Dictionary<string, byte[]> Imgs = new Dictionary<string, byte[]>();
     //  static Dictionary<int, Dictionary<string, byte[]>> List = new Dictionary<int, Dictionary<string, byte[]>>();

        public Sign_Contract()
        {
            InitializeComponent();
            dateTimePicker1.Value.ToLocalTime();
            dateTimePicker2.Value.ToLocalTime();
            dateTimePicker3.Value.ToLocalTime();
            Imgs.Clear();
            Add_Image.Images.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Sign_Contract_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apartment._Apartment' table. You can move, or remove it, as needed.
            //   this.apartmentTableAdapter.Fill(this.apartment._Apartment);
               // this.apartmentTableAdapter.FillBy(this.apartment._Apartment);
            DataTable d = con.get_blocks_empty();
            if (d == null)
                return;

            for (int i = 0; i < d.Rows.Count; i++)

            {
                comboBox1.Items.Add(d.Rows[i][0].ToString());
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string person_name,apartmentname, startdate, enddate,increasingdate, address, email,comment,phones,Service,Phones;
            int phone, increasingpercentage;
            float rentcost, insurance,services;

            if (textBox1.Text == ""|| textBox8.Text == "" ||textBox7.Text == "" || textBox5.Text == "" ||comboBox1.Text =="" )
            {
                MessageBoxs.mes.Show("من فضلك إملأ الأماكن المطلوبة");
                return;
            }

            person_name = textBox1.Text;
            startdate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            enddate = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            increasingdate = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            apartmentname = comboBox1.Text;
            if(!float.TryParse(textBox8.Text,out rentcost))
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

            */

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

            if (textBox2.Text == "")
                Phones = "NULL";
            else if (!int.TryParse(textBox2.Text, out phone))
            {
                MessageBoxs.mes.Show("من فضلك أدخل رقم هاتف صحيح");
                return;
            }
            else
                Phones = textBox2.Text;

            if (textBox3.Text == "")
                Service = "NULL";
            else if (!float.TryParse(textBox3.Text, out services))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة خدمات صحيحة");
                return;
            }
            else
            Service = textBox3.Text;

            address = con.unrequired_Fields(textBox6.Text);
            email = con.unrequired_Fields(textBox10.Text);
            comment = con.unrequired_Fields(textBox9.Text);
            Service = con.unrequired_Fields(textBox3.Text);
            if (address != "NULL")
                address = "'" + address + "'";
            if (email != "NULL")
                email = "'" + email + "'";
            if (comment != "NULL")
                comment = "'" + comment + "'";



            if (con.Sign_Contract(person_name, apartmentname, startdate, enddate, address, comment, rentcost, increasingpercentage, increasingdate, insurance, Service, Phones, email) != 0)
            {
                int id = con.getvalueunspecified("max(id)", "person");
                for (int i = 0; i < Imgs.Count; i++)
                {
                    byte[] Img = Imgs.Values.ElementAt(i);
                    string Name_Img = Imgs.Keys.ElementAt(i);
                    if (con.saveimage(Img, Name_Img, id.ToString(), "NULL") == 0)
                    {
                        MessageBoxs.mes.Show("!لم يتم حفظ الصور بنجاح");
                    }
                }

                MessageBoxs.mes.Show("!تم التعاقد بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!لم يتم التعاقد");
            }
        }

        public static void LoadImage(Dictionary<string,byte[]> k )
        {
            Imgs = k;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBy(this.apartment._Apartment);
                DataTable d = con.get_blocks_empty();
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

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBy(this.apartment._Apartment);
                DataTable d = con.get_blocks_empty();
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

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
            try
            {
                //  this.apartmentTableAdapter.FillBy(this.apartment._Apartment);
                DataTable d = con.get_blocks_empty();
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

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add_Image form = new Add_Image('P');
            form.Show();
        }
    }
}
