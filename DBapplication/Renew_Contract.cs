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
    public partial class Renew_Contract : Form
    {
        Controller con = new Controller();
        int id;
        public Renew_Contract()
        {
            InitializeComponent();
            dateTimePicker1.Value.ToLocalTime();
            dateTimePicker2.Value.ToLocalTime();
            dateTimePicker3.Value.ToLocalTime();
        }

        private void Renew_Contract_Load(object sender, EventArgs e)
        {
            DataTable D = con.getdatacolumn("P.NAME", "PERSON P,APARTMENT A", "P.ID = A.PERSON_ID");
            if (D == null)
                return;
            for (int i = 0; i < D.Rows.Count; i++)
            {
                comboBox1.Items.Add(D.Rows[i][0].ToString());
            }
            comboBox1.SelectedIndex = 0;
            comboBox1.Refresh();
            // TODO: This line of code loads data into the 'person._Person' table. You can move, or remove it, as needed.
            //  this.personTableAdapter.Fill(this.person._Person);
            // this.personTableAdapter.FillBy(this.person._Person);

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string person_name, startdate, enddate, comment,increasingdate,Service;
            int increasingpercentage;
            float rentcost, insurance,services;
            if (comboBox1.Text == "" || textBox8.Text == "" || textBox7.Text == "" || textBox5.Text == "" )
            {
                MessageBoxs.mes.Show("من فضلك إملأ الأماكن المطلوبة");
                return;
            }
            person_name = comboBox1.Text;
            startdate = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;
            increasingdate = dateTimePicker3.Value.Year + "-" + dateTimePicker3.Value.Month + "-" + dateTimePicker3.Value.Day;
            enddate = dateTimePicker2.Value.Year + "-" + dateTimePicker2.Value.Month + "-" + dateTimePicker2.Value.Day;
            comment = con.unrequired_Fields(textBox9.Text);
            if (comment != "NULL")
                comment = "'" + comment + "'";

            if (!float.TryParse(textBox8.Text, out rentcost))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة إيجار حقيقية");
                return;
            }

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

            if (textBox1.Text == "")
                Service = "NULL";
            else if (!float.TryParse(textBox1.Text, out services))
            {
                MessageBoxs.mes.Show("من فضلك أدخل قيمة خدمات صحيحة");
                return;
            }
            else
                Service = services.ToString();


            if (con.Renew_Contract(person_name, startdate,enddate,comment,rentcost,increasingpercentage,increasingdate,insurance,Service) != 0)
            {
                MessageBoxs.mes.Show("!تم التجديد بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!فشلت عملية التجديد");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            id = con.getvalue("p.id", "person p,apartment a", "p.id = a.person_id and p.name = '" + comboBox1.Text + "'");
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {/*
            try
            {
                this.personTableAdapter.FillBy(this.person._Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void fillByToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStrip_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Image form = new Edit_Image(id,'P');
            form.Show();
        }
    }
}
