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
    public partial class ALL : Form
    {
        Controller controller = new Controller();
        public ALL()
        {
            InitializeComponent();
           // this.apartmentTableAdapter.Fill(this.rentDataSet.Apartment);
            dataGridView1.DataSource = controller.get_All_Information();

        }

        private void AllInformation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentDataSet.Apartment' table. You can move, or remove it, as needed.
         //   this.apartmentTableAdapter.Fill(this.rentDataSet.Apartment);
            // TODO: This line of code loads data into the 'rentDataSet.Apartment' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'rentDataSet1.Apartment' table. You can move, or remove it, as needed.
         //   this.apartmentTableAdapter.Fill(this.rentDataSet1.Apartment);
            // TODO: This line of code loads data into the 'rentDataSet.Person' table. You can move, or remove it, as needed.
          //  this.personTableAdapter.Fill(this.rentDataSet.Person);
          dataGridView1.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
          dataGridView1.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
          dataGridView1.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";

          //dataGridView1.Columns[0].Width = 200;
          dataGridView1.Columns[1].Width = 200;
          dataGridView1.Columns[2].Width = 70;
          dataGridView1.Columns[3].Width = 110;
          dataGridView1.Columns[4].Width = 110;
          dataGridView1.Columns[5].Width = 60;
          dataGridView1.Columns[6].Width = 110;
          dataGridView1.Columns[7].Width = 120;
          dataGridView1.Columns[8].Width = 65;
          dataGridView1.Columns[18].Width = 900;
            for (int i = 0; i < dataGridView1.ColumnCount -3; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {/*
            try
            {
                this.personTableAdapter.FillBy(this.rentDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBy(this.rentDataSet.Apartment);
                dataGridView1.DataSource = controller.get_All_Information();

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
                // this.apartmentTableAdapter.FillBy(this.rentDataSet.Apartment);
                dataGridView1.DataSource = controller.get_All_Information();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
         /*   try
            {
                this.apartmentTableAdapter.FillBy(this.rentDataSet1.Apartment);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }*/

        }

        private void fillByToolStripButton_Click_2(object sender, EventArgs e)
        {
        /*    try
            {
                this.personTableAdapter.FillBy(this.rentDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void fillByToolStripButton_Click_3(object sender, EventArgs e)
        {/*
            try
            {
                this.personTableAdapter.FillBy(this.rentDataSet1.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void fillByToolStripButton_Click_4(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBy(this.rentDataSet.Apartment);
                dataGridView1.DataSource = controller.get_All_Information();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_5(object sender, EventArgs e)
        {/*
            try
            {
                this.personTableAdapter.FillBy(this.rentDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void fillByToolStripButton_Click_6(object sender, EventArgs e)
        {
            try
            {
                // this.apartmentTableAdapter.FillBy(this.rentDataSet.Apartment);
                dataGridView1.DataSource = controller.get_All_Information();

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_2(object sender, EventArgs e)
        {/*
            try
            {
                this.personTableAdapter.FillBy(this.rentDataSet.Person);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
