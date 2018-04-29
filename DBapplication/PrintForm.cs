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
    public partial class PrintForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public PrintForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          //  e.Graphics.DrawString("hello", new Font("arial", 12, FontStyle.Regular), Brushes.Brown, new Point(0, 0));
        }

        private void PrintForm_Load(object sender, EventArgs e)
        {
        }
    }
}
