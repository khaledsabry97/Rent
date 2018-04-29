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
    public partial class Edit_Apartment_Contract : Form
    {
        public Edit_Apartment_Contract()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edit_Information_Contract form = new Edit_Information_Contract();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Apartment form = new Edit_Apartment();
            form.Show();
        }
    }
}
