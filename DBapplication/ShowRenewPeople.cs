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
    public partial class ShowRenewPeople : Form
    {
        List<int> list = new List<int>();
        Controller con = new Controller();
        public ShowRenewPeople()
        {
            InitializeComponent();
            dateTimePicker1.Value.ToLocalTime();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.RowHeadersWidth = 40;
            
        }

        private void ShowRenewPeople_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            if (dataGridView1.Rows.Count < 1)
                return;
            dataGridView1.Columns[0].Width = 300;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.Columns[2].Width = 120;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 77;




        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void UpdateGridView()
        {
            int count = dataGridView1.Rows.Count;
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            string Date;
            if (radioButton1.Checked)
            {
                Date = dateTimePicker1.Value.Year.ToString() + "-0" + dateTimePicker1.Value.Month.ToString();
                button1.Text = radioButton1.Text + dateTimePicker1.Value.Month.ToString();
            }
            else
            {
                Date = dateTimePicker1.Value.Year.ToString();
                button1.Text = radioButton2.Text +" " + dateTimePicker1.Value.Year.ToString();
            }

            DataTable d = con.show_Renew_People(Date);
            if (d == null)
            {
                return;
            }
            dataGridView1.DataSource = d;
            dataGridView1.Refresh();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
