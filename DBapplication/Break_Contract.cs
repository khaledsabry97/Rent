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
    public partial class Break_Contract : Form
    {
        Controller con = new Controller();
        
        public Break_Contract()
        {
            InitializeComponent();
        }

        private void Break_Contract_Load(object sender, EventArgs e)
        {
            DataTable D = con.getdatacolumn("P.NAME", "PERSON P,APARTMENT A", "P.ID = A.PERSON_ID");
            if (D == null)
                return;
            for(int i =0; i <D.Rows.Count;i++)
            {
                comboBox1.Items.Add(D.Rows[i][0].ToString());
            }
            comboBox1.Text = D.Rows[0][0].ToString();
            comboBox1.Refresh();

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          /*  try
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

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            if(comboBox1.Text =="")
            {
                MessageBoxs.mes.Show("من فضلك إملأ الأماكن المطلوبة");
                return;
            }
            name = comboBox1.Text;
            if (con.Break_Contract(name) != 0)
            {
                MessageBoxs.mes.Show("!تم فسخ التعاقد بنجاح");
                Close();
            }
            else
            {
                MessageBoxs.mes.Show("!فشلت عملية فسخ التعاقد");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
