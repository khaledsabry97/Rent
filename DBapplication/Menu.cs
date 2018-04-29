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
    public partial class Menu : Form
    {
        Controller con = new Controller();
        public Menu()
        {
            InitializeComponent();
            con.Auto_Increasing_Date_Increament();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Apartment form = new Add_Apartment();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_Contract form = new Sign_Contract();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Renew_Contract form = new Renew_Contract();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ALL form = new ALL();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ShowRenewPeople form = new ShowRenewPeople();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Break_Contract form = new Break_Contract();
            form.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Edit_Apartment_Contract form = new Edit_Apartment_Contract();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Show_Pic form = new Show_Pic();

            form.Show();
        }
    }
}
