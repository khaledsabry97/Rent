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
    public partial class MessageBoxs : Form
    {
        public static MessageBoxs mes = new MessageBoxs();
        public MessageBoxs()
        {
            InitializeComponent();
        }

        private void MessageBoxs_Load(object sender, EventArgs e)
        {

        }

        public void Show(string name)
        {
            button1.Text = name;
            Show();
            mes = new MessageBoxs();
           

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
